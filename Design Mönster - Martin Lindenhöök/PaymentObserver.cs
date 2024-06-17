namespace Design_Mönster___Martin_Lindenhöök;

public class PaymentObserver : IObserver //Del av Observer
{
    private string _name;

    public PaymentObserver(string name)
    {
        _name = name;
    }

    public void Updates(string message)
    {
        Console.WriteLine($"{_name} received update: {message}");
    }
}