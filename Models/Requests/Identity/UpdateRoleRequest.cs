namespace ABCShared.Library.Models.Requests.Identity;

public class UpdateRoleRequest
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
}
