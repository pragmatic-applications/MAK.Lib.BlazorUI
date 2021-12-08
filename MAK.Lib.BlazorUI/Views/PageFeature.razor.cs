namespace Views;

public partial class PageFeature : CoreComponent
{
    public PagerData PagerDataValue { get; set; }

    protected override void OnParametersSet() => this.PagerDataValue = this.PagerDataParameter;
}
