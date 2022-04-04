namespace Domain;

public class NavigationJSInterop : IAsyncDisposable
{
    public NavigationJSInterop(IJSRuntime jsRuntime) => this.moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/MAK.LibBlazorUI/js/Navigation.js").AsTask());

    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public async ValueTask LoadNavigation()
    {
        var module = await this.moduleTask.Value;
        await module.InvokeVoidAsync("loadNavigation");
    }

    public async ValueTask DisposeAsync()
    {
        if(this.moduleTask.IsValueCreated)
        {
            var module = await this.moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}