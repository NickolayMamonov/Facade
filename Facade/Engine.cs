namespace Facade;

public class Engine
{
    private bool isStarted;
    public bool Start()
    {
        isStarted = true;
        return isStarted;
    }

    public bool Stop()
    {
        isStarted = false;
        return isStarted;
    }
    public bool IsStarted => isStarted;
}