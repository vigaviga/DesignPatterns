PrinterAdapter printerAdapter = new PrinterAdapter();
IElements<int> elementsObj = new Elements();
printerAdapter.Print(elementsObj);

//third party library
public class Printer
{
    public void Print<T>(IContainer<T> container)
    {
        foreach (var item in container.Items)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

//CLASSES
class Elements : IElements<int>
{
    public IEnumerable<int> GetElements()
    {
        IEnumerable<int> elements = new List<int>() { 1, 2, 3, 4, 5, 6 };
        return elements;
    }
}

public class PrinterAdapter : IPrinter<int>
{
    public void Print(IElements<int> elements)
    {
        var container = new Container(elements);
        Printer printer = new Printer();
        printer.Print(container);
    }
}

public class Container : IContainer<int>
{
    private IEnumerable<int> elements;
    private int count;

    public Container(IElements<int> Elements)
    {
        elements = Elements.GetElements();
        count = elements.Count();
    }

    public IEnumerable<int> Items => elements;

    public int Count => count;
}

//INTERFACES
public interface IContainer<T>
{
    IEnumerable<T> Items { get; }
    int Count { get; }
}

//es im kodi mej goiutyun unecox interfacne
public interface IElements<T>
{
    IEnumerable<T> GetElements();
}

public interface IPrinter<T>
{
    void Print(IElements<T> elements);
}
