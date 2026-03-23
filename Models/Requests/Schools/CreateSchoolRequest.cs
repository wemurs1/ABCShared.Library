namespace ABCShared.Library.Models.Requests.Schools;

public class CreateSchoolRequest
{
    public required string Name { get; set; }
    public DateTime EstablishedDate { get; set; }
}
