using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Program
{
    public partial class NhapGT : Form
    {
        public NhapGT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapNhatButton_Click(object sender, EventArgs e)
        {

            int batdau = int.Parse(Giatribatdau_TextBox.Text);
            int ketthuc = int.Parse(Giatriketthuc_TextBox.Text);
            MainForm MF = new MainForm();
            MF.TaoMangNgauNhien2(6,batdau,ketthuc);
            this.DialogResult = DialogResult.OK;
        }
    }
}
