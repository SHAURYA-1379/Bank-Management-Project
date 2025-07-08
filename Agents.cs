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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER.000\Documents\BankDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAgents()
        {
            Con.Open();
            string Query = "select * from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            agent_DGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            agtName.Text = "";
            agtPass.Text = "";
            agtAddr.Text = "";
            agtPhone.Text = "";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (agtName.Text == "" || agtPass.Text == "" || agtPhone.Text == "" ||  agtAddr.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTbl(A_Name,A_Pass,A_Phone,A_Address)values(@AN,@APA,@APh,@AA)", Con);
                    cmd.Parameters.AddWithValue("@AN", agtName.Text);
                    cmd.Parameters.AddWithValue("@APA", agtPass.Text);
                    cmd.Parameters.AddWithValue("@APh", agtPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", agtAddr.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Added !!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Account");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where A_Id=@AccKey", Con);
                    cmd.Parameters.AddWithValue("@AccKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Deleted !!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;

        private void agent_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            agtName.Text = agent_DGV.SelectedRows[0].Cells[1].Value.ToString();
            agtPass.Text = agent_DGV.SelectedRows[0].Cells[2].Value.ToString();
            agtPhone.Text = agent_DGV.SelectedRows[0].Cells[3].Value.ToString();
            agtAddr.Text = agent_DGV.SelectedRows[0].Cells[4].Value.ToString();
            
            if (agtName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(agent_DGV.SelectedRows[0].Cells[0].Value.ToString()); //Display the account when clicked on it 
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (agtName.Text == "" || agtPass.Text == "" || agtPhone.Text == "" || agtAddr.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AgentTbl set A_Name=@AN,A_Pass=@APA,A_Phone=@APh,A_Address=@AA where A_Id=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AN", agtName.Text);
                    cmd.Parameters.AddWithValue("@APA", agtPass.Text);
                    cmd.Parameters.AddWithValue("@APh", agtPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", agtAddr.Text);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Updated !!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
         Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
   
}
