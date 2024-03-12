using System;

// Strateji arayüzü
interface IPaymentStrategy
{
    void Pay(double amount);
}

// Kredi kartı ödeme stratejisi
class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Kredi kartı ile {amount} TL ödeme yapıldı.");
    }
}

// PayPal ödeme stratejisi
class PayPalPaymentStrategy : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"PayPal ile {amount} TL ödeme yapıldı.");
    }
}

// Bağlam sınıfı
class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public ShoppingCart(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void Checkout(double amount)
    {
        paymentStrategy.Pay(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ödeme stratejileri oluşturuluyor
        IPaymentStrategy creditCardStrategy = new CreditCardPaymentStrategy();
        IPaymentStrategy paypalStrategy = new PayPalPaymentStrategy();

        // Bağlam sınıfı oluşturuluyor ve seçilen strateji ile checkout işlemi yapılıyor
        ShoppingCart cart1 = new ShoppingCart(creditCardStrategy);
        cart1.Checkout(100.0);

        ShoppingCart cart2 = new ShoppingCart(paypalStrategy);
        cart2.Checkout(200.0);

        Console.ReadLine();
    }
}
