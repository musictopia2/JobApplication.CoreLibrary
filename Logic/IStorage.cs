namespace JobApplication.CoreLibrary.Logic;
public interface IStorage
{
    JobApplicationModel? GetJobApplication();
    void SaveJobApplication(JobApplicationModel model);
}