using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using LifeJournal;
using System.Security.Policy;

namespace LifeQuest
{
	public partial class StartWindow : Form
	{
		string connStr;
		SqlConnection conn;
		SqlDataReader reader;

		public StartWindow()
		{
			InitializeComponent();
			connStr = ConfigurationManager.ConnectionStrings["LifeQuest"].ConnectionString;
			conn = new SqlConnection(connStr);
		}

		bool ValidateLogin(string login)
		{
			if(Regex.IsMatch(login, @"^[a-zA-Z][a-zA-Z0-9._@]{3,20}$"))return true;
			return false;
		}

		bool ValidatePass(string pwd)
		{
			if (Regex.IsMatch(pwd, @"^([A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")) return true;
			return false;
		}

		bool CheckMatchPass()
		{
			if (textBoxRegisterPWD.Text.Equals(textBoxRegisterPWDConfirm.Text) && !textBoxRegisterPWD.Text.Equals("")) return true;
			return false;
		}

		bool CheckLoginExistence()
		{
			string command = $@"SELECT * FROM Users WHERE Users.login = '{textBoxRegisterLogin.Text}'";
			SqlCommand cmd = new SqlCommand(command, conn);
			conn.Open();
			reader = cmd.ExecuteReader();
			if (reader.HasRows)
			{
				conn.Close(); 
				return true;
			}
			conn.Close();
			return false;
		}

		private void buttonSWLogin_Click(object sender, EventArgs e)
		{
			string command = $@"SELECT user_id, password FROM Users WHERE login = @login";
			conn.Open();
			SqlCommand cmd = new SqlCommand(command, conn);
			cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
			reader = cmd.ExecuteReader();
			reader.Read();
			if (reader.HasRows && PWDHasher.Verify(textBoxPassword.Text, reader[1].ToString()))
			{
				int user = Convert.ToInt32(reader[0].ToString());
				MainWindow mainWindow = new MainWindow(user, conn);
				mainWindow.Show(this);
				this.Hide();
			}
			else
			{
				labelLoginMessage.Text = "Incorrect login or password!";
			}
			reader.Close();
			conn.Close();
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			string hash = PWDHasher.Hash(textBoxRegisterPWD.Text);
			string command = $@"
			IF NOT EXISTS (SELECT user_id FROM Users WHERE login = @login) 
			BEGIN 
				INSERT INTO Users (login, password) 
				VALUES (@login, @password) 
			END";
			conn.Open();
			SqlCommand cmd = new SqlCommand(command, conn);
			cmd.Parameters.AddWithValue("@login", textBoxRegisterLogin.Text);
			cmd.Parameters.AddWithValue("@password", hash);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		private void textBoxRegisterLogin_TextChanged(object sender, EventArgs e)
		{
			if (!ValidateLogin(textBoxRegisterLogin.Text)) textBoxRegisterLogin.BackColor = Color.Pink;
			else
			{
				if (!CheckLoginExistence())
				{
					textBoxRegisterLogin.BackColor = Color.LightGreen;
				}
			}
			ValidateRegData();
		}

		private void textBoxRegisterPWD_TextChanged(object sender, EventArgs e)
		{
			if (!ValidatePass(textBoxRegisterPWD.Text)) textBoxRegisterPWD.BackColor = Color.Pink;
			else textBoxRegisterPWD.BackColor = Color.LightGreen;
			ValidateRegData();
		}

		private void textBoxRegisterPWDConfirm_TextChanged(object sender, EventArgs e)
		{
			if (!CheckMatchPass()) textBoxRegisterPWDConfirm.BackColor = Color.Pink;
			else textBoxRegisterPWDConfirm.BackColor = Color.LightGreen;
			ValidateRegData();
		}

		private void ValidateRegData()
		{
			if(ValidateLogin(textBoxRegisterLogin.Text) && ValidatePass(textBoxRegisterPWD.Text) && CheckMatchPass())
				buttonRegister.Enabled = true;
			else buttonRegister.Enabled = false;
		}

		private string GetHash(string pwd)
		{
			string hash = PWDHasher.Hash(pwd);
			return hash;
		}
	}
}
