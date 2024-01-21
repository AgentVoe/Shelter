using Microsoft.AspNetCore.Mvc;
using Shelter.ContextModels;
using Shelter.ViewModels;

namespace REST.Controllers
{
	[ApiController]
    [Route("api/[controller]")]
    public class ActsController : ControllerBase
    {
        private SchedulesContext context;

        public ActsController(SchedulesContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<ActViewModel> GetActs()
        {
            var acts = from act in context.Acts
                       join city in context.Cities on act.CityId equals city.Id
                       join contract in context.Contracts on act.ContractId equals contract.Id
                       select new ActViewModel
                       {
                           Id = act.Id,
                           ActNumber = act.ActNumber,
                           CatchedCats = act.CatchedCats,
                           CatchedDogs = act.CatchedDogs,
                           CatchingDate = act.CatchingDate,
                           Purpose = act.Purpose,
                           ContractNumber = contract.ContractNumber,
                           CityTitle = city.CityTitle
                       };
            return acts;
        }
    }
}
