using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.Responses
{
	public class AuthResponse
	{
		/// Tells if the API call was processed successfully.
		/// </summary>
		public bool IsSuccess { get; set; }

		/// <summary>
		/// Result received from the API.
		/// Could be JSON or String.
		/// </summary>
		public string Status { get; set; }
		public string Message { get; set; }
		public string StatusCode { get; set; }
		public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
		public long UserId { get; set; }
		public string UserFirstName { get; set; }
		public string UserRoles { get; set; }
	}
}
