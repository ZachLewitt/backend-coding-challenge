﻿using TechTalk.SpecFlow;

namespace BackendCodingChallenge.FizzBuzz.Tests;

[Binding]
public class FizzBuzzContext
{
    public int InputNumber { get; set; } = 1;

    public string? Result { get; set; }
}