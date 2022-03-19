using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views;

public partial class BannerLite
{
    [Parameter]
    public string BannerImageCssParameter { get; set; }

    [Parameter]
    public string BannerTitleCssParameter { get; set; }

    [Parameter]
    public string BannerTitleParameter { get; set; }
}
