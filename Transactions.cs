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
using System.Xml.Linq;

namespace Project
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER.000\Documents\BankDB.mdf;Integrated Security=True;Connect Timeout=30");
        int Balance;
        private void CheckBalance()
        {
          Con.Open();
            string Query = "Select * from AccountTbl where AccNumber="+txtBalance.Text+"";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                lblBalance.Text = "Rs."+dr["AccBal"].ToString();
                Balance = Convert.ToInt32(dr["AccBal"].ToString());
            }
          Con.Close();
        }
        private void CheckAvailableBal()
        {
            //Con.Open();
            string Query = "Select * from AccountTbl where AccNumber="+txtTransFrom.Text+"";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblBalance1.Text = "Rs." + dr["AccBal"].ToString();
                Balance = Convert.ToInt32(dr["AccBal"].ToString());
            }
            Con.Close();
        }
        private void GetNewBalance()
        {
            Con.Open();
            string Query = "Select * from AccountTbl where AccNumber="+txtBalance.Text+"";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //lblBalance.Text = "Rs." + dr["AccBal"].ToString();
                Balance = Convert.ToInt32(dr["AccBal"].ToString());
            }
            Con.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtBalance.Text == "")
            {
                MessageBox.Show("Enter Account Number");
            }else
            {
                CheckBalance();
                if(lblBalance.Text == "YourBalance")
                {
                    MessageBox.Show("Account Not Found");
                    txtBalance.Text = "";
                }
            }
        }
        private void Deposit()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmt,TAccNumber)values(@TN,@TD,@TA,@TAc)", Con);
                cmd.Parameters.AddWithValue("@TN", "DEPOSIT");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", amtDeposit.Text);
                cmd.Parameters.AddWithValue("@TAc", amtDeposit.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }
        private void AddBal()
        {
            GetNewBalance();
            int newBal = Balance + Convert.ToInt32(txtTransAmt.Text);
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AccBal=@AB where AccNumber=@AccKey", Con);
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@AccKey", txtTransTo.Text);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Money Deposit !!");
                Con.Close();
                //amtDeposit.Text = "";
                //accDeposit.Text = "";
                //lblBalance.Text = "YourBalancece";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void SubtractBal()
        {
            GetNewBalance();
            int newBal = Balance - Convert.ToInt32(txtTransAmt.Text);
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AccBal=@AB where AccNumber=@AccKey", Con);
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@AccKey", txtTransFrom.Text);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Money Deposit !!");
                Con.Close();
                //amtDeposit.Text = "";
                //accDeposit.Text = "";
                //lblBalance.Text = "YourBalancece";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (accDeposit.Text == "" || amtDeposit.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Deposit();
                GetNewBalance();
                int newBal = Balance + Convert.ToInt32(amtDeposit.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AccBal=@AB where AccNumber=@AccKey", Con);
                    cmd.Parameters.AddWithValue("@AB", newBal);
                    cmd.Parameters.AddWithValue("@AccKey", accDeposit.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Deposit !!");
                    Con.Close();
                    amtDeposit.Text = "";
                    accDeposit.Text = "";
                    lblBalance.Text = "YourBalancece";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Withdraw()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmt,TAccNumber)values(@TN,@TD,@TA,@TAc)", Con);
                cmd.Parameters.AddWithValue("@TN", "Withdraw");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", amtDeposit.Text);
                cmd.Parameters.AddWithValue("@TAc", amtDeposit.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (accWithdraw.Text == "" || amtWithdraw.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                GetNewBalance();
                Withdraw();
                if (Balance < Convert.ToInt32(amtWithdraw.Text))
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    int newBal = Balance - Convert.ToInt32(amtWithdraw.Text);
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update AccountTbl set AccBal=@AB where AccNumber=@AccKey", Con);
                        cmd.Parameters.AddWithValue("@AB", newBal);
                        cmd.Parameters.AddWithValue("@AccKey", accWithdraw.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money Withdrawn !!");
                        Con.Close();
                        amtWithdraw.Text = "";
                        accWithdraw.Text = "";
                        lblBalance.Text = "Your Balance";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtTransFrom.Text == "")
            {
                MessageBox.Show("Enter Source Amount ");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AccNumber='"+txtTransFrom.Text+"'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBal();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Account Doesnot Exist ");
                    txtTransFrom.Text = "";                   
                }
                Con.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtTransTo.Text == "")
            {
                MessageBox.Show("Enter Destination Amount ");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AccNumber='" + txtTransTo.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //CheckAvailableBal();
                    MessageBox.Show("Account Found");
                    Con.Close();
                    if(txtTransTo.Text == txtTransFrom.Text)
                    {
                        MessageBox.Show("Source and Destination accounts are the same");
                        txtTransTo.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Account Doesnot Exist ");
                    txtTransTo.Text = "";
                }
                Con.Close();
            }
        }
        private void Transfer()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransferTbl(TrSrc,TrDest,TrAmt,TrDate)values(@TS,@TD,@TA,@TDa)", Con);
                cmd.Parameters.AddWithValue("@TS", txtTransFrom.Text);
                cmd.Parameters.AddWithValue("@TD", txtTransTo.Text);
                cmd.Parameters.AddWithValue("@TA", txtTransAmt.Text);
                cmd.Parameters.AddWithValue("@TAc", DateTime.Now.Date);
                MessageBox.Show("Money Transferred");
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(txtTransTo.Text == "" || txtTransFrom.Text == "" || txtTransAmt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt16(txtTransAmt.Text)>Balance)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                Transfer();
                SubtractBal();
                AddBal();
                txtTransFrom.Text = "";
                txtTransTo.Text = "";
                txtTransAmt.Text = ""; 
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBalance.Text = "";
            lblBalance.Text = "Your Balance";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
