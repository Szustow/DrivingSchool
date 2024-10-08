﻿using System;
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
using Microsoft.Win32;
namespace Login_and_Register_System
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
        NpgsqlCommand cmd = new NpgsqlCommand();
        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();   
            txtUsername.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;

            if (email == "" || username == "" || password == "" || phone == "")
            {
                MessageBox.Show("Please fill in all fields", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string query = $"SELECT * FROM users WHERE user_name = '{username}'";
                cmd = new NpgsqlCommand(query, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    conn.Close();
                    MessageBox.Show($"A user with that username '{username}' already exists", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else conn.Close();

                try
                {
                    conn.Open();
                    string register = $"INSERT INTO users (user_name,password,user_role,phone,email) VALUES ('{username}','{password}','student','{phone}','{email}')";
                    cmd = new NpgsqlCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    txtEmail.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtPhone.Clear();

                    MessageBox.Show("Your account has been Successfully Created", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void label6_Click_1(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}