namespace Views;

public partial class Submit : ComponentBase
{
    [Parameter]
    public string Css { get; set; }

    [Parameter]
    public string LinkText { get; set; }

    [Parameter]
    public bool Condition { get; set; }
}
