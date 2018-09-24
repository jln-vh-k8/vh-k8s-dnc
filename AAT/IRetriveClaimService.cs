namespace msa_demo
{
    public interface IRetriveClaimService
    {
        string GetClaimByClaimId(string claimId);
        string GetAllClaims();
    }
}