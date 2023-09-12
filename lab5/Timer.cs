namespace lab5;

class CustomTimer
{
    private int interval;
    private Action callback;
    private Thread thread;
    private bool running;

    public CustomTimer(int interval, Action callback)
    {
        this.interval = interval;
        this.callback = callback;
        thread = new Thread(Run);
        running = false;
    }

    public void Start()
    {
        if (!running)
        {
            running = true;
            thread.Start();
        }
    }

    public void Stop()
    {
        running = false;
    }

    private void Run()
    {
        while (running)
        {
            Thread.Sleep(interval);
            callback();
        }
    }
}
