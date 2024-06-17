namespace Design_Mönster___Martin_Lindenhöök;

public sealed class PaymentFactory //Singleton och Factory
{
    //privat variabel för att köra en enkel instans
    private static readonly Lazy<PaymentFactory> lazyInstance = new Lazy<PaymentFactory>(() => new PaymentFactory());
    
    private PaymentFactory() //privat constructor så man inte kan skapa en till.
    {
    }
    
    public static PaymentFactory Instance
    {
        get
        {
            return lazyInstance.Value;
        }
    }
    
    public IPayment Create(Payment paymentMethod) // Del av Factory Method 
    {
        switch (paymentMethod)
        {
            case Payment.CreditCard:
                return new CreditCardPayment();
            case Payment.GooglePay:
                return new GooglePayment();
            case Payment.ApplePay:
                return new ApplePayment();
            case Payment.PayPal:
                return new PayPalPayment();
            default:
                throw new ArgumentException("Invalid payment method");
        }
    }
}