using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeQuest
{
	public partial class NewHabbit : Form
	{
		SqlConnection conn;
		SqlDataReader reader;

		public string Habbit { get; set; }
		public string HabbitType { get; set; }
		public string HabbitCategory { get; set; }
		public int HabbitValue { get; set; }

		public NewHabbit(SqlConnection connection)
		{
			InitializeComponent();
			this.conn = connection;
		}

		private void buttonNewHabbitOk_Click(object sender, EventArgs e)
		{
			Habbit = textBoxNewHabbit.Text;
			this.DialogResult = DialogResult.OK;
		}

		private void GetHabbitValue()
		{
			if (HabbitType != null && HabbitCategory != null)
			{
				string command = $@"SELECT price, ratio FROM HabbitTypes, HabbitCategory 
								WHERE type = @type AND category = @category";
				conn.Open();
				SqlCommand cmd = new SqlCommand(command, conn);
				cmd.Parameters.AddWithValue("@type", HabbitType);
				cmd.Parameters.AddWithValue("@category", HabbitCategory);
				reader = cmd.ExecuteReader();
				reader.Read();
				HabbitValue = Convert.ToInt32(reader[0]) * Convert.ToInt32(reader[1]);
				reader.Close();
				conn.Close();
				labelRewardValue.Text = HabbitValue.ToString(); 
			}
		}

		private void comboBoxNewHabbitType_SelectedIndexChanged(object sender, EventArgs e)
		{
			HabbitType = comboBoxNewHabbitType.SelectedItem.ToString();
			GetHabbitValue();
		}

		private void comboBoxNewHabbitCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			HabbitCategory = comboBoxNewHabbitCategory.SelectedItem.ToString();
			GetHabbitValue();
		}

		private void LoadDataToComboBox(ComboBox comboBox, string command)
		{
			SqlCommand cmd = new SqlCommand(command, conn);
			conn.Open();
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				comboBox.Items.Add(reader[0].ToString());
			}
			reader.Close();
			conn.Close();
		}

		private void NewHabbit_Load(object sender, EventArgs e)
		{
			LoadDataToComboBox(comboBoxNewHabbitType, "SELECT type FROM HabbitTypes");
			LoadDataToComboBox(comboBoxNewHabbitCategory, "SELECT category FROM HabbitCategory");
			comboBoxNewHabbitType.SelectedIndex = 0;
			comboBoxNewHabbitCategory.SelectedIndex = 0;
			GetHabbitValue();
		}
	}
}
