namespace Shelter.Views
{
	partial class Contracts
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ContractsView = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)ContractsView).BeginInit();
			SuspendLayout();
			// 
			// ContractsView
			// 
			ContractsView.AllowUserToAddRows = false;
			ContractsView.AllowUserToDeleteRows = false;
			ContractsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ContractsView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
			ContractsView.Location = new Point(0, -1);
			ContractsView.Name = "ContractsView";
			ContractsView.ReadOnly = true;
			ContractsView.RowHeadersWidth = 51;
			ContractsView.RowTemplate.Height = 29;
			ContractsView.Size = new Size(599, 233);
			ContractsView.TabIndex = 0;
			// 
			// Column1
			// 
			Column1.HeaderText = "Номер";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Width = 125;
			// 
			// Column2
			// 
			Column2.HeaderText = "Заказчик";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Width = 125;
			// 
			// button1
			// 
			button1.Location = new Point(36, 301);
			button1.Name = "button1";
			button1.Size = new Size(103, 35);
			button1.TabIndex = 1;
			button1.Text = "Открыть";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(175, 301);
			button2.Name = "button2";
			button2.Size = new Size(103, 35);
			button2.TabIndex = 2;
			button2.Text = "Добавить";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(314, 301);
			button3.Name = "button3";
			button3.Size = new Size(103, 35);
			button3.TabIndex = 3;
			button3.Text = "Удалить";
			button3.UseVisualStyleBackColor = true;
			// 
			// Contracts
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(ContractsView);
			Name = "Contracts";
			Text = "Contracts";
			((System.ComponentModel.ISupportInitialize)ContractsView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView ContractsView;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}