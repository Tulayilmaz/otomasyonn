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
    public partial class kayıt_ol : Form
    {
        public kayıt_ol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giriş yeniform = new giriş();
            this.Hide();
            yeniform.Show();
        }
    }
}
