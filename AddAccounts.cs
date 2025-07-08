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
    public partial class AddAccounts : Form
    {
        public AddAccounts()
        {
            InitializeComponent();
            DisplayAccounts();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER.000\Documents\BankDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAccounts()
        {
            Con.Open();
            string Query = "select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            acc_DGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            cmbGender.SelectedIndex = -1;
            txtOccu.Text = "";
            txtIncome.Text = "";
            cmbEdu.SelectedIndex = -1;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || cmbGender.SelectedIndex == -1 || txtOccu.Text == "" || cmbEdu.SelectedIndex == -1 || txtIncome.Text == "") 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(AccName,AccPhone,AccAddress,AccGender,AccOccup,AccEdu,AccIncome, AccBal)values(@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)", Con);
                    cmd.Parameters.AddWithValue("@AN", txtName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@AG", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", txtOccu.Text);
                    cmd.Parameters.AddWithValue("@AE", cmbEdu.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", txtIncome.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created !!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where AccNumber=@AccKey", Con);
                    cmd.Parameters.AddWithValue("@AccKey", Key);  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted !!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void acc_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = acc_DGV.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = acc_DGV.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = acc_DGV.SelectedRows[0].Cells[3].Value.ToString();
            cmbGender.SelectedItem = acc_DGV.SelectedRows[0].Cells[4].Value.ToString();
            txtOccu.Text = acc_DGV.SelectedRows[0].Cells[5].Value.ToString();
            cmbEdu.SelectedItem = acc_DGV.SelectedRows[0].Cells[6].Value.ToString();
            txtIncome.Text = acc_DGV.SelectedRows[0].Cells[7].Value.ToString();
            if (txtName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(acc_DGV.SelectedRows[0].Cells[0].Value.ToString()); //Display the account when clicked on it 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || cmbGender.SelectedIndex == -1 || txtOccu.Text == "" || cmbEdu.SelectedIndex == -1 || txtIncome.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AccName=@AN,AccPhone=@AP,AccAddress=@AA,AccGender=@AG,AccOccup=@AO,AccEdu=@AE,AccIncome=@AI where AccNumber=@AccKey", Con);
                    cmd.Parameters.AddWithValue("@AN", txtName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@AG", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", txtOccu.Text);
                    cmd.Parameters.AddWithValue("@AE", cmbEdu.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", txtIncome.Text);
                    cmd.Parameters.AddWithValue("@AccKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated !!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
