namespace OCP;
public class PaymentProcessor
{
    public void Pay(IPaymentMethod paymentMethod)
    {
        paymentMethod.ProcessPayment();
    }
}