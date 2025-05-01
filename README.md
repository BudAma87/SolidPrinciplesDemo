# Solid Principles Demo

This repository demonstrates the implementation of the SOLID principles in C#. Each principle is implemented in its own folder with relevant classes and interfaces.

## Project Structure

- **DIP/**: Demonstrates the Dependency Inversion Principle.
  - `ConsoleLogger.cs`: A concrete implementation of the `ILogger` interface.
  - `ILogger.cs`: Interface for logging.
  - `ProductService.cs`: A service that depends on the `ILogger` interface.

- **ISP/**: Demonstrates the Interface Segregation Principle.
  - `HumanWorker.cs`: A class implementing both `IEatable` and `IWorkable` interfaces.
  - `IEatable.cs`: Interface for eatable entities.
  - `IWorkable.cs`: Interface for workable entities.
  - `RobotWorker.cs`: A class implementing only the `IWorkable` interface.

- **LSP/**: Demonstrates the Liskov Substitution Principle.
  - `Bird.cs`: Base class for birds.
  - `IFlyable.cs`: Interface for flyable entities.
  - `Ostrich.cs`: A bird that does not implement `IFlyable`.
  - `Sparrow.cs`: A bird that implements `IFlyable`.

- **OCP/**: Demonstrates the Open/Closed Principle.
  - `CreditCardPayment.cs`: A concrete implementation of the `IPaymentMethod` interface.
  - `IPaymentMethod.cs`: Interface for payment methods.
  - `PaymentProcessor.cs`: A class that processes payments using `IPaymentMethod`.
  - `PayPalPayment.cs`: Another implementation of the `IPaymentMethod` interface.

- **SRP/**: Demonstrates the Single Responsibility Principle.
  - `Employee.cs`: A class representing an employee.
  - `SalaryCalculator.cs`: A class responsible for calculating salaries.

## How to Run

1. Open the solution file `SolidPrinciplesDemo.sln` in Visual Studio.
2. Build the solution to restore dependencies and compile the code.
3. Run the project to see the implementation of the SOLID principles in action.

## Requirements

- .NET 9.0 SDK or later
- Visual Studio 2022 or later

## License

This project is licensed under the MIT License. See the LICENSE file for details.