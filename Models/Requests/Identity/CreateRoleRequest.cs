namespace ABCShared.Library.Models.Requests.Identity;

public class CreateRoleRequest
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}
