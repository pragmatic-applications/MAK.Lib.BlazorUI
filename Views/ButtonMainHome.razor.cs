namespace Views;

public partial class ButtonMainHome
{
    [Parameter]
    public EventCallback OnCloseMenu
    {
        get; set;
    }

    [Parameter]
    public ButtonCss ButtonCss
    {
        get; set;
    }


    [Parameter]
    public string BusinessName
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
