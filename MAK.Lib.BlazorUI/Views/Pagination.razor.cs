namespace Views;

public partial class Pagination : ComponentBase
{
    [CascadingParameter(Name = nameof(CascadingData.PagerDataValue))]
    public PagerData PagerData { get; set; }

    [CascadingParameter(Name = nameof(CascadingData.SpreadValue))]
    public int Spread { get; set; }

    [Parameter] public EventCallback<int> OnSelectedPage { get; set; }
    private List<PagingLink> links;

    protected override void OnParametersSet() => this.CreatePaginationLinks();

    //// Orig
    //private void CreatePaginationLinks()
    //{
    //    this.links = new List<PagingLink>
    //    {
    //        new PagingLink(this.PagerData.CurrentPage - 1, this.PagerData.HasPrevious, "<<", this.PagerData.IsCursorPointer)
    //    };

    //    for(var i = 1; i <= this.PagerData.TotalPages; i++)
    //    {
    //        if(i >= this.PagerData.CurrentPage - this.Spread && i <= this.PagerData.CurrentPage + this.Spread)
    //        {
    //            this.links.Add(new PagingLink(i, true, i.ToString(), true) { Active = this.PagerData.CurrentPage == i });
    //        }
    //    }

    //    this.links.Add(new PagingLink(this.PagerData.CurrentPage + 1, this.PagerData.HasNext, ">>", true));

    //    this.StateHasChanged();
    //}

    private void CreatePaginationLinks()
    {
        this.links = new List<PagingLink>
        {
            new PagingLink(this.PagerData.CurrentPage - 1, this.PagerData.HasPrevious, "<<", this.PagerData.HasPrevious)
        };

        for(var i = 1; i <= this.PagerData.TotalPages; i++)
        {
            if(i >= this.PagerData.CurrentPage - this.Spread && i <= this.PagerData.CurrentPage + this.Spread)
            {
                //this.links.Add(new PagingLink(i, true, i.ToString(), true) { Active = this.PagerData.CurrentPage == i }); YYY
                this.links.Add(new PagingLink(i, true, i.ToString(), !(this.PagerData.CurrentPage == i), this.PagerData.CurrentPage == i));
            }
        }

        this.links.Add(new PagingLink(this.PagerData.CurrentPage + 1, this.PagerData.HasNext, ">>", this.PagerData.HasNext));

        this.StateHasChanged();
    }


    private async Task SelectPageHandler(PagingLink link)
    {
        if(link.Page == this.PagerData.CurrentPage || !link.Enabled)
        {
            return;
        }

        this.PagerData.CurrentPage = link.Page;
        await this.OnSelectedPage.InvokeAsync(link.Page);
        this.StateHasChanged();
    }
}
