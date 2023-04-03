using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OMEGA.Core.Services;
using OMEGA.Core.Repositories;
using static OMEGA.Core.Global.Constants;
using static OMEGA.Core.Global.Variables;
using OMEGA.Core.Models;
using OMEGA.Core.Model.DTOs;
using OMEGA.Core.Models.DTOs;

namespace OMEGA.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repo;
        private readonly IMapper _mapper;
        public LoginService(ILoginRepository repo,
                            IMapper mapper)
        {
            _repo = repo;

            _mapper = mapper;
        }
        public int GetUser(string UserName, string pswstr, APIResult apiResult)
        {
            int iReturn = API_SUCCESS;

            try
            {
                iReturn = _repo.GetUsers(apiResult);

                if (iReturn == API_SUCCESS)
                {
                    var ListOfUsers = JsonSerializer.Deserialize<List<TfsTbUserMasterDTO>>(apiResult.Result);

                    var User = ListOfUsers.FindAll(x => x.Username.Equals(UserName));

                    if (User.Count == 0)
                    {
                        iReturn = API_FAILED;

                        apiResult.APIStatusMessage = "User not found";

                        apiResult.APIStatus = API_FAILED;

                        apiResult.Result = string.Empty;

                        return iReturn;
                    }
                    else if (User[0].Password != pswstr)
                    {
                        iReturn = API_FAILED;

                        apiResult.APIStatusMessage = "Incorrect Password";

                        apiResult.APIStatus = API_FAILED;

                        apiResult.Result = string.Empty;

                        return iReturn;
                    }

                    var ListOfTfsTbUserMasterWithUserDTO = _mapper.Map<List<TfsTbUserMasterWithUserDTO>>(User);

                    //foreach (QuizQuestionWithCategoryNameDTO quizQuestionWithCategoryNameDTO in listOFQuizQuestionWithCategoryNameDTO)
                    //{
                    //    quizQuestionWithCategoryNameDTO.CategoryName = CategoryName;
                    //}

                    apiResult.APIStatusMessage = "Login Success ";

                    apiResult.Result = JsonSerializer.Serialize(ListOfTfsTbUserMasterWithUserDTO);
                }


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
