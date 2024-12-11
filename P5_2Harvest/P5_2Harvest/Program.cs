namespace P5_2Harvest;
public class Plant
{
    public void CanGrow()
    {
        Console.WriteLine("I can grow.");
    }
}

public class Grain : Plant
{
    public void CanBeHarvested()
    {
        Console.WriteLine("I can be harvested.");
    }
}

public class Wheat : Grain
{
    public void CanBeProcessedToBread()
    {
        Console.WriteLine("I can be processed to bread.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Plant plant = new Plant();
        Grain grain = new Grain();
        Wheat wheat = new Wheat();

        Console.WriteLine("Plant methods:");
        plant.CanGrow();

        Console.WriteLine("\nGrain methods:");
        grain.CanGrow();
        grain.CanBeHarvested();

        Console.WriteLine("\nWheat methods:");
        wheat.CanGrow();
        wheat.CanBeHarvested();
        wheat.CanBeProcessedToBread();
    }
}
