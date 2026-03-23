namespace ABCShared.Library.Models.Requests.Identity;

public class UpdateRolePermissionsRequest
{
    public required string RoleId { get; set; }
    public List<string> NewPermissions { get; set; } = [];
}
