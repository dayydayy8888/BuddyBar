using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dayyana\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");

		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (guna2CheckBox1.Checked)
			{
				password.UseSystemPasswordChar = false;
			}
			else
			{
				password.UseSystemPasswordChar = true;
			}

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if (u_name.Text != "" && password.Text != "")
			{
				string query = "SELECT count(*) FROM WinFormsApp1 WHERE email = '" + u_name.Text +
					"' AND password = '" + password.Text + "'";
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				int v = (int)command.ExecuteScalar();
				if (v !=1)
				{
					MessageBox.Show("Error Username or Password" , "Error!");
				}
				else
				{
					MessageBox.Show("Welcome to Your Profile");
					u_name.Text = "";
					password.Text = "";
				}

			}
			else
			{
				MessageBox.Show("Please Enter Username and Password");
			}
		}
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}
	}
}