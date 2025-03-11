using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osr.Domain.Osr.Dto
{
    public class DashboardModel
    {
        public string Name { get; set; }
        public int TotalTransactions { get; set; }
        public string ImageName { get; set; }
        public double TotalPaymentRecieved { get; set; }
        public double MonthlyPendingEmi { get; set; }
        public double MonthlyPaidEmi { get; set; }
        public int TotalPlotSale { get; set; }
        public int TotalActiveUser { get; set; }
        public int TotalInactiveUser { get; set; }
        public int TotalHoldUser { get; set; }
        public int TotalLeftUser { get; set; }
        public int TotalRightUser { get; set; }
        public int TotalCOV { get; set; }
        public int? CurrentLevel { get; set; }
        public double RightBusiness { get; set; }
        public double LeftBusiness { get; set; }
        public int CurrentMonthCOV { get; set; }
        public string Status { get; set; }
        public string Color { get; set; }

    }
}
