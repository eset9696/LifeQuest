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
	public partial class MainWindow : Form
	{
		SqlConnection conn;
		SqlDataReader reader;

		int user;
		List<string> habbits = new List<string>();

		public MainWindow(int user, SqlConnection connection)
		{
			InitializeComponent();
			this.user = user;
			conn = connection;
			//LoadHabbits();
		}

		private void LoadHabbits()
		{
			string command = $@"SELECT habbitDescription, habbitStatus FROM Habbits, Users WHERE [user] = @user";
			SqlCommand cmd = new SqlCommand(command, conn);
			cmd.Parameters.AddWithValue("@user", user.ToString());
			conn.Open();
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				checkedListBoxMainHabbits.Items.Add(reader[0], Convert.ToBoolean(reader[1]));
			}
			reader.Close();
			conn.Close();
		}

		private void buttonMainAddHabbit_Click(object sender, EventArgs e)
		{
			NewHabbit newHabbit = new NewHabbit(conn);
			DialogResult dialogResult = newHabbit.ShowDialog(this);
			if(dialogResult == DialogResult.OK)
			{
				string command = $@"IF NOT EXISTS (SELECT habbit_id FROM Habbits, Users, HabbitTypes
								WHERE [user] = @user AND habbitDescription = @habbitDescription AND type = @type) 
									BEGIN 
										INSERT INTO Habbits([user], habbitDescription, habbitType, habbitStatus, value, habbitCategory)
										VALUES (@user, @habbitDescription, @habbitType, @habbitStatus, @value, @habbitCategory)
									END";
				conn.Open();
				SqlCommand cmd = new SqlCommand(command, conn);
				cmd.Parameters.AddWithValue("@user", user.ToString());
				cmd.Parameters.AddWithValue("@habbitDescription", newHabbit.Habbit);
				cmd.Parameters.AddWithValue("@type", newHabbit.HabbitType);
				cmd.Parameters.AddWithValue("@habbitType", $"SELECT habbit_type_id FROM HabbitTypes WHERE type = '{newHabbit.HabbitType}'");
				cmd.Parameters.AddWithValue("@habbitStatus", 0);
				cmd.Parameters.AddWithValue("@value", newHabbit.HabbitValue);
				cmd.Parameters.AddWithValue("@habbitCategory", $"SELECT habbit_category_id FROM HabbitCategory WHERE category = '{newHabbit.HabbitCategory}'");
				cmd.ExecuteNonQuery();
				conn.Close();
				checkedListBoxMainHabbits.Items.Add(newHabbit.Habbit);
			}
		}

		

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			//SaveHabbits();
			Application.Exit();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			LoadHabbits();
		}


		private void SaveHabbits()
		{
			string command = $@"UPDATE Habbits SET habbitStatus = @habbitStatus WHERE [user] = @user";
			SqlCommand cmd = new SqlCommand(command, conn);
			conn.Open();
			cmd.Parameters.AddWithValue("@user", user);
			cmd.Parameters.AddWithValue("@habbitStatus", !checkedListBoxMainHabbits.GetItemChecked(checkedListBoxMainHabbits.SelectedIndex));
			cmd.ExecuteNonQuery();
			/*for(int i = 0; i < checkedListBoxMainHabbits.Items.Count; i++)
			{
				cmd.Parameters.AddWithValue("@user", user);
				cmd.Parameters.AddWithValue("@habbitStatus", checkedListBoxMainHabbits.GetItemChecked(i));
				cmd.ExecuteNonQuery();
			}*/
			conn.Close();
		}

		private void SaveProgress()
		{
			
		}

		private void LoadProgress() { }

		private bool CheckHabbitStatus()
		{
			bool result;
			string command = $@"SELECT habbitStatus FROM Habbits WHERE [user] = @user AND @habbitDescription = @habbitDescription";
			SqlCommand cmd = new SqlCommand(command, conn);
			cmd.Parameters.AddWithValue("@user", user);
			cmd.Parameters.AddWithValue("@habbitDescription", checkedListBoxMainHabbits.SelectedItem.ToString());
			conn.Open();
			reader = cmd.ExecuteReader();
			reader.Read();
			result = Convert.ToBoolean(reader[0]);
			reader.Close();
			conn.Close();
			return result == checkedListBoxMainHabbits.GetItemChecked(checkedListBoxMainHabbits.SelectedIndex);
		}

		private void checkedListBoxMainHabbits_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (checkedListBoxMainHabbits.SelectedIndex >= 0)
			{
				
				if (!checkedListBoxMainHabbits.GetItemChecked(checkedListBoxMainHabbits.SelectedIndex))
				{
					string command = $@"SELECT value FROM Habbits WHERE [user] = @user AND @habbitDescription = @habbitDescription";
					SqlCommand cmd = new SqlCommand(command, conn);
					cmd.Parameters.AddWithValue("@user", user);
					cmd.Parameters.AddWithValue("@habbitDescription", checkedListBoxMainHabbits.SelectedItem.ToString());
					conn.Open();
					reader = cmd.ExecuteReader();
					reader.Read();
					int value = Convert.ToInt32(reader[0]);
					reader.Close();
					conn.Close();
					if(CheckHabbitStatus()) progressBarReward.Value += value;
					SaveHabbits();
				} 
			}
		}
	}
}
