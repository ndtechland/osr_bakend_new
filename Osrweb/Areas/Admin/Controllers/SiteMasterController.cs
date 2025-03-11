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
    public class SiteMasterController : Controller
    {
        private readonly osr_newContext _Context;
        private readonly ICommonImplement _commonImplement;
        private readonly IImageUpload _imageUpload;
        private readonly IOsrImplement _osrImplement;

        public SiteMasterController(osr_newContext Context, ICommonImplement commonImplement, IImageUpload imageUpload, IOsrImplement osrImplement)
        {
            this._Context = Context;
            this._commonImplement = commonImplement;
            _imageUpload = imageUpload;
            _osrImplement = osrImplement;
        }
        [HttpGet, Route("SiteMasterList")]
        public async Task<IActionResult> SiteMasterList()
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            var data = await _osrImplement.SiteMasterslist();

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
        [HttpPost, Route("AddSiteMaster")]
        public async Task<IActionResult> AddSiteMaster(SiteMasterDTO model)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            SiteMaster site = new SiteMaster();
            {
                site.SiteName = model.SiteName;
                site.SiteAddress = model.SiteAddress;
                site.SiteDescription = model.SiteDescription;
            };
            _Context.SiteMasters.Add(site);
            _Context.SaveChanges();

            int count1 = (Convert.ToInt32(model.TotalArea) / model.NoOfPlots);
            List<int> AddData = new List<int>();

            for (int i = 1; i <= Convert.ToInt32(model.NoOfPlots); i++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    //PlotNumber = count1.ToString(),
                    PlotNumber = model.TotalArea,
                    TotalArea = model.TotalArea,
                    PlotId = i,
                    Status = "Vacant",
                    PlotType1 = "Type1",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + i

                };
                _Context.PlotDetails.Add(plotDetail);
                _Context.SaveChanges();
            }

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber2); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail2 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size2,
                    Size2 = model.Size2,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 2",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail2);
                _Context.SaveChanges();
            }

            //type 3

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber3); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail3 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size3,
                    Size2 = model.Size3,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 3",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail3);
                _Context.SaveChanges();
            }

            //type 4

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber4); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail4 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size4,
                    Size2 = model.Size4,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 4",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail4);
                _Context.SaveChanges();
            }

            //type 5

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber5); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail5 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size5,
                    Size2 = model.Size5,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 5",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail5);
                _Context.SaveChanges();
            }
            //type 6

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber6); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail6 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size6,
                    Size2 = model.Size6,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 6",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail6);
                _Context.SaveChanges();
            }
            //type 7

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber7); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail7 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size7,
                    Size2 = model.Size7,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 7",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail7);
                _Context.SaveChanges();
            }
            //type 8

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber8); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail8 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size8,
                    Size2 = model.Size8,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 8",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail8);
                _Context.SaveChanges();
            }
            //type 9

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber9); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail9 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size9,
                    Size2 = model.Size9,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 9",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail9);
                _Context.SaveChanges();
            }
            //type 10

            for (int y = 1; y <= Convert.ToInt32(model.PlotNumber10); y++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail10 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.Size10,
                    Size2 = model.Size10,

                    PlotId = y,
                    Status = "Vacant",
                    PlotType1 = "Type 10",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + y

                };
                _Context.PlotDetails.Add(plotDetail10);
                _Context.SaveChanges();
            }



            for (int z = 1; z <= Convert.ToInt32(model.PlotNumberShop2); z++)
            {
                //var plotDetail = new PlotDetail { SiteMaster_Id = site.Id, PlotNumber = siteName };
                var plotDetail3 = new PlotDetail
                {
                    SiteMasterId = site.Id,
                    PlotNumber = model.ShopSize2,
                    ShopSize2 = model.ShopSize2,

                    PlotId = z,
                    Status = "Vacant",
                    PlotType1 = "Shop",
                    PlotIdPrefix = model.SiteName.Substring(0, 2) + z

                };
                _Context.PlotDetails.Add(plotDetail3);
                _Context.SaveChanges();

            }

            return View();

        }
    }
}
