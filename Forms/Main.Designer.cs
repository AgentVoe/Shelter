namespace Shelter
{
	partial class Main
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
			btnChooseOrg = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// btnChooseOrg
			// 
			btnChooseOrg.Location = new Point(214, 56);
			btnChooseOrg.Name = "btnChooseOrg";
			btnChooseOrg.Size = new Size(221, 53);
			btnChooseOrg.TabIndex = 0;
			btnChooseOrg.Text = "Реестр Организаций";
			btnChooseOrg.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(214, 115);
			button2.Name = "button2";
			button2.Size = new Size(221, 53);
			button2.TabIndex = 1;
			button2.Text = "Реестр План-Графиков";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(214, 174);
			button3.Name = "button3";
			button3.Size = new Size(221, 53);
			button3.TabIndex = 2;
			button3.Text = "Реестр Актов Отлова";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(214, 233);
			button4.Name = "button4";
			button4.Size = new Size(221, 53);
			button4.TabIndex = 3;
			button4.Text = "Реестр Муниципальных Контрактов";
			button4.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(640, 388);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(btnChooseOrg);
			Name = "MainForm";
			Text = "Главная Страница";
			ResumeLayout(false);
		}

		#endregion

		private Button btnChooseOrg;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}