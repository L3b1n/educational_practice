# Refactoring Exception Guard Clauses

A beginner level task for practicing refactoring and exception throwing.


## Get the Project

* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

Read articles in *See also* section first.

The **ThrowingExceptions.cs**  file contains methods that throws exceptions in case of passing incorrect pararameters. The problem is the code uses wrong exception classes, and you have to replace the exception classes with the classes that suits best in each situation.

### 1. Use Proper Exception Class

Read the description of ArgumentException, ArgumentNullException, ArgumentOutOfRangeException, and IndexOutOfRangeException exception classes to understand what exception class works best in "throw" language construction.

Example - a method argument is not valid.

```cs
public static int ConvertHexCharToInteger(char c)
{
    if (int.TryParse($"{c}", NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int result))
    {
        return result;
    }

    throw new Exception("c is not a hex char.");
}
```

The [description of ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception) says "The exception that is thrown when one of the arguments provided to a method is not valid", and this means using ArgumentException is more descriptive and clear than using Exception class.

```cs
public static int ConvertHexCharToInteger(char c)
{
    if (int.TryParse($"{c}", NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int result))
    {
        return result;
    }

    throw new ArgumentException("c is not a hex char.");
}
```

### 2. Set Parameter Name

Argument exceptions has a special "paramName" parameter in the class constructor, that contains the name of the parameter that caused the current exception. Read the exception constructors documentation pages, and set an argument name when throwing exceptions.

Example - a method argument "c" is not valid.

A [constructor description for ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.-ctor?view=net-5.0#System_ArgumentException__ctor_System_String_System_String_) says "Initializes a new instance of the ArgumentException class with a specified error message and the name of the parameter that causes this exception".

```cs
public ArgumentException(string message, string paramName);
```

Add an argument (parameter) name to the constructor call using _nameof_ expression.

```cs
public static int ConvertHexCharToInteger(char c)
{
    if (int.TryParse($"{c}", NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int result))
    {
        return result;
    }

    throw new ArgumentException("c is not a hex char.", nameof(c));
}
```


## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintaining consistency of the project source code and avoiding silly mistakes. [Review the Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google the error or warning code to get more information about the issue.


## Save Your Work

* [Rebuild your solution](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio) in Visual Studio.
* Check out the [Error List window](https://docs.microsoft.com/en-us/visualstudio/ide/reference/error-list-window) for compiler errors and warnings. If you have any of those issues, **fix issues** and rebuild the solution again.
* [Run all unit tests with Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer) and make sure there are **no failed unit tests**. Fix your code to [make all your unit tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing).
* Review all your changes **before** saving your work.
    * Open "Changes" view in [Team Explorer](https://docs.microsoft.com/en-us/visualstudio/ide/reference/team-explorer-reference).
    * Click with your right mouse button on a modified file.
    * Click on "Compare with Unmodified" menu item to open a comparison window.
* [Stage your changes](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#stage-your-changes) and [create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#create-a-commit).
* Share your changes by [pushing them to remote repository](https://docs.microsoft.com/en-us/azure/devops/repos/git/pushing).


## See also

* [Guard Clauses Explained](https://medium.com/@maximegel/what-are-guard-clauses-and-how-to-use-them-350c8f1b6fd2)
* [Using Standard Exception Types](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/using-standard-exception-types)
* [nameof expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)
* .NET API
  * [ArgumentException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)
  * [ArgumentNullException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)
  * [ArgumentOutOfRangeException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)
  * [IndexOutOfRangeException Class](https://docs.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception)
