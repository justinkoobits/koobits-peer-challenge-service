using Koobits.PeerChallenge.Application.Common.Utilities;

namespace Koobits.PeerChallenge.Application.Common.Exceptions
{
    //not using for now, currently exceptions are captured with ExtendedApiController
    public class ErrorResponse : ServiceResponse
    {
        public int StatusCode { get; set; }
        public string Description { get; set; }
    }
}