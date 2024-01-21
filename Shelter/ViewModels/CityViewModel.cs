using Shelter.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.ViewModels
{
	public class CityViewModel: BaseViewModel
	{
		public new int Id { get; set; }

		public string? CityTitle { get; set; }

		public string? OrgTitle { get; set; }
	}
}
