# CalculatorApp

This project is an ASP.NET Core MVC application built to demonstrate Dependency Injection and Separation of Concerns.

## ## Description

The application features a simple calculator service that is injected into a controller to perform calculations. The result is then displayed on the home page.

## ## Key Concepts Demonstrated

- **Dependency Injection (DI):** The `ICalculator` service is injected into the `HomeController`.
- **Separation of Concerns (SoC):** Business logic (the calculation) is separated into its own service, distinct from the controller.
- **Service Lifetimes:** The service is registered with a `Scoped` lifetime in `Program.cs`.

## ## How to Run

1.  Clone the repository.
2.  Open the solution file (`.sln`) in Visual Studio.
3.  Press F5 to build and run the project.
