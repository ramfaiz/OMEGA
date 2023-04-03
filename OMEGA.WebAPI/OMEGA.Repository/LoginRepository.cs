using OMEGA.Core.Models;
using OMEGA.Core.Repositories;
using OMEGA.DAL.DBContext;
using OMEGA.Core.Model.DTOs;
using static OMEGA.Core.Global.Constants;
using static OMEGA.Core.Global.Variables;
using OMEGA.DAL.Models.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Text.Json;


namespace OMEGA.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly OMEGADBContext _OMEGADBContext;

		private readonly IMapper _mapper;
        public LoginRepository(OMEGADBContext OMEGADBContext,
                IMapper mapper)
        {
            _OMEGADBContext = OMEGADBContext;

            _mapper = mapper;
        }
        public int GetUsers(APIResult apiResult)
        {
            int iReturn = API_SUCCESS;

            try
            {
                var dbList = _OMEGADBContext.TfsTbUserMasters.Where(x => x.DeleteStatus == 0)
                                                         .ToList();
                                                         //.OrderByDescending(x => x.Displayorder)
                                                         //.ToList();

                var ResultList = _mapper.Map<List<TfsTbUserMasterDTO>>(dbList);

                apiResult.APIStatusMessage = "Users retrieved successfully";

                apiResult.Result = JsonSerializer.Serialize(ResultList);
            }
            catch (Exception ex)
            {
                iReturn = API_FAILED;

                apiResult.Reset();

                apiResult.APIStatusMessage = ex.Message;

                apiResult.APIStatus = (int)Core.Enums.APIStatus.Exception;

                log.Error($"Exception caught. Exception: {ex.Message}");

                if (ex.InnerException != null)
                {
                    log.Error($"Details: {ex.InnerException.Message}");
                }
            }

            return iReturn;
        }
    }
    

}

