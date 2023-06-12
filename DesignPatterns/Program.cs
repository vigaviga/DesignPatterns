Food bbq = new BBQ();
bbq.MakeFood();
Console.WriteLine("------------------");
Food salad = new Salad();
salad.MakeFood();
public abstract class Food
{
    public void MakeFood() 
    {
        BuyIngredients();
        CleanIngredients();
        CutIngredients();
        MixIngredients();
        CookIngredients();
    }

    protected virtual void BuyIngredients() 
    {
        Console.WriteLine("Bought ingredients.");
    }

    protected virtual void CleanIngredients()
    {
        Console.WriteLine("Cleaned ingredients.");
    }

    protected virtual void CutIngredients()
    {
        Console.WriteLine("Cut ingredients.");
    }

    protected virtual void MixIngredients()
    {
        Console.WriteLine("Mixed ingredients.");
    }

    protected virtual void CookIngredients()
    {
        Console.WriteLine("Cooked ingredients.");
    }
}

public class BBQ : Food
{
    protected override void CleanIngredients()
    {
        Console.WriteLine("------------------");
    }

    protected override void MixIngredients()
    {
        Console.WriteLine("------------------");
    }
}

public class Salad : Food
{
    protected override void CookIngredients()
    {
        Console.WriteLine("------------------");
    }
}