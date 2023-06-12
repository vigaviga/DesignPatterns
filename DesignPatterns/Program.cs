Context.SetBook("Novel");
Context.Write();

public interface IBookWriter
{
    void Write();
}

public class Fantasy : IBookWriter
{
    public void Write()
    {
        Console.WriteLine("I'm writting a fantasy book.");
    }
}


public class Novel : IBookWriter
{
    public void Write()
    {
        Console.WriteLine("I'm writting a novel book");
    }
}

public class Comedy : IBookWriter
{
    public void Write()
    {
        Console.WriteLine("I'm writting a comedy book.");
    }
}

public class Context
{
    private static IBookWriter _book;

    public static void SetBook(string type)
    {
        switch (type)
        {
            case "Novel":
                _book = new Novel();
                break;
            case "Comedy":
                _book = new Comedy();
                break;
            case "Fantasy":
                _book = new Fantasy();
                break;
            default:
                _book = new Novel();
                break;
        }
    }

    public static void Write()
    {
        _book.Write();
    }
}
