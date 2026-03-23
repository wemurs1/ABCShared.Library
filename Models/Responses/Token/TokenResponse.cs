namespace ABCShared.Library.Models.Responses.Token;

public class TokenResponse
{
    public required string Jwt { get; set; }
    public required string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryDate { get; set; }
}
