using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Osr.Domain.Osr.Domain.Entities;
using Osr.Domain.Osr.Dto;
using Osr.Services.IImplementation;
using Osr.Services.IUtilities;

namespace Osrweb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("SiteMaster")]
    public class SiteMaster : Controller
    {
        private readonly osr_newContext _Context;
        private readonly ICommonImplement _commonImplement;
        private readonly IImageUpload _imageUpload;

        public SiteMaster(osr_newContext Context, ICommonImplement commonImplement, IImageUpload imageUpload)
        {
            this._Context = Context;
            this._commonImplement = commonImplement;
            _imageUpload = imageUpload;

        }
        [HttpGet, Route("SiteMasterList")]
        public async Task<IActionResult> SiteMasterList()
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;

            var data = _Context.SiteMasters
                .Select(sm => new
                {
                    sm,
                    NoOfPlots = _Context.PlotDetails.Count(pd => pd.SiteMasterId == sm.Id)
                })
                .AsEnumerable()
                .Select(x => new SiteMasterDTO
                {
                    Id = x.sm.Id,
                    SiteName = x.sm.SiteName,
                    SiteAddress = x.sm.SiteAddress,
                    SiteDescription = x.sm.SiteDescription,
                    NoOfPlots = x.NoOfPlots
                })
                .OrderByDescending(x => x.Id)
                .ToList();

            return View(data);
        }
        [HttpGet, Route("AddSiteMaster")]
        public async Task<IActionResult> AddSiteMaster(int id = 0)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            //var result = _Context.PlotDetails.FirstOrDefault(x => x.SiteMasterId == id);
            //return View(result);
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> AddSiteMaster(SiteMasterDTO model)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            var result = _Context.PlotDetails.FirstOrDefault(x => x.SiteMasterId == model.Id);
            return View(result);

        }
    }
}
