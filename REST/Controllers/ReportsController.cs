using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shelter.ViewModels;
using System.Globalization;
using System.Linq;

namespace REST.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ReportsController : ControllerBase
	{

		[HttpPost("/api/Report")]
		public IActionResult GenerateReport([FromBody] ReportRequestModel reportRequestModel)
		{
			var contracts = reportRequestModel.Contracts;
			var contractsCities = reportRequestModel.ContractsCities;

			int selectedMonth = reportRequestModel.Month;
			string orgTitle = reportRequestModel.OrganizationTitle;
			int selectedYear = reportRequestModel.Year;

			var filteredContracts = contracts.FindAll(contract =>
			contract.ConclusionDate.Value.Month == selectedMonth &&
			contract.ConclusionDate.Value.Year == selectedYear &&
			contract.OrganizationTitle == orgTitle)
			.ToList();

			var schedules = reportRequestModel?.Schedules;

			var schedulesByMonth = schedules.FindAll(schedule =>
			schedule.CatchingMonth.Value.Month == selectedMonth &&
			 schedule.CatchingMonth.Value.Year == selectedYear);

			var acts = reportRequestModel?.Acts;

			var actsByMonth = acts?.FindAll(act =>
			act.CatchingDate.Value.Month == selectedMonth &&
				filteredContracts.Any(contract =>
				contract.ConclusionDate.HasValue &&
				contract.ConclusionDate.Value.Month == act.CatchingDate.Value.Month &&
				contract.ConclusionDate.Value.Year == act.CatchingDate.Value.Year));

			var animalsByCityWithTotalCostBySchedules = schedulesByMonth
				.GroupBy(schedule => schedule.CityTitle)
				.Join(contractsCities,
					  scheduleGroup => scheduleGroup.Key,
					  contract => contract.CityTitle,
					  (scheduleGroup, contract) => new
					  {
						  City = scheduleGroup.Key,
						  TotalAnimals = scheduleGroup.Sum(schedule => schedule.AnimalsToCatch),
						  CityCost = contract.CatchingPrice
					  })
				.Select(result => new
				{
					result.City,
					result.TotalAnimals,
					TotalCost = result.TotalAnimals * result.CityCost
				})
				.GroupBy(result => result.City)
				.Select(group => group.First())
				.ToList();


			var totalCostByCityByActs = actsByMonth
				.GroupBy(act => act.CityTitle)
				.Select(group => new
				{
					City = group.Key,
					TotalCost = group.Sum(act =>
						(act.CatchedCats + act.CatchedDogs) *
						contractsCities.FirstOrDefault(cc => cc.CityTitle == act.CityTitle)?.CatchingPrice ?? 0
					)
				})
				.ToList();

			double totalCostAnimalsBySchedul = (double)animalsByCityWithTotalCostBySchedules.Sum(item => item.TotalCost);
			double totalCostByActs = totalCostByCityByActs.Sum(item => item.TotalCost);


			double percentage = totalCostByActs / totalCostAnimalsBySchedul * 100;

			string monthString = new DateTime(DateTime.Now.Year, selectedMonth, 1).ToString("MMMM", CultureInfo.CurrentCulture);

			return Ok(new ReportViewModel()
			{
				Month = monthString,
				OrganizationTitle = orgTitle,
				Percentage = Math.Round(percentage).ToString() + "%"
			});
		}
	}
}
