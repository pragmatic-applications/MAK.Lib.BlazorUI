namespace Domain;

public class Component : ComponentLite
{
    [Inject]
    public IComponentService ComponentService
    {
        get; set;
    }

    [Inject]
    protected Navigation Navigation
    {
        get; set;
    }

    [CascadingParameter]
    protected Banner Banner
    {
        get; set;
    }

    [CascadingParameter(Name = nameof(CascadingData.RootDataCascadingParameterValue))]
    public RootData RootDataCascadingParameter
    {
        get; set;
    }

    [CascadingParameter(Name = nameof(CascadingData.BottomMenuCascadingParameterValue))]
    public List<MenuData> BottomMenuCascadingParameter
    {
        get; set;
    }

    [CascadingParameter(Name = nameof(CascadingData.BannerTitleCascadingValue))]
    public string BannerTitleCascadingParameter
    {
        get; set;
    }

    public string ButtonText { get; set; } = "Save";

    public FormMode FormMode { get; set; } = FormMode.Create;
    public string FormTitle
    {
        get; set;
    }

    public string CurrentTitle { get; set; } = string.Empty;

    public string UrlUpdate
    {
        get; set;
    }
    public string UrlDelete
    {
        get; set;
    }

    public bool IsLoading
    {
        get; set;
    }
    public bool IsError
    {
        get; set;
    }
    protected int ImageCount { get; set; } = 0;

    protected virtual List<string> Images { get; } = new();

    public static int EntityId = 0;

    public int CurrentCategoryId
    {
        get; set;
    }
    public string CategoryId { get; set; } = "0";
    public string Zero { get; set; } = "0";
    protected bool IsDisabled => this.CategoryId == this.Zero;

    public int GetCategoryId(string categoryId)
    {
        int.TryParse(categoryId, out var result);

        return result;
    }

    protected virtual Task SetStringAsync(string value) => Task.FromResult(default(object));

    protected async Task SetTitleAsync(string title)
    {
        MenuState.SetTitle(title);
        MenuState.SetLinkValue(title);
        await this.InvokeAsync(() => this.StateHasChanged());
    }
    protected async Task SetTitleAsync(string action, string linkText)
    {
        MenuState.SetTitle($"{action} | {linkText}");
        MenuState.SetLinkValue($"{action} | {linkText}");
        await this.InvokeAsync(() => this.StateHasChanged());
    }

    protected string GetTitle(string action, string linkText) => $"{action} | {linkText}";
}
