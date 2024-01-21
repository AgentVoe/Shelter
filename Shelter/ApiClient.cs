using Newtonsoft.Json;
using Shelter.ViewModels;
using System.Text;

namespace Shelter
{
	internal class ApiClient
	{
		private HttpClient httpClient;
		private string baseUrl;

        public ApiClient(string baseUrl)
        {
			httpClient = new HttpClient();
			this.baseUrl = baseUrl;
            
        }
		public async Task<List<object>> GetTableDataAsync(string tableName)
		{
			var response = await httpClient.GetAsync($"{baseUrl}/api/{tableName}");
			response.EnsureSuccessStatusCode();

			var content = await response.Content.ReadAsStringAsync();
			var data = JsonConvert.DeserializeObject<List<object>>(content);

			return data;
		}
		public async Task<List<T>> GetTableDataAsync<T>(string tableName)
		{
			var response = await httpClient.GetAsync($"{baseUrl}/api/{tableName}");
			response.EnsureSuccessStatusCode();

			var content = await response.Content.ReadAsStringAsync();
			var data = JsonConvert.DeserializeObject<List<T>>(content);

			return data;
		}

		public async Task<ReportViewModel> GenerateReportAsync<T>(ReportRequestModel reportRequestModel)
		{
			try
			{

				string jsonData = JsonConvert.SerializeObject(reportRequestModel);
				StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

				var response = await httpClient.PostAsync($"{baseUrl}/api/Report", content);
				response.EnsureSuccessStatusCode();

				var responseContent = await response.Content.ReadAsStringAsync();
				var reportViewModel = JsonConvert.DeserializeObject<ReportViewModel>(responseContent);

				return reportViewModel;
			}
			catch (HttpRequestException ex)
			{
				// Handle exceptions if the request fails
				Console.WriteLine($"Error generating report: {ex.Message}");
				throw;
			}
		}


		public async Task<Dictionary<string, List<object>>> GetAllTableDataAsync(List<string> tableNames)
		{
			var allTableData = new Dictionary<string, List<object>>();

			foreach (var tableName in tableNames)
			{
				var tableData = await GetTableDataAsync(tableName);
				allTableData.Add(tableName, tableData);
			}

			return allTableData;
		}
		public async Task<List<T>> GetTableAsync<T>(string tableName)
		{		
			return await GetTableDataAsync<T>(tableName);
		}
		
	}
}
