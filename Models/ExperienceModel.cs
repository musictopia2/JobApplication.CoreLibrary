namespace JobApplication.CoreLibrary.Models;
[Table("ExperienceTable")]
public partial class ExperienceModel : ISimpleDatabaseEntity
{
    public int ID { get; set; }
    public string CompanyName { get; set; } = "";
    public string CompanyAddress { get; set; } = "";
    public string SupervisorName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string JobTitle { get; set; } = "";
    public string StartingSalary { get; set; } = "";
    public string EndingSalary { get; set; } = "";
    public string JobDuties { get; set; } = "";
    public string DateFrom { get; set; } = "";
    public string DateTo { get; set; } = "";
    public string ReasonForLeaving { get; set; } = "";
}