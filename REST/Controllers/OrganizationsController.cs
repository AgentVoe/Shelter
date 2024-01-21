using Microsoft.AspNetCore.Mvc;
using Shelter.ContextModels;
using Shelter.ViewModels;

namespace REST.Controllers
{
    [ApiController]
	[Route("api/[controller]")]
	public class OrganizationsController
	{
		private SchedulesContext context;
		public OrganizationsController(SchedulesContext context)
        {
            this.context = context;
        }
		[HttpGet]
		public IEnumerable<OrganizationViewModel> GetOrganizations()
		{
			var organizations = from org in context.Organizations
								select new OrganizationViewModel
								{
									Id = org.Id,
									OrgTitle = org.OrgTitle,
									Inn = org.Inn,
									Kpp = org.Kpp,
									Adres = org.Adres,
								};
			return organizations;
		}
	}
}
