using System.IO;

namespace msa_demo.MockRetriveClaimServive
{
    public class MockRetriveClaimServive : IRetriveClaimService
    {
        private static string _InvalidClaimNumber = @"MockClaimsService\ExampleJson\invalidClaimId_response_example.json";
        private static string _ValidClaimNumber = @"MockClaimsService\ExampleJson\oneClaim_response_example.json";
        private static string _AllClaims= @"MockClaimsService\ExampleJson\allClaims_response_example.json";


        public string GetAllClaims()
        {
            return File.ReadAllText(_AllClaims);
        }

        public string GetClaimByClaimId(string claimId)
        {
            switch (claimId)
            {
                case "1": return GetInvalidClaimNumber();
                default : return GetValidClaimNumber();
            }
        }

        private string GetInvalidClaimNumber()
        {
            return File.ReadAllText(_InvalidClaimNumber);
        }
        private string GetValidClaimNumber()
        {
            return File.ReadAllText(_ValidClaimNumber);
        }
    }
}