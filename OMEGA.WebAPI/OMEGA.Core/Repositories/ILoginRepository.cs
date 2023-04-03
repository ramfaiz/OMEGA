using OMEGA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMEGA.Core.Repositories
{
    public interface ILoginRepository
    {
        public int GetUsers(APIResult apiResult);
    }
}
