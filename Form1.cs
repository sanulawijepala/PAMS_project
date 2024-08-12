using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
       
        public Form1()
        {
            InitializeComponent();
            Instance = this;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "MyAdmin" && txtpassword.Text == "123")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect");
                txtUserName.Clear();
                txtpassword.Clear();
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "MyAdmin" && txtpassword.Text == "123")
                            {
                
               
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is invalid, try again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}