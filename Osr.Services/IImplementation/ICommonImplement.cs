using Osr.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osr.Services.IImplementation
{

    public interface ICommonImplement 
    {
        public Task<int> GetUserDetailId(int id);
    }
}
