using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.DTOs
{
	public record CustomUserClaims(string Id = null!, string Name = null!, string Email = null!, string Role = null!, List<Claim> Permissions = null!);
}

