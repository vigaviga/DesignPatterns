var s1 = new Subscriber1();
var s2 = new Subscriber2();
var s3 = new Subscriber3();
Publisher pub = new Publisher();
pub.AddSubscriber(s1);
pub.AddSubscriber(s2);
pub.AddSubscriber(s3);
Event e = new Event();
pub.NotifyAll(e);


public class Publisher
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    public void AddSubscriber(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public void NotifyAll(IEvent e)
    {
        foreach (ISubscriber subscriber in subscribers)
        {
            subscriber.ReceivedEvent(e.EventNumber);
        }    
    }
}


public interface ISubscriber
{
    void ReceivedEvent(int e);
}

public interface IEvent
{
    int EventNumber { get; set; }
}

public class Subscriber1 : ISubscriber
{
    public void ReceivedEvent(int e)
    {
        Console.WriteLine("Subscriber 1 received event E " + e);
    }
}

public class Subscriber2 : ISubscriber
{
    public void ReceivedEvent(int e)
    {
        Console.WriteLine("Subscriber 2 received event E " + e);
    }
}

public class Subscriber3 : ISubscriber
{
    public void ReceivedEvent(int e)
    {
        Console.WriteLine("Subscriber 3 received event E " + e);
    }
}

public class Event : IEvent
{
    public int EventNumber { get; set; } = 10;
}
