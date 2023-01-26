namespace Builder.Services.HTML;

public class HtmlBuilder
{
    HtmlElement root = new HtmlElement();
    private readonly string rootTag;

    public HtmlBuilder(string rootTag)
    {
        this.rootTag = rootTag;
        root.Tag = rootTag;
    }

    public void AddChild(string childTag, string childText)
    {
        var e = new HtmlElement(childTag, childText);
        root.Elements.Add(e);
    }

    public HtmlBuilder AddChildFluent(string childTag, string childText)
    {
        var e = new HtmlElement(childTag, childText);
        root.Elements.Add(e);
        return this;
    }

    public override string ToString()
    {
        return root.ToString();
    }

    public void Clear()
    {
        root = new HtmlElement { Tag = rootTag };
    }
}