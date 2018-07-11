using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.example.dotnet.webapi.Model{

    public interface IClaimsRepository
    {
         Task<Claim> GetClaimAsync(string claimid);
    }
}