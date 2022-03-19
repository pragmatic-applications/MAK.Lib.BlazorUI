namespace Interfaces;

public interface IComponentService
{
    NavigationManager NavigationManager
    {
        get;
        set;
    }
    PagerData PagerData
    {
        get;
        set;
    }
    PagingEntity PagingResult
    {
        get;
        set;
    }
}
