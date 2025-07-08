using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void picAcc_Click(object sender, EventArgs e)
        {
            AddAccounts Obj = new AddAccounts();
            Obj.Show();
            this.Hide();
        }

        private void picTrans_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }

        private void picSet_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
