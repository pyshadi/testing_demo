# StatisticsCalculator (testing demo)

StatisticsCalculator is a C# library for calculating basic statistical measures, including mean, variance, and standard deviation from a list of numbers.

## Getting Started

These instructions will help you get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later

### Installing

Clone the repository to your local machine:

```
git clone https://github.com/pyshadi/testing_demo.git
cd testing_demo/StatisticsCalculator
dotnet build
dotnet test
```

### Usage
Here is a simple example of how to use the Statistics class to calculate the mean, variance, and standard deviation of a list of numbers:
```
using StatisticsCalculator;
using System.Collections.Generic;

var numbers = new List<double> { 1, 2, 3, 4, 5 };
var statsCalculator = new Statistics();

var mean = statsCalculator.Mean(numbers);
var variance = statsCalculator.Variance(numbers);
var standardDeviation = statsCalculator.StandardDeviation(numbers);

System.Console.WriteLine($"Mean: {mean}");
System.Console.WriteLine($"Variance: {variance}");
System.Console.WriteLine($"Standard Deviation: {standardDeviation}");
```

### License
