﻿namespace Design_Mönster___Martin_Lindenhöök;

public class PayPalPayment: IPayment // Del av Factory Method
{
    public void Pay(double amount)
    {
        Console.Clear();
        Console.WriteLine($"Successfully paid ${amount} to merchant using PayPal");
    }
    
}