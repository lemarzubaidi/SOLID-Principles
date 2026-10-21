using System;
public class Vehcile
{
  
    public virtual void Drive()
    {
        Console.WriteLine("Driving...");
    }

}
public class HaveEngineVehicle : Vehcile
{
    public virtual void StartEngine()
    {
        Console.WriteLine("This vehicle have an engine to start.");
    }
}
public class Car : HaveEngineVehicle
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

public class Bicycle : Vehcile
{
   
  
    public override void Drive()
    {
        Console.WriteLine("Riding the bicycle...");
    }
}

public class program
{
    public static void Main(string[] args)
    {
        HaveEngineVehicle myCar = new Car();
        myCar.StartEngine();
        myCar.Drive();
        Vehcile myBicycle = new Bicycle();
      
        myBicycle.Drive();
    }
}