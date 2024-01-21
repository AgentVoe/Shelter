using Shelter.ViewModels;
using Excel = Microsoft.Office.Interop.Excel;
namespace Shelter

{
	public partial class Form1 : Form
	{
		private ApiClient client;
		private Dictionary<string, List<object>> allTablesData;
		public List<ContractViewModel> contracts;
		public List<ActViewModel> acts;
		public List<CityViewModel> cities;
		public List<ScheduleViewModel> schedules;
		public List<OrganizationViewModel> organizations;
		public List<ContractCityViewModel> contractsCities;
		public Form1()
		{
			InitializeComponent();
			client = new ApiClient("https://localhost:7212");

		}
		private async void Form1_Load(object sender, EventArgs e)
		{
			InitializeComboBox();
			await LoadDataAsync();
			await DisplayOrganizations();
		}
		private void InitializeComboBox()
		{
			tableComboBox.Items.Add("Acts");
			tableComboBox.Items.Add("Contracts");
			tableComboBox.Items.Add("Organizations");
			tableComboBox.Items.Add("Cities");
			tableComboBox.Items.Add("Schedules");
			tableComboBox.Items.Add("ContractsCities");

		}

		private async Task LoadDataAsync()
		{
			try
			{
				var tableNames = new List<string> { "Acts", "Contracts", "Organizations", "Cities", "Schedules", "ContractsCities" };
				allTablesData = await client.GetAllTableDataAsync(tableNames);
				contracts = await client.GetTableDataAsync<ContractViewModel>("Contracts");
				acts = await client.GetTableDataAsync<ActViewModel>("Acts");
				cities = await client.GetTableDataAsync<CityViewModel>("Cities");
				organizations = await client.GetTableDataAsync<OrganizationViewModel>("Organizations");
				schedules = await client.GetTableDataAsync<ScheduleViewModel>("Schedules");
				contractsCities = await client.GetTableDataAsync<ContractCityViewModel>("ContractsCities");
				DisplayTableData(tableNames[0]);
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private async Task LoadReportAsync()
		{
			int month = dateTimePicker1.Value.Month;
			string selectedOrgTitle = comboBoxOrganizations.SelectedItem?.ToString();
			int selectedYear = dateTimePicker1.Value.Year;
			try
			{

				var reportRequestModel = new ReportRequestModel
				{
					Contracts = contracts,
					Acts = acts,
					Organizations = organizations,
					Cities = cities,
					Schedules = schedules,
					ContractsCities = contractsCities,
					Month = month,
					OrganizationTitle = selectedOrgTitle,
					Year = selectedYear

				};
				var reportData = await client.GenerateReportAsync<ReportViewModel>(reportRequestModel);

				DisplayReport(reportData);
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DisplayReport(ReportViewModel report)
		{
			List<ReportViewModel> reportResult = new List<ReportViewModel>()
			{
				report
			};
			dataGridView.DataSource = reportResult;
			dataGridView.Update();
			dataGridView.Refresh();
		}
		private void DisplayTableData(string tableName)
		{
			var tableData = allTablesData[tableName];

			dataGridView.DataSource = tableData.ToList();
			dataGridView.Update();
			dataGridView.Refresh();
		}

		private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedTableName = tableComboBox.SelectedItem.ToString();

			if (allTablesData.ContainsKey(selectedTableName))
			{
				DisplayTableData(selectedTableName);
			}
			else
			{
				MessageBox.Show($"No data available for the selected table: {selectedTableName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private async void ReportGenerateButton_Click(object sender, EventArgs e)
		{
			await LoadReportAsync();
		}
		private async Task DisplayOrganizations()
		{
			foreach (var organization in organizations)
			{
				comboBoxOrganizations.Items.Add(organization.OrgTitle);
			}
		}
		private void ExportToExcel(DataGridView dataGridView, string fileName)
		{
			Excel.Application excelApp = new Excel.Application();
			Excel.Workbook workbook = excelApp.Workbooks.Add();
			Excel.Worksheet worksheet = workbook.Sheets[1];

			for (int i = 0; i < dataGridView.Columns.Count; i++)
			{
				worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
			}

			for (int i = 0; i < dataGridView.Rows.Count; i++)
			{
				for (int j = 0; j < dataGridView.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
				}
			}

			workbook.SaveAs(fileName);
			excelApp.Quit();
		}
		private void ExportToExcelButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ExportToExcel(dataGridView, saveFileDialog.FileName);
				MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
