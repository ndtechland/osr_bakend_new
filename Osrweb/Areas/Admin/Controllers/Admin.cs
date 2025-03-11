using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Osr.Domain.Osr.Domain.Entities;
using Osr.Domain.Osr.Dto;
using Osr.Services.IImplementation;
using Osr.Services.Implementation;
using Osr.Services.IUtilities;
using System.Security.Claims;

namespace Osrweb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class Admin : Controller
    {
        private readonly osr_newContext _Context;
        private readonly ICommonImplement _commonImplement;
        private readonly IImageUpload _imageUpload;

        public Admin(osr_newContext Context, ICommonImplement commonImplement, IImageUpload imageUpload)
        {
            this._Context = Context;
            this._commonImplement = commonImplement;
            _imageUpload = imageUpload;

        }
        [HttpGet, Route("Login")]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost, Route("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = _Context.UserLogins
                .FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserName", user.Username);
                HttpContext.Session.SetString("UserId", user.Id.ToString());

                var resultSlips = _Context.Slips.FirstOrDefault(x => x.AdminLoginId == user.Id);
                if (resultSlips != null)
                {
                    var result = _Context.SlipNews.FirstOrDefault(x => x.AdminLoginId == user.Id);
                    if (result != null)
                    {
                        if (result.LevelId.HasValue)
                        {
                            HttpContext.Session.SetInt32("UserLevel", result.LevelId.Value);
                        }
                    }
                    string role = user.Role;
                    // Creating a list of claims for authentication
                    var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

                    // Add claims only if values are not null
                    if (!string.IsNullOrEmpty(result?.CustomerName))
                        claims.Add(new Claim("CustomerName", result.CustomerName));
                    if (!string.IsNullOrEmpty(role))
                        claims.Add(new Claim("Role", role));

                    if (!string.IsNullOrEmpty(result?.Email))
                        claims.Add(new Claim("Email", result.Email));

                    if (!string.IsNullOrEmpty(result?.MobileNumber))
                        claims.Add(new Claim("Mobile", result.MobileNumber));

                    if (result?.Id != null)
                        claims.Add(new Claim("UserId", result.Id.ToString()));

                    claims.Add(new Claim("User", "OldUser"));

                    // Creating authentication identity and principal
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    // Sign in the user
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("Dashboard");
                }
            }

            // Check for broker login
            var broker = _Context.Brokers
                .FirstOrDefault(x => x.Name == model.Username && x.Password == model.Password);

            if (broker != null)
            {
                var brokerClaims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, broker.Id.ToString()),
            new Claim(ClaimTypes.Name, broker.Name),
            new Claim(ClaimTypes.Role, broker.Role),
            new Claim("User", "Broker"),
            new Claim("BrokerId", broker.Id.ToString())
        };

                var brokerIdentity = new ClaimsIdentity(brokerClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                var brokerPrincipal = new ClaimsPrincipal(brokerIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, brokerPrincipal);

                return RedirectToAction("Demo");
            }

            return View();
        }

        [HttpGet, Route("Dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            int id = 0; 
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            var userId = int.TryParse(userIdClaim, out int parsedId) ? parsedId : 0;
            var record = _Context.UserLogins.Find(userId);
            var slip = _Context.Slips.ToList();
            var emi = _Context.Emis.ToList();
            int totalSlips = _Context.Slips.Count();
            int totalEmis = _Context.Emis.Count();
            var totalTransactions = totalSlips + totalEmis;
            var model = new DashboardModel();

            if (User.IsInRole("user"))
            {
                //check logged in user detail
                int userDetailId = await _commonImplement.GetUserDetailId(id);
                //var userDetailId = 1;
                var myDetail = _Context.Slips.AsNoTracking().FirstOrDefault(a => a.Id == userDetailId);
                var ulevel = _Context.UserLevels.OrderByDescending(a => a.Id).Where(a => a.UserId == myDetail.Id).FirstOrDefault();
                var IsActive = await _Context.Slips
                    .FromSqlRaw(@"SELECT s.* FROM Slip s 
                  WHERE s.Id = @id 
                  AND s.[Status] = 'Active' 
                  AND dbo.GetPayout(s.Id) >= (s.Total * 0.25)",
                                  new SqlParameter("@id", myDetail.Id))
                    .FirstOrDefaultAsync();
                if (IsActive != null)
                {
                    model.Color = "g";
                    model.Status = "Active";
                }
                else if (myDetail.Status == "Hold")
                {
                    model.Color = "o";
                    model.Status = "Hold";
                }
                else
                {
                    model.Color = "r";
                    model.Status = "Inactive";
                }
                if (ulevel != null)
                {
                    model.CurrentLevel = ulevel.ULevel;
                }
                model.Name = myDetail.CustomerName;
                double totalLeftYards = 0;
                double totalRightYards = 0;
                int totalleftuser = 0;
                int totalrightuser = 0;
                var leftChildren = new List<Slip>();
                var rightChildren = new List<Slip>();

                var leftChild = _Context.Slips.AsNoTracking().FirstOrDefault(a => a.SpillSponsorId == myDetail.Id && a.IsLeft == true);
                var rightChild = _Context.Slips.AsNoTracking().FirstOrDefault(a => a.SpillSponsorId == myDetail.Id && a.IsLeft == false);
                // check total left user

                if (leftChild != null)
                {
                    leftChildren = await _Context.Slips
                   .FromSqlRaw("EXEC getTotalUser @userId", new SqlParameter("@userId", leftChild.Id))
                   .ToListAsync();

                    var IsleftChildActive = await _Context.Slips
                        .FromSqlRaw("SELECT s.* FROM Slip s WHERE s.Id = @id AND s.[Status] = 'Active' AND dbo.GetPayout(s.Id) >= (s.Total * 0.25)",
                            new SqlParameter("@id", leftChild.Id))
                        .FirstOrDefaultAsync();

                    if (IsleftChildActive != null)
                    {
                        leftChildren.Add(leftChild);
                    }

                    totalleftuser = leftChildren.Count();
                    totalLeftYards = leftChildren.Sum(a => a.Yards);
                }

                //check total right user

                if (rightChild != null)
                {
                    rightChildren = await _Context.Slips
                        .FromSqlRaw("EXEC getTotalUser @userId", new SqlParameter("@userId", rightChild.Id))
                        .ToListAsync();

                    var IsrightChildActive = await _Context.Slips
                        .FromSqlRaw("SELECT s.* FROM Slip s WHERE s.Id = @id AND s.[Status] = 'Active' AND dbo.GetPayout(s.Id) >= (s.Total * 0.25)",
                            new SqlParameter("@id", rightChild.Id))
                        .FirstOrDefaultAsync();

                    if (IsrightChildActive != null)
                    {
                        rightChildren.Add(rightChild);
                    }

                    totalrightuser = rightChildren.Count();
                    totalRightYards = rightChildren.Sum(a => a.Yards);

                }
                model.TotalLeftUser = totalleftuser;
                model.TotalRightUser = totalrightuser;
                model.LeftBusiness = totalLeftYards;
                model.RightBusiness = totalRightYards;
                //model.Status = myDetail.Status;
            }

            model.TotalTransactions = totalTransactions;
            model.ImageName = record.ImageName;
            model.TotalPaymentRecieved = slip.Sum(a => a.Advance) + emi.Sum(a => a.EmiAmount);
            var month = DateTime.Now.Month;
            model.MonthlyPaidEmi = emi.Where(a => a.NextEmiDate.Month == month).ToList().Sum(a => a.EmiAmount);
            model.MonthlyPendingEmi = emi.Where(a => a.EmiDate.Value.Month == month).ToList().Sum(a => a.EmiAmount);
            model.TotalActiveUser = slip.Where(a => a.SponsorId != null && a.Status == "Active").Count();
            model.TotalInactiveUser = slip.Where(a => a.SponsorId != null && a.Status == "Inactive").Count();
            model.TotalHoldUser = slip.Where(a => a.SponsorId != null && a.Status == "Hold").Count();
            model.TotalPlotSale = totalSlips;
            return View(model);
        }
        [HttpPost, Route("Dashboard")]
        public async Task<IActionResult> Dashboard(IFormFile file = null)
        {
            int id = 0;
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            var userId = int.TryParse(userIdClaim, out int parsedId) ? parsedId : 0;
            var record = _Context.UserLogins.Find(userId);
            if (file != null)
            {
                var result = _imageUpload.UploadImage(file, "Images");
                if (result == "not allowed")
                {
                    TempData["imgMessage"] = "Only .jpg,.png,.jpeg,.gif files are allowed";
                }
                record.ImageName = result;
                _Context.SaveChanges();
            }
            return RedirectToAction("Dashboard");
        }

    }
}
