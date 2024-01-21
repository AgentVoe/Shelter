using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.ViewModels
{
    public class ActViewModel : BaseViewModel
    {
        public new int Id { get; set; }
        public string? ActNumber { get; set; }
        public int? CatchedCats { get; set; }
        public int? CatchedDogs { get; set; }
        public DateOnly? CatchingDate { get; set; }
        public string? Purpose { get; set; }
        public string? ContractNumber { get; set; }
        public string? CityTitle { get; set; }
    }

}
