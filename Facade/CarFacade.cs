namespace Facade;

public class CarFacade
{
    private Engine _engine;
    private ClimateControl _climateControl;

    public CarFacade(Engine engine, ClimateControl climateControl)
    {
        _engine = engine;
        _climateControl = climateControl;
    }

    public void StartEngine()
    {
        if (!_engine.IsStarted)
        {
            _engine.Start();
        }
    }

    public void StopEngine()
    {
        if (_engine.IsStarted)
        {
            _engine.Stop();
        }
    }

    public void ChangeTemp(int curTemp)
    {
        if (curTemp < _climateControl.currentTemp)
        {
            _climateControl.ReduceTemp(curTemp);
        }
        else if(curTemp > _climateControl.currentTemp)
        {
            _climateControl.IncreaseTemp(curTemp);
        }
    }
}