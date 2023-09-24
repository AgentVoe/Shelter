namespace Shelter.Views
{
	partial class ContractCard
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(153, 49);
			label1.Name = "label1";
			label1.Size = new Size(60, 20);
			label1.TabIndex = 0;
			label1.Text = "Номер:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(80, 92);
			label2.Name = "label2";
			label2.Size = new Size(133, 20);
			label2.TabIndex = 1;
			label2.Text = "Дата Заключения:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(100, 149);
			label3.Name = "label3";
			label3.Size = new Size(113, 20);
			label3.TabIndex = 2;
			label3.Text = "Дата Действия:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(109, 202);
			label4.Name = "label4";
			label4.Size = new Size(104, 20);
			label4.TabIndex = 3;
			label4.Text = "Исполнитель:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(139, 265);
			label5.Name = "label5";
			label5.Size = new Size(74, 20);
			label5.TabIndex = 4;
			label5.Text = "Заказчик:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(219, 42);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(219, 85);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(219, 142);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 27);
			textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(219, 202);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(125, 27);
			textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(219, 262);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(125, 27);
			textBox5.TabIndex = 9;
			// 
			// button1
			// 
			button1.Location = new Point(163, 332);
			button1.Name = "button1";
			button1.Size = new Size(125, 44);
			button1.TabIndex = 10;
			button1.Text = "Сохранить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ContractCard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(457, 439);
			Controls.Add(button1);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ContractCard";
			Text = "ContractCard";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private Button button1;
	}
}