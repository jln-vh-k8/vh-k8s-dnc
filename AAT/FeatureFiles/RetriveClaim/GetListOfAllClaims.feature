
Feature: Get list of all claims
    As a Healthcare Associate 
    I want to be able to browse a list off all claims 
    So that I can locate the claim I need

    Scenario: List is returned
        Given more than one claim exists
	    When I request the list of all claims
	    Then the list will have more than one claim