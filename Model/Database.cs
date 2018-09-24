
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

        public async Task<List<Claim>> GetAllRecordsAsync(){

            string datapath = Path.Combine( Directory.GetCurrentDirectory(), "UAT-Claims-Data.csv");

List<Claim> values = File.ReadAllLines(datapath)
                                           .Skip(1)
                                           .Select(v => ClaimsFromCSV.FromCSV(v))
                                           .ToList();
            return await Task.Run(()=>  values);
        }

        public List<Claim> fillCollection()
        {
            string datapath = Path.Combine( Directory.GetCurrentDirectory(), "UAT-Claims-Data.csv");
            
List<Claim> values = File.ReadAllLines(datapath)
                                           .Skip(1)
                                           .Select(v => ClaimsFromCSV.FromCSV(v))
                                           .ToList();
                                           return values;
        }
    }

}