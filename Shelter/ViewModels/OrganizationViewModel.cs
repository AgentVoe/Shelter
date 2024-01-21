using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.ViewModels
{
	public class OrganizationViewModel: BaseViewModel
	{
		public new int Id { get; set; }

		public string? OrgTitle { get; set; }

		public string? Inn { get; set; }

		public string? Kpp { get; set; }

		public string? Adres { get; set; }

	}
}
