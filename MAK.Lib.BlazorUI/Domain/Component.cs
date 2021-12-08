namespace Domain
{
    public class Component : ComponentBase
    {
        public string ButtonText { get; set; } = "Save";

        public FormMode FormMode { get; set; } = FormMode.Create;
        public string FormTitle { get; set; }

        [Parameter] public int Id { get; set; }
        [Parameter] public string? CategoryUrl { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> Attributes { get; set; }

        [Parameter]
        public string CardLinkParameter { get; set; }

        [Parameter] public int IdParameter { get; set; } = 0;
        [Parameter] public string UrlParameter { get; set; } = string.Empty;

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string CurrentTitle { get; set; } = string.Empty;
        public string PageToNavigateTo { get; set; } = string.Empty;

        [Parameter] public PagerData PagerDataParameter { get; set; }

        [Parameter] public string ButtonLogoValueParameter { get; set; }


        [CascadingParameter(Name = nameof(CascadingData.BrowserTitleCascadingValue))]
        public string BrowserTitleCascadingParameter { get; set; }
        public string BrowserTitleValue { get; set; }

        [CascadingParameter(Name = nameof(CascadingData.AppNameCascadingValue))]
        public string AppNameCascadingParameter { get; set; }
        public string AppNameValue { get; set; }

        [CascadingParameter(Name = nameof(CascadingData.BannerTitleCascadingValue))]
        public string BannerTitleCascadingParameter { get; set; }
        public string BannerTitleValue { get; set; }


        public string UrlUpdate { get; set; }
        public string UrlDelete { get; set; }
        public string Url { get; set; }
        public string UrlDetail { get; set; }
        public string UrlEdit { get; set; }

        public bool IsLoading { get; set; }
        public bool IsError { get; set; }
        protected int ImageCount { get; set; } = 0;

        protected virtual string IsDone { get; }
        protected virtual string IsComplete { get; }
        protected virtual string EntryId { get; }

        public bool IsDebugConsole { get; set; } = true;
        public static int EntityId = 0;

        public int CurrentCategoryId { get; set; }
        public string CategoryId { get; set; } = "0";
        public string Zero { get; set; } = "0";
        protected bool IsDisabled => this.CategoryId == this.Zero;

        public int GetCategoryId(string categoryId)
        {
            int.TryParse(categoryId, out var result);

            return result;
        }

        protected virtual List<string> Images { get; } = new();
        protected virtual void AssignImageUrl(List<string> images) { }
        protected virtual void AssignImageUrl(string imgUrl) { }
    }
}
