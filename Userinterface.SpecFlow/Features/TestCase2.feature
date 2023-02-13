Feature: Help form

@tc002
Scenario: Validation that help form content on the Game page is hiding
    Given I navigate to home page
    Then Home page is opened
    When I click the next page link
    Then Game page is opened
    When I hide help form
    Then Help form content is hidden