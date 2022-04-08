namespace Views;

public partial class ButtonBarMenu
{
    [Parameter]
    public EventCallback OnToggle
    {
        get; set;
    }

    [Parameter]
    public string ToggleNavMenuId
    {
        get; set;
    }

    [Parameter]
    public string NavigationToggleCss
    {
        get; set;
    }

    [Parameter]
    public string NavigationMenuButtonCss
    {
        get; set;
    }

    [Parameter]
    public string ButtonIconBarCss
    {
        get; set;
    }
}
