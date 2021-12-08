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
}


//public partial class Banner : Component //CoreComponent
//{
//    [CascadingParameter(Name = nameof(CascadingData.BannerBackgroundImageCssClassParameterValue))]
//    public string BannerBackgroundImageCssClassCascadingParameter { get; set; }
//}
