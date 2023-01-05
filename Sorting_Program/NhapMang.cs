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
    public partial class NhapMang : Form
    {
        public List<int> dayCanNhap;
        public NhapMang()
        {
            InitializeComponent();
            dayCanNhap = new List<int>();
            dayCanNhapTextBox.Text = Properties.Settings.Default.dayCanNhap;
            if (dayCanNhapTextBox.Text != "")
            {
                luuDayCheckBox.Checked = true;
            }
        }
        private void NhapMang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }

        private void dayCanNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void TaoButton_Click(object sender, EventArgs e)
        {
            dayCanNhap.Clear();

            foreach (string soString in dayCanNhapTextBox.Text.Split(' '))
            {
                int so = 100;
                bool rs = int.TryParse(soString, out so);
                if (rs == true && (so < 0 || so > 99))
                {
                    MessageBox.Show("Lưu ý các số phải là số thuộc khoản từ 0 đến 99", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (rs == true)
                    dayCanNhap.Add(so);
            }

            if (dayCanNhap.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dayCanNhap.Count > ThamSo.SoLuongNodeToiDa)
            {
                MessageBox.Show("Số lượng phần tử phải thuộc từ 1 đến " + ThamSo.SoLuongNodeToiDa.ToString() + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (luuDayCheckBox.Checked)
            {
                Properties.Settings.Default["dayCanNhap"] = dayCanNhapTextBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.dayCanNhap = "";
            }


            this.DialogResult = DialogResult.OK;
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
