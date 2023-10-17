Feature: Factorial
    As a user
    I want to be able to calculate a factorial
    So that I can determine the number of different permutations given a number of items

Scenario Outline: The factorial is calculated when the user enters a valid number
    Given the user has entered <Number>
    When the user submits the value
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
    | 10     | 3628800|

Scenario: Large factorials can be calculated
    Given the user has entered 99
    When the user submits the value
    Then the result should be 933262154439441526816992388562667004907159682643816214685929638952175999932299156089414639761565182862536979208272237582511852109168640000000000000000000000

Scenario Outline: The user is shown an error message when they enter an invalid value
    Given the user has entered <InvalidValue>
    When the user submits the value
    Then the user should be shown the error '<ErrorMessage>'
Examples:
    | InvalidValue | ErrorMessage                                                                     |
    | -1           | The supplied value is less than zero. The value must be a positive integer.      |
    |              | No value has been provided. The value must be a positive integer.                |
    | null         | The supplied value is not a valid integer. The value must be a positive integer. |
    | one          | The supplied value is not a valid integer. The value must be a positive integer. |

Scenario: The user is shown an error message when there is an error occurs reading the value
    Given an error will occur when the user tries to submit the value
    When the user submits the value
    Then the user should be shown the error 'An error occurred reading the users input'

Scenario: The user is shown an error when they quit the application without submitting a value
    Given the user does not enter a value
    When the user quits the application
    Then the user should be shown the error 'No value has been provided. The value must be a positive integer.'