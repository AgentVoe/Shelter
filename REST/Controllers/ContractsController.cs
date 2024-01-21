using Microsoft.AspNetCore.Mvc;
using Shelter.ContextModels;
using Shelter.ViewModels;

namespace REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractsController : ControllerBase
    {
        private SchedulesContext context;
        public ContractsController(SchedulesContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<ContractViewModel> GetContracts()
        {
            var contracts = from contract in context.Contracts
                            join org in context.Organizations on contract.OrganizationId equals org.Id
                            select new ContractViewModel
                            {
                                Id = contract.Id,
                                ContractNumber = contract.ContractNumber,
                                ConclusionDate = contract.ConclusionDate,
                                ValidDate = contract.ValidDate,
                                OrganizationTitle = org.OrgTitle
                            };
            return contracts;
        }

    }
}
