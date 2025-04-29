using System.Text.Json.Serialization;

namespace PetRyt.PWABaseLibrary.DTOs
{
	public class UserSession
	{
		public string? AccessToken { get; set; }
		public string? RefreshToken { get; set; }
		public string? UserFirstName { get; set; }
		public string? UserLastName { get; set; }
		public string? UserEmail { get; set; }
		public string? UserRoles { get; set; }
		public long UserId { get; set; }
		public DateTime AccessTokenExpiration { get; set; }

		[JsonIgnore]
		public bool IsTokenExpired => DateTime.UtcNow > AccessTokenExpiration;

		[JsonIgnore]
		public string FullName => $"{UserFirstName} {UserLastName}";

	}
}
