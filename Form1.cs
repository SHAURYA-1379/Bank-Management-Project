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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startP = 0;     
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startP += 1;
            ProgressBar.Value = ProgressBar.Value + startP;
            if (ProgressBar.Value == 300)
            {
                ProgressBar.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
