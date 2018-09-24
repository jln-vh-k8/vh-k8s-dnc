using Newtonsoft.Json;

namespace msa_demo
{
    public class Claim
    {
        [JsonProperty("CLAIM_ID ")]
        public string ClaimId {get; set;}

        [JsonProperty("PPR_CONSULTANT_ID")]
        public string PprConsultantId {get; set;}

        [JsonProperty("CLAIM_TYPE_ID")]
        public string ClaimTypeId {get; set;}

        [JsonProperty("STATUS_TYPE_ID")]
        public string StatusTypeId {get; set;}

        [JsonProperty("CLAIM_NUMBER")]
        public string ClaimNumber {get; set;}

        [JsonProperty("POLICY_NUMBER")]
        public string PolicyNumber {get; set;}

        [JsonProperty("PEER_NUMBER")]
        public string PeerNumber {get; set;}

        [JsonProperty("CLAIMANT_NUMBER")]
        public string ClaimentNumber {get; set;}

        [JsonProperty("HOLDER_NUMBER")]
        public string HolderNumber {get; set;}

        [JsonProperty("REFERRED_BY_GP")]
        public string ReferredByGp {get; set;}

        [JsonProperty("GP_VISIT_DATE")]
        public string GPVisitDate {get; set;}

        [JsonProperty("REVIEW_DATE")]
        public string ReveiwDate {get; set;}

        [JsonProperty("IN_PAY_AMOUNT")]
        public string InPayAmount {get; set;}

        [JsonProperty("NO_OF_PAYOUTS")]
        public string NoOfPayouts {get; set;}

        [JsonProperty("IS_CASE_MANAGED")]
        public string IsCaseManaged {get; set;}

        [JsonProperty("START_ACCEPTANCE")]
        public string StartAcceptance {get; set;}

        [JsonProperty("END_ACCEPTANCE")]
        public string EndAcceptance {get; set;}

        [JsonProperty("CLAIM_REFEREE")]
        public string ClaimReferee {get; set;}

        [JsonProperty("POLICY_START_DATE")]
        public string PolicyStartDate {get; set;}

        [JsonProperty("PPR_RADIUS")]
        public string PprRadius {get; set;}

        [JsonProperty("PPR_POSTCODE")]
        public string PprPostode {get; set;}

        [JsonProperty("NO_PPR_REASON")]
        public string NoPprReason {get; set;}

        [JsonProperty("IS_THIRD_PARTY_CLAIM")]
        public string IsThirdPartClaim {get; set;}

        [JsonProperty("HOT_MESSAGE")]
        public string HotMessage {get; set;}

        [JsonProperty("CREATED_BY")]
        public string CreatedBy {get; set;}

        [JsonProperty("CREATION_DATE")]
        public string CreationDate {get; set;}

        [JsonProperty("AMENDED_BY")]
        public string AmendedBy {get; set;}

        [JsonProperty("AMEND_DATE")]
        public string AmedDate {get; set;}

        [JsonProperty("INSURED_LIFE_ID")]
        public string InsuredLifeId {get; set;}

        [JsonProperty("NHS_CASH_PROOF")]
        public string NhsCashProof {get; set;}

        [JsonProperty("WORK_OBJECT_KEY")]
        public string WorkObjectKey {get; set;}

        [JsonProperty("REVIEW_DATE_LETTER_SENT")]
        public string ReviewDateLetterSent {get; set;}

        [JsonProperty("CHANGED_FLAG")]
        public string ChangedFlag {get; set;}

        [JsonProperty("DPN_REFUSED")]
        public string DpnRefused {get; set;}

        [JsonProperty("MIGRATED_CLAIM_ID")]
        public string MigratedClaimId {get; set;}

        [JsonProperty("MI_CHANGE_FLAG")]
        public string MiChangeFlag {get; set;}

        [JsonProperty("CLIENT_TYPE_ID")]
        public string ClientTypeId {get; set;}

        [JsonProperty("LOCK_FLAG")]
        public string LockFlag {get; set;}

        [JsonProperty("IS_PHYSIOTHERAPY_NETWORK")]
        public string IsPhysiotherapyNetwork {get; set;}

        [JsonProperty("CONSULTATION_REFERENCE_NUMBER")]
        public string ConsultationReferenceNumber {get; set;}

        [JsonProperty("IS_ACTIVE")]
        public string IsActive {get; set;}

        [JsonProperty("EDI_MEMBER_LOCK")]
        public string EdiMemberLock {get; set;}

        [JsonProperty("DECLINE_DATE")]
        public string DeclineDate {get; set;}

        [JsonProperty("IS_CLAIM_FORM_RECEIVED")]
        public string IsClaimFormReceived {get; set;}

        [JsonProperty("DOC_TO_PRI_MEMIS_ALTERNATIVE_ADDRESS")]
        public string DocToPriMemisAlternativeAddress {get; set;}
    }
}