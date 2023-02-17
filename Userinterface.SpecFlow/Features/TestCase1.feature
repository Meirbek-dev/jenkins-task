Feature: User authentication 

@tc001
Scenario: Validation that user authentication on the game page is successful
    Given I navigate to home page
    Then Home page is opened
    When I click the next page link
    Then Card '1' is open