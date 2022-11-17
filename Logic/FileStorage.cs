namespace JobApplication.CoreLibrary.Logic;
//this is not designed for azure.  afterall, can't require internet access in order to retrieve this.
public class FileStorage : IStorage
{
    private readonly string _applicationPath = "job application.json";
    public FileStorage()
    {
        if (bb1.OS == bb1.EnumOS.Android)
        {
            _applicationPath = Path.Combine(ff1.GetApplicationDataForMobileDevices(), _applicationPath);
        }
        else if (bb1.OS == bb1.EnumOS.WindowsDT)
        {
            _applicationPath = Path.Combine(aa1.GetApplicationPath(), _applicationPath);
        }
        else
        {
            throw new CustomBasicException("FileStorage Implementation only supports Desktop, or Android");
        }
    }
    JobApplicationModel? IStorage.GetJobApplication()
    {
        if (ff1.FileExists(_applicationPath) == false)
        {
            return null;
        }
        return jj1.RetrieveSavedObject<JobApplicationModel>(_applicationPath);
    }
    void IStorage.SaveJobApplication(JobApplicationModel model)
    {
        jj1.SaveObject(_applicationPath, model); //has to not be async  otherwise, the desktop version does not work well.
    }
}