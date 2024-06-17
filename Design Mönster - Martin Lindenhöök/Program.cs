namespace Design_Mönster___Martin_Lindenhöök;

class Program
{
    static void Main(string[] args)
    {
        
        
        Menu();

        void Menu()
        {
            
            var notifier = new PaymentNotifier();  //Del av Observer
            var observer1 = new PaymentObserver("Kassan");
            var observer2 = new PaymentObserver("Chefen");

            notifier.Attach(observer1);
            notifier.Attach(observer2);

            
            Console.WriteLine("Hej!");
            Console.WriteLine("Vad Vill du göra?\n 1. Betala för din kaffe\n 2. Avsluta");
            Console.WriteLine("Skriv en siffra från ovan");
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.WriteLine($"\n Du tryckte på {userInput.KeyChar}!");
            
            int inputToInt = userInput.KeyChar - '0';
            switch (inputToInt)
            {
                case 1 : // Del av Factory Method, Singleton, Observer
                    //Console.Clear();
                    Console.WriteLine("Vilken metod vill du använda för att betala?\n1. Kredit Kort\n2. Google Pay\n3. Apple Pay\n4. Paypal");
                    ConsoleKeyInfo paymentMethod = Console.ReadKey();
                    int metod = paymentMethod.KeyChar - '0';
                    double kaffe = 20;
                    string[] valutor = {"SEK", "USD"};
                    switch (metod)
                    {
                        case 1:
                            IPayment paymentCreditCard = PaymentFactory.Instance.Create(Payment.CreditCard);
                            paymentCreditCard.Pay(kaffe);
                            notifier.Notify($"Kund har betalt {kaffe} {valutor[0]} med Kredit Kort");
                            Console.WriteLine("Tryck på valfri knapp för att forsätta.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Välkommen tillbaka till menyn");
                            Menu();
                            break;
                        case 2:
                            IPayment paymentGooglePay = PaymentFactory.Instance.Create(Payment.GooglePay);
                            paymentGooglePay.Pay(kaffe);
                            notifier.Notify($"Kund har betalt {kaffe} {valutor[0]} med Google Pay"); 
                            Console.WriteLine("Tryck på valfri knapp för att forsätta.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Välkommen tillbaka till menyn");
                            Menu();
                            break;
                        case 3:
                            IPayment paymentApplePay = PaymentFactory.Instance.Create(Payment.ApplePay);
                            paymentApplePay.Pay(kaffe);
                            notifier.Notify($"Kund har betalt {kaffe} {valutor[0]} med Apple Pay"); 
                            Console.WriteLine("Tryck på valfri knapp för att forsätta.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Välkommen tillbaka till menyn");
                            Menu();
                            break;
                        case 4:
                            IPayment paymentPayPal = PaymentFactory.Instance.Create(Payment.PayPal);
                            paymentPayPal.Pay(kaffe);
                            notifier.Notify($"Kund har betalt {kaffe} {valutor[0]} med PayPal");
                            Console.WriteLine("Tryck på valfri knapp för att forsätta.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Välkommen tillbaka till menyn");
                            Menu();
                            break;
                    }
                    break;
                case 2 :
                    
                    break;
                    
            }
        }
    }
}