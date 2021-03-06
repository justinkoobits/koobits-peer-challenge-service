using Koobits.PeerChallenge.Api.Extensions;
using Koobits.PeerChallenge.Application.Common.Exceptions;
using Koobits.PeerChallenge.Application.Common.Utilities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
//using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
//using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Koobits.PeerChallenge.Api.Controllers
{
    public class ExtendedApiController : ControllerBase
    {
        public ExtendedApiController(){}
        protected bool IsPageingrequested()
        {
            var pi = Request.GetPageIndex(-1);
            var ps = Request.GetPageSize(-1);
            return pi >= 0 && ps > 0 ? true : false;
        }

        protected int UserId
        {
            get
            {
                return ConvertHelper.ToInt(User.Identity.GetId());
            }
        }
        protected string UserName
        {
            get
            {
                return ConvertHelper.ToString(User.Identity.GetUserName());
            }
        }

        protected int Role
        {
            get
            {
                return ConvertHelper.ToInt(User.Identity.GetRole());
            }
        }

        protected ServiceResponse<T> Run<T>(Func<T> resolve) where T : class
        {
            ServiceResponse<T> response = new ServiceResponse<T>();
            try
            {
                response.Result = resolve();
                response.IsSuccessful = true;
            }
            catch (ExpectedException exp)
            {
                Log.Error(exp,"Expected Exception");
                response.Message = new { code = exp.ErrorCode, Message = exp.Message };
            }
            catch (Exception exp)
            {
                Log.Error(exp,"ERUKN:Unknown Error");
                response.Message = new { code = "ERUKN", Message = "UnKnown Error" };
            }
            return response;

        }

        protected async Task<ServiceResponse<T>> Run<T>(Func<Task<T>> resolve) where T : class
        {
            ServiceResponse<T> response = new ServiceResponse<T>();
            try
            {
                response.Result = await resolve();
                response.IsSuccessful = true;
            }
            catch (ExpectedException exp)
            {
                Log.Error(exp,"Expected Exception");
                response.Message = new { code = exp.ErrorCode, Message = exp.Message };
            }
            catch (Exception exp)
            {
                Log.Error(exp,"ERUKN:Unknown Error");
                response.Message = new { code = "ERUKN", Message = "UnKnown Error" };
            }
            return response;

        }

        protected ServiceResponse Run(Func<object> resolve)
        {
            ServiceResponse response = new ServiceResponse();
            try
            {
                response.Result = resolve();
                response.IsSuccessful = true;
            }
            catch (ExpectedException exp)
            {
                Log.Error(exp,"Expected Exception");
                response.Message = new { code = exp.ErrorCode, Message = exp.Message };
            }
            catch (Exception exp)
            {
                 Log.Error(exp,"ERUKN:Unknown Error");
                response.Message = new { code = "ERUKN", Message = "UnKnown Error" };
            }
            return response;

        }
        protected async Task<ServiceResponse> RunAsync(Func<Task<object>> resolve)
        {
            ServiceResponse response = new ServiceResponse();
            try
            {
                response.Result = await resolve();
                response.IsSuccessful = true;
            }
            catch (ExpectedException exp)
            {
                  Log.Error(exp,"Expected Exception");
                //_logger.LogError("Expected Exception", exp);
                response.Message = new { code = exp.ErrorCode, Message = exp.Message };
                // response.Result = reject?.Invoke();
            }
            catch (Exception exp)
            {
                 Log.Error(exp,"ERUKN:Unknown Error");
                // _logger.LogError("ERUKN:Unknown Error", exp);
                response.Message = new { code = "ERUKN", Message = "UnKnown Error" };
                // response.Result = reject?.Invoke();

               // Elmah.ErrorSignal.FromCurrentContext().Raise(exp);
            }
            return response;

        }
        private JsonSerializerSettings GetJsonSettings()
        {
            var setting = new JsonSerializerSettings();
            //setting.DateFormatString = ConstHelper.API_DATETIME_FORMAT;

            return setting;
        }
    }
}
