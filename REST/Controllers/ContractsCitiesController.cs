using Microsoft.AspNetCore.Mvc;
using Shelter.ContextModels;
using Shelter.ViewModels;

namespace REST.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ContractsCitiesController: ControllerBase
	{
        private SchedulesContext context;
        public ContractsCitiesController(SchedulesContext context)
        {
            this.context = context;
        }
		[HttpGet]
		public IEnumerable<ContractCityViewModel> GetContractsCities()
		{
			var contractsCities = from cs in context.ContractsCities
								  join contract in context.Contracts on cs.ContractId equals contract.Id
								  join city in context.Cities on cs.CityId equals city.Id
								  select new ContractCityViewModel
								  {
									  Id = cs.Id,
									  CatchingPrice = cs.CatchingPrice,
									  ContractNumber = contract.ContractNumber,
									  CityTitle = city.CityTitle
								  };
			return contractsCities;
		}
	}
}
