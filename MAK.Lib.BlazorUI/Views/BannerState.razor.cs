namespace Views;

public partial class BannerState : Component
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
}
