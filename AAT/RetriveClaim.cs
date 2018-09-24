using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace msa_demo
{
    public class RetriveClaim
    {
        private IRetriveClaimService _RetriveClaimService {get; set;}
        public Claim GetClaimByClaimId(string claimId)
        {
            var json = _RetriveClaimService.GetClaimByClaimId(claimId);
            return CovertJsonToClaim(json);
        }

        public List<Claim> GetListOfAllClaims()
        {
            var json = _RetriveClaimService.GetAllClaims();
            return ConvertJsonToClaimList(json);
        }

        private Claim CovertJsonToClaim(string json)
        {
            return JsonConvert.DeserializeObject<Claim>(json);
        }

        private List<Claim> ConvertJsonToClaimList(string json)
        {
            return JsonConvert.DeserializeObject<List<Claim>>(json);
        }

        public RetriveClaim(IRetriveClaimService retriveClaimService)
        {
            _RetriveClaimService = retriveClaimService;
        }
    }
}