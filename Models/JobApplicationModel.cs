namespace JobApplication.CoreLibrary.Models;
public class JobApplicationModel
{
    public BasicList<ReferenceModel> References { get; set; } = new();
    public BasicList<ExperienceModel> Experiences { get; set; } = new();
    public BasicList<string> Schools { get; set; } = new();
    public string PhoneNumber { get; set; } = "";
    public string EmailAddress { get; set; } = "";
}