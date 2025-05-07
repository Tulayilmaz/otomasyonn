using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAPISALLLL
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        
            if (checkBox1.Checked)
            {
                html_css html_Css = new html_css();
                html_Css.Show();
                this.Hide(); // Veya this.Close(); eğer mevcut formu kapatmak istersen
            }
       
    }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                c_ c_= new c_();
                c_.Show();
                this.Hide(); // Veya this.Close(); eğer mevcut formu kapatmak istersen
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked)
            {
                javascript javascript = new javascript();
                javascript.Show();
                this.Hide(); // Veya this.Close(); eğer mevcut formu kapatmak istersen
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                siber_güvenlik siber_güvenlik = new siber_güvenlik();
                siber_güvenlik.Show();
                this.Hide(); // Veya this.Close(); eğer mevcut formu kapatmak istersen
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                web_tasarım web_tasarım = new web_tasarım();
                web_tasarım.Show();
                this.Hide(); // Veya this.Close(); eğer mevcut formu kapatmak istersen
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                pyhton pyhton = new pyhton();
                pyhton.Show();
                this.Hide(); // Veya this.Close(); eğer mevcut formu kapatmak istersen
            }

        }
    }
}
