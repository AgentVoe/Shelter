﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelter.Views
{
	public partial class Main : Form
	{
		private Contracts contracts;
		public Main()
		{
			InitializeComponent();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			contracts = new Contracts();
			contracts.Show();
		}
	}
}
