using Shelter.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.ViewModels
{
	public class ContractCityViewModel: BaseViewModel
	{
		public new int Id { get; set; }

		public double? CatchingPrice { get; set; }

		public string? CityTitle { get; set; }
		public string? ContractNumber { get; set; }
	}
}
