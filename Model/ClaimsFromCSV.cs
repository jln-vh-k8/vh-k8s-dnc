namespace com.example.dotnet.webapi.Model {

    public static class ClaimsFromCSV
    {

        public static Claim FromCSV( string csvLine )
        {

            Claim claim = new Claim();
            string[] values = csvLine.Split(',');

            claim.CLAIM_ID = values[0];
            claim.POLICY_NUMBER = values[1];

            return claim;
        }
    }
}
