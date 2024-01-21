namespace Shelter
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridView = new DataGridView();
			tableComboBox = new ComboBox();
			ReportGenerateButton = new Button();
			dateTimePicker1 = new DateTimePicker();
			comboBoxOrganizations = new ComboBox();
			ExportToExcelButton = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// dataGridView
			// 
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Location = new Point(36, 55);
			dataGridView.Name = "dataGridView";
			dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridView.Size = new Size(717, 359);
			dataGridView.TabIndex = 0;
			// 
			// tableComboBox
			// 
			tableComboBox.FormattingEnabled = true;
			tableComboBox.Location = new Point(790, 110);
			tableComboBox.Name = "tableComboBox";
			tableComboBox.Size = new Size(151, 28);
			tableComboBox.TabIndex = 1;
			tableComboBox.SelectedIndexChanged += tableComboBox_SelectedIndexChanged;
			// 
			// ReportGenerateButton
			// 
			ReportGenerateButton.Location = new Point(790, 284);
			ReportGenerateButton.Name = "ReportGenerateButton";
			ReportGenerateButton.Size = new Size(151, 40);
			ReportGenerateButton.TabIndex = 2;
			ReportGenerateButton.Text = "Создать отчёт";
			ReportGenerateButton.UseVisualStyleBackColor = true;
			ReportGenerateButton.Click += ReportGenerateButton_Click;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(790, 190);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(151, 27);
			dateTimePicker1.TabIndex = 3;
			// 
			// comboBoxOrganizations
			// 
			comboBoxOrganizations.FormattingEnabled = true;
			comboBoxOrganizations.Location = new Point(790, 250);
			comboBoxOrganizations.Name = "comboBoxOrganizations";
			comboBoxOrganizations.Size = new Size(151, 28);
			comboBoxOrganizations.TabIndex = 4;
			// 
			// ExportToExcelButton
			// 
			ExportToExcelButton.Location = new Point(790, 363);
			ExportToExcelButton.Name = "ExportToExcelButton";
			ExportToExcelButton.Size = new Size(151, 51);
			ExportToExcelButton.TabIndex = 5;
			ExportToExcelButton.Text = "Выгрузить отчёт в Excel";
			ExportToExcelButton.UseVisualStyleBackColor = true;
			ExportToExcelButton.Click += ExportToExcelButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(811, 227);
			label1.Name = "label1";
			label1.Size = new Size(105, 20);
			label1.TabIndex = 6;
			label1.Text = "Организация:";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(838, 167);
			label2.Name = "label2";
			label2.Size = new Size(44, 20);
			label2.TabIndex = 7;
			label2.Text = "Дата:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(832, 87);
			label3.Name = "label3";
			label3.Size = new Size(74, 20);
			label3.TabIndex = 8;
			label3.Text = "Таблицы:";
			// 
			// button1
			// 
			button1.Location = new Point(202, 454);
			button1.Name = "button1";
			button1.Size = new Size(115, 48);
			button1.TabIndex = 9;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(359, 454);
			button2.Name = "button2";
			button2.Size = new Size(115, 48);
			button2.TabIndex = 10;
			button2.Text = "Удалить";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(521, 454);
			button3.Name = "button3";
			button3.Size = new Size(115, 48);
			button3.TabIndex = 11;
			button3.Text = "Изменить";
			button3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(990, 546);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(ExportToExcelButton);
			Controls.Add(comboBoxOrganizations);
			Controls.Add(dateTimePicker1);
			Controls.Add(ReportGenerateButton);
			Controls.Add(tableComboBox);
			Controls.Add(dataGridView);
			Name = "Form1";
			Text = "Учёт отловов по графикам";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView;
		private ComboBox tableComboBox;
		private Button ReportGenerateButton;
		private DateTimePicker dateTimePicker1;
		private ComboBox comboBoxOrganizations;
		private Button ExportToExcelButton;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}
