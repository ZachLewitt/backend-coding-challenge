Feature: Factorial
    As a user
    I want to be able to calculate a factorial
    So that I can determine the number of different permutations given a number of items

Scenario Outline: The factorial is calculated when the user enters a valid number
    Given the user has entered <Number>
    When the factorial is calculated
    Then the result should be <Result>
Examples:
    | Number | Result |
    | 0      | 1      |
    | 1      | 1      |
    | 2      | 2      |
    | 3      | 6      |
    | 4      | 24     |
    | 5      | 120    |
    | 6      | 720    |
    | 7      | 5040   |
    | 8      | 40320  |
    | 9      | 362880 |
    | 10     | 1      |
    | 999    | 1      |
    | 999999 | 1      |

Scenario Outline: The user is shown an error when they enter an invalid value
    Given the user has entered <Number>
    When the factorial is calculated
    Then the user should be shown an error
Examples:
    | Number |
    | -1     |
    |        |
    | null   |
    | one    |