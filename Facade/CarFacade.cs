namespace Facade;

public class CarFacade
{
    private Engine _engine;
    private ClimateControl _climateControl;
    private static CarFacade _instance;

    private CarFacade(Engine engine, ClimateControl climateControl)
    {
        _engine = engine;
        _climateControl = climateControl;
    }

    public static CarFacade GetInstance(Engine engine, ClimateControl climateControl)
    {
        if (_instance == null)
        {
            _instance = new CarFacade(engine, climateControl);
        }

        return _instance;
    }

    public void StartEngine()
    {
        if (!_engine.IsStarted)
        {
            _engine.Start();
            Console.WriteLine("Автомобиль запустили...");
        }
    }

    public void StopEngine()
    {
        if (_engine.IsStarted)
        {
            _engine.Stop();
            Console.WriteLine("Автомобиль выключили...");
        }
    }


    public void ChangeTemp(int curTemp)
    {
        if (curTemp < _climateControl.currentTemp)
        {
            _climateControl.ReduceTemp(curTemp);
        }
        else if (curTemp > _climateControl.currentTemp)
        {
            _climateControl.IncreaseTemp(curTemp);
        }

        Console.WriteLine($"Температуру в салоне изменили на {curTemp}");
    }
}