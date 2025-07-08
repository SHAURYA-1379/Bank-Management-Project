using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblReset_1_Click(object sender, EventArgs e)
        {
            txtNewPass.Text = "";
            cmbTheme.SelectedIndex = -1;
        }

        private void btnAppTheme_Click(object sender, EventArgs e)
        {
            if(cmbTheme.SelectedIndex == -1) 
            {
                MessageBox.Show("Select a Theme");
            }else if(cmbTheme.SelectedIndex == 0) 
            {
                panel1.BackColor = Color.Gold;
            }
            else if (cmbTheme.SelectedIndex == 1)
            {
                panel1.BackColor = Color.Crimson;
            }else 
            {
                panel1.BackColor = Color.Green;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER.000\Documents\BankDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnAppPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("Enter New Password");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AdminTbl set Ad_Pass=@AP where Ad_id=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AP", txtNewPass.Text);       
                    cmd.Parameters.AddWithValue("@AKey", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Updated !!");
                    Con.Close();
                    txtNewPass.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
