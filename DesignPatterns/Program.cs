using System.Text;

var inputText = new InputText("text", "hello world");
var labelText = new LabelText("body");
var form = new Form("simpleForm");
form.AddComponent(inputText);
form.AddComponent(labelText);
Console.WriteLine(form.ConvertToString()); 


public class InputText : Element
{
    private readonly string _name;
    private readonly string _value;

    public InputText(string name, string value)
    {
        _name = name;
        _value = value;
    }

    public override string ConvertToString()
    {
        return $"<inputText name='{_name}' value='{_value}'/>";
    }
}


public class LabelText : Element
{
    private string _value;

    public LabelText(string value)
    {
        _value = value;
    }

    public override string ConvertToString()
    {
        return $"<label value='{_value}'/>";
    }
}

public class Form : Element
{
    private string _name;
    private IList<Element> _elements;

    public Form(string name)
    {
        _name = name;
        _elements = new List<Element>();
    }

    public new void AddComponent(Element element)
    {
        _elements.Add(element);
    }

    public override string ConvertToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"<form name='{_name}'");
        foreach(var e in _elements)
        {
            result.AppendLine(e.ConvertToString());
        }
        result.AppendLine("</form>");
        return result.ToString();
    }
}

public abstract class Element
{
    public virtual string ConvertToString()
    {
        throw new NotImplementedException();
    }

    public virtual void AddComponent(Element element)
    {
        throw new NotImplementedException();
    }

}
