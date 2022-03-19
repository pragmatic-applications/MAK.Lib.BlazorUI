namespace Domain;

public class CoreComponent : Component
{
    protected override void OnInitialized()
    {
        base.OnInitialized();

        this.CurrentTitle = string.IsNullOrWhiteSpace(this.BannerTitleCascadingParameter) ? "Blazor & MVC" : this.BannerTitleCascadingParameter;
    }

    //// 2022-02-28 - O
    //// Todo: update to include category with search and sort...
    //protected virtual Task GetAsync(string categoryUrl = null) => Task.FromResult(default(object));
    //protected async Task SearchChanged(string searchTerm)
    //{
    //    this.PagingEntity.SearchTerm = searchTerm;

    //    await this.GetAsync();
    //    await this.InvokeAsync(() => this.StateHasChanged());
    //}
    //protected async Task SortChanged(string orderBy)
    //{
    //    this.PagingEntity.OrderBy = orderBy;

    //    await this.GetAsync();
    //    await this.InvokeAsync(() => this.StateHasChanged());
    //}
    //protected async Task SelectedPage(int page)
    //{
    //    this.PagingEntity.PageNumber = page;

    //    await this.GetAsync();
    //    await this.InvokeAsync(() => this.StateHasChanged());
    //}

    // 2022-02-28 - N
    // Todo: update to include category with search and sort...
    protected virtual Task LoadAsync(string categoryUrl = null) => Task.FromResult(default(object));
    protected async Task SearchChanged(string searchTerm)
    {
        this.ComponentService.PagingResult.SearchTerm = searchTerm;

        await this.LoadAsync();
        await this.InvokeAsync(() => this.StateHasChanged());
    }
    protected async Task SortChanged(string orderBy)
    {
        this.ComponentService.PagingResult.OrderBy = orderBy;

        await this.LoadAsync();
        await this.InvokeAsync(() => this.StateHasChanged());
    }
    protected async Task SelectedPage(int page)
    {
        this.ComponentService.PagingResult.PageNumber = page;

        await this.LoadAsync();
        await this.InvokeAsync(() => this.StateHasChanged());
    }

    protected virtual void ClearFields()
    {
    }

    protected void GoBack(string linkText = null)
    {
        MenuState.SetTitle(linkText);
        MenuState.SetLinkValue(linkText);

        this.Navigation.NavigateBack();
    }

    protected async Task Reload()
    {
        this.ClearFields();
        await this.InvokeAsync(() => this.StateHasChanged());
        this.Navigation.NavigateBack();
    }
}
