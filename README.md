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
You can add the following section to your `README.md` file. This text explains the architectural choices you made in your project, which directly addresses the assignment requirement.

---
## Design Notes

This project was built using key software design principles to create a maintainable and testable application.

### ## Separation of Concerns (SoC)

Separation of Concerns is the principle of breaking a program into distinct sections, where each section addresses a separate concern. In this application, we separated the business logic from the user interface (UI) logic.

* **Concern 1: Calculation Logic:** The `Calculator` class is solely responsible for performing calculations. It knows nothing about web requests or how to display data.
* **Concern 2: UI Logic:** The `HomeController` is responsible for handling HTTP requests and deciding which view to show. It doesn't know how to perform the actual calculation; it only knows how to ask for it.

By using the `ICalculator` interface, we created a clean boundary between these concerns. This makes the code easier to manage, debug, and test.

### ## Dependency Injection (DI) Choices

Dependency Injection is a technique where an object receives its dependencies from an external source rather than creating them itself.

* **Service:** `ICalculator`
* **Implementation:** `Calculator`
* **Lifetime:** **`Scoped`**

We registered the `Calculator` service with a **`Scoped`** lifetime in `Program.cs`. A scoped service is created once per client request. While a `Singleton` (one instance for the entire application) or `Transient` (a new instance every time it's requested) could have worked for this simple, stateless service, `Scoped` is a safe and standard choice for web applications. It ensures that if the service were ever expanded to use other resources that are also scoped (like a database connection), it would function correctly without any changes.
