using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.ViewModels
{
	public class ReportRequestModel
	{
		public List<ContractViewModel> Contracts { get; set; }
		public List<ActViewModel> Acts { get; set; }
		public List<OrganizationViewModel> Organizations { get; set; }
		public List<CityViewModel> Cities { get; set; }
		public List<ScheduleViewModel> Schedules { get; set; }
		public List<ContractCityViewModel> ContractsCities { get; set; }
		public int Month { get; set; }
		public string OrganizationTitle { get; set; }
		public int Year { get; set; }
	}

}
