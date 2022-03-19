namespace Views;

public partial class Sort : ComponentBase
{
    [Parameter]
    public ISelect SelectCascadingParameter { get; set; }

    [Parameter]
    public string PositionCssClassCascadingParameter { get; set; }
    
    [Parameter]
    public EventCallback<string> OnSortChanged { get; set; }

    private async Task ApplySort(ChangeEventArgs eventArgs)
    {
        if(eventArgs.Value.ToString() == "-1") { return; }

        await this.OnSortChanged.InvokeAsync(eventArgs.Value.ToString());

        this.StateHasChanged();
    }
}
