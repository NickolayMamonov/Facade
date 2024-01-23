using Facade;

public static class Program
{
    public static void Main(string[] args)
    {
        
        Engine engine = new Engine();
        ClimateControl climateControl = new ClimateControlBuilder()
            .SetMinTemp(-30)
            .SetMaxTemp(30)
            .SetCurrentTemp(0)
            .Build();
        CarFacade carFacade = CarFacade.GetInstance(engine, climateControl);
        carFacade.StartEngine();
        carFacade.ChangeTemp(20);
        carFacade.StopEngine();
    }
}