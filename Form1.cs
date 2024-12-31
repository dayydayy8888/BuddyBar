using System;
using System.Data.SqlClient;
using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WinFormsApp1


{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dayyana\Documents\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (first_name.Text != "" && l_name.Text != "" && date.Text != "" && gender.Text != ""
					&& email.Text != "" && address.Text != "" && password.Text != "" && con_password.Text != "")
				{
					if (password.Text == con_password.Text)
					{
						int v = check(email.Text);
						if (v != 1)
						{
							connection.Open();
							SqlCommand command = new SqlCommand("INSERT INTO RegistrationTbl values (@f_name,@last_name, " +
																"@b_date,@gender,@email,@address,@password)", connection);
							command.Parameters.AddWithValue("@f_name", first_name.Text);
							command.Parameters.AddWithValue("@last_name", l_name.Text);
							command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(date.Text));
							command.Parameters.AddWithValue("@gender", gender.Text);
							command.Parameters.AddWithValue("@email", email.Text);
							command.Parameters.AddWithValue("@address", address.Text);
							command.Parameters.AddWithValue("@password", password.Text);
							command.ExecuteNonQuery();
							connection.Close();
							MessageBox.Show("Registration Successful");
							first_name.Text = "";
							l_name.Text = "";
							gender.Text = "";
							email.Text = "";
							password.Text = "";
							con_password.Text = "";
						}
						else
						{
							MessageBox.Show("You are already registered!");
						}
					}
					else
					{
						MessageBox.Show("Password does not match!");
					}
				}
				else
				{
					MessageBox.Show("Please fill in all the fields!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			int check(string email)
			{
				connection.Open();
				string query = "SELECT count(*) FROM RegistrationTbl WHERE Email = '" + email + "'";
				SqlCommand command = new SqlCommand(query, connection);
				int v = (int)command.ExecuteScalar();
				connection.Close();
				return v;

			}
		}
		private void guna2Button1_CheckedChanged(object sender, EventArgs e)
		{
			if (guna2Button1.Checked)
			{
				password.UseSystemPasswordChar = false;
				con_password.UseSystemPasswordChar = false;
			}
			else
			{
				password.UseSystemPasswordChar = true;
				con_password.UseSystemPasswordChar = true;
			}
		}
	
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.Show();
		}

	}
}
