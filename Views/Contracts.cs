using System;
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
	public partial class Contracts : Form
	{
		ContractCard card;
		public Contracts()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			card = new ContractCard();
			card.ShowDialog();
			if (card.DialogResult == DialogResult.OK)
			{
				var t = card.ReturnData();
				MessageBox.Show(t);
			}
			this.Show();
		}
	}
}
