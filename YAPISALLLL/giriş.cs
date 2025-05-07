using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAPISALLLL
{
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa yeniform = new anasayfa();
            this.Hide();
            yeniform.Show();
            string ka = textkullanıcı.Text;
            string sifre = textpassword.Text;
            if (ka == "Tülay yılmaz")
            {
                if (sifre == "23430040003")
                {
                    lblsonuc.Text = "giriş başarılı";

                }
                else { lblsonuc.Text = " şifreniz yanlış"; }
            }
            else
            {
                lblsonuc.Text = "kullanıcı adınız yanlış";
            }
        }
    }
}
