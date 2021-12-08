﻿namespace Domain;

public class CoreComponent : Component
{
    protected override void OnInitialized()
    {
        base.OnInitialized();

        this.CurrentTitle = string.IsNullOrWhiteSpace(this.BannerTitleCascadingParameter) ? "Blazor & MVC" : this.BannerTitleCascadingParameter;
    }

    [CascadingParameter]
    protected Banner Banner { get; set; }

    protected virtual void ClearFields() { }
    protected virtual void GoBack() { }

    protected virtual void Reload()
    {
        this.ClearFields();

        this.NavigationManager.NavigateTo("/");
    }

    protected void GoToPage(string pageToNavigateTo)
    {
        this.ClearFields();
        this.StateHasChanged();
        this.NavigationManager.NavigateTo(pageToNavigateTo);
    }

    [Inject] public PagingEntity PagingEntity { get; set; }
    [Inject] public PagerData PagerData { get; set; }

    [Parameter] public EventCallback<string> OnSearchChanged { get; set; }
    protected async Task SearchChanged(string searchTerm)
    {
        this.PagingEntity.SearchTerm = searchTerm;
        await this.GetAsync();
    }

    [Parameter] public EventCallback<string> OnSortChanged { get; set; }
    protected async Task SortChanged(string orderBy)
    {
        this.PagingEntity.OrderBy = orderBy;
        await this.GetAsync();
    }

    [Parameter] public EventCallback<int> OnSelectedPage { get; set; }
    protected async Task SelectedPage(int page)
    {
        this.PagingEntity.PageNumber = page;

        await this.GetAsync();
    }

    protected virtual void LoadDataFail(Exception exception) { }
    protected virtual void LoadDataCategoryFail(Exception exception) { }

    //Task<DataResult<PagingResponse<ProductDto>>> GetEntitiesAsync(PagingEntity entityParameter, string categoryUrl = null);

    //protected virtual Task GetAsync() => Task.FromResult(default(object));
    protected virtual Task GetAsync(string categoryUrl = null) => Task.FromResult(default(object));
    protected virtual Task GetAsync(int id) => Task.FromResult(default(object));
    protected virtual Task InsertAsync() => Task.FromResult(default(object));
    protected virtual Task UpdateAsync() => Task.FromResult(default(object));
    protected virtual Task DeleteAsync() => Task.FromResult(default(object));
    protected virtual Task GetEntityCategoryAsync() => Task.FromResult(default(object));
}
