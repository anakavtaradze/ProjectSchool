namespace School
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_usernameRegistration = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_logIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_reenter = new System.Windows.Forms.Label();
            this.label_password2 = new System.Windows.Forms.Label();
            this.textBox_passwordRegistration = new System.Windows.Forms.TextBox();
            this.textBox_reenterPasswordRegistration = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label1_course = new System.Windows.Forms.Label();
            this.comboBox_statusRegistration = new System.Windows.Forms.ComboBox();
            this.comboBox_courseRegistration = new System.Windows.Forms.ComboBox();
            this.label_invalidUsername = new System.Windows.Forms.Label();
            this.label_passwordsDoNotMatch = new System.Windows.Forms.Label();
            this.label_someFieldsAreEmpty = new System.Windows.Forms.Label();
            this.label_registeredSuccessfully = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBox_usernameRegistration
            // 
            this.textBox_usernameRegistration.Location = new System.Drawing.Point(662, 197);
            this.textBox_usernameRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_usernameRegistration.Name = "textBox_usernameRegistration";
            this.textBox_usernameRegistration.Size = new System.Drawing.Size(128, 28);
            this.textBox_usernameRegistration.TabIndex = 3;
            this.textBox_usernameRegistration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 198);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 28);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 273);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(128, 28);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button_logIn
            // 
            this.button_logIn.BackColor = System.Drawing.Color.Coral;
            this.button_logIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_logIn.Location = new System.Drawing.Point(272, 376);
            this.button_logIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_logIn.Name = "button_logIn";
            this.button_logIn.Size = new System.Drawing.Size(97, 35);
            this.button_logIn.TabIndex = 6;
            this.button_logIn.Text = "Log In";
            this.button_logIn.UseVisualStyleBackColor = false;
            this.button_logIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log In";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Location = new System.Drawing.Point(552, 99);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(69, 23);
            this.Register.TabIndex = 8;
            this.Register.Text = "Register";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(552, 201);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(82, 23);
            this.label_username.TabIndex = 9;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(552, 283);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(77, 23);
            this.label_password.TabIndex = 10;
            this.label_password.Text = "Password";
            // 
            // label_reenter
            // 
            this.label_reenter.AutoSize = true;
            this.label_reenter.Location = new System.Drawing.Point(858, 229);
            this.label_reenter.Name = "label_reenter";
            this.label_reenter.Size = new System.Drawing.Size(66, 23);
            this.label_reenter.TabIndex = 11;
            this.label_reenter.Text = "Reenter";
            this.label_reenter.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_password2
            // 
            this.label_password2.AutoSize = true;
            this.label_password2.Location = new System.Drawing.Point(858, 252);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(77, 23);
            this.label_password2.TabIndex = 12;
            this.label_password2.Text = "Password";
            this.label_password2.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox_passwordRegistration
            // 
            this.textBox_passwordRegistration.Location = new System.Drawing.Point(662, 278);
            this.textBox_passwordRegistration.Name = "textBox_passwordRegistration";
            this.textBox_passwordRegistration.PasswordChar = '*';
            this.textBox_passwordRegistration.Size = new System.Drawing.Size(128, 28);
            this.textBox_passwordRegistration.TabIndex = 13;
            this.textBox_passwordRegistration.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox_reenterPasswordRegistration
            // 
            this.textBox_reenterPasswordRegistration.Location = new System.Drawing.Point(868, 278);
            this.textBox_reenterPasswordRegistration.Name = "textBox_reenterPasswordRegistration";
            this.textBox_reenterPasswordRegistration.PasswordChar = '*';
            this.textBox_reenterPasswordRegistration.Size = new System.Drawing.Size(128, 28);
            this.textBox_reenterPasswordRegistration.TabIndex = 14;
            this.textBox_reenterPasswordRegistration.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.Coral;
            this.button_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_register.Location = new System.Drawing.Point(884, 560);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(83, 33);
            this.button_register.TabIndex = 16;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(272, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "You Logged In Successfully";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(272, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Error: the Username does not exist";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(272, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Error: incorrect Password";
            this.label11.Visible = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(552, 453);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(55, 23);
            this.label_status.TabIndex = 20;
            this.label_status.Text = "Status";
            // 
            // label1_course
            // 
            this.label1_course.AutoSize = true;
            this.label1_course.Location = new System.Drawing.Point(858, 427);
            this.label1_course.Name = "label1_course";
            this.label1_course.Size = new System.Drawing.Size(58, 23);
            this.label1_course.TabIndex = 21;
            this.label1_course.Text = "Course";
            // 
            // comboBox_statusRegistration
            // 
            this.comboBox_statusRegistration.FormattingEnabled = true;
            this.comboBox_statusRegistration.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.comboBox_statusRegistration.Location = new System.Drawing.Point(662, 453);
            this.comboBox_statusRegistration.Name = "comboBox_statusRegistration";
            this.comboBox_statusRegistration.Size = new System.Drawing.Size(121, 31);
            this.comboBox_statusRegistration.TabIndex = 22;
            // 
            // comboBox_courseRegistration
            // 
            this.comboBox_courseRegistration.FormattingEnabled = true;
            this.comboBox_courseRegistration.Items.AddRange(new object[] {
            "C#",
            "C++",
            "Java",
            "Web"});
            this.comboBox_courseRegistration.Location = new System.Drawing.Point(868, 453);
            this.comboBox_courseRegistration.Name = "comboBox_courseRegistration";
            this.comboBox_courseRegistration.Size = new System.Drawing.Size(121, 31);
            this.comboBox_courseRegistration.TabIndex = 23;
            // 
            // label_invalidUsername
            // 
            this.label_invalidUsername.AutoSize = true;
            this.label_invalidUsername.ForeColor = System.Drawing.Color.Red;
            this.label_invalidUsername.Location = new System.Drawing.Point(612, 517);
            this.label_invalidUsername.Name = "label_invalidUsername";
            this.label_invalidUsername.Size = new System.Drawing.Size(377, 23);
            this.label_invalidUsername.TabIndex = 24;
            this.label_invalidUsername.Text = "Error: invalid username. Please choose another one.";
            this.label_invalidUsername.Visible = false;
            // 
            // label_passwordsDoNotMatch
            // 
            this.label_passwordsDoNotMatch.AutoSize = true;
            this.label_passwordsDoNotMatch.ForeColor = System.Drawing.Color.Red;
            this.label_passwordsDoNotMatch.Location = new System.Drawing.Point(612, 517);
            this.label_passwordsDoNotMatch.Name = "label_passwordsDoNotMatch";
            this.label_passwordsDoNotMatch.Size = new System.Drawing.Size(384, 23);
            this.label_passwordsDoNotMatch.TabIndex = 25;
            this.label_passwordsDoNotMatch.Text = "Error: the passwords you have entered do not match.";
            this.label_passwordsDoNotMatch.Visible = false;
            // 
            // label_someFieldsAreEmpty
            // 
            this.label_someFieldsAreEmpty.AutoSize = true;
            this.label_someFieldsAreEmpty.ForeColor = System.Drawing.Color.Red;
            this.label_someFieldsAreEmpty.Location = new System.Drawing.Point(647, 517);
            this.label_someFieldsAreEmpty.Name = "label_someFieldsAreEmpty";
            this.label_someFieldsAreEmpty.Size = new System.Drawing.Size(256, 23);
            this.label_someFieldsAreEmpty.TabIndex = 26;
            this.label_someFieldsAreEmpty.Text = "Error: some fields were left empty";
            this.label_someFieldsAreEmpty.Visible = false;
            // 
            // label_registeredSuccessfully
            // 
            this.label_registeredSuccessfully.AutoSize = true;
            this.label_registeredSuccessfully.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label_registeredSuccessfully.Location = new System.Drawing.Point(612, 517);
            this.label_registeredSuccessfully.Name = "label_registeredSuccessfully";
            this.label_registeredSuccessfully.Size = new System.Drawing.Size(208, 23);
            this.label_registeredSuccessfully.TabIndex = 27;
            this.label_registeredSuccessfully.Text = "You registered successfully!";
            this.label_registeredSuccessfully.Visible = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(552, 367);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 23);
            this.label_name.TabIndex = 28;
            this.label_name.Text = "Name";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(858, 338);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(74, 23);
            this.label_surname.TabIndex = 29;
            this.label_surname.Text = "Surname";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(662, 367);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(128, 28);
            this.textBox_name.TabIndex = 30;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(868, 364);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(128, 28);
            this.textBox_surname.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1028, 690);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_registeredSuccessfully);
            this.Controls.Add(this.label_someFieldsAreEmpty);
            this.Controls.Add(this.label_passwordsDoNotMatch);
            this.Controls.Add(this.label_invalidUsername);
            this.Controls.Add(this.comboBox_courseRegistration);
            this.Controls.Add(this.comboBox_statusRegistration);
            this.Controls.Add(this.label1_course);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_reenterPasswordRegistration);
            this.Controls.Add(this.textBox_passwordRegistration);
            this.Controls.Add(this.label_password2);
            this.Controls.Add(this.label_reenter);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_logIn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_usernameRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_usernameRegistration;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_logIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_reenter;
        private System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.TextBox textBox_passwordRegistration;
        private System.Windows.Forms.TextBox textBox_reenterPasswordRegistration;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label1_course;
        private System.Windows.Forms.ComboBox comboBox_statusRegistration;
        private System.Windows.Forms.ComboBox comboBox_courseRegistration;
        private System.Windows.Forms.Label label_invalidUsername;
        private System.Windows.Forms.Label label_passwordsDoNotMatch;
        private System.Windows.Forms.Label label_someFieldsAreEmpty;
        private System.Windows.Forms.Label label_registeredSuccessfully;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
    }
}

