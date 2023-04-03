using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMEGA.Core.Models;

namespace OMEGA.Core.Services
{
    public interface ILoginService
    {
        public int GetUser(string UserName, string pswstr, APIResult apiResult);
    }
}
