namespace Views;

public partial class ImageContainer : ComponentBase
{
    [Parameter] public string ImageParameter { get; set; }
    [Parameter] public string MaxWidthParameter { get; set; }
    [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> Attributes { get; set; }
}
