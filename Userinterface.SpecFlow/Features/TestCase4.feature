Feature: Timer

@tc004
Scenario: Validation that timer on the Game page starts from "00:00:00"
    Given I navigate to home page
    Then Home page is opened
    When I click the next page link
    Then Game page is opened
        And Timer starts at '00:00:00'