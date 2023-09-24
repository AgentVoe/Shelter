namespace Shelter.Views
{
	partial class Main
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
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(225, 69);
			button1.Name = "button1";
			button1.Size = new Size(223, 50);
			button1.TabIndex = 0;
			button1.Text = "Реестр Организаций";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(225, 125);
			button2.Name = "button2";
			button2.Size = new Size(223, 50);
			button2.TabIndex = 1;
			button2.Text = "Реестр План-Графиков";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(225, 181);
			button3.Name = "button3";
			button3.Size = new Size(223, 50);
			button3.TabIndex = 2;
			button3.Text = "Реестр Муниципальных  Контрактов";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(225, 237);
			button4.Name = "button4";
			button4.Size = new Size(223, 50);
			button4.TabIndex = 3;
			button4.Text = "Реестр Актов Отлова";
			button4.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Main";
			Text = "Main";
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}