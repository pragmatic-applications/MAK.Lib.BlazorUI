namespace Views;

public partial class Banner : Component
{
    private string bannerTitle;
    public string BannerTitle
    {
        get => this.bannerTitle;
        set
        {
            this.bannerTitle = value;

            this.StateHasChanged();
        }
    }

    private string bannerBackgroundImage;
    public string BannerBackgroundImage
    {
        get => this.bannerBackgroundImage;
        set
        {
            this.bannerBackgroundImage = value;

            this.StateHasChanged();
        }
    }

    private string dataStateKey;
    public string DataStateKey
    {
        get => this.dataStateKey;
        set
        {
            this.dataStateKey = value;

            this.StateHasChanged();
        }
    }
}
