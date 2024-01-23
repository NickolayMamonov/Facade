namespace Facade;

public class ClimateControl
{
    private int minTemp = -30; 
    public int currentTemp = 0;
    private int maxTemp = 30;

    public void SetMinTemp(int temp) => minTemp = temp;
    public void SetCurrentTemp(int temp) => currentTemp = temp;
    public void SetMaxTemp(int temp) => maxTemp = temp;
    public int ReduceTemp(int curTemp)
    {
        if (curTemp != minTemp)
        {
            currentTemp = curTemp;
        }

        return currentTemp;
    }

    public int IncreaseTemp(int curTemp)
    {
        if (curTemp != maxTemp)
        {
            currentTemp = curTemp;
        }
        return currentTemp;
    }
    
}