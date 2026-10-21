using System;

public class Bird
{
    public virtual void Eat()
    {
        Console.WriteLine("Eating...");
    }
    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}
public class Eagle : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Eagle is eating...");
    }
    public override void Fly()
    {
        Console.WriteLine("Eagle is flying...");
    }
}

public class Ostrich : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Ostrich is eating...");
    }
    public override void Fly()
    {
        throw new NotSupportedException("Ostriches cannot fly.");
    }
}
    public class Program
    {
        public static void Main(string[] args)
        {
            Bird bird1 = new Eagle();
            bird1.Eat();
            bird1.Fly();
            Bird ostrich = new Ostrich();
            ostrich.Eat();
            try
            {
                ostrich.Fly();
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }


