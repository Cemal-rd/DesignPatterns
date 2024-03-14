// gidip kontrol etmek yerine sürekli bunun için haber almak istiyor.Türkçede izleyici.Biir değişiklik olduğunda haber almak için.

using System;
using System.Collections.Generic;

// Gözlemci arayüzü
interface IObserver
{
    void Update(float temperature);
}

// Konu arayüzü
interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// Somut Konu
class WeatherStation : ISubject
{
    private List<IObserver> observers;
    private float temperature;

    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(float temperature)
    {
        this.temperature = temperature;
        NotifyObservers();
    }
}

// Somut Gözlemci
class Display : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Sıcaklık güncellendi: " + temperature);
    }
}

class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        Display display = new Display();
        weatherStation.RegisterObserver(display);

        // Hava durumu istasyonunda sıcaklık güncellendiğinde, gözlemcilere haber verilir
        weatherStation.SetTemperature(25.5f);

        Console.ReadLine();
    }
}
