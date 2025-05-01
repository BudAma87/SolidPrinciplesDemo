namespace OCP;
public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment() => Console.WriteLine("Paid with PayPal");
}