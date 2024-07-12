using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();  
            txtSonuc.ResetText(); //Her defasında şifre oluştura basınca yeni şifreler oluşturacak.
            for (int i = 1;i<=numSifre.Value;i++)
            {
                string karakter = "";
                for (int j = 1; j <= numSifreUzun.Value; j++)
                {
                    int degisken = rnd.Next(33, 127);
                    karakter += Convert.ToChar(degisken).ToString();
                }
                txtSonuc.Text += i + ". " + karakter + Environment.NewLine;
            }
        }
    }
}
