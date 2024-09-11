using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login_and_Register_System
{
    public partial class Dashboard : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
        NpgsqlCommand cmd = new NpgsqlCommand();
        public Dashboard(string name, string role)
        {
            InitializeComponent();

            labelName.Text = name;
            labelRole.Text = role;

            if (labelName.Text == "teacher") panelTeacher.Visible = true;
            else panelStudent.Visible = true;
            trafficTests.Select();

            panelButtons.Controls.Add(panelUser);
            panelButtons.Controls.Add(panelTeacher);
            panelButtons.Controls.Add(panelStudent);
            panelDashboard.Controls.Add(panelRegistration);
            panelDashboard.Controls.Add(panelDelete);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRegistration.Visible = true;
            panelDelete.Visible = true;

            updateList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = usersList.Text;
            string deleteUser = $"DELETE FROM users WHERE user_name = '{user}'";

            try
            {
                conn.Open();
                cmd = new NpgsqlCommand(deleteUser, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"The {user} has been Successfully Deleted", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
            }
            updateList();
        }

        private void updateList()
        {
            usersList.Items.Clear();

            string getUsers = $"SELECT user_name FROM users WHERE user_role = 'student'";

            conn.Open();
            cmd = new NpgsqlCommand(getUsers, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usersList.Items.Add(dr.GetString(0));
            }
            if (dr.HasRows) usersList.SelectedIndex = 0;

            conn.Close();
        }
    }
}
