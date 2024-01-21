using Microsoft.AspNetCore.Mvc;
using Shelter.ContextModels;
using Shelter.ViewModels;

namespace REST.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CitiesController: ControllerBase
	{
		private SchedulesContext context;

        public CitiesController(SchedulesContext context)
        {
            this.context = context;
        }
		[HttpGet]
		public IEnumerable<CityViewModel> GetCities()
		{
			var cities = from city in context.Cities
						 join org in context.Organizations on city.OrganizationId equals org.Id
						 select new CityViewModel
						 {
							 Id = city.Id,
							 CityTitle = city.CityTitle,
							 OrgTitle = org.OrgTitle,
						 };
			return cities;
		}
	}
}
