namespace JobApplication.CoreLibrary.Models;
public class JobApplicationModel
{
    public BasicList<ReferenceModel> References { get; set; } = [];
    public BasicList<ExperienceModel> Experiences { get; set; } = [];
    public BasicList<string> Schools { get; set; } = [];
    public string PhoneNumber { get; set; } = "";
    public string EmailAddress { get; set; } = "";
}