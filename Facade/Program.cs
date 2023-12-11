using Facade;

public static class Program
{
    public static void Main(string[] args)
    {
        Engine engine = new Engine();
        ClimateControl climateControl = new ClimateControl();
        
        CarFacade carFacade = new CarFacade(engine,climateControl);
        
        carFacade.StartEngine();
        Console.WriteLine($"Engine is started: {engine.IsStarted}");
        
        carFacade.ChangeTemp(15);
        Console.WriteLine($"Current temperature: {climateControl.currentTemp}");
        
        carFacade.StopEngine();
        Console.WriteLine($"Engine is stopped: {engine.IsStarted}");
    }
}