namespace Domain;

public class ComponentService : IComponentService
{
    public ComponentService(NavigationManager navigationManager, PagingEntity pagingResult, PagerData pagerData)
    {
        this.NavigationManager = navigationManager;
        this.PagingResult = pagingResult;
        this.PagerData = pagerData;
    }

    public NavigationManager NavigationManager
    {
        get; set;
    }

    public PagingEntity PagingResult
    {
        get; set;
    }

    public PagerData PagerData
    {
        get; set;
    }
}
