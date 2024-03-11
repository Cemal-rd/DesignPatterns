﻿using System;
using System.Diagnostics;

namespace DesignPatterns.DecoratorPattern.Computers;

public class Computer
{
    public void Start()
    {
        Console.WriteLine($"{GetType().Name} is starting");
    }

    public void ShutDown()
    {
        Console.WriteLine($"{GetType().Name} is shutting down");
    }
}


public class Laptop : Computer
{
    public void OpenLid()
    {
        Debug.WriteLine($"{GetType().Name}'s lid is opening");
    }

    public void CloseLid()
    {
        Debug.WriteLine($"{GetType().Name}'s lid is closing");
    }
}



public class LaptopDecorator : Laptop
{
    public virtual void OpenLid()
    {
        // do something
        base.OpenLid();
    }

    public virtual void CloseLid()
    {
        base.CloseLid();
        
    }
}


public class DellLaptop : LaptopDecorator
{
    public override void CloseLid()
    {
        base.CloseLid();
        Debug.WriteLine("Dell Laptop is sleeping");
    }

    public override void OpenLid()
    {
        Console.WriteLine("Dell Laptop is waking up");
        base.OpenLid();
    }
}
public class AppleLaptop : Laptop
{

}