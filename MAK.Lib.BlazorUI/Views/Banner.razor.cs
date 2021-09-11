using Constants;

using Domain;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class Banner : CoreComponent
    {
        [CascadingParameter(Name = nameof(CascadingData.BannerBackgroundImageCssClassParameterValue))]
        public string BannerBackgroundImageCssClassCascadingParameter { get; set; }
    }
}
