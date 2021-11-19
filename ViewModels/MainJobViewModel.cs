namespace JobApplication.CoreLibrary.ViewModels;
public class MainJobViewModel
{
    public JobApplicationModel? CurrentJobApplication { get; private set; }
    private readonly IStorage _storage;
    private readonly IJobService _service;
    private readonly ITitleModel _model;
    private bool _didInit;
    public Action? StateChanged { get; set; }
    public string Title { init; get; } = "";
    public bool IsBusy { private set; get; }
    public MainJobViewModel(IStorage storage,
        IJobService service,
        ITitleModel model
        )
    {
        _storage = storage;
        _service = service;
        _model = model;
        Title = _model.Title;
    }
    public void Init()
    {
        if (_didInit)
        {
            return;
        }
        CurrentJobApplication = _storage.GetJobApplication();
        _didInit = true;
    }
    public async Task DownloadJobApplicationAsync()
    {
        IsBusy = true;
        StateChanged?.Invoke();
        await Task.Delay(10);
        CurrentJobApplication = await _service.GetJobApplicationAsync();
        _storage.SaveJobApplication(CurrentJobApplication);
        IsBusy = false;
    }
    public string EmailAddress => CurrentJobApplication is null ? "" : CurrentJobApplication.EmailAddress;
    public string PhoneNumber => CurrentJobApplication is null ? "" : CurrentJobApplication.PhoneNumber;
}