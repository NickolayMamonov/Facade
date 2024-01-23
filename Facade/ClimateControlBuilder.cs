namespace Facade;

public class ClimateControlBuilder
{
    private ClimateControl _climateControl;

    public ClimateControlBuilder()
    {
        _climateControl = new ClimateControl();
    }

    public ClimateControl Build()
    {
        return _climateControl;
    }
    public ClimateControlBuilder SetMinTemp(int minTemp)
    {
        _climateControl.SetMinTemp(minTemp);
        return this;
    }

    public ClimateControlBuilder SetMaxTemp(int maxTemp)
    {
        _climateControl.SetMaxTemp(maxTemp);
        return this;
    }

    public ClimateControlBuilder SetCurrentTemp(int currentTemp)
    {
        _climateControl.SetCurrentTemp(currentTemp);
        return this;
    }
}