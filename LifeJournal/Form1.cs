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
	public partial class Form1 : Form
	{
		List<Button> buttonsHabbitDone = new List<Button>();
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonMainAddHabbit_Click(object sender, EventArgs e)
		{
			buttonsHabbitDone.Add(new Button());
			if (buttonsHabbitDone.Count > 1 ) 
			{
				int x = buttonsHabbitDone[buttonsHabbitDone.Count - 2].Location.X;
				int y = buttonsHabbitDone[buttonsHabbitDone.Count - 2].Location.Y + buttonsHabbitDone[buttonsHabbitDone.Count - 2].Height + 5;
				buttonsHabbitDone.Last().Location = new Point(x,y);
			}
			else buttonsHabbitDone.Last().Location = new Point(30, 30);
			buttonsHabbitDone.Last().Text = "Done";
			panelMainHabbits.Controls.Add(buttonsHabbitDone.Last());

		}
	}
}
