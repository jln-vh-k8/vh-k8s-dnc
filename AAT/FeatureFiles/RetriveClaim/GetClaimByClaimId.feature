
Feature: Get claim by claim ID
    As a Claims Assessor
    I want to be able to locate claims by the claim number
    So that I can find the claim from any documentation about the claim


	Scenario: Claim number is valid
	    Given a valid claim number 
	    When I search using the claim number
	    Then the information about the claim should be shown

    Scenario: Claim number does not exist
	    Given a claim number that does not exist
	    When I search using the claim number
	    Then I will be informed the no claims could be found
	    
	    # Comment