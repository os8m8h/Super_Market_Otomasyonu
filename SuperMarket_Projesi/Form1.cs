using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Projesi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (UserTxt.Text == "Anas" && PassTxt.Text == 1234.ToString())
            {
                MessageBox.Show("You entered Successfully");
                Catagory prc = new Catagory();
               
                prc.Show();
                
                this.Hide();
                MessageBox.Show("You entered Successfully");
            }
            else
                MessageBox.Show("You entered the username or the password wrong !  try again", " Eror"); }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
