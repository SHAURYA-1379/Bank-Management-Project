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
namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER.000\Documents\BankDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUser.Text = " "; 
            txtPass.Text = " ";
            cmbRole.SelectedIndex = -1;
            cmbRole.Text = "Role";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Role");
            }
            else if(cmbRole.SelectedIndex == 1)
            {
                if (txtUser.Text == " " || txtPass.Text == " ")
                {
                    MessageBox.Show("Enter The Details Before Trying to Login ");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTbl where Ad_Name='" +txtUser.Text+ "'and Ad_Pass='" +txtPass.Text+ "'",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Agents Obj = new Agents();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or Password");
                        txtUser.Text = "";
                        txtPass.Text = "";
                    }
                    Con.Close();
                }
            }
            else
            {
                if (txtUser.Text == " " || txtPass.Text == " ")
                {
                    MessageBox.Show("Enter Both Username and Paassword ");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTbl where A_Name='" +txtUser.Text+ "'and A_Pass='" +txtPass.Text+ "'",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainMenu Obj = new MainMenu();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name or Password");
                        txtUser.Text = "";
                        txtPass.Text = "";
                    }
                    Con.Close();
                }
            }

        }
    }
}
