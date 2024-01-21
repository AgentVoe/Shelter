using Microsoft.AspNetCore.Mvc;
using Shelter.ContextModels;
using Shelter.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private SchedulesContext context;

        public DataController(SchedulesContext context)
        {
            this.context = context;
        }

        [HttpGet("{tableName}")]
        public IEnumerable<BaseViewModel> GetTableData(string tableName)
        {
            switch (tableName)
            {
                case "Acts":
                    var acts = new ActsController(context);
                    return acts.GetActs();
                case "Contracts":
                    var contracts = new ContractsController(context);
                    return contracts.GetContracts();
                case "Organizations":
					var organizations = new OrganizationsController(context);
					return organizations.GetOrganizations();
                case "Cities":
					var cities = new CitiesController(context);
                    return cities.GetCities();
                case "Schedules":
                    var schedules = new SchedulesController(context);
                    return schedules.GetSchedules();
                case "ContractsCities":
                    var contractsCities = new ContractsCitiesController(context);
                    return contractsCities.GetContractsCities();
				default:
                    return new List<BaseViewModel>();
            }
        }
    }
}
