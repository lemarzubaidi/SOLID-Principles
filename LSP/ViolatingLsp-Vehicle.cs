using System;
public class Vehcile { 
public virtual void StartEngine()
    {
        Console.WriteLine("Starting the vehicle's engine...");
    }
    public virtual void Drive()
    {
        Console.WriteLine("Driving...");
    }

}

public class Car : Vehcile
{
    public override void StartEngine()
    {
        Console.WriteLine("Starting the car's engine...");
    }
    public override void Drive()
    {
        Console.WriteLine("Driving the car...");
    }
}

public class  Bicycle:Vehcile
{
    public override void StartEngine()
    {
        //wrong 
        Console.WriteLine("Bicycles don't have engines to start.");

    }
    public override void Drive()
    {
        Console.WriteLine("Riding the bicycle...");
    }
}

public class program
{
    public static void Main(string[] args)
    {
        Vehcile myCar = new Car();
        myCar.StartEngine();
        myCar.Drive();
        Vehcile myBicycle = new Bicycle();
        myBicycle.StartEngine();
        myBicycle.Drive();
    }
}

