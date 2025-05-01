namespace OCP;
public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment() => Console.WriteLine("Paid with Credit Card");
}