using System;

namespace OMEGA.Core.Models
{
    public class HTTPResponse
    {
        public string Data { get; set; }

        public HTTPResponse()
        {
            Data = string.Empty;
        }
    }

    public class APIResult
    {
        public int APIStatus { get; set; }
        public string APIStatusMessage { get; set; }
        public string Result { get; set; }

        public string Token { get; set; }

        public APIResult()
        {
            Reset();
        }

        public void Reset()
        {
            APIStatus = (int)Enums.APIStatus.Success;

            APIStatusMessage = string.Empty;

            Result = null;
        }
    }
}
