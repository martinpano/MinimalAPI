# MinimalAPI
A minimal api demo project for the purpose of a knowledge sharing session

### Overview 🧐

Demo project which serves for demonstration of the minimal api concepts in .NET 6 preview 7. There are two folders created in this repo, both of them containing one console application and one web application. The difference is in the version of the .NET framework. The 3.x folder uses 3.1.412 version of .NET and the 6.x folder uses 6.0.100-preview.7.21379.14. The idea is to compare the difference between an empty web project created with 3.x .net version and 6.x .net version. 

### Setup for test  ⚙️

If you want to play around with this project you need to keep in mind several things before run of the project (minimal API) in the 6.x folder.

* Install the latest version of .NET 6 which is still in preview
* Have at least .NET 6 preview 4 (minimal API concept starts from that preview version)
* Work in VSCode, there is not a .sln file for this demo app
* Use dotnet cli commands to run/build the project


## YAKSS 📚

1. .NET evolution  

* .NET 5.0 is the next major release of .NET Core following 3.1. It is named .NET 5.0 instead of .NET Core 4.0 for two reasons:
* Version numbers 4.x are skipped to avoid confusion with .NET Framework 4.x.
* "Core" is dropped from the name to emphasize that this is the main implementation of .NET going forward. .NET 5.0 supports more types of apps and more platforms than .NET Core or .NET Framework.
* ASP.NET Core 5.0 is based on .NET 5.0 but retains the name "Core" to avoid confusing it with ASP.NET MVC 5. Likewise, Entity Framework Core 5.0 retains the name "Core" to avoid confusing it with Entity Framework 5 and 6.

2. Few new features from .NET5 and C# 9  

* Developers writing .NET 5 apps will have access to the latest C# version and features. .NET 5 is paired with C# 9, which brings many new features to the language
* Top-level statements: As a means for accelerating adoption and learning of C#, the Main method can be omitted and application as simple as the following is valid.

Going from this

    ```
    using System;
    namespace ConsoleApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
    ```


Into this  

    ```csharp
        Console.WriteLine("Hello, World!");
    ```

3. MinimalAPI  

* In .NET 6, minimal APIs are introduced for hosting and routing in web applications. 
* This opens the doors for new developers building their first web application with .NET and to our existing customers who want to build small microservices and HTTP APIs. 
* These streamlined APIs provide the benefits of ASP.NET MVC with less ceremony.


## Used links
[ASP.NET Core updates in .NET 6 Preview 4](https://devblogs.microsoft.com/aspnet/asp-net-core-updates-in-net-6-preview-4/)  
[Building Minimal APIs In .NET 6](https://dotnetcoretutorials.com/2021/07/16/building-minimal-apis-in-net-6/)  
[Getting Setup With .NET 6 Preview](https://dotnetcoretutorials.com/2021/03/13/getting-setup-with-net-6-preview/)  
[MinimalAPIPlayground - Github](https://github.com/DamianEdwards/MinimalApiPlayground)  
