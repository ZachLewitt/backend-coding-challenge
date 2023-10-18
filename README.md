# Backend Coding Challenge

This repository contains solutions to two coding challenges. The solutions have been developed as .NET 7 console applications. Both solutions have supporting test projects which have been developed using SpecFlow.

## Project Structure

The solution is comprised of the following projects:

### FizzBuzz.App

This is the entry point for the FizzBuzz console application. This is a thin console application that hosts the components in the FizzBuzz.Lib.

Info on how to run can be found here - [FizzBuzz App](BackendCodingChallenge/BackendCodingChallenge.FizzBuzz.App/README.md)

### FizzBuzz.Lib

The service layer logic for the FizzBuzz application. This contains the bulk of the logic for the application. The components in this library are covered by the tests in FizzBuzz.Tests.

[FizzBuzz Lib](BackendCodingChallenge/BackendCodingChallenge.FizzBuzz.Lib/README.md)

### FizzBuzz.Tests

This is a SpecFlow test project that contains BDD spec tests for the components in the FizzBuzz.Lib.

Info on how to run can be found here - [FizzBuzz Tests](BackendCodingChallenge/BackendCodingChallenge.FizzBuzz.Tests/README.md)

### Factorial.App

This is the entry point for the Factorial console application. This is a thin console application that hosts the components in the Factorial.Lib.

Info on how to run can be found here - [Factorial App](BackendCodingChallenge/BackendCodingChallenge.Factorial.App/README.md)

### Factorial.Lib

The service layer logic for the Factorial application. This contains the bulk of the logic for the application. The components in this library are covered by the tests in Factorial.Tests.

[Factorial Lib](BackendCodingChallenge/BackendCodingChallenge.Factorial.Lib/README.md)

### Factorial.Tests

This is a SpecFlow test project that contains BDD spec tests for the components in the Factorial.Lib.

Info on how to run can be found here - [Factorial Tests](BackendCodingChallenge/BackendCodingChallenge.Factorial.Tests/README.md)

### Utilities

This project contains common 'utility' types that are used across the various projects in the BackendCodingChallenge solution.

## Additional Thoughts

Below are a list of thoughts and considerations that I came across during the development process. This includes changes I would make given more time.

- Introduce logging framework e.g. Serilog.
- Potentially make the IFizzBuzzRules more concrete by making them more specific to the conditions and less configurable to reduce unnecessary complexity
- `FizzBuzzApp` is not currently being unit tested. This could be remedied by adding an interface to `FizzBuzzEngine` and mocking it in a unit test to ensure the correct values are passed to the engine. The current level of coverage seemed appropriate given the time constraints and the low complexity of the `FizzBuzzApp`.
- Fake the logic in the tests closer to the `Console` type. Currently, this is done by introducing fakes for `IInputReader` and `IOutputWriter` but a thin pass through client that directly reflects the `Console` type would give better test coverage.
