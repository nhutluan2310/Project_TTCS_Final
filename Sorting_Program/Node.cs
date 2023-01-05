using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Program
{
    public partial class Node : Button
    {
        public int giaTri;
        public int vitriHienTai;
        public TextBox nhapTayTextBox;
        #region Tạo Node
        public Node(int vitrihientai, int giatri)
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = ThamSo.MauNenNode;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(ThamSo.KichCoNode, ThamSo.KichCoNode);
            this.Padding = new Padding(0);
            this.Font = new Font("Consolas", ThamSo.KichCoNode / 3.2f, FontStyle.Bold);
            this.UseCompatibleTextRendering = true;

            this.Text = giatri.ToString();
            giaTri = giatri;
            vitriHienTai = vitrihientai;
            this.GotFocus += new EventHandler(Node_GotFocus);

            nhapTayTextBox = new TextBox();
            nhapTayTextBox.MaxLength = 2;
            nhapTayTextBox.TextAlign = HorizontalAlignment.Center;
            nhapTayTextBox.BorderStyle = BorderStyle.Fixed3D;
            nhapTayTextBox.Visible = false;
            nhapTayTextBox.Size = new Size(ThamSo.KichCoNode, ThamSo.KichCoNode);
            nhapTayTextBox.Font = new Font("Consolas", ThamSo.KichCoNode / 2, FontStyle.Bold);
            this.Controls.Add(nhapTayTextBox);
            nhapTayTextBox.KeyPress += new KeyPressEventHandler(nhapTayTextBox_KeyPress);
            nhapTayTextBox.KeyDown += new KeyEventHandler(nhapTayTextBox_KeyDown);
            nhapTayTextBox.TextChanged += new EventHandler(nhapTayTextBox_TextChanged);
            nhapTayTextBox.LostFocus += new EventHandler(nhapTayTextBox_LostFocus);
        }
        #endregion

        #region Khu vực Hàm Nhập Tay
        private void Node_GotFocus(object sender, EventArgs e)
        {
            if (nhapTayTextBox.Enabled == true)
            {
                nhapTayTextBox.BackColor = this.BackColor;
                nhapTayTextBox.Visible = true;
                nhapTayTextBox.Text = this.Text;
                nhapTayTextBox.SelectAll();
                nhapTayTextBox.Focus();
            }
        }
        public static Action NodeValueChangedHandler;
        private void nhapTayTextBox_LostFocus(object sender, EventArgs e)
        {
            nhapTayTextBox.Visible = false;
            this.Text = nhapTayTextBox.Text;
            this.giaTri = int.Parse(nhapTayTextBox.Text);
            NodeValueChangedHandler();
        }
        private void nhapTayTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nhapTayTextBox.Text.Count() == 0)
            {
                nhapTayTextBox.Text = "0";
                nhapTayTextBox.SelectAll();
                nhapTayTextBox.Focus();
            }
        }
        private void nhapTayTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nhapTayTextBox.Visible = false;
                this.Text = nhapTayTextBox.Text;
            }

        }
        private void nhapTayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);

                if (nhapTayTextBox.Text.Count() == 0)
                {
                    nhapTayTextBox.Text = "0";
                }
            }
        }
        #endregion

        #region Di chuyển Node Lên, Xuống, Trái, Phải 
        public static ManualResetEvent pauseStatus = new ManualResetEvent(true);
        public static bool IsPause = false;

        public void NodeDown()
        {
            int y_ViTriMoi = this.Location.Y + ThamSo.KhoangCachTrenDuoiNode;
            while (this.Location.Y < y_ViTriMoi)
            {
                pauseStatus.WaitOne(Timeout.Infinite);
                Thread.Sleep(ThamSo.TocDo);
                this.Location = new Point(this.Location.X, this.Location.Y + 2);
            }
        }

        public void NodeUp()
        {
            int y_ViTriMoi = this.Location.Y - ThamSo.KhoangCachTrenDuoiNode;
            while (this.Location.Y > y_ViTriMoi)
            {
                pauseStatus.WaitOne(Timeout.Infinite);
                Thread.Sleep(ThamSo.TocDo);
                this.Location = new Point(this.Location.X, this.Location.Y - 2);
            }
        }

        public void NodeRightLeft(int vitriMoi)
        {
            int x_vitririMoi;
            if (vitriMoi > this.vitriHienTai)
            {
                x_vitririMoi = this.Location.X + ((vitriMoi - vitriHienTai) * ThamSo.KhoangCachGiuaCacNode);
                while (this.Location.X < x_vitririMoi)
                {
                    pauseStatus.WaitOne(Timeout.Infinite);
                    Thread.Sleep(ThamSo.TocDo);
                    this.Location = new Point(this.Location.X + 2, this.Location.Y);
                }
            }
            else
            {
                x_vitririMoi = this.Location.X - ((vitriHienTai - vitriMoi) * ThamSo.KhoangCachGiuaCacNode);
                while (this.Location.X > x_vitririMoi)
                {
                    pauseStatus.WaitOne(Timeout.Infinite);
                    Thread.Sleep(ThamSo.TocDo);
                    this.Location = new Point(this.Location.X - 2, this.Location.Y);
                }
            }
        }
        #endregion
    }
}
