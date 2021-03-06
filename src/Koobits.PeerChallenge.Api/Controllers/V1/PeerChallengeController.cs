using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koobits.PeerChallenge.Application.Common.Exceptions;
using Koobits.PeerChallenge.Application.Common.Utilities;
using Koobits.PeerChallenge.Application.Common.Utilities.Pagination;
using Koobits.PeerChallenge.Domain.Common.Constants;
using Koobits.PeerChallenge.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;

namespace Koobits.PeerChallenge.Api.Controllers.V1
{

    // Get Challenge(V)
    //      New Incoming Challenge (Paginated)
    //      History (Paginated)
    // Retrieve Challenge(V)
    //      By ID
    //Issue Challenge(NewPeerChallenge)
    // Submit Challenge
    // Update (Accept/Reject) Incoming Challenge
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class PeerChallengeController : ExtendedApiController
    {
        private readonly ILogger<PeerChallengeController> _logger;

        public PeerChallengeController(ILogger<PeerChallengeController> logger)
        {
            _logger = logger;
        }

        //dommy endpoint:      
        //old: [Route("GetSolutionByPCId/{pcId}")]
        [HttpGet]
        [Route("{pcId}/Solutions")]
        // [ServiceFilter(typeof(TimeValidationAttribute))]
        public async Task<ServiceResponse<object>> GetSolutionByPCIdAsync(int pcId, int userId)
        {
            //TODO: check from query paramerter
            return await Run(async () =>
            {
                // var result = await _peerChallengeV2Service.GetSolutionByPCIdAsync(pcId);
                var result = await Task.FromResult<object>(null);
                if (result == null)
                {
                    throw new ExpectedException(nameof(Constants.CommonMessages.ER013), Constants.CommonMessages.ER013);
                }

                return result;
            });
        }

        //dommy endpoint:
        [HttpGet]
        [Route("Subjects/{subjectId}/Users/{userId}/IncomingChallenges")]
        // [ServiceFilter(typeof(TimeValidationAttribute))]
        public async Task<ServiceResponse<object>> GetIncomingChallenges(int subjectId, int userId)
        {
            return await Run(async () =>
            {
                //   var result = _peerChallengeV2Service.GetIncomingChallengesBySubject(subjectId);
                var result = await Task.FromResult<object>(null);
                if (result == null)
                {
                    throw new ExpectedException(nameof(Constants.CommonMessages.ER013), Constants.CommonMessages.ER013);
                }

                return result;
            });
        }


        [HttpGet]
        [Route("Subjects/{subjectId}/Users/{userId}/HasIncomingChallenges")]
        // [ServiceFilter(typeof(TimeValidationAttribute))]
        public async Task<ServiceResponse<object>> HasIncomingChallengesAsync(int subjectId, int userId)
        {
            return await Run(async () =>
            {
                // var hasIncomingChallenges = await _peerChallengeV2Service.HasIncomingChallengesAsync(subjectId);
                var result = await Task.FromResult<object>(null);
                // result.Result = hasIncomingChallenges;
                return result;
            });
        }

        //dommy endpoint:
        [HttpGet]
        [Route("Subjects/{subjectId}/Users/{userId}/HistoryChallenges")]
        public ServiceResponse<IPagedList<object>> PeerChallengeHistory(int subjectId, int userId, int period, EnumChallengeInitiator challengeInitiater)
        {
            return Run(() =>
            {
                // var result = _peerChallengeV2Service.PeerChallengeHistory(period, challengeInitiater,
                //     IsPageingrequested(), Request.GetPageIndex(), Request.GetPageSize(), subjectId);

                IPagedList<object> result = null; ;
                if (result == null)
                {
                    throw new ExpectedException(nameof(Constants.CommonMessages.ER013), Constants.CommonMessages.ER013);
                }

                return result;
            });
        }

        [HttpGet]
        [Route("Subjects/{subjectId}/Users/{userId}/Quota")]
        public ServiceResponse<string> GetChallengesQuota(int subjectId, int userId)
        {
            return Run(() =>
            {
                // var result = _peerChallengeV2Service.GetChallengesQuota(subjectId);
                return "";
            });
        }

        //dommy endpoint:
        //old: {subjectId}/NewPeerChallenge/{opponentId}
        [HttpGet]
        [Route("Subjects/{subjectId}/Issue")]
        // [ServiceFilter(typeof(TimeValidationAttribute))]
        public async Task<ServiceResponse<object>> NewPeerChallenge(int subjectId, int initiatorId, int opponentId)
        {
            return await Run(async () =>
            {
                // var result = await _peerChallengeV2Service.NewPeerChallengeAsync(opponentId, subjectId);
                var result = await Task.FromResult<object>(null);

                if (result == null)
                {
                    throw new ExpectedException(nameof(Constants.CommonMessages.ER013), Constants.CommonMessages.ER013);
                }

                return result;
            });
        }

        [HttpPost]
        [Route("{pcId}/Users/{userId}/Accept")]
        // [ServiceFilter(typeof(TimeValidationAttribute))]
        public async Task<ServiceResponse<object>> AcceptPeerChallenge(int pcId)
        {
            return await Run(async () =>
            {
                // var result = await _peerChallengeV2Service.AcceptPeerChallengeAsync(peerChallengeId);
                var result = await Task.FromResult<object>(null);
                if (result == null)
                {
                    throw new ExpectedException(nameof(Constants.CommonMessages.ER013), Constants.CommonMessages.ER013);
                }

                return result;
            });
        }

        [HttpPost]
        [Route("{pcId}/Users/{userId}/Reject")]
        // [ServiceFilter(typeof(TimeValidationAttribute))]
        public async Task<ServiceResponse<List<object>>> RejectPeerChallenge(int pcId)
        {
            return await Run(async () =>
            {
                // var result = await _peerChallengeV2Service.RejectPeerChallengeAsync(peerChallengeId);
                List<object> result = new List<object>();
                if (result == null)
                {
                    throw new ExpectedException(nameof(Constants.CommonMessages.ER013), Constants.CommonMessages.ER013);
                }

                return result;
            });
        }

        [HttpPost]
        [Route("Submit")]
        // [ServiceFilter(typeof(TimeValidationAttribute))]
        public async Task<ServiceResponse<object>> SubmitPeerChallenge([FromBody] object inputPeerChallengeModel)
        {
            return await Run(async () =>
            {
                if (ModelState.IsValid)
                {
                    // var result = await _peerChallengeV2Service.SubmitPeerChallengeAsync(inputPeerChallengeModel);
                      var result = await Task.FromResult<object>(null);
                    if (result == null)
                    {
                        throw new ExpectedException(nameof(Constants.CommonMessages.ER013),
                            Constants.CommonMessages.ER013);
                    }

                    return result;
                }

                var modelStateErrors = ConvertHelper.SerializetoString<List<ModelErrorCollection>>(ModelState.Select(m => m.Value.Errors).ToList());
                throw new ExpectedException("ER008", string.Format(Constants.CommonMessages.ER008, modelStateErrors));
            });
        }
    }
}
