using Microsoft.AspNetCore.Mvc;
using Shelter.ContextModels;
using Shelter.ViewModels;

namespace REST.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SchedulesController
	{
        private SchedulesContext context;
        public SchedulesController(SchedulesContext context)
        {
            this.context = context;
        }
		[HttpGet]
		public IEnumerable<ScheduleViewModel> GetSchedules()
		{
			var schedules = from s in context.Schedules
							join c in context.Contracts on s.ContractId equals c.Id
							join city in context.Cities on s.CityId equals city.Id
							select new ScheduleViewModel
							{
								Id = s.Id,
								CatchingMonth = s.CatchingMonth,
								AnimalsToCatch = s.AnimalsToCatch,
								ContractNumber = c.ContractNumber,
								CityTitle = city.CityTitle
							};
			return schedules;
		}
	}
}
