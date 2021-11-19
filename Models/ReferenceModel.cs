namespace JobApplication.CoreLibrary.Models;
[Table("ReferenceTable")]
public class ReferenceModel : ISimpleDapperEntity
{
    public int ID { get; set; }
    public string FullName { get; set; } = "";
    public string Company { get; set; } = "";
    public string JobTitle { get; set; } = "";
    public string Relationship { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Address { get; set; } = "";
}