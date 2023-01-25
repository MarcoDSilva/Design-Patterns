using System.Text;

namespace Builder.Services.HTML;

public class HtmlElement
{
    public string Tag, Text;
    public List<HtmlElement> Elements = new List<HtmlElement>();
    private const int indentSize = 2;

    public HtmlElement() { }

    public HtmlElement(string tag, string text)
    {
        Tag = tag;
        Text = text;
    }


    public string ToStringImpl(int indent)
    {
        var sb = new StringBuilder();
        var spaces = new string(' ', indentSize * indent);
        sb.Append($"{spaces}<{Tag}>\n");

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', indentSize * (indent + 2)));
            sb.Append(Text);
            sb.Append("\n");
        }

        foreach (var e in Elements)
        {
            sb.Append(e.ToStringImpl(indent + 2));
        }

        sb.Append($"{spaces}</{Tag}>\n");
        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }

}