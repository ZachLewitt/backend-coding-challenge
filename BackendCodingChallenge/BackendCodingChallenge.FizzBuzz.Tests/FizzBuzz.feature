Feature: FizzBuzz
    As a user
    I want to enter a number and receive either Fizz, Buzz, or FizzBuzz
    So that I can determine if the number is a multiple of 3, 5, or both,

Scenario Outline: The correct response is output based on the number
    Given the input number is <Number>
    When the number is processed
    Then the result should be <Result>
Examples:
    | Number | Result   |
    | 0      | 0        |
    | 1      | 1        |
    | 2      | 2        |
    | 3      | Fizz     |
    | 5      | Buzz     |
    | 15     | FizzBuzz |
