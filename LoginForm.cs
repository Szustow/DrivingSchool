using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;

namespace Login_and_Register_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
        NpgsqlCommand cmd = new NpgsqlCommand();
        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        private void label6_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string login = ("SELECT * FROM users WHERE user_name =  '" + txtUsername.Text +"' and password = '"+txtPassword.Text+"' ");
            cmd = new NpgsqlCommand(login, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
           

            if (dr.Read() == true)
            {
                conn.Close();
                MessageBox.Show("Successful login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Dashboard().Show();
                Dashboard.instance.lbl.Text = txtUsername.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, please try Again.","Login Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
