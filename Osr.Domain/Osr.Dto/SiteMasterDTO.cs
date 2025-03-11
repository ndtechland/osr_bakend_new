using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osr.Domain.Osr.Dto
{
    public class SiteMasterDTO
    {
        public int Id { get; set; }
        [Required]
        public string SiteName { get; set; }
        [Required]
        public string SiteAddress { get; set; }

        public int NoOfPlots { get; set; }
        public string SiteDescription { get; set; }
        public string TotalArea { get; set; }
        public List<string> SiteNames { get; set; }

        public string PlotNumber2 { get; set; }
        public string Size2 { get; set; }

        public string PlotNumber3 { get; set; }
        public string Size3 { get; set; }

        public string PlotNumber4 { get; set; }
        public string Size4 { get; set; }

        public string PlotNumber5 { get; set; }
        public string Size5 { get; set; }

        public string PlotNumber6 { get; set; }
        public string Size6 { get; set; }

        public string PlotNumber7 { get; set; }
        public string Size7 { get; set; }

        public string PlotNumber8 { get; set; }
        public string Size8 { get; set; }

        public string PlotNumber9 { get; set; }
        public string Size9 { get; set; }

        public string PlotNumber10 { get; set; }
        public string Size10 { get; set; }

        public string PlotNumberShop2 { get; set; }
        public string ShopSize2 { get; set; }
    }
}
