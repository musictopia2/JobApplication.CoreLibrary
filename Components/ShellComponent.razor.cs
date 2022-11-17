namespace JobApplication.CoreLibrary.Components;
public partial class ShellComponent
{
    [Inject]
    [AllowNull]
    private MainJobViewModel DataContext { get; set; }
    private BasicList<MenuItem> _menus = new();
    protected override void OnInitialized()
    {
        _menus.Add(new MenuItem()
        {
            Text = "Download Job Application",
            Clicked = DownloadAsync
        });
        DataContext.StateChanged = StateHasChanged;
        DataContext.Init();
        base.OnInitialized();
    }
    private async void DownloadAsync()
    {
        await DataContext.DownloadJobApplicationAsync();
        StateHasChanged();
    }
}