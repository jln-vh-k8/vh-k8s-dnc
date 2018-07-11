

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace com.example.dotnet.webapi.Model
{

    public class ClaimRepository : IClaimsRepository
    {
         private readonly Database _database = new Database();
        public async Task<Claim> GetClaimAsync(string claimid)
        {
            var data = await _database.StringGetAsync(claimid);
           // if (data.IsNullOrEmpty)
            //{
              //  return null;
            //}

            return JsonConvert.DeserializeObject<Claim>(data.ToString());
        }
    }
}

