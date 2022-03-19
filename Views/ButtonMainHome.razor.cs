namespace Views;

public partial class ButtonMainHome
{
    [Parameter]
    public EventCallback OnCloseMenu { get; set; }

    [Parameter]
    public string ButtonCss { get; set; }
}
