using Microsoft.EntityFrameworkCore;
using Osr.Domain.Osr.Domain.Entities;
using Osr.Domain.Osr.Dto;
using Osr.Services.IImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osr.Services.Implementation
{
    public class OsrImplement : IOsrImplement
    {
        private osr_newContext _Context;
        public OsrImplement(osr_newContext context)
        {
            this._Context = context;
        }
        public async Task<List<SiteMasterDTO>> SiteMasterslist()
        {
            var data = await _Context.SiteMasters
                .Select(sm => new SiteMasterDTO
                {
                    Id = sm.Id,
                    SiteName = sm.SiteName,
                    SiteAddress = sm.SiteAddress,
                    SiteDescription = sm.SiteDescription,
                    NoOfPlots = _Context.PlotDetails.Count(pd => pd.SiteMasterId == sm.Id)
                })
                .OrderByDescending(x => x.Id)
                .ToListAsync();

            return data;
        }

    }
}
