using Microsoft.EntityFrameworkCore;
using Osr.Domain.Osr.Domain.Entities;
using Osr.Services.IImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Osr.Services.Implementation
{
    public class CommonImplement : ICommonImplement
    {
        private osr_newContext _context;
        public CommonImplement(osr_newContext context)
        {
            this._context = context;
        }
        public async Task<int> GetUserDetailId(int id)
        {
            var user = await _context.Slips.FirstOrDefaultAsync(a => a.AdminLoginId == id);
            var userNew = await _context.SlipNews.FirstOrDefaultAsync(a => a.AdminLoginId == id);

            if (user != null)
            {
                return user.Id;
            }
            else if (userNew != null)
            {
                return userNew.Id;
            }
            return 0;
        }

    }
}
