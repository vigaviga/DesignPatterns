BaseAuto baseAuto = new BaseAuto();
FerrariAutoDecorator ferrariAutoDecorator = new FerrariAutoDecorator();
TeslaDecorator teslaDecorator = new TeslaDecorator();
ferrariAutoDecorator.SetBaseAuto(baseAuto);
teslaDecorator.SetBaseAuto(ferrariAutoDecorator);

teslaDecorator.AddAutoParts();



abstract class AutoPart
{
    public abstract void AddAutoParts();
}


class BaseAuto : AutoPart
{
    public override void AddAutoParts()
    {
        Console.WriteLine("Added Engine to a car");
        Console.WriteLine("Added 4 tiers to a car");
        Console.WriteLine("-------------------");
    }
}

class BaseAutoDecorator : AutoPart
{
    protected AutoPart _wrapee;

    public void SetBaseAuto(AutoPart wrapee)
    {
        _wrapee = wrapee;
    }

    public override void AddAutoParts()
    {
        if(_wrapee != null )
        {
            _wrapee.AddAutoParts(); 
        }
    }
}

class FerrariAutoDecorator : BaseAutoDecorator
{
    public override void AddAutoParts()
    {
        Console.WriteLine("Added very strong engine");
        Console.WriteLine("Painted auto in red");
        Console.WriteLine("-------------------");
        base.AddAutoParts();
    }
}

class TeslaDecorator : BaseAutoDecorator
{
    public override void AddAutoParts()
    {
        Console.WriteLine("Made engine electric");
        Console.WriteLine("-------------------");
        base.AddAutoParts();

    }
}
