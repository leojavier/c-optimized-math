# Prerequisites

Install the .NET Core SDK. The .NET Core SDK includes the latest release of the .NET Core framework and runtime.
`https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install`

## Run the app

In your command prompt, run the following command:

```
dotnet run
```

## Notes:

- for this test I used `Documentation comments` this would provide intellisense to other developers when trying to use the `program` class and the `EvaluateNumber` method.
- regarless the results coming from the if statement, the final output will always start with the sting "The number ". I decided to initialize the variable `msg` with the value `The number` in this case to avoid repeting myself and to simulate Memoization... (It is not necessary in this very naive test, but you would understand the concept). Its worth mention that when using memoization we are trading memory-complexity for time-complexity... so, its an approach that should be evaluated when coding applications where memory space is limited. Ex: embedded systems...
- instead of hardcoding the logic directly within the `Main` method. I extracted in a separated method. It is a pure function (or method in this context), easy to test and reusable.
  -Instead of writing to the console from `EvaluateNumber` method I decided to return the calculated value instead and execute the `Console.WriteLine` from within the for loop. I made it in an effort to make the `EvaluateNumber` method more reusable.
