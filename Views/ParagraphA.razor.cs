namespace Views;

public partial class ParagraphA
{
    [Parameter]
    public string Link
    {
        get; set;
    }

    [Parameter]
    public string Url
    {
        get; set;
    }

    [Parameter]
    public string Paragraph
    {
        get; set;
    }

    [Parameter]
    public string ParagraphCss
    {
        get; set;
    }

    [Parameter]
    public EventCallback<string> OnClickAction
    {
        get; set;
    }

    protected virtual async Task DoClickAction(MouseEventArgs e, string linkText) => await this.OnClickAction.InvokeAsync(linkText);
}
