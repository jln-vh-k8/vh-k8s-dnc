
using System;
using System.Threading.Tasks;
namespace com.example.dotnet.webapi.model
{

    public class Database
    {
        public async Task<Claim> StringGetAsync(string claimid){

            return await Task.Run(()=>  new Claim());
        }
    }

}