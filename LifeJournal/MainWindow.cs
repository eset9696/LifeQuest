using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeJournal
{
	public partial class MainWindow : Form
	{
		List<string> habbits = new List<string>();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void buttonMainAddHabbit_Click(object sender, EventArgs e)
		{
			NewHabbit newHabbit = new NewHabbit();
			newHabbit.Show(this);
		}
	}
}
