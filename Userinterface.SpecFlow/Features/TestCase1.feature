﻿Feature: User authentication 

@tc001
Scenario: Validation that user authentication on the game page is successful
    Given I navigate to home page
    Then Home page is opened
    When I click the next page link
    Then Card '1' is open
    When I register random user
        And I click Next button on the first card
    Then Card '2' is open
    When I unselect all interests
        And I select '3' random interests
        And I upload an image
        And I click Next button on the second card
    Then Card '3' is open