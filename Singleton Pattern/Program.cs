using Singleton_Pattern;

class Program
{
    static void Main(string[] args)
    {
        // Singleton nesneye erişim.
        Singleton singleton1 = Singleton.Instance;
        Singleton singleton2 = Singleton.Instance;

        // İki nesne aynı nesne mi kontrolü.
        if (singleton1 == singleton2)
        {
            Console.WriteLine("Aynı singleton nesnesine erişildi.");
        }
        else
        {
            Console.WriteLine("Farklı singleton nesnelerine erişildi.");
        }

        // Singleton sınıfından bir işlem gerçekleştirilir.
        singleton1.DoSomething();

        Console.ReadLine();
    }
}