
public delegate void ThresholdReachedHandler(object sender, EventArgs e);

class Counter
{
    public int Count { get; private set; }

    public event ThresholdReachedHandler Between10And15;
    public event ThresholdReachedHandler Between15And20;

    public void Increment()
    {
        Count++;

        // Step 4: Raise events based on condition
        if (Count > 10 && Count < 15)
        {
            Between10And15?.Invoke(this, EventArgs.Empty);
        }
        else if (Count > 15 && Count < 20)
        {
            Between15And20?.Invoke(this, EventArgs.Empty);
        }
    }
}

class EventHandling_Task_6
{
    public static void Run()
    {
        Counter counter = new Counter();

        // Step 5: Subscribe handlers (decoupled)
        counter.Between10And15 += Handle10To15;
        counter.Between15And20 += Handle15To20;

        // Step 6: Main loop
        for (int i = 0; i < 20; i++)
        {
            counter.Increment();
        }
    }

    // Step 7: Event handlers
    static void Handle10To15(object sender, EventArgs e)
    {
        Console.WriteLine("Count is between 10 and 15");
    }

    static void Handle15To20(object sender, EventArgs e)
    {
        Console.WriteLine("Count is between 15 and 20");
    }
}