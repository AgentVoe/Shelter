using Shelter.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.ViewModels
{
	public class ScheduleViewModel: BaseViewModel
	{
		public new int Id { get; set; }

		public DateOnly? CatchingMonth { get; set; }

		public int? AnimalsToCatch { get; set; }
		public string? ContractNumber { get; set; }
		public string? CityTitle { get; set; }
	}
}
