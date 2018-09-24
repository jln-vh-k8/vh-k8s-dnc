using System.Collections.Generic;
using Xunit;
using Xunit.Gherkin.Quick;

namespace msa_demo.StepDefinitions
{
 [FeatureFile("./FeatureFiles/RetriveClaim/GetListOfAllClaims.feature")]
    public sealed class GetListOfAllClaims : Feature
    {
        RetriveClaim RetriveClaimsService = new RetriveClaim(new MockRetriveClaimServive.MockRetriveClaimServive());
        List<Claim> ClaimsList = new List<Claim>();

        [Given(@"more than one claim exists")]
        public void MoreThanOneClaimExists()
        {
           //Nothing to do here, we are going to make this an assumtion.
        }

        [When(@"I request the list of all claims")]
        public void IRequestTheListOfAllClaims()
        {
            ClaimsList = RetriveClaimsService.GetListOfAllClaims();
        }

        [Then(@"the list will have more than one claim")]
        public void TheListWillHaveMoreThanOneClaim()
        {
            Assert.True(ClaimsList.Count > 1);
        }
    }
}