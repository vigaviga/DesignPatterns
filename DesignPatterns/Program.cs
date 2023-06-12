A a = new A();
a.NotifySomeone(2);

interface IMediator
{
    void Notify(int num);
}

public class Mediator : IMediator
{
    public void Notify(int num)
    {
        switch(num)
        {
            case 0:
                A a = new A();
                a.GotNotified();
                break;
            case 1:
                B b = new B();
                b.GotNotified();
                break;
            case 2:
                C c = new C();
                c.GotNotified();
                break;
        }
    }
}

public interface IComponent
{
    void GotNotified();
    void NotifySomeone(int num);
}

class A : IComponent
{
    private Mediator m = new Mediator();

    public void GotNotified()
    {
        Console.WriteLine("Class A got Notified");
    }

    public void NotifySomeone(int i)
    {
        m.Notify(i);
    }
}

class B : IComponent
{
    private Mediator m = new Mediator();

    public void GotNotified()
    {
        Console.WriteLine("Class B got Notified");
    }
    public void NotifySomeone(int i)
    {
        m.Notify(i);
    }

}
class C : IComponent
{
    private Mediator m = new Mediator();

    public void GotNotified()
    {
        Console.WriteLine("Class C got Notified");
    }
    public void NotifySomeone(int i)
    {
        m.Notify(i);
    }

}
