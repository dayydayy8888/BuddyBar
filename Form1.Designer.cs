namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			linkLabel1 = new LinkLabel();
			guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			check_pass = new CheckBox();
			con_password = new TextBox();
			password = new TextBox();
			label9 = new Label();
			label8 = new Label();
			email = new TextBox();
			label7 = new Label();
			address = new TextBox();
			label6 = new Label();
			gender = new ComboBox();
			label5 = new Label();
			date = new DateTimePicker();
			label4 = new Label();
			l_name = new TextBox();
			label3 = new Label();
			first_name = new TextBox();
			label2 = new Label();
			label1 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightCoral;
			panel1.Controls.Add(linkLabel1);
			panel1.Controls.Add(guna2Button1);
			panel1.Controls.Add(check_pass);
			panel1.Controls.Add(con_password);
			panel1.Controls.Add(password);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(email);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(address);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(gender);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(date);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(l_name);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(first_name);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(111, 37);
			panel1.Name = "panel1";
			panel1.Size = new Size(557, 369);
			panel1.TabIndex = 0;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			linkLabel1.LinkColor = Color.Red;
			linkLabel1.Location = new Point(123, 332);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(73, 23);
			linkLabel1.TabIndex = 19;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Sign In";
			// 
			// guna2Button1
			// 
			guna2Button1.CustomizableEdges = customizableEdges1;
			guna2Button1.DisabledState.BorderColor = Color.DarkGray;
			guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
			guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			guna2Button1.FillColor = Color.FromArgb(255, 192, 192);
			guna2Button1.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			guna2Button1.ForeColor = Color.Firebrick;
			guna2Button1.Location = new Point(202, 324);
			guna2Button1.Name = "guna2Button1";
			guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
			guna2Button1.Size = new Size(145, 31);
			guna2Button1.TabIndex = 18;
			guna2Button1.Text = "Sign Up";
			guna2Button1.Click += guna2Button1_Click;
			// 
			// check_pass
			// 
			check_pass.AutoSize = true;
			check_pass.Location = new Point(407, 315);
			check_pass.Name = "check_pass";
			check_pass.Size = new Size(104, 19);
			check_pass.TabIndex = 17;
			check_pass.Text = "Remember me";
			check_pass.UseVisualStyleBackColor = true;
			// 
			// con_password
			// 
			con_password.Location = new Point(328, 282);
			con_password.Name = "con_password";
			con_password.Size = new Size(138, 23);
			con_password.TabIndex = 16;
			con_password.UseSystemPasswordChar = true;
			// 
			// password
			// 
			password.Location = new Point(328, 228);
			password.Name = "password";
			password.Size = new Size(138, 23);
			password.TabIndex = 15;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.Red;
			label9.Location = new Point(328, 254);
			label9.Name = "label9";
			label9.Size = new Size(190, 25);
			label9.TabIndex = 14;
			label9.Text = "Confirm Password";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.Red;
			label8.Location = new Point(328, 200);
			label8.Name = "label8";
			label8.Size = new Size(103, 25);
			label8.TabIndex = 13;
			label8.Text = "Password";
			// 
			// email
			// 
			email.Location = new Point(328, 174);
			email.Name = "email";
			email.Size = new Size(138, 23);
			email.TabIndex = 12;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.Red;
			label7.Location = new Point(328, 146);
			label7.Name = "label7";
			label7.Size = new Size(74, 25);
			label7.TabIndex = 11;
			label7.Text = "Email";
			// 
			// address
			// 
			address.Location = new Point(328, 120);
			address.Name = "address";
			address.Size = new Size(138, 23);
			address.TabIndex = 10;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Red;
			label6.Location = new Point(328, 92);
			label6.Name = "label6";
			label6.Size = new Size(88, 25);
			label6.TabIndex = 9;
			label6.Text = "Address";
			// 
			// gender
			// 
			gender.FormattingEnabled = true;
			gender.Items.AddRange(new object[] { "Female", "Male", "Prefer not to disclose" });
			gender.Location = new Point(70, 282);
			gender.Name = "gender";
			gender.Size = new Size(121, 23);
			gender.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Red;
			label5.Location = new Point(69, 254);
			label5.Name = "label5";
			label5.Size = new Size(82, 25);
			label5.TabIndex = 7;
			label5.Text = "Gender";
			// 
			// date
			// 
			date.Location = new Point(69, 228);
			date.Name = "date";
			date.Size = new Size(200, 23);
			date.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Red;
			label4.Location = new Point(69, 200);
			label4.Name = "label4";
			label4.Size = new Size(76, 25);
			label4.TabIndex = 5;
			label4.Text = "D.O.B.";
			label4.Click += label4_Click;
			// 
			// l_name
			// 
			l_name.Location = new Point(69, 174);
			l_name.Name = "l_name";
			l_name.Size = new Size(138, 23);
			l_name.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Red;
			label3.Location = new Point(69, 146);
			label3.Name = "label3";
			label3.Size = new Size(117, 25);
			label3.TabIndex = 3;
			label3.Text = "Last Name\r\n";
			// 
			// first_name
			// 
			first_name.Location = new Point(69, 120);
			first_name.Name = "first_name";
			first_name.Size = new Size(138, 23);
			first_name.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(69, 92);
			label2.Name = "label2";
			label2.Size = new Size(122, 25);
			label2.TabIndex = 1;
			label2.Text = "First Name\r\n";
			label2.Click += label2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.LightCoral;
			label1.Font = new Font("Modern No. 20", 23.9999962F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(202, 41);
			label1.Name = "label1";
			label1.Size = new Size(121, 34);
			label1.TabIndex = 0;
			label1.Text = "Sign Up";
			label1.Click += label1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(775, 450);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private TextBox l_name;
		private Label label3;
		private TextBox first_name;
		private Label label4;
		private DateTimePicker date;
		private CheckBox check_pass;
		private TextBox con_password;
		private TextBox password;
		private Label label9;
		private Label label8;
		private TextBox email;
		private Label label7;
		private TextBox address;
		private Label label6;
		private ComboBox gender;
		private Label label5;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private LinkLabel linkLabel1;
	}
}
