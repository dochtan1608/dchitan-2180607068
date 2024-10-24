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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int Cong = 0;
            Console.WriteLine(txtSoA.Text);
            Console.WriteLine(txtSoB.Text);
            Cong = int.Parse(txtSoA.Text)+int.Parse(txtSoB.Text);
            txtKetQua.Text = Cong+"";

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int Tru = 0;
            Console.WriteLine(txtSoA.Text);
            Console.WriteLine(txtSoB.Text);
            Tru = int.Parse(txtSoA.Text) - int.Parse(txtSoB.Text);
            txtKetQua.Text = Tru + "";

        }
    }
}
