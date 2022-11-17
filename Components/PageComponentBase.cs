namespace JobApplication.CoreLibrary.Components;
public abstract class PageComponentBase : ComponentBase
{
    [Parameter]
    [AllowNull]
    public MainJobViewModel DataContext { get; set; }
}