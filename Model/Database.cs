
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace com.example.dotnet.webapi.Model
{

    public class Database
    {
        public async Task<Claim> StringGetAsync(string claimid){

            return await Task.Run(()=>  new Claim(){CLAIM_ID=claimid});
        }

        public async Task<List<Claim>> GetAllRecordsAsync(string claimid){
List<Claim> values = File.ReadAllLines("C:\\Users\\Josh\\Sample.csv")
                                           .Skip(1)
                                           .Select(v => DailyValues.FromCsv(v))
                                           .ToList();
            return await Task.Run(()=>  values);
        }
    }

}