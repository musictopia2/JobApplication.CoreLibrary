namespace JobApplication.CoreLibrary.Services;
public interface IJobService
{
    Task<JobApplicationModel> GetJobApplicationAsync();
}