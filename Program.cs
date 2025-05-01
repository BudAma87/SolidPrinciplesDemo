using SRP;
using OCP;
using LSP;
using ISP;
using DIP;

Console.WriteLine("=== Single Responsibility Principle ===");
var employee = new Employee { Name = "John", Salary = 50000 };
var calculator = new SalaryCalculator();
var updatedSalary = calculator.CalculateSalary(employee);
Console.WriteLine($"Updated Salary: {updatedSalary}");

Console.WriteLine("\n=== Open/Closed Principle ===");
var paymentProcessor = new PaymentProcessor();
paymentProcessor.Pay(new CreditCardPayment());
paymentProcessor.Pay(new PayPalPayment());

Console.WriteLine("\n=== Liskov Substitution Principle ===");
List<Bird> birds = new() { new Sparrow(), new Ostrich() };
foreach (var bird in birds) bird.Eat();
IFlyable flyingBird = new Sparrow();
flyingBird.Fly();

Console.WriteLine("\n=== Interface Segregation Principle ===");
IWorkable human = new HumanWorker();
IEatable eater = new HumanWorker();
IWorkable robot = new RobotWorker();
human.Work();
eater.Eat();
robot.Work();

Console.WriteLine("\n=== Dependency Inversion Principle ===");
ILogger logger = new ConsoleLogger();
var productService = new ProductService(logger);
productService.AddProduct("Laptop");