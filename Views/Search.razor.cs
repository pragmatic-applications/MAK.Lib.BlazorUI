namespace Views;

public partial class Search : ComponentBase
{
    private Timer timer;
    private string SearchTerm { get; set; }

    // nn

    [Parameter] public EventCallback<string> OnSearchChanged { get; set; }

    //protected async Task SearchChanged(string searchTerm)
    //{
    //    this.PagingEntity.SearchTerm = searchTerm;
    //    await this.GetAsync();
    //}
    // nn

    private void SearchChanged()
    {
        if(this.timer != null)
        {
            this.timer.Dispose();
        }

        this.timer = new Timer(this.OnTimerElapsed, null, 500, 0);

        this.StateHasChanged();
    }

    private void OnTimerElapsed(object sender)
    {
        this.OnSearchChanged.InvokeAsync(this.SearchTerm);
        this.timer.Dispose();
    }
}
