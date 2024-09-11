namespace Login_and_Register_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.chatStudent = new System.Windows.Forms.Button();
            this.trafficTests = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.calendarStudent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.studentsCD = new System.Windows.Forms.Button();
            this.calendarTeacher = new System.Windows.Forms.Button();
            this.chatTeacher = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.checkboxShowPass = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.usersList = new System.Windows.Forms.ComboBox();
            this.panelButtons.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegistration.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelButtons.Controls.Add(this.panelUser);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(186, 577);
            this.panelButtons.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelUser.Controls.Add(this.panelTeacher);
            this.panelUser.Controls.Add(this.flowLayoutPanel1);
            this.panelUser.Controls.Add(this.labelRole);
            this.panelUser.Controls.Add(this.labelName);
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(186, 144);
            this.panelUser.TabIndex = 2;
            // 
            // panelTeacher
            // 
            this.panelTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelTeacher.Controls.Add(this.panelStudent);
            this.panelTeacher.Controls.Add(this.studentsCD);
            this.panelTeacher.Controls.Add(this.calendarTeacher);
            this.panelTeacher.Controls.Add(this.chatTeacher);
            this.panelTeacher.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTeacher.Location = new System.Drawing.Point(0, 0);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(186, 144);
            this.panelTeacher.TabIndex = 6;
            this.panelTeacher.Visible = false;
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelStudent.Controls.Add(this.chatStudent);
            this.panelStudent.Controls.Add(this.trafficTests);
            this.panelStudent.Controls.Add(this.button3);
            this.panelStudent.Controls.Add(this.calendarStudent);
            this.panelStudent.Controls.Add(this.button5);
            this.panelStudent.Controls.Add(this.button6);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudent.Location = new System.Drawing.Point(0, 0);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(186, 144);
            this.panelStudent.TabIndex = 6;
            this.panelStudent.Visible = false;
            // 
            // chatStudent
            // 
            this.chatStudent.FlatAppearance.BorderSize = 0;
            this.chatStudent.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatStudent.ForeColor = System.Drawing.Color.Black;
            this.chatStudent.Location = new System.Drawing.Point(0, 262);
            this.chatStudent.Name = "chatStudent";
            this.chatStudent.Size = new System.Drawing.Size(186, 52);
            this.chatStudent.TabIndex = 5;
            this.chatStudent.Text = "Chat";
            this.chatStudent.UseVisualStyleBackColor = true;
            // 
            // trafficTests
            // 
            this.trafficTests.FlatAppearance.BorderSize = 0;
            this.trafficTests.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trafficTests.ForeColor = System.Drawing.Color.Black;
            this.trafficTests.Location = new System.Drawing.Point(0, 146);
            this.trafficTests.Name = "trafficTests";
            this.trafficTests.Size = new System.Drawing.Size(186, 52);
            this.trafficTests.TabIndex = 4;
            this.trafficTests.Text = "Traffic Tests";
            this.trafficTests.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Chat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // calendarStudent
            // 
            this.calendarStudent.FlatAppearance.BorderSize = 0;
            this.calendarStudent.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarStudent.ForeColor = System.Drawing.Color.Black;
            this.calendarStudent.Location = new System.Drawing.Point(0, 204);
            this.calendarStudent.Name = "calendarStudent";
            this.calendarStudent.Size = new System.Drawing.Size(186, 52);
            this.calendarStudent.TabIndex = 3;
            this.calendarStudent.Text = "Calendar";
            this.calendarStudent.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "Calendar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(0, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 52);
            this.button6.TabIndex = 3;
            this.button6.Text = "Students";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // studentsCD
            // 
            this.studentsCD.FlatAppearance.BorderSize = 0;
            this.studentsCD.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsCD.ForeColor = System.Drawing.Color.Black;
            this.studentsCD.Location = new System.Drawing.Point(0, 146);
            this.studentsCD.Name = "studentsCD";
            this.studentsCD.Size = new System.Drawing.Size(186, 52);
            this.studentsCD.TabIndex = 3;
            this.studentsCD.Text = "Students";
            this.studentsCD.UseVisualStyleBackColor = true;
            this.studentsCD.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendarTeacher
            // 
            this.calendarTeacher.FlatAppearance.BorderSize = 0;
            this.calendarTeacher.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarTeacher.ForeColor = System.Drawing.Color.Black;
            this.calendarTeacher.Location = new System.Drawing.Point(0, 204);
            this.calendarTeacher.Name = "calendarTeacher";
            this.calendarTeacher.Size = new System.Drawing.Size(186, 52);
            this.calendarTeacher.TabIndex = 4;
            this.calendarTeacher.Text = "Calendar";
            this.calendarTeacher.UseVisualStyleBackColor = true;
            // 
            // chatTeacher
            // 
            this.chatTeacher.FlatAppearance.BorderSize = 0;
            this.chatTeacher.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatTeacher.ForeColor = System.Drawing.Color.Black;
            this.chatTeacher.Location = new System.Drawing.Point(0, 259);
            this.chatTeacher.Name = "chatTeacher";
            this.chatTeacher.Size = new System.Drawing.Size(186, 52);
            this.chatTeacher.TabIndex = 5;
            this.chatTeacher.Text = "Chat";
            this.chatTeacher.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(189, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(763, 577);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // labelRole
            // 
            this.labelRole.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(3, 111);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(180, 23);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "label2";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(180, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(12, 269);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(218, 28);
            this.txtPhone.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 47);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 28);
            this.txtEmail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(12, 390);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(218, 28);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Black;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.Location = new System.Drawing.Point(12, 343);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(218, 28);
            this.registrationButton.TabIndex = 19;
            this.registrationButton.Text = "REGISTER";
            this.registrationButton.UseVisualStyleBackColor = false;
            // 
            // checkboxShowPass
            // 
            this.checkboxShowPass.AutoSize = true;
            this.checkboxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxShowPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkboxShowPass.Location = new System.Drawing.Point(111, 307);
            this.checkboxShowPass.Name = "checkboxShowPass";
            this.checkboxShowPass.Size = new System.Drawing.Size(119, 21);
            this.checkboxShowPass.TabIndex = 16;
            this.checkboxShowPass.Text = "Show Password";
            this.checkboxShowPass.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(111, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 196);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(218, 28);
            this.txtPassword.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 196);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 28);
            this.textBox2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(12, 120);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 28);
            this.txtUsername.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username";
            // 
            // panelRegistration
            // 
            this.panelRegistration.Controls.Add(this.txtUsername);
            this.panelRegistration.Controls.Add(this.txtPhone);
            this.panelRegistration.Controls.Add(this.label5);
            this.panelRegistration.Controls.Add(this.txtEmail);
            this.panelRegistration.Controls.Add(this.label3);
            this.panelRegistration.Controls.Add(this.label7);
            this.panelRegistration.Controls.Add(this.label4);
            this.panelRegistration.Controls.Add(this.clearButton);
            this.panelRegistration.Controls.Add(this.textBox2);
            this.panelRegistration.Controls.Add(this.registrationButton);
            this.panelRegistration.Controls.Add(this.txtPassword);
            this.panelRegistration.Controls.Add(this.checkboxShowPass);
            this.panelRegistration.Controls.Add(this.checkBox1);
            this.panelRegistration.Location = new System.Drawing.Point(117, 43);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(242, 475);
            this.panelRegistration.TabIndex = 21;
            this.panelRegistration.Visible = false;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.panelDelete);
            this.panelDashboard.Controls.Add(this.panelRegistration);
            this.panelDashboard.Location = new System.Drawing.Point(189, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(763, 577);
            this.panelDashboard.TabIndex = 22;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.button1);
            this.panelDelete.Controls.Add(this.usersList);
            this.panelDelete.Location = new System.Drawing.Point(399, 43);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(338, 148);
            this.panelDelete.TabIndex = 23;
            this.panelDelete.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(41, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // usersList
            // 
            this.usersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersList.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersList.FormattingEnabled = true;
            this.usersList.Location = new System.Drawing.Point(41, 41);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(265, 29);
            this.usersList.TabIndex = 22;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelTeacher.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button studentsCD;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.CheckBox checkboxShowPass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRegistration;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button calendarTeacher;
        private System.Windows.Forms.Button chatTeacher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button chatStudent;
        private System.Windows.Forms.Button trafficTests;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button calendarStudent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox usersList;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button button1;
    }
}