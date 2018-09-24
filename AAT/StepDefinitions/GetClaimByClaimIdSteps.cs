using System.Collections.Generic;
using Xunit;
using Xunit.Gherkin.Quick;

namespace msa_demo.StepDefinitions
{
    [FeatureFile("./FeatureFiles/RetriveClaim/GetClaimByClaimId.feature")]
    public sealed class GetClaimByClaimId : Feature
    {
        RetriveClaim RetriveClaimsService = new RetriveClaim(new MockRetriveClaimServive.MockRetriveClaimServive());
        Claim Claim {get; set;}
        string ClaimNumber {get; set;}

        [Given(@"a valid claim number")]
        public void GivenAValidClaimNumber()
        {
           ClaimNumber = "9132864";
        }

        [When(@"I search using the claim number")]
        public void ISearchUsingTheClaimNumber()
        {
            Claim = RetriveClaimsService.GetClaimByClaimId(ClaimNumber);
        }

        [Then(@"the information about the claim should be shown")]
        public void theInformationAboutTheClaimShouldBeShown()
        {
            Assert.True(Claim.PolicyNumber == "50346252");
        }

        [Given(@"a claim number that does not exist")]
        public void AClaimNumberThatDoesNotExist()
        {
            ClaimNumber = "1";
        }

        [Then(@"I will be informed the no claims could be found")]
        public void IWillBeInformedTheNoClaimsCouldBeFound()
        {
            Assert.True(Claim == null);
        }
    }
}