
Feature: Data about a claims
    As a Healthcare Associate 
    I want specific details of the claim to be displayed when I view it
    So that I can understand the nature of the claim

    Scenario: List is returned
	    When I retrieve a claim
	    Then I will be able to view the following information about it
            |Claim Data                             |
            |CLAIM_ID                               |
            |PPR_CONSULTANT_ID                      |
            |CLAIM_TYPE_ID                          |
            |STATUS_TYPE_ID                         |
            |CLAIM_NUMBER                           |
            |POLICY_NUMBER                          |
            |PEER_NUMBER                            |
            |CLAIMANT_NUMBER                        |
            |HOLDER_NUMBER                          |
            |REFERRED_BY_GP                         |
            |GP_VISIT_DATE                          |
            |REVIEW_DATE                            |
            |IN_PAY_AMOUNT                          |
            |NO_OF_PAYOUTS                          |
            |IS_CASE_MANAGED                        |
            |START_ACCEPTANCE                       |
            |END_ACCEPTANCE                         |
            |CLAIM_REFEREE                          |
            |POLICY_START_DATE                      |
            |PPR_RADIUS                             |
            |PPR_POSTCODE                           |
            |NO_PPR_REASON                          |
            |IS_THIRD_PARTY_CLAIM                   |
            |HOT_MESSAGE                            |
            |CREATED_BY                             |
            |CREATION_DATE                          |
            |AMENDED_BY                             |
            |AMEND_DATE                             |
            |INSURED_LIFE_ID                        |
            |NHS_CASH_PROOF                         |
            |WORK_OBJECT_KEY                        |
            |REVIEW_DATE_LETTER_SENT                |
            |CHANGED_FLAG                           |
            |DPN_REFUSED                            |
            |MIGRATED_CLAIM_ID                      |
            |MI_CHANGE_FLAG                         |
            |CLIENT_TYPE_ID                         |
            |LOCK_FLAG                              |
            |IS_PHYSIOTHERAPY_NETWORK               |
            |CONSULTATION_REFERENCE_NUMBER          |
            |IS_ACTIVE                              |
            |EDI_MEMBER_LOCK                        |
            |DECLINE_DATE                           |
            |IS_CLAIM_FORM_RECEIVED                 |
            |DOC_TO_PRI_MEMIS_ALTERNATIVE_ADDRESS   |