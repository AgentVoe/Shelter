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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchPurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special_signs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identification_mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_chip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catch_act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusion_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valid_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipyyur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caid,
            this.dogcount,
            this.catcount,
            this.animalcount,
            this.orgname,
            this.catchDate,
            this.catchPurp,
            this.aplicid,
            this.mcid});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(944, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // caid
            // 
            this.caid.HeaderText = "Номер акта отлова";
            this.caid.Name = "caid";
            // 
            // dogcount
            // 
            this.dogcount.HeaderText = "Кол-во пойманных собак";
            this.dogcount.Name = "dogcount";
            // 
            // catcount
            // 
            this.catcount.HeaderText = "Кол-во пойманных котов";
            this.catcount.Name = "catcount";
            // 
            // animalcount
            // 
            this.animalcount.HeaderText = "Кол-во пойманных животных";
            this.animalcount.Name = "animalcount";
            // 
            // orgname
            // 
            this.orgname.HeaderText = "Организация";
            this.orgname.Name = "orgname";
            // 
            // catchDate
            // 
            this.catchDate.HeaderText = "Дата отлова";
            this.catchDate.Name = "catchDate";
            // 
            // catchPurp
            // 
            this.catchPurp.HeaderText = "Цель отлова";
            this.catchPurp.Name = "catchPurp";
            // 
            // aplicid
            // 
            this.aplicid.HeaderText = "Заявка на отлов";
            this.aplicid.Name = "aplicid";
            // 
            // mcid
            // 
            this.mcid.HeaderText = "Муниципальный контракт";
            this.mcid.Name = "mcid";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.sex,
            this.breed,
            this.hair,
            this.color,
            this.ears,
            this.tail,
            this.special_signs,
            this.identification_mark,
            this.number_of_chip,
            this.settlement,
            this.catch_act});
            this.dataGridView2.Location = new System.Drawing.Point(12, 303);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1243, 226);
            this.dataGridView2.TabIndex = 1;
            // 
            // category
            // 
            this.category.HeaderText = "Категория";
            this.category.Name = "category";
            // 
            // sex
            // 
            this.sex.HeaderText = "Пол";
            this.sex.Name = "sex";
            // 
            // breed
            // 
            this.breed.HeaderText = "Порода";
            this.breed.Name = "breed";
            // 
            // hair
            // 
            this.hair.HeaderText = "Шерсть";
            this.hair.Name = "hair";
            // 
            // color
            // 
            this.color.HeaderText = "Окрас";
            this.color.Name = "color";
            // 
            // ears
            // 
            this.ears.HeaderText = "Уши";
            this.ears.Name = "ears";
            // 
            // tail
            // 
            this.tail.HeaderText = "Хвост";
            this.tail.Name = "tail";
            // 
            // special_signs
            // 
            this.special_signs.HeaderText = "Особые приметы";
            this.special_signs.Name = "special_signs";
            // 
            // identification_mark
            // 
            this.identification_mark.HeaderText = "Идентификационная метка";
            this.identification_mark.Name = "identification_mark";
            // 
            // number_of_chip
            // 
            this.number_of_chip.HeaderText = "Номер эл. чипа";
            this.number_of_chip.Name = "number_of_chip";
            // 
            // settlement
            // 
            this.settlement.HeaderText = "Населённый пункт";
            this.settlement.Name = "settlement";
            // 
            // catch_act
            // 
            this.catch_act.HeaderText = "Акт отлова";
            this.catch_act.Name = "catch_act";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.conclusion_date,
            this.valid_date,
            this.executor,
            this.customer});
            this.dataGridView3.Location = new System.Drawing.Point(12, 535);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(544, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // number
            // 
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            // 
            // conclusion_date
            // 
            this.conclusion_date.HeaderText = "Дата заключения";
            this.conclusion_date.Name = "conclusion_date";
            // 
            // valid_date
            // 
            this.valid_date.HeaderText = "Дата действия";
            this.valid_date.Name = "valid_date";
            // 
            // executor
            // 
            this.executor.HeaderText = "Исполнитель";
            this.executor.Name = "executor";
            // 
            // customer
            // 
            this.customer.HeaderText = "Заказчик";
            this.customer.Name = "customer";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.inn,
            this.kpp,
            this.adress,
            this.orgtype,
            this.ipyyur});
            this.dataGridView4.Location = new System.Drawing.Point(562, 535);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(644, 150);
            this.dataGridView4.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Организация";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // inn
            // 
            this.inn.HeaderText = "ИНН";
            this.inn.Name = "inn";
            // 
            // kpp
            // 
            this.kpp.HeaderText = "КПП";
            this.kpp.Name = "kpp";
            // 
            // adress
            // 
            this.adress.HeaderText = "Адрес";
            this.adress.Name = "adress";
            // 
            // orgtype
            // 
            this.orgtype.HeaderText = "Тип организации";
            this.orgtype.Name = "orgtype";
            // 
            // ipyyur
            // 
            this.ipyyur.HeaderText = "ИП/Юр. лицо";
            this.ipyyur.Name = "ipyyur";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.month,
            this.municipality});
            this.dataGridView5.Location = new System.Drawing.Point(962, 12);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(344, 285);
            this.dataGridView5.TabIndex = 4;
            // 
            // year
            // 
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            // 
            // month
            // 
            this.month.HeaderText = "Месяц";
            this.month.Name = "month";
            // 
            // municipality
            // 
            this.municipality.HeaderText = "Муниципальное образование";
            this.municipality.Name = "municipality";
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.password,
            this.role});
            this.dataGridView6.Location = new System.Drawing.Point(1212, 535);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.Size = new System.Drawing.Size(343, 150);
            this.dataGridView6.TabIndex = 5;
            // 
            // login
            // 
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            // 
            // password
            // 
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            // 
            // role
            // 
            this.role.HeaderText = "Роль";
            this.role.Name = "role";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 696);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn caid;
        private DataGridViewTextBoxColumn dogcount;
        private DataGridViewTextBoxColumn catcount;
        private DataGridViewTextBoxColumn animalcount;
        private DataGridViewTextBoxColumn orgname;
        private DataGridViewTextBoxColumn catchDate;
        private DataGridViewTextBoxColumn catchPurp;
        private DataGridViewTextBoxColumn aplicid;
        private DataGridViewTextBoxColumn mcid;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn breed;
        private DataGridViewTextBoxColumn hair;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn ears;
        private DataGridViewTextBoxColumn tail;
        private DataGridViewTextBoxColumn special_signs;
        private DataGridViewTextBoxColumn identification_mark;
        private DataGridViewTextBoxColumn number_of_chip;
        private DataGridViewTextBoxColumn settlement;
        private DataGridViewTextBoxColumn catch_act;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn conclusion_date;
        private DataGridViewTextBoxColumn valid_date;
        private DataGridViewTextBoxColumn executor;
        private DataGridViewTextBoxColumn customer;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn inn;
        private DataGridViewTextBoxColumn kpp;
        private DataGridViewTextBoxColumn adress;
        private DataGridViewTextBoxColumn orgtype;
        private DataGridViewTextBoxColumn ipyyur;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn month;
        private DataGridViewTextBoxColumn municipality;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn login;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
    }
}