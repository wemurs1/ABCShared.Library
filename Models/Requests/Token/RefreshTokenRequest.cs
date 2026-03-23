namespace ABCShared.Library.Models.Requests.Token;

public class RefreshTokenRequest
{
    public required string CurrentJwt { get; set; }
    public required string CurrentRefreshToken { get; set; }
    public DateTime RefreshTokenExpiryDate { get; set; }
}
