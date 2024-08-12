using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Guna2HtmlLabel label1;
        public TextBox txtUsername1;
      
        public Form3()
        {
            InitializeComponent();
            instance = this;
            label1 = guna2HtmlLabel3;
            txtUsername1 = new TextBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            { guna2ProgressBar1.Value += 1;
                guna2HtmlLabel2.Text = guna2ProgressBar1.Value.ToString() + "%";
            }
            else
            { timer1.Stop();

                MessageBox.Show("Welcome MyAdmin ");
                new Form1().Show();
                this.Hide();
            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
 
}
