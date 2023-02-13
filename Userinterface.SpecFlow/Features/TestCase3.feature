Feature: Cookies form

@tc003
Scenario: Validation that cookies form on the Game page is closing
    Given I navigate to home page
    Then Home page is opened
    When I click the next page link
    Then Game page is opened
    When I accept Cookies
    Then Cookies form is closed