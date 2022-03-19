namespace Domain;

public class Navigation : IDisposable
{
    public Navigation(NavigationManager navigationManager)
    {
        this.navigationManager = navigationManager;
        this.historyStack.Push(this.navigationManager.Uri);
        this.navigationManager.LocationChanged += this.OnLocationChanged;
    }

    private readonly NavigationManager navigationManager;
    private readonly Stack<string> historyStack = new();

    public bool CanGoBack => this.historyStack.Count > 1;

    /// <summary>
    /// Navigates to the previous url if possible or does nothing if it is not.
    /// </summary>
    public void NavigateBack()
    {
        if(!this.CanGoBack)
        {
            return;
        }

        var _ = this.historyStack.Pop();

        if(!this.historyStack.Any())
        {
            return;
        }

        var backPageUrl = this.historyStack.Pop();
        this.navigationManager.NavigateTo(backPageUrl);
    }

    private void OnLocationChanged(object sender, LocationChangedEventArgs e) => this.historyStack.Push(e.Location);

    public void Dispose()
    {
        this.navigationManager.LocationChanged -= this.OnLocationChanged;
        this.historyStack.Clear();
    }

    /// <summary>
    /// Navigates to the specified url.
    /// </summary>
    /// <param name="url">The destination url (relative or absolute).</param>
    public void NavigateTo(string url) => this.navigationManager.NavigateTo(url);
}
