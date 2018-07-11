

using Newtonsoft.Json;

namespace com.example.dotnet.webapi.Model {

public class Claim
{
    [JsonProperty("CLAIM_ID")]      
    public string CLAIM_ID {get;set;}     
    public string PPR_CONSULTANT_ID {get;set;}
    public string CLAIM_TYPE_ID {get;set;}
    public string STATUS_TYPE_ID {get;set;}
    public string CLAIM_NUMBER {get;set;}
    public string POLICY_NUMBER {get;set;}
    public string PEER_NUMBER {get;set;}
    public string CLAIMANT_NUMBER {get;set;}
    public string HOLDER_NUMBER {get;set;}
    public string REFERRED_BY_GP {get;set;}
    public string GP_VISIT_DATE {get;set;}
    public string REVIEW_DATE {get;set;}
    public string IN_PAY_AMOUNT {get;set;}
    public string NO_OF_PAYOUTS {get;set;}
    public string IS_CASE_MANAGED {get;set;}
    public string START_ACCEPTANCE {get;set;}
    public string END_ACCEPTANCE {get;set;}
    public string CLAIM_REFEREE {get;set;}
    public string POLICY_START_DATE {get;set;}
    public string PPR_RADIUS {get;set;}
    public string PPR_POSTCODE {get;set;}
    public string NO_PPR_REASON {get;set;}
    public string IS_THIRD_PARTY_CLAIM {get;set;}
    public string HOT_MESSAGE {get;set;}
    public string CREATED_BY {get;set;}
    public string CREATION_DATE {get;set;}
    public string AMENDED_BY {get;set;}
    public string AMEND_DATE {get;set;}
    public string INSURED_LIFE_ID {get;set;}
    public string NHS_CASH_PROOF {get;set;}
    public string WORK_OBJECT_KEY {get;set;}
    public string REVIEW_DATE_LETTER_SENT {get;set;}
    public string CHANGED_FLAG {get;set;}
    public string DPN_REFUSED {get;set;}
    public string MIGRATED_CLAIM_ID {get;set;}
    public string MI_CHANGE_FLAG {get;set;}
    public string CLIENT_TYPE_ID {get;set;}
    public string LOCK_FLAG {get;set;}
    public string IS_PHYSIOTHERAPY_NETWORK {get;set;}
    public string CONSULTATION_REFERENCE_NUMBER {get;set;}
    public string IS_ACTIVE {get;set;}
    public string EDI_MEMBER_LOCK {get;set;}
    public string DECLINE_DATE {get;set;}
    public string IS_CLAIM_FORM_RECEIVED {get;set;}
    public string DOC_TO_PRI_MEMIS_ALTERNATIVE_ADDRESS {get;set;}

     
}

}