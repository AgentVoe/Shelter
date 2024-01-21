using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.ViewModels
{
    public class ContractViewModel : BaseViewModel
    {
        public new int Id { get; set; }

        public string? ContractNumber { get; set; }

        public DateOnly? ConclusionDate { get; set; }

        public DateOnly? ValidDate { get; set; }

        public string OrganizationTitle { get; set; }
    }
}
