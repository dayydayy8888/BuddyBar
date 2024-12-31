namespace WinFormsApp1
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			panel1 = new Panel();
			linkLabel1 = new LinkLabel();
			guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
			password = new TextBox();
			label3 = new Label();
			u_name = new TextBox();
			label2 = new Label();
			label1 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(255, 192, 192);
			panel1.Controls.Add(linkLabel1);
			panel1.Controls.Add(guna2Button1);
			panel1.Controls.Add(guna2CheckBox1);
			panel1.Controls.Add(password);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(u_name);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			panel1.Location = new Point(157, 46);
			panel1.Name = "panel1";
			panel1.Size = new Size(482, 346);
			panel1.TabIndex = 0;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			linkLabel1.LinkColor = Color.Red;
			linkLabel1.Location = new Point(121, 287);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(74, 20);
			linkLabel1.TabIndex = 21;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Sign Up";
			// 
			// guna2Button1
			// 
			guna2Button1.CustomBorderColor = Color.White;
			guna2Button1.CustomizableEdges = customizableEdges1;
			guna2Button1.DisabledState.BorderColor = Color.DarkGray;
			guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
			guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			guna2Button1.FillColor = Color.FromArgb(255, 192, 192);
			guna2Button1.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			guna2Button1.ForeColor = Color.Firebrick;
			guna2Button1.Location = new Point(200, 279);
			guna2Button1.Name = "guna2Button1";
			guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
			guna2Button1.Size = new Size(145, 31);
			guna2Button1.TabIndex = 20;
			guna2Button1.Text = "Sign In";
			// 
			// guna2CheckBox1
			// 
			guna2CheckBox1.AutoSize = true;
			guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			guna2CheckBox1.CheckedState.BorderRadius = 0;
			guna2CheckBox1.CheckedState.BorderThickness = 0;
			guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			guna2CheckBox1.Location = new Point(159, 233);
			guna2CheckBox1.Name = "guna2CheckBox1";
			guna2CheckBox1.Size = new Size(142, 29);
			guna2CheckBox1.TabIndex = 5;
			guna2CheckBox1.Text = "Remember me";
			guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			guna2CheckBox1.UncheckedState.BorderRadius = 0;
			guna2CheckBox1.UncheckedState.BorderThickness = 0;
			guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			// 
			// password
			// 
			password.Location = new Point(128, 196);
			password.Name = "password";
			password.Size = new Size(217, 31);
			password.TabIndex = 4;
			password.UseSystemPasswordChar = true;
			password.TextChanged += guna2CheckBox1_CheckedChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(184, 168);
			label3.Name = "label3";
			label3.Size = new Size(92, 25);
			label3.TabIndex = 3;
			label3.Text = "Password";
			// 
			// u_name
			// 
			u_name.Location = new Point(128, 123);
			u_name.Name = "u_name";
			u_name.Size = new Size(217, 31);
			u_name.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(184, 95);
			label2.Name = "label2";
			label2.Size = new Size(95, 25);
			label2.TabIndex = 1;
			label2.Text = "Username";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Monotype Corsiva", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(175, 31);
			label1.Name = "label1";
			label1.Size = new Size(117, 45);
			label1.TabIndex = 0;
			label1.Text = "Sign In";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Name = "Login";
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
		private TextBox password;
		private Label label3;
		private TextBox u_name;
		private Label label2;
		private LinkLabel linkLabel1;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}