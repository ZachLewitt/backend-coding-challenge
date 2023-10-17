# Backend Coding Challenge

This repository contains solutions to two coding challenges. The solutions have been developed as .NET 7 console applications. Both solutions have supporting test projects which have been developed using SpecFlow.

Further details of each project can be found in the project README's:

[FizzBuzz App]('./BackendCodingChallenge.FizzBuzz.App/README.md')

[FizzBuzz Tests]('./BackendCodingChallenge.FizzBuzz.Tests/README.md')

[Factorial App]('./BackendCodingChallenge.Factorial.App/README.md')

[Factorial Tests]('./BackendCodingChallenge.Factorial.Tests/README.md')

## Additional Considerations

- Could any logic be shared between solutions?
- Introduce logging framework
- Potentially make the IFizzBuzzRules more concrete by making them more specific to the conditions and less configurable to reduce unnecessary complexity
- `FizzBuzzApp` is not currently being unit tested. This could be remedied by adding an interface to `FizzBuzzEngine` and mocking it in a unit test to ensure the correct values are passed to the engine.
