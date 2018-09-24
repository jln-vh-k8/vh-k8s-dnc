using Xunit;
using Xunit.Gherkin.Quick;
using System.Collections.Generic;

namespace msa_demo.StepDefinitions
{
    [FeatureFile("./FeatureFiles/RetriveClaim/DataAboutAClaim.feature")]
    public sealed class DataAboutAClaim : Feature
    {
        RetriveClaim RetriveClaimsService = new RetriveClaim(new MockRetriveClaimServive.MockRetriveClaimServive());
        Claim Claim {get; set;}

        [When(@"I retrieve a claim")]
        public void IRetrieveAClaim()
        {
            Claim = RetriveClaimsService.GetClaimByClaimId("9132864");
        }

        [Then(@"I will be able to view the following information about it")]
        public void IWillBeAbleToViewTheFollowingInformationAboutIt()
        {
            Assert.True(Claim != null);
        }
    }
}