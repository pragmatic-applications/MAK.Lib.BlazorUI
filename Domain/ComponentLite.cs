namespace Domain;

public class ComponentLite : ComponentBase
{
    [Parameter]
    public RenderFragment ChildContent
    {
        get; set;
    }

    [Parameter]
    public int Id
    {
        get; set;
    }

    [Parameter]
    public string CategoryUrl
    {
        get; set;
    }

    [Parameter]
    public string UrlParameter { get; set; } = string.Empty;

    [Parameter]
    public string CssParameter
    {
        get; set;
    }

    [Parameter]
    public string AltParameter
    {
        get; set;
    }

    [Parameter]
    public string TitleParameter
    {
        get; set;
    }

    [Parameter]
    public RenderFragment LinkContainerParameter
    {
        get; set;
    }

    [Parameter]
    public string LinkTextParameter
    {
        get; set;
    }

    [Parameter]
    public EventCallback OnActionParameter
    {
        get; set;
    }

    [Parameter]
    public EventCallback<string> OnClickAction
    {
        get; set;
    }

    protected virtual async Task DoClickAction(MouseEventArgs e, string linkText) => await this.OnClickAction.InvokeAsync(linkText);



    [Parameter]
    public EventCallback OnAction
    {
        get; set;
    }

    protected virtual async Task DoAction(MouseEventArgs e) => await this.OnAction.InvokeAsync();

    ////nnn??
    /// <summary>


    [Parameter]
    public EventCallback<bool> OnClick
    {
        get; set;
    }

    protected virtual async Task DoClick(MouseEventArgs e, bool value) => await this.OnClick.InvokeAsync(value);


    /// </summary>
    //[Parameter]
    //public EventCallback<List<string>> OnClick { get; set; }

    //protected virtual async Task DoClick(MouseEventArgs e, List<string> values) => await this.OnClick.InvokeAsync(values);
    ////nnn??

    [Parameter]
    public EventCallback<string> OnUpdateProductName
    {
        get; set;
    }


    //???
    [Parameter]
    public bool ConditionParameter
    {
        get; set;
    }

    [Parameter]
    public EventCallback OnClickParameter
    {
        get; set;
    }

    // S 2022-03-02
    [Parameter]
    public bool IsCreateParameter
    {
        get; set;
    }
    [Parameter]
    public string AppNameParameter
    {
        get; set;
    }
    [Parameter]
    public MenuData MenuDataParameter
    {
        get; set;
    }
    // E 2022-03-02
}
