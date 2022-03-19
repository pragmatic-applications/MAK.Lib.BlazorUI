namespace Domain
{
    public class AppComponent : CoreComponent
    {
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            //this.PagingEntity.SearchTerm = string.Empty;
            this.ComponentService.PagingResult.SearchTerm = string.Empty;
        }
    }
    public class AppComponent<TEntity> : AppComponent where TEntity : class
    {
        protected virtual void LoadDataSuccess(PagingResponse<TEntity> data)
        {
            this.IsLoading = false;
            this.IsError = false;
        }

        protected virtual Task TryLoadAsync(Action<PagingResponse<TEntity>> success, Action<Exception> fail) => Task.FromResult(default(object));
    }
    public class AppComponent<TEntity, TEntityCategory> : AppComponent where TEntity : class where TEntityCategory : class
    {
    }
}
