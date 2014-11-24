using System;
using System.Threading;

internal class AsyncTimer
{
    private Action executedMethod;
    private int ticks;
    private int interval;

    public AsyncTimer(Action executedMethod, int ticks, int interval)
    {
        this.ExecutedMethod = executedMethod;
        this.Ticks = ticks;
        this.Interval = interval;
    }

    public Action ExecutedMethod
    {
        get { return this.executedMethod; }
        set { this.executedMethod = value; }
    }

    public int Ticks
    {
        get { return this.ticks; }
        set { this.ticks = value; }
    }

    public int Interval
    {
        get { return this.interval; }
        set { this.interval = value; }
    }

    public void Start()
    {
        Thread thread = new Thread(this.CallMethod);
        thread.Start();
    }

    private void CallMethod()
    {
        for (int i = 0; i < this.Ticks; i++)
        {
            Thread.Sleep(this.Interval);

            this.ExecutedMethod();
        }
    }
}