namespace Views;

public partial class Repeater<TEntity> : ComponentBase
{
    [Parameter] public RenderFragment<TEntity> Entity { get; set; }
    [Parameter] public IEnumerable<TEntity> Entities { get; set; }
}
