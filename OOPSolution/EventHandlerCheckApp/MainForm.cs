using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
               
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var reslut = TxtUserID.Text + "\n" + TxtPassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {reslut}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

        private void TextUerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
