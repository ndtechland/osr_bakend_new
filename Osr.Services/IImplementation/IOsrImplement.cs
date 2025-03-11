using Osr.Domain.Osr.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osr.Services.IImplementation
{
    public interface IOsrImplement
    {
        public Task<List<SiteMasterDTO>> SiteMasterslist();
    }
}
