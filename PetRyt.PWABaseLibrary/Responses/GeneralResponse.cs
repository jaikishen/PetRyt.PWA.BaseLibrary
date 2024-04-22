using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRyt.PWABaseLibrary.Responses
{
	public record GeneralResponse(bool IsSuccess, string Message = null!);
}
