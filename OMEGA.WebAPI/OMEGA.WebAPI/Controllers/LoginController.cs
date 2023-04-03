using Microsoft.AspNetCore.Mvc;
using OMEGA.Core.Models;
using OMEGA.Core.Services;
using static OMEGA.Core.Global.Variables;
using static OMEGA.Core.Global.Constants;
using static OMEGA.Core.Global.Functions;
using System.Text.Json;
using OMEGA.Core.Models.DTOs;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace OMEGA.WebAPI.Controllers
{
    public class LoginController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ILoginService _LoginService;
        private APIResult apiResult = new APIResult();
        private readonly IJwtAuthService _JwtAuthService;

        public LoginController(ILoginService LoginService, IJwtAuthService JwtAuthService )
        {
            _LoginService = LoginService;
            _JwtAuthService = JwtAuthService;
        }

        [AllowAnonymous]
        [HttpGet("Login")]
        public IActionResult CheckUser(string UserName, string Password)
        {
            LogRequest(Request);
          
            try
            {               
                string pswstr = string.Empty;
                byte[] psw_encode = new byte[Password.Length];
                psw_encode = System.Text.Encoding.UTF8.GetBytes(Password);
                pswstr = Convert.ToBase64String(psw_encode);
                    
                List<TfsTbUserMasterWithUserDTO> UserDetails = null;

                int iRC = _LoginService.GetUser(UserName, pswstr, apiResult);
                if (iRC != API_SUCCESS)
                {
                    return BadRequest(apiResult);
                }

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, UserName),

                    new Claim("ID", Guid.NewGuid().ToString()),

                    new Claim("Email", "ecesisdevelopersteam@gmail.com")

                };

                var jwtResult = _JwtAuthService.GenerateTokens(UserName, claims, DateTime.Now);

                apiResult.Token = jwtResult.AccessToken;

                UserDetails = JsonSerializer.Deserialize<List<TfsTbUserMasterWithUserDTO>>(apiResult.Result);

                var loginResult = new { Result = UserDetails, AccessToken = jwtResult.AccessToken};

                return Ok(loginResult);
            }
            catch (System.Exception ex)
            {
                apiResult.APIStatusMessage = ex.Message;

                apiResult.APIStatus = (int)Core.Enums.APIStatus.Exception;

                log.Error($"Exception caught. Exception: {ex.Message}");

                if (ex.InnerException != null)
                {
                    log.Error($"Details: {ex.InnerException.Message}");

                    apiResult.APIStatusMessage = apiResult.APIStatusMessage + "\r\n" + ex.InnerException.Message;
                }

                return BadRequest(apiResult);
            }

            return BadRequest();

        }

    }
}
