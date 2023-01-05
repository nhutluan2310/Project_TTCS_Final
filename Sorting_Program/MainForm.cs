using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Program
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeComponentExtend();

            // Tắt các Button cần tắt khi khởi động
            destroyButton.Enabled = batDauButton.Enabled = tamDungButton.Enabled = huyButton.Enabled = false;
            gtbd_textBox.Enabled = gtkt_textBox.Enabled = false;

            // track bar
            speedTrackBar.Maximum = ThamSo.TocDo;
            speedTrackBar.Minimum = 0;
            speedTrackBar.Value = ThamSo.TocDo / 4;
            speedTrackBar.LargeChange = 1;

            // radiobutton check
            tangRadioButton.Checked = true;
            interchangeSortRadioButton.Checked = true;

            // menuStrip
            menuStrip.Renderer = new MySR();
            menuStrip.BackColor = Color.FromArgb(51, 51, 51);
            menuStrip.ForeColor = Color.Gainsboro;

            // Load các thông tin cài đặt của người dùng 
            ThamSo.MauNenNode = Properties.Settings.Default.MauNenNode;
            ThamSo.MauNodeDangXet = Properties.Settings.Default.MauNodeDangXet;
            ThamSo.MauNodeDaXetQua = Properties.Settings.Default.MauNodeDaXetQua;
            ThamSo.KichCoNode = Properties.Settings.Default.KichCoNode;
            ThamSo.KhoangCachGiuaCacNode = Properties.Settings.Default.KhoanCachGiuaCacNode;
            soPhanTuTextBox.Text = Properties.Settings.Default.SoLuongPhanTuMacDinh.ToString();
            yTuongTextBox.Font = Properties.Settings.Default.fontYTuongTextBox;
            codeListBox.Font = Properties.Settings.Default.fontCodeListBox;

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void CapNhatYTuongVaCode()
        {
            ShowCode.codeListBox = codeListBox;
            ShowCode.ytuongTextBox = yTuongTextBox;
            bool tang = tangRadioButton.Checked;

            if (interchangeSortRadioButton.Checked)
            {
                ShowCode.InterchangeSort(tang);
                hamSapXep = InterchangeSort;
            }
            else if (insertionSortRadioButton.Checked)
            {
                ShowCode.InsertionSort(tang);
                hamSapXep = InsertionSort;
            }
            else if (bubbleSortRadioButton.Checked)
            {
                ShowCode.BubbleSort(tang);
                hamSapXep = BubbleSort;
            }
            else if (selectionSortRadioButton.Checked)
            {
                ShowCode.SelectionSort(tang);
                hamSapXep = SelectionSort;
            }
            else if (mergeSortRadioButton.Checked)
            {
                ShowCode.MergeSort(tang);
                hamSapXep = MergeSort;
            }
            else if (quickSortRadioButton.Checked)
            {
                ShowCode.QuickSort(tang);
                hamSapXep = QuickSort;
            }
            else if (shakerSortRadioButton.Checked)
            {
                ShowCode.ShakerSort(tang);
                hamSapXep = ShakerSort;
            }
            else if (shellSortRadioButton.Checked)
            {
                ShowCode.ShellSort(tang);
                hamSapXep = ShellSort;
            }
            else if (heapSortRadioButton.Checked)
            {
                ShowCode.HeapSort(tang);
                hamSapXep = HeapSort;
            }
        }

        #region Main_Form_Extend
        private Point root;
        public bool isRunning = false;
        private List<Node> nodeArr = new List<Node>();
        private List<Label> labelSTTArr = new List<Label>();
        private Dictionary<string, Label> bienArr;
        private Label daySoChuaSapXepLabel;

        private void InitializeComponentExtend()
        {
            root.X = 30;
            root.Y = (sortingPanel.Size.Height / 2) - 15;

            daySoChuaSapXepLabel = new Label();
            this.unsortedPanel.Controls.Add(daySoChuaSapXepLabel);
            daySoChuaSapXepLabel.TextAlign = ContentAlignment.MiddleCenter;
            daySoChuaSapXepLabel.ForeColor = Color.Cornsilk;
            daySoChuaSapXepLabel.Font = new Font("Consolas", ThamSo.KichCoNode / 5 * 2, FontStyle.Regular);
            daySoChuaSapXepLabel.Size = new Size(unsortedPanel.Size.Width, unsortedPanel.Size.Height);

            Node.NodeValueChangedHandler += CapNhatDaySoChuaSapXep;

            bienArr = new Dictionary<string, Label>();
            List<string> bienArrString = new List<string>() { "i", "j", "min", "right", "left", "k", "pos", "m", "vt_x", "gap", "a:", "b:", "c:" };
            foreach (string item in bienArrString)
            {
                bienArr.Add(item, new Label());
            }
            foreach (var item in bienArr)
            {

                this.sortingPanel.Controls.Add(item.Value);
                item.Value.TextAlign = ContentAlignment.MiddleCenter;
            }

            bienArr["i"].Size = bienArr["j"].Size = new Size(ThamSo.KichCoNode, 15);
            bienArr["i"].ForeColor = bienArr["j"].ForeColor = ThamSo.MauNodeDangXet;
            bienArr["i"].BackColor = bienArr["j"].BackColor = Color.Transparent;

            bienArr["min"].ForeColor = Color.LightGreen;
            bienArr["min"].Size = new Size(60, 20);
            bienArr["left"].ForeColor = Color.LightGreen;
            bienArr["left"].Size = new Size(60, 20);
            bienArr["right"].ForeColor = Color.IndianRed;
            bienArr["right"].Size = new Size(60, 20);
            bienArr["m"].ForeColor = bienArr["k"].ForeColor = Color.Coral;
            bienArr["m"].Size = bienArr["k"].Size = new Size(40, 15);
            bienArr["pos"].ForeColor = Color.Cornsilk;
            bienArr["pos"].Size = new Size(60, 20);
            bienArr["vt_x"].ForeColor = Color.Yellow;
            bienArr["vt_x"].Size = new Size(60, 20);
            bienArr["gap"].ForeColor = Color.LightGreen;
            bienArr["gap"].Size = new Size(60, 20);
            bienArr["a:"].ForeColor = bienArr["b:"].ForeColor = bienArr["c:"].ForeColor = Color.White;
            bienArr["a:"].Size = bienArr["b:"].Size = bienArr["c:"].Size = new Size(40, 15);
        }
        public void TaoMangNgauNhien2(int soPhanTu, int batdau, int ketthuc)
        {
            XoaMang();
            ChinhKichCoNode();
            Random rd = new Random();
            for (int i = 0; i < soPhanTu; i++)
            {
                int giaTri = rd.Next(batdau, ketthuc);
                Node temp = new Node(i, giaTri);
                this.sortingPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(root.X + i * ThamSo.KhoangCachGiuaCacNode, root.Y - ThamSo.KichCoNode / 2);
                TaoLabelSoThuTuChoMang(i);
            }
            CapNhatDaySoChuaSapXep();
            destroyButton.Enabled = true;

        }
        #region Tạo mảng ngẫu nhiên
        private void TaoMangNgauNhien(int soPhanTu)
        {
            XoaMang();
            ChinhKichCoNode();
            Random rd = new Random();
            for (int i = 0; i < soPhanTu; i++)
            {
                int giaTri = rd.Next(0, 99);
                Node temp = new Node(i, giaTri);
                this.sortingPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(root.X + i * ThamSo.KhoangCachGiuaCacNode, root.Y - ThamSo.KichCoNode / 2);
                TaoLabelSoThuTuChoMang(i);
            }
            CapNhatDaySoChuaSapXep();
            destroyButton.Enabled = true;
            
        }
        #endregion

        private void ChinhKichCoNode()
        {
            int soPhanTu = int.Parse(soPhanTuTextBox.Text);
            if (soPhanTu > 14 && soPhanTu <= ThamSo.SoLuongNodeToiDa)
            {
                ThamSo.KichCoNode = 30 + (18 - soPhanTu) * 2;
                ThamSo.KhoangCachGiuaCacNode = ThamSo.KichCoNode * 2;
            }
            else if ((Properties.Settings.Default.KichCoNode > 40 || Properties.Settings.Default.KhoanCachGiuaCacNode > 80) && soPhanTu > 11)
            {
                ThamSo.KichCoNode = 45;
                ThamSo.KhoangCachGiuaCacNode = 85;
            }
            else if (soPhanTu <= 14)
            {
                ThamSo.KichCoNode = Properties.Settings.Default.KichCoNode;
                ThamSo.KhoangCachGiuaCacNode = Properties.Settings.Default.KhoanCachGiuaCacNode;
            }
        }

        private void TaoLabelSoThuTuChoMang(int i)
        {
            Label temp = new Label();
            temp.Location = new Point(root.X + i * ThamSo.KhoangCachGiuaCacNode, sortingPanel.Size.Height - 30);
            temp.Font = new Font("Consolas", ThamSo.KichCoNode / 3.3f, FontStyle.Regular);
            temp.BackColor = Color.Transparent;
            temp.ForeColor = Color.White;
            temp.Size = new Size(ThamSo.KichCoNode, ThamSo.KichCoNode / 2);
            temp.TextAlign = ContentAlignment.MiddleCenter;
            temp.Text = i.ToString();
            this.sortingPanel.Controls.Add(temp);
            labelSTTArr.Add(temp);
        }

        #region Nhập tay
        private void NhapTay(int soPhanTu)
        {
            XoaMang();
            ChinhKichCoNode();
            for (int i = 0; i < soPhanTu; i++)
            {
                int giaTri = 0;
                Node temp = new Node(i, giaTri);
                this.sortingPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(root.X + i * ThamSo.KhoangCachGiuaCacNode, root.Y - ThamSo.KichCoNode / 2);
                TaoLabelSoThuTuChoMang(i);
            }
            nodeArr[0].Focus();
            destroyButton.Enabled = true;
        }
        #endregion

        #region Nhập một dãy
        private void NhapMotDay(List<int> dayCanNhap)
        {
            XoaMang();
            ChinhKichCoNode();
            for (int i = 0; i < dayCanNhap.Count; i++)
            {
                int giaTri = dayCanNhap[i];
                Node temp = new Node(i, giaTri);
                this.sortingPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(root.X + i * ThamSo.KhoangCachGiuaCacNode, root.Y - ThamSo.KichCoNode / 2);
                TaoLabelSoThuTuChoMang(i);
            }
            CapNhatDaySoChuaSapXep();
            destroyButton.Enabled = true;
        }
        #endregion

        #region Xóa mảng hiện tại
        private void XoaMang()
        {
            foreach (Control node in nodeArr)
            {
                node.Dispose();
            }
            nodeArr.Clear();

            foreach (Control label in labelSTTArr)
            {
                label.Dispose();
            }
            labelSTTArr.Clear();

            if (CodeListBoxIsPause == true || Node.IsPause == true)
            {
                TamDung();
            }

            if (sortingThread != null)
            {
                sortingThread.Abort();
            }
            foreach (Label item in bienArr.Values)
            {
                item.Visible = false;
            }
            SortRunOrStop(false);

            daySoChuaSapXepLabel.Text = "";

            CapNhatYTuongVaCode();

            thoiGianChayTimer.Stop();
            thoiGianChay_GiayLabel.Text = thoiGianChay_PhutLabel.Text = "00";

            destroyButton.Enabled = false;
        }
        #endregion

        #region Bắt đầu sắp xếp
        public void SortRunOrStop(bool IsRun)
        {
            if (nodeArr != null)
                batDauButton.Enabled = !IsRun;

            huyButton.Enabled = IsRun;
            isRunning = IsRun;
            codeListBox.SelectedIndex = -1;
            taoNgauNghienButton.Enabled = !IsRun;
            nhapMotDayButton.Enabled = !IsRun;
            nhapTayButton.Enabled = !IsRun;
            
            foreach (Node node in nodeArr)
            {
                node.nhapTayTextBox.Enabled = !IsRun;
                if (IsRun)
                {
                    node.BackColor = ThamSo.MauNenNode;
                }
            }
            foreach (Label label in bienArr.Values)
            {
                label.Visible = false;
            }

            if (!IsRun)
            {
                thoiGianChayTimer.Stop();
            }
        }

        Thread sortingThread;
        Action hamSapXep;
        public void BatDauSapXep()
        {
            SortRunOrStop(true);
            tamDungButton.Enabled = true;
            interchangeSortRadioButton.Enabled = insertionSortRadioButton.Enabled = shellSortRadioButton.Enabled = bubbleSortRadioButton.Enabled = 
            shakerSortRadioButton.Enabled = selectionSortRadioButton.Enabled = heapSortRadioButton.Enabled = quickSortRadioButton.Enabled = mergeSortRadioButton.Enabled = false;
            if (sortingThread != null)   
            {
                sortingThread.Abort();
            }

            
            thoiGianChay_GiayLabel.Text = thoiGianChay_PhutLabel.Text = "00";
            thoiGianChayTimer.Start();

            sortingThread = new Thread(new ThreadStart(hamSapXep));
            sortingThread.Start();

            
        }

        #endregion

        #region Hủy quá trình sắp xếp
        private void HuyQuaTrinh(int soPhanTu)
        {
            string[] mangCu = daySoChuaSapXepLabel.Text.Split();
            XoaMang();

            for (int i = 0; i < soPhanTu; i++)
            {
                int giaTri = int.Parse(mangCu[i]);
                Node temp = new Node(i, giaTri);
                this.sortingPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(root.X + i * ThamSo.KhoangCachGiuaCacNode, root.Y - ThamSo.KichCoNode / 2);
                TaoLabelSoThuTuChoMang(i);
            }
            CapNhatDaySoChuaSapXep();
            destroyButton.Enabled = true;
            tamDungButton.Enabled = false;
            interchangeSortRadioButton.Enabled = insertionSortRadioButton.Enabled = shellSortRadioButton.Enabled = bubbleSortRadioButton.Enabled =
            shakerSortRadioButton.Enabled = selectionSortRadioButton.Enabled = heapSortRadioButton.Enabled = quickSortRadioButton.Enabled = mergeSortRadioButton.Enabled = true;
        }
        #endregion

        #region Di chuyển và hoán vị Node
        public void DiChuyenNodeDen(object oNode, object oVitriMoi) 
        {
            int vitriMoi = (int)oVitriMoi;
            Node node = (Node)oNode;
            if (vitriMoi > node.vitriHienTai)
            {
                node.NodeUp();
                node.NodeRightLeft(vitriMoi);
                node.NodeDown();
            }
            else if (vitriMoi < node.vitriHienTai)
            {
                node.NodeDown();
                node.NodeRightLeft(vitriMoi);
                node.NodeUp();
            }

            node.vitriHienTai = vitriMoi;


        }

        Task hoanVi1Task;
        Task hoanVi2Task;
        private void HoanVi2Node(int vitriNodeA, int vitriNodeB)
        {
            hoanVi1Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(nodeArr[vitriNodeA], vitriNodeB); });
            hoanVi2Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(nodeArr[vitriNodeB], vitriNodeA); });
            
            Task.WaitAll(hoanVi1Task, hoanVi1Task);

            if (nodeArr.Count != 0)
            {
                Color tempColor = nodeArr[vitriNodeA].BackColor;
                nodeArr[vitriNodeA].BackColor = nodeArr[vitriNodeB].BackColor;
                nodeArr[vitriNodeB].BackColor = tempColor;

                Node t = nodeArr[vitriNodeA];
                nodeArr[vitriNodeA] = nodeArr[vitriNodeB];
                nodeArr[vitriNodeB] = t;
            }

        }
        #endregion

        #region Tạm dừng
        public static ManualResetEvent codeListBoxPauseStatus = new ManualResetEvent(true);
        public static bool CodeListBoxIsPause = false;
        void TamDung()
        {
            if (Node.IsPause)
            {
                Node.pauseStatus.Set();
                Node.IsPause = false;
                tamDungButton.Text = "Tạm dừng";
                thoiGianChayTimer.Start();
            }
            else
            {
                Node.pauseStatus.Reset();
                Node.IsPause = true;
                tamDungButton.Text = "Tiếp tục";
                thoiGianChayTimer.Stop();
            }
            if (CodeListBoxIsPause)
            {
                codeListBoxPauseStatus.Set();
                CodeListBoxIsPause = false;
                tamDungButton.Text = "Tạm dừng";
                thoiGianChayTimer.Start();
            }
            else
            {
                codeListBoxPauseStatus.Reset();
                CodeListBoxIsPause = true;
                tamDungButton.Text = "Tiếp tục";
                thoiGianChayTimer.Stop();
            }
        }
        #endregion

        #region Chọn từng line trong codeListBox - và chế độ Debug
        public void ChonDongChoCodeListBox(int viTri)
        {
            Thread.Sleep(ThamSo.TocDo * 30);
            codeListBoxPauseStatus.WaitOne(Timeout.Infinite);
            codeListBox.SelectedIndex = viTri;
        }
        #endregion

        #region Cập nhật cho trạng thái mảng vào Ý tưởng TextBox
        public void CapNhatYTuongTextBox(int i, int j, string chuDau, string chuCuoi)
        {
            string temp = "\r\n" + chuDau + "=" + i + " ," + chuCuoi + "=" + j + " : ";
            for (int h = 0; h < nodeArr.Count; h++)
            {
                temp += nodeArr[h].giaTri.ToString("D2") + " ";
            }
            yTuongTextBox.AppendText(temp);
        }
        #endregion

        #region Cập nhật dãy số chưa sắp xếp 
        private void CapNhatDaySoChuaSapXep()
        {
            daySoChuaSapXepLabel.Text = "";
            foreach (Node node in nodeArr)
            {
                node.BackColor = ThamSo.MauNenNode;
                daySoChuaSapXepLabel.Text += node.Text + " ";
            }
        }
        #endregion

        #region Thuật toán

        public void InterchangeSort()
        {
            yTuongTextBox.Clear();

            ChonDongChoCodeListBox(3);
            int i = 0, j = 0;

            ChonDongChoCodeListBox(4);
            nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
            bienArr["i"].Text = "i = " + i;
            bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, sortingPanel.Height - 50);
            bienArr["i"].Visible = true;

            for (i = 0; i < nodeArr.Count - 1; i++)
            {
                ChonDongChoCodeListBox(5);
                j = i + 1;
                bienArr["j"].Text = "j = " + j;
                bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, sortingPanel.Height - 50);
                bienArr["j"].Visible = true;
                if (j != nodeArr.Count)
                    nodeArr[j].BackColor = ThamSo.MauNodeDangXet;

                for (j = i + 1; j < nodeArr.Count; j++)
                {
                    ChonDongChoCodeListBox(6);

                    bool thucHien = false;
                    if (tangRadioButton.Checked == true)
                    {
                        if (nodeArr[i].giaTri > nodeArr[j].giaTri)
                            thucHien = true;
                    }
                    else
                    {
                        if (nodeArr[i].giaTri < nodeArr[j].giaTri)
                            thucHien = true;
                    }
                    if (thucHien)
                    {
                        ChonDongChoCodeListBox(7);
                        HoanVi2Node(i, j);
                        CapNhatYTuongTextBox(i, j, "i", "j");
                    }

                    ChonDongChoCodeListBox(5);
                    bienArr["j"].Text = "j = " + (j + 1);
                    bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (j + 1), sortingPanel.Height - 50);
                    if (j + 1 != nodeArr.Count)
                        nodeArr[j + 1].BackColor = ThamSo.MauNodeDangXet;
                    nodeArr[j].BackColor = ThamSo.MauNenNode;

                }

                ChonDongChoCodeListBox(4);
                bienArr["i"].Text = "i = " + (i + 1);
                bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (i + 1), sortingPanel.Height - 50);
                if (i + 1 != nodeArr.Count)
                    nodeArr[i + 1].BackColor = ThamSo.MauNodeDangXet;
                // Đổi màu các node đã xét qua
                nodeArr[i].BackColor = ThamSo.MauNodeDaXetQua;
            }

            ChonDongChoCodeListBox(4);
            // Đổi màu node i cuối
            nodeArr[nodeArr.Count - 1].BackColor = ThamSo.MauNodeDaXetQua;

            // Kết thúc
            SortRunOrStop(false);
            if (nodeArr.Count != 0)               // Nếu mảng bị huy trong lúc chạy thì k cần in ra kết quả
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void SelectionSort()
        {
            yTuongTextBox.Clear();

            ChonDongChoCodeListBox(3);
            int i = 0, j = 0, min;

            ChonDongChoCodeListBox(4);
            nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
            bienArr["i"].Text = "i = " + i;
            bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, sortingPanel.Height - 50);
            bienArr["i"].Visible = true;

            for (i = 0; i < nodeArr.Count - 1; i++)
            {

                ChonDongChoCodeListBox(6);
                min = i;
                bienArr["min"].Text = "min = " + min;
                bienArr["min"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * min - 10, 40);
                bienArr["min"].SendToBack();
                bienArr["min"].Visible = true;                     // Đặt visible ở dây tránh trường hợp khi hiện lên vẫn còn nằm ở vị trí cũ
                nodeArr[min].BackColor = Color.LightGreen;

                ChonDongChoCodeListBox(7);
                j = i + 1;
                bienArr["j"].Text = "j = " + j;
                bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, sortingPanel.Height - 50);
                bienArr["j"].Visible = true;
                if (j != nodeArr.Count)
                    nodeArr[j].BackColor = ThamSo.MauNodeDangXet;

                for (j = i + 1; j < nodeArr.Count; j++)
                {
                    ChonDongChoCodeListBox(8);

                    bool thucHien = false; // dùng để xét tăng/giảm , nếu bằng true thì code sẽ chạy
                    if (tangRadioButton.Checked == true)
                    {
                        if (nodeArr[j].giaTri < nodeArr[min].giaTri)
                            thucHien = true;
                    }
                    else
                    {
                        if (nodeArr[j].giaTri > nodeArr[min].giaTri)
                            thucHien = true;
                    }
                    if (thucHien)
                    {
                        // đổi lại màu nền khi k còn là node min
                        if (min == i)
                            nodeArr[min].BackColor = ThamSo.MauNodeDangXet;
                        else
                            nodeArr[min].BackColor = ThamSo.MauNenNode;

                        min = j;
                        bienArr["min"].Text = "min = " + min;
                        nodeArr[min].BackColor = Color.LightGreen;
                        bienArr["min"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * min - 10, 40);
                    }

                    ChonDongChoCodeListBox(7);
                    bienArr["j"].Text = "j = " + (j + 1);
                    bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (j + 1), sortingPanel.Height - 50);
                    if (j + 1 != nodeArr.Count)
                        nodeArr[j + 1].BackColor = ThamSo.MauNodeDangXet;
                    // Nếu là min thì k đổi màu
                    if (j != min)
                        nodeArr[j].BackColor = ThamSo.MauNenNode;

                }
                ChonDongChoCodeListBox(10);
                HoanVi2Node(i, min);
                Task.WaitAll(hoanVi1Task, hoanVi2Task);
                CapNhatYTuongTextBox(i, j, "i", "j");
                //  đổi lại màu bth cho node min sau khi đã swap xong
                nodeArr[min].BackColor = ThamSo.MauNenNode;

                ChonDongChoCodeListBox(4);
                bienArr["i"].Text = "i = " + (i + 1);
                bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (i + 1), sortingPanel.Height - 50);
                if (i + 1 != nodeArr.Count)
                    nodeArr[i + 1].BackColor = ThamSo.MauNodeDangXet;

                // Đổi màu các node đã xét qua
                nodeArr[i].BackColor = ThamSo.MauNodeDaXetQua;
            }

            ChonDongChoCodeListBox(4);
            // Đổi màu node i cuối
            nodeArr[nodeArr.Count - 1].BackColor = ThamSo.MauNodeDaXetQua;

            SortRunOrStop(false);
            if (nodeArr.Count != 0)
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void ShakerSort()
        {
            yTuongTextBox.Clear();

            ChonDongChoCodeListBox(3);
            int j, left, right, k;

            ChonDongChoCodeListBox(4);
            left = 0; right = nodeArr.Count - 1; k = nodeArr.Count - 1;

            ChonDongChoCodeListBox(5);
            bienArr["left"].Text = "left = " + left;
            bienArr["left"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * left - 10, 32);
            bienArr["left"].Visible = true;
            bienArr["left"].SendToBack();
            bienArr["right"].Text = "right = " + right;
            bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 12);
            bienArr["right"].Visible = true;
            bienArr["right"].SendToBack();
            bienArr["k"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * k, 188);
            bienArr["k"].Text = "k = " + k;
            bienArr["k"].Visible = true;
            bienArr["k"].SendToBack();
            nodeArr[k].BackColor = Color.Coral;

            while (left < right)
            {

                ChonDongChoCodeListBox(7);

                j = right;
                bienArr["j"].Text = "j = " + j;
                bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, 208);
                bienArr["j"].Visible = true;
                bienArr["j"].SendToBack();
                nodeArr[j].BackColor = ThamSo.MauNodeDangXet;

                for (j = right; j > left; j--)
                {

                    bool thucHien = false;
                    if (tangRadioButton.Checked == true)
                    {
                        if (nodeArr[j].giaTri < nodeArr[j - 1].giaTri)
                            thucHien = true;
                    }
                    else
                    {
                        if (nodeArr[j].giaTri > nodeArr[j - 1].giaTri)
                            thucHien = true;
                    }

                    ChonDongChoCodeListBox(8);
                    if (thucHien)
                    {
                        ChonDongChoCodeListBox(10);
                        HoanVi2Node(j, j - 1);
                        CapNhatYTuongTextBox(j, k, "j", "k");

                        ChonDongChoCodeListBox(11);
                        nodeArr[k].BackColor = ThamSo.MauNenNode;
                        k = j;
                        bienArr["k"].Text = "k = " + k;
                        bienArr["k"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * k, 188);
                        nodeArr[k].BackColor = Color.Coral;
                    }

                    ChonDongChoCodeListBox(7);
                    bienArr["j"].Text = "j = " + (j - 1);
                    bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (j - 1), 208);
                    nodeArr[j - 1].BackColor = ThamSo.MauNodeDangXet;
                    if (j != k)
                        nodeArr[j].BackColor = ThamSo.MauNenNode;
                    else
                        nodeArr[j].BackColor = Color.Coral;
                }

                ChonDongChoCodeListBox(13);
                left = k;
                bienArr["left"].Text = "left = " + left;
                bienArr["left"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * left - 10, 32);
                // Đổi màu các node đã xét qua
                for (int i = 0; i < left; i++)
                {
                    nodeArr[i].BackColor = ThamSo.MauNodeDaXetQua;
                }

                ChonDongChoCodeListBox(14);
                j = left;
                bienArr["j"].Text = "j = " + j;
                bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, 208);
                nodeArr[j].BackColor = ThamSo.MauNodeDangXet;

                for (j = left; j < right; j++)
                {

                    bool thucHien = false;
                    if (tangRadioButton.Checked == true)
                    {
                        if (nodeArr[j + 1].giaTri < nodeArr[j].giaTri)
                            thucHien = true;
                    }
                    else
                    {
                        if (nodeArr[j + 1].giaTri > nodeArr[j].giaTri)
                            thucHien = true;
                    }

                    ChonDongChoCodeListBox(15);
                    if (thucHien)
                    {
                        ChonDongChoCodeListBox(17);
                        HoanVi2Node(j, j + 1);
                        CapNhatYTuongTextBox(j, k, "j", "k");

                        ChonDongChoCodeListBox(18);
                        nodeArr[k].BackColor = ThamSo.MauNenNode;
                        k = j;
                        bienArr["k"].Text = "k = " + k;
                        bienArr["k"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * k, 188);
                        nodeArr[k].BackColor = Color.Coral;
                    }


                    ChonDongChoCodeListBox(14);
                    bienArr["j"].Text = "j = " + (j + 1);
                    bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (j + 1), 208);
                    nodeArr[j + 1].BackColor = ThamSo.MauNodeDangXet;
                    if (j != k)
                        nodeArr[j].BackColor = ThamSo.MauNenNode;
                    else
                        nodeArr[j].BackColor = Color.Coral;
                }

                ChonDongChoCodeListBox(20);
                right = k;
                bienArr["right"].Text = "right = " + right;
                bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 12);

                ChonDongChoCodeListBox(5);
                bienArr["left"].Text = "left = " + left;
                bienArr["left"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * left - 10, 32);
                bienArr["right"].Text = "right = " + right;
                bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 12);


                // Đổi màu các node đã xét qua
                for (int i = nodeArr.Count - 1; i > right; i--)
                {
                    nodeArr[i].BackColor = ThamSo.MauNodeDaXetQua;
                }

            }

            ChonDongChoCodeListBox(5);
            nodeArr[left].BackColor = ThamSo.MauNodeDaXetQua;


            // Kết thúc
            SortRunOrStop(false);
            if (nodeArr.Count != 0)
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void InsertionSort()
        {
            yTuongTextBox.Clear();
            int i, pos, x;
            Node nodeTam, nodeTam2;
            nodeArr[0].BackColor = ThamSo.MauNodeDangXet;
            for (i = 1; i < nodeArr.Count; i++)
            {
                ChonDongChoCodeListBox(6);
                nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
                nodeArr[i].ForeColor = Color.Red;
                x = nodeArr[i].giaTri;
                ChonDongChoCodeListBox(8);
                nodeTam = nodeArr[i];
                pos = i - 1;
                bienArr["i"].Text = "i = " + i;
                bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, sortingPanel.Height - 50);
                bienArr["i"].Visible = true;
                nodeArr[i].NodeUp();
                nodeArr[0].BackColor = ThamSo.MauNodeDaXetQua;
                nodeArr[0].ForeColor = Color.Purple;
                ChonDongChoCodeListBox(9);
                bienArr["pos"].Text = "pos = " + pos;
                bienArr["pos"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * pos - 10, sortingPanel.Height - 50);
                bienArr["pos"].Visible = true;
                if (tangRadioButton.Checked == true)
                {
                    while ((pos >= 0) && (nodeArr[pos].giaTri > x))
                    {
                        ChonDongChoCodeListBox(11);
                        nodeArr[pos].NodeRightLeft(pos + 1);
                        nodeArr[pos].vitriHienTai = pos + 1;
                        nodeTam2 = nodeArr[pos + 1];
                        nodeArr[pos + 1] = nodeArr[pos];
                        nodeArr[pos] = nodeTam2;
                        ChonDongChoCodeListBox(12);
                        pos--;
                    }
                }
                else
                {
                    while ((pos >= 0) && (nodeArr[pos].giaTri < x))
                    {
                        ChonDongChoCodeListBox(11);
                        nodeArr[pos].NodeRightLeft(pos + 1);
                        nodeArr[pos].vitriHienTai = pos + 1;
                        nodeTam2 = nodeArr[pos + 1];
                        nodeArr[pos + 1] = nodeArr[pos];
                        nodeArr[pos] = nodeTam2;
                        ChonDongChoCodeListBox(12);
                        pos--;
                    }
                }
                ChonDongChoCodeListBox(14);
                nodeTam.NodeRightLeft(pos + 1);
                nodeTam.NodeDown();
                nodeArr[pos + 1] = nodeTam;
                nodeTam.vitriHienTai = pos + 1;
                nodeArr[pos + 1].BackColor = ThamSo.MauNodeDaXetQua;
                nodeArr[pos + 1].ForeColor = Color.Purple;
                //Cập nhật ý tưởng Text Box
                string temp = "\r\ni=" + i + ",pos=" + (i - 1) + " : ";
                for (int h = 0; h < nodeArr.Count; h++)
                {
                    temp += nodeArr[h].giaTri + " ";
                }
                yTuongTextBox.AppendText(temp);
            }
            SortRunOrStop(false);
            if (nodeArr.Count != 0)
            {
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void BinaryInsertionSort()
        {
            yTuongTextBox.Clear();
            int left, right, m, i, pos;
            int x;
            Node nodeTam, nodeTam2;
            for (i = 1; i < nodeArr.Count; i++)
            {
                pos = i - 1;

                ChonDongChoCodeListBox(5);
                nodeArr[0].BackColor = ThamSo.MauNodeDaXetQua;
                bienArr["i"].Text = "i = " + i;
                bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode + 220, 12);
                bienArr["i"].Visible = true;
                nodeTam = nodeArr[i];
                x = nodeArr[i].giaTri;
                ChonDongChoCodeListBox(7);
                nodeArr[i].NodeUp();
                nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
                left = 0;
                right = i - 1;
                bienArr["left"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * left - 10, 203);
                bienArr["left"].Text = "l = " + left;
                bienArr["left"].Visible = true;

                bienArr["pos"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * pos - 10, 180);
                bienArr["pos"].Text = "pos = " + pos;
                bienArr["pos"].Visible = false;
                bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 180);
                bienArr["right"].Text = "r = " + right;
                bienArr["right"].Visible = true;
                ChonDongChoCodeListBox(8);

                while (left <= right)
                {
                    m = (left + right) / 2;

                    if (tangRadioButton.Checked == true)
                    {

                        if (x < nodeArr[m].giaTri)
                        {
                            ChonDongChoCodeListBox(11);
                            bienArr["m"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode + 480, 12);
                            bienArr["m"].Text = "m = " + m;
                            bienArr["m"].Visible = true;

                            bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 180);
                            bienArr["right"].Text = "r = " + right;
                            bienArr["right"].Visible = true;

                            right = m - 1;

                            bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 180);
                            bienArr["right"].Text = "r = " + right;
                            bienArr["right"].Visible = true;
                        }
                        else
                        {
                            ChonDongChoCodeListBox(12);
                            bienArr["m"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode + 480, 12);
                            bienArr["m"].Text = "m = " + m;
                            bienArr["m"].Visible = true;
                            left = m + 1;


                        }
                    }
                    else
                    {
                        if (x > nodeArr[m].giaTri)
                        {
                            ChonDongChoCodeListBox(11);
                            bienArr["m"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode + 480, 12);
                            bienArr["m"].Text = "m = " + m;
                            bienArr["m"].Visible = true;

                            bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 180);
                            bienArr["right"].Text = "r = " + right;
                            bienArr["right"].Visible = true;

                            right = m - 1;

                            bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 180);
                            bienArr["right"].Text = "r = " + right;
                            bienArr["right"].Visible = true;
                        }
                        else
                        {
                            ChonDongChoCodeListBox(12);
                            bienArr["m"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode + 480, 12);
                            bienArr["m"].Text = "m = " + m;
                            bienArr["m"].Visible = true;
                            left = m + 1;


                        }
                    }
                    ChonDongChoCodeListBox(8);
                    bienArr["left"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * left - 10, 203);
                    bienArr["left"].Text = "l = " + left;
                    bienArr["left"].Visible = true;

                }
                ChonDongChoCodeListBox(14);
                bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 180);
                bienArr["right"].Text = "r = " + right;
                bienArr["right"].Visible = false;
                pos = i - 1;
                bienArr["pos"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * pos - 10, 180);
                bienArr["pos"].Text = "pos = " + pos;
                bienArr["pos"].Visible = true;
                for (pos = i - 1; pos >= left; pos--)
                {
                    bienArr["pos"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * pos - 10, 180);
                    bienArr["pos"].Text = "pos = " + pos;
                    bienArr["pos"].Visible = true;

                    ChonDongChoCodeListBox(15);
                    nodeArr[pos].NodeRightLeft(pos + 1);
                    nodeArr[pos].vitriHienTai = pos + 1;
                    nodeTam2 = nodeArr[pos + 1];
                    nodeArr[pos + 1] = nodeArr[pos];
                    nodeArr[pos] = nodeTam2;



                }

                bienArr["pos"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * pos - 10, 180);
                bienArr["pos"].Text = "pos = " + pos;
                bienArr["pos"].Visible = true;

                ChonDongChoCodeListBox(16);
                nodeTam.NodeRightLeft(pos + 1);
                nodeTam.NodeDown();
                nodeArr[pos + 1] = nodeTam;
                nodeTam.vitriHienTai = pos + 1;
                nodeArr[pos + 1].BackColor = ThamSo.MauNodeDaXetQua;

                nodeArr[left].giaTri = x;

                //Cập nhật ý tưởng Text Box
                CapNhatYTuongTextBox(pos, i, "pos", "i");
            }
            SortRunOrStop(false);
            if (nodeArr.Count != 0)
            {
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void BubbleSort()
        {
            // Clear yTuongTextBox
            yTuongTextBox.Clear();

            ChonDongChoCodeListBox(4);
            int i = 0, j = 0;

            nodeArr[i].BackColor = ThamSo.MauNodeDaXetQua;
            bienArr["i"].Text = "i = " + i;
            bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, sortingPanel.Height - 50);
            bienArr["i"].Visible = true;

            for (i = 0; i < nodeArr.Count - 1; i++)
            {
                ChonDongChoCodeListBox(5);

                j = nodeArr.Count - 1;
                bienArr["j"].Text = "j = " + j;
                bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, sortingPanel.Height - 50);
                bienArr["j"].Visible = true;

                for (j = nodeArr.Count - 1; j > i; j--)
                {

                    //Đổi màu các Node đang xét
                    if (j != i)
                        nodeArr[j].BackColor = ThamSo.MauNodeDangXet;
                    nodeArr[j - 1].BackColor = ThamSo.MauNodeDangXet;

                    ChonDongChoCodeListBox(6);

                    bool thucHien = false; // dùng để xét tăng/giảm , nếu bằng true thì code sẽ chạy
                    if (tangRadioButton.Checked == true)
                    {
                        if (nodeArr[j].giaTri < nodeArr[j - 1].giaTri)
                            thucHien = true;
                    }
                    else
                    {
                        if (nodeArr[j].giaTri > nodeArr[j - 1].giaTri)
                            thucHien = true;
                    }
                    if (thucHien)
                    {
                        ChonDongChoCodeListBox(7);
                        HoanVi2Node(j, j - 1);
                        // Cập nhật trạng thái của mảng lên yTuongTextBox -- AppendText : thêm dòng mới rồi scroll textbox tới dòng vừa thêm
                        CapNhatYTuongTextBox(i, j, "i", "j");

                    }

                    if (j - 1 != i)
                    {

                        ChonDongChoCodeListBox(5);
                        bienArr["j"].Text = "j = " + (j - 1);
                        bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (j - 1), sortingPanel.Height - 50);

                    }
                    //Đổi màu Node đã xét qua
                    if (j != i)
                        nodeArr[j].BackColor = ThamSo.MauNenNode;
                }

                // Đổi màu các node đã xét qua
                nodeArr[i].BackColor = ThamSo.MauNodeDaXetQua;

                ChonDongChoCodeListBox(4);
                bienArr["i"].Text = "i = " + (i + 1);
                bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * (i + 1), sortingPanel.Height - 50);



                //Đổi màu Node cuối cùng
                if (i != nodeArr.Count)
                {
                    ChonDongChoCodeListBox(4);
                    nodeArr[i + 1].BackColor = ThamSo.MauNodeDaXetQua;
                }

            }


            ChonDongChoCodeListBox(4);
            // Đổi màu node i cuối
            nodeArr[nodeArr.Count - 1].BackColor = ThamSo.MauNodeDaXetQua;

            // Kết thúc
            SortRunOrStop(false);
            if (nodeArr.Count != 0)               // Nếu mảng bị huy trong lúc chạy thì k cần in ra kết quả
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void QuickSort()
        {
            yTuongTextBox.Clear();
            ThucHienQuickSort(0, nodeArr.Count - 1);
            SortRunOrStop(false);
            foreach (Node node in nodeArr)
            {
                node.BackColor = ThamSo.MauNodeDaXetQua;
            }
            if (nodeArr.Count != 0)
            {
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ThucHienQuickSort(int left, int right)
        {
            ChonDongChoCodeListBox(1);
            int i, j, x, vt_x;
            bienArr["left"].Text = "left = " + left;
            bienArr["left"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * left - 10, 32);
            bienArr["left"].BackColor = Color.Yellow;
            bienArr["left"].ForeColor = Color.DarkBlue;
            bienArr["left"].Visible = true;
            bienArr["left"].SendToBack();

            bienArr["right"].Text = "right = " + right;
            bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * right - 10, 12);
            bienArr["right"].BackColor = Color.Yellow;
            bienArr["right"].ForeColor = Color.DarkBlue;
            bienArr["right"].Visible = true;
            bienArr["right"].SendToBack();
            x = nodeArr[(left + right) / 2].giaTri;
            ChonDongChoCodeListBox(4);
            vt_x = (left + right) / 2;
            i = left; j = right;
            do
            {
                int z_vt_x = vt_x;
                if (tangRadioButton.Checked == true)
                {
                    ChonDongChoCodeListBox(8);
                    bienArr["vt_x"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * vt_x - 10, 188);
                    bienArr["vt_x"].Text = "x = a[" + vt_x + "]";
                    nodeArr[vt_x].BackColor = Color.Yellow;
                    nodeArr[vt_x].ForeColor = Color.Blue;
                    bienArr["vt_x"].Visible = true;
                    bienArr["vt_x"].SendToBack();

                    bienArr["i"].Text = "i = " + i;
                    bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, 208);
                    nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
                    nodeArr[i].ForeColor = Color.Red;
                    bienArr["i"].Visible = true;
                    bienArr["i"].SendToBack();

                    bienArr["j"].Text = "j = " + j;
                    bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, 208);
                    nodeArr[j].BackColor = ThamSo.MauNodeDangXet;
                    nodeArr[j].ForeColor = Color.Red;
                    bienArr["j"].Visible = true;
                    bienArr["j"].SendToBack();
                    while (nodeArr[i].giaTri < x)
                    {
                        ChonDongChoCodeListBox(9);
                        int f_i = i;
                        i++;
                        bienArr["i"].Text = "i = " + i;
                        bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, 208);
                        nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
                        nodeArr[i].ForeColor = Color.Red;
                        nodeArr[f_i].BackColor = Color.White;
                        nodeArr[f_i].ForeColor = Color.Purple;
                        bienArr["i"].Visible = true;
                        bienArr["i"].SendToBack();
                    }
                    ChonDongChoCodeListBox(10);
                    while (nodeArr[j].giaTri > x)
                    {
                        ChonDongChoCodeListBox(11);
                        int f_j = j;
                        j--;
                        bienArr["j"].Text = "j = " + j;
                        bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, 208);
                        nodeArr[j].BackColor = ThamSo.MauNodeDangXet;
                        nodeArr[j].ForeColor = Color.Red;
                        nodeArr[f_j].BackColor = Color.White;
                        nodeArr[f_j].ForeColor = Color.Purple;
                        bienArr["j"].Visible = true;
                        bienArr["j"].SendToBack();
                    }
                }
                else
                {
                    ChonDongChoCodeListBox(8);
                    bienArr["vt_x"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * vt_x - 10, 188);
                    bienArr["vt_x"].Text = "x = a[" + vt_x + "]";
                    nodeArr[vt_x].BackColor = Color.Yellow;
                    nodeArr[vt_x].ForeColor = Color.Blue;
                    bienArr["vt_x"].Visible = true;
                    bienArr["vt_x"].SendToBack();

                    bienArr["i"].Text = "i = " + i;
                    bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, 208);
                    nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
                    nodeArr[i].ForeColor = Color.Red;
                    bienArr["i"].Visible = true;
                    bienArr["i"].SendToBack();

                    bienArr["j"].Text = "j = " + j;
                    bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, 208);
                    nodeArr[j].BackColor = ThamSo.MauNodeDangXet;
                    nodeArr[j].ForeColor = Color.Red;
                    bienArr["j"].Visible = true;
                    bienArr["j"].SendToBack();
                    while (nodeArr[i].giaTri > x)
                    {
                        ChonDongChoCodeListBox(9);
                        int f_i = i;
                        i++;
                        bienArr["i"].Text = "i = " + i;
                        bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, 208);
                        nodeArr[i].BackColor = ThamSo.MauNodeDangXet;
                        nodeArr[i].ForeColor = Color.Red;
                        nodeArr[f_i].BackColor = Color.White;
                        nodeArr[f_i].ForeColor = Color.Purple;
                        bienArr["i"].Visible = true;
                        bienArr["i"].SendToBack();
                    }
                    ChonDongChoCodeListBox(10);
                    while (nodeArr[j].giaTri < x)
                    {
                        ChonDongChoCodeListBox(11);
                        int f_j = j;
                        j--;
                        bienArr["j"].Text = "j = " + j;
                        bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, 208);
                        nodeArr[j].BackColor = ThamSo.MauNodeDangXet;
                        nodeArr[j].ForeColor = Color.Red;
                        nodeArr[f_j].BackColor = Color.White;
                        nodeArr[f_j].ForeColor = Color.Purple;
                        bienArr["j"].Visible = true;
                        bienArr["j"].SendToBack();
                    }
                }
                ChonDongChoCodeListBox(12);
                if (i <= j)
                {
                    int f_vt_x = vt_x;
                    if (i == vt_x)
                    {
                        vt_x = j;
                    }
                    else if (j == vt_x)
                    {
                        vt_x = i;
                    }
                    ChonDongChoCodeListBox(14);
                    HoanVi2Node(i, j);
                    nodeArr[i].BackColor = Color.White;
                    nodeArr[i].ForeColor = Color.Purple;
                    nodeArr[j].BackColor = Color.White;
                    nodeArr[j].ForeColor = Color.Purple;
                    bienArr["vt_x"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * vt_x - 10, 188);
                    bienArr["vt_x"].Text = "x = a[" + vt_x + "]";
                    nodeArr[vt_x].BackColor = Color.Yellow;
                    nodeArr[vt_x].ForeColor = Color.Blue;
                    nodeArr[f_vt_x].BackColor = Color.White;
                    nodeArr[f_vt_x].ForeColor = Color.Purple;
                    bienArr["vt_x"].Visible = true;
                    bienArr["vt_x"].SendToBack();
                    i++; j--;
                }
                nodeArr[z_vt_x].BackColor = Color.White;
                nodeArr[z_vt_x].ForeColor = Color.Purple;
                nodeArr[i].BackColor = Color.White;
                nodeArr[i].ForeColor = Color.Purple;
                if (j != -1)
                {
                    nodeArr[j].BackColor = Color.White;
                    nodeArr[j].ForeColor = Color.Purple;
                }
                CapNhatYTuongTextBox(i, j, "i", "j");
                ChonDongChoCodeListBox(17);
            } while (i <= j);
            ChonDongChoCodeListBox(18);
            if (left < j)
            {
                ChonDongChoCodeListBox(19);
                ThucHienQuickSort(left, j);
            }
            ChonDongChoCodeListBox(20);
            if (i < right)
            {
                ChonDongChoCodeListBox(21);
                ThucHienQuickSort(i, right);
            }
        }


        public void HeapSort()
        {
            yTuongTextBox.Clear();

            ChonDongChoCodeListBox(1);
            ChonDongChoCodeListBox(2);
            ChonDongChoCodeListBox(3);
            CreateHeap(nodeArr.Count);

            ChonDongChoCodeListBox(4);
            ChonDongChoCodeListBox(5);
            int r = nodeArr.Count - 1;

            ChonDongChoCodeListBox(6);
            while (r > 0)
            {
                ChonDongChoCodeListBox(7);
                ChonDongChoCodeListBox(8);
                HoanVi2Node(0, r);
                Task.WaitAll(hoanVi1Task, hoanVi2Task);

                ChonDongChoCodeListBox(9);
                bienArr["right"].Text = "right = " + r;
                bienArr["right"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * r - 10, 12);
                bienArr["right"].Visible = true;
                bienArr["right"].SendToBack();
                nodeArr[r].BackColor = ThamSo.MauNodeDaXetQua;
                r--;


                ChonDongChoCodeListBox(10);
                if (r > 0)
                {
                    ChonDongChoCodeListBox(11);
                    Shift(0, r);
                }

                ChonDongChoCodeListBox(12);
                ChonDongChoCodeListBox(6);
            }
            ChonDongChoCodeListBox(13);

            SortRunOrStop(false);
            foreach (Node node in nodeArr)
            {
                node.BackColor = ThamSo.MauNodeDaXetQua;
            }
            if (nodeArr.Count != 0)
            {
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CreateHeap(int N)
        {
            ChonDongChoCodeListBox(15);
            ChonDongChoCodeListBox(16);
            ChonDongChoCodeListBox(17);
            ChonDongChoCodeListBox(18);
            int l = N / 2 - 1;

            ChonDongChoCodeListBox(19);
            while (l >= 0)
            {
                ChonDongChoCodeListBox(20);
                ChonDongChoCodeListBox(21);
                Shift(l, N - 1);

                ChonDongChoCodeListBox(22);
                bienArr["left"].Text = "left = " + l;
                bienArr["left"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * l - 10, 32);
                bienArr["left"].Visible = true;
                bienArr["left"].SendToBack();
                l--;

                ChonDongChoCodeListBox(23);
                ChonDongChoCodeListBox(19);
            }

            ChonDongChoCodeListBox(24);
        }
        private void Shift(int l, int r)
        {
            ChonDongChoCodeListBox(26);
            ChonDongChoCodeListBox(27);
            ChonDongChoCodeListBox(28);
            ChonDongChoCodeListBox(29);
            int i = l;
            int j = 2 * i + 1;

            ChonDongChoCodeListBox(30);
            while (j <= r)
            {
                ChonDongChoCodeListBox(31);
                ChonDongChoCodeListBox(32);
                if (tangRadioButton.Checked == true)
                {
                    if (j < r && nodeArr[j].giaTri < nodeArr[j + 1].giaTri)
                    {
                        ChonDongChoCodeListBox(33);
                        j++;
                    }
                }
                else
                {
                    if (j < r && nodeArr[j].giaTri > nodeArr[j + 1].giaTri)
                    {
                        ChonDongChoCodeListBox(33);
                        j++;
                    }
                }

                ChonDongChoCodeListBox(34);
                if (tangRadioButton.Checked == true)
                {
                    if (nodeArr[i].giaTri < nodeArr[j].giaTri)
                    {
                        ChonDongChoCodeListBox(35);
                        ChonDongChoCodeListBox(36);
                        HoanVi2Node(i, j);
                        Task.WaitAll(hoanVi1Task, hoanVi2Task);
                        CapNhatYTuongTextBox(i, j, "i", "j");

                        ChonDongChoCodeListBox(37);
                        i = j;

                        ChonDongChoCodeListBox(38);
                        j = 2 * i + 1;

                        ChonDongChoCodeListBox(39);
                    }
                    else
                    {
                        ChonDongChoCodeListBox(40);
                        return;
                    }
                }
                else
                {
                    if (nodeArr[i].giaTri > nodeArr[j].giaTri)
                    {
                        ChonDongChoCodeListBox(35);
                        ChonDongChoCodeListBox(36);
                        HoanVi2Node(i, j);
                        Task.WaitAll(hoanVi1Task, hoanVi2Task);
                        CapNhatYTuongTextBox(i, j, "i", "j");

                        ChonDongChoCodeListBox(37);
                        i = j;

                        ChonDongChoCodeListBox(38);
                        j = 2 * i + 1;

                        ChonDongChoCodeListBox(39);
                    }
                    else
                    {
                        ChonDongChoCodeListBox(40);
                        return;
                    }
                }

                ChonDongChoCodeListBox(41);
                ChonDongChoCodeListBox(30);
            }
            ChonDongChoCodeListBox(42);
        }


        public void ShellSort()
        {
            yTuongTextBox.Clear();

            ChonDongChoCodeListBox(1);
            ChonDongChoCodeListBox(2);
            ChonDongChoCodeListBox(3);
            for (int gap = nodeArr.Count / 2; gap > 0; gap /= 2)
            {
                bienArr["gap"].Text = "gap = " + gap;
                bienArr["gap"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * 0, 10);
                bienArr["gap"].SendToBack();
                bienArr["gap"].Visible = true;

                ChonDongChoCodeListBox(4);
                ChonDongChoCodeListBox(5);
                for (int i = gap; i < nodeArr.Count; i++)
                {
                    bienArr["i"].Text = "i = " + i;
                    bienArr["i"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * i, sortingPanel.Height - 50);
                    bienArr["i"].Visible = true;

                    ChonDongChoCodeListBox(6);
                    ChonDongChoCodeListBox(7);
                    for (int j = i; j >= gap; j -= gap)
                    {
                        bienArr["j"].Text = "j = " + j;
                        bienArr["j"].Location = new Point(root.X + ThamSo.KhoangCachGiuaCacNode * j, sortingPanel.Height - 70);
                        bienArr["j"].SendToBack();
                        bienArr["j"].Visible = true;
                        nodeArr[j].BackColor = ThamSo.MauNodeDangXet;
                        nodeArr[j - gap].BackColor = Color.Gray;

                        if (tangRadioButton.Checked == true)
                        {
                            if (nodeArr[j].giaTri < nodeArr[j - gap].giaTri)
                            {
                                ChonDongChoCodeListBox(8);
                                ChonDongChoCodeListBox(9);
                                HoanVi2Node(j, j - gap);
                                Task.WaitAll(hoanVi1Task, hoanVi2Task);
                                CapNhatYTuongTextBox(i, j, "i", "j");

                                ChonDongChoCodeListBox(10);
                                ChonDongChoCodeListBox(7);
                            }
                        }
                        else
                        {
                            if (nodeArr[j].giaTri > nodeArr[j - gap].giaTri)
                            {
                                ChonDongChoCodeListBox(8);
                                ChonDongChoCodeListBox(9);
                                HoanVi2Node(j, j - gap);
                                Task.WaitAll(hoanVi1Task, hoanVi2Task);
                                CapNhatYTuongTextBox(i, j, "i", "j");

                                ChonDongChoCodeListBox(10);
                                ChonDongChoCodeListBox(7);
                            }
                        }

                        nodeArr[j].BackColor = ThamSo.MauNenNode;
                        nodeArr[j - gap].BackColor = ThamSo.MauNenNode;
                    }
                    ChonDongChoCodeListBox(11);
                    ChonDongChoCodeListBox(5);
                }
                ChonDongChoCodeListBox(12);
                ChonDongChoCodeListBox(3);
            }
            ChonDongChoCodeListBox(13);

            SortRunOrStop(false);
            foreach (Node node in nodeArr)
            {
                node.BackColor = ThamSo.MauNodeDaXetQua;
            }

            if (nodeArr.Count != 0)
            {
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        List<Node> b = new List<Node>();
        List<Node> c = new List<Node>();
        int nb, nc;
        int Min(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }
        void Distribute(List<Node> a, int N, ref int nb, ref int nc, int k)
        {
            int i, pa, pb, pc;
            pa = pb = pc = 0;
            ChonDongChoCodeListBox(11);
            while (pa < N)
            {
                ChonDongChoCodeListBox(13);
                for (i = 0; (pa < N) && (i < k); i++, pa++, pb++)
                {
                    ChonDongChoCodeListBox(14);
                    //b[pb] = a[pa];
                    a[pa].BackColor = ThamSo.MauNodeDangXet;
                    a[pa].NodeUp();
                    a[pa].NodeRightLeft(pb);
                    a[pa].vitriHienTai = pb;

                    b[pb] = a[pa];

                    ChonDongChoCodeListBox(13);
                }
                ChonDongChoCodeListBox(13);

                ChonDongChoCodeListBox(15);
                for (i = 0; (pa < N) && (i < k); i++, pa++, pc++)
                {
                    ChonDongChoCodeListBox(16);
                    //c[pc] = a[pa];
                    a[pa].BackColor = Color.LightYellow;
                    a[pa].NodeDown();
                    a[pa].NodeRightLeft(pc);
                    a[pa].vitriHienTai = pc;

                    c[pc] = a[pa];

                    ChonDongChoCodeListBox(15);
                }
                ChonDongChoCodeListBox(15);

                ChonDongChoCodeListBox(11);
            }
            ChonDongChoCodeListBox(11);
            nb = pb; nc = pc;
        }
        void Merge(List<Node> a, int nb, int nc, int k)
        {
            int p, pb, pc, ib, ic, kb, kc;
            p = pb = pc = 0; ib = ic = 0;

            ChonDongChoCodeListBox(24);
            while ((nb > 0) && (nc > 0))
            {
                kb = Min(k, nb);
                kc = Min(k, nc);

                ChonDongChoCodeListBox(27);

                bool thucHien = false; // dùng để xét tăng/giảm , nếu bằng true thì code sẽ chạy
                if (tangRadioButton.Checked == true)
                {
                    if (c[pc + ic].giaTri >= b[pb + ib].giaTri)
                        thucHien = true;
                }
                else
                {
                    if (c[pc + ic].giaTri <= b[pb + ib].giaTri)
                        thucHien = true;
                }
                if (thucHien)
                {
                    ChonDongChoCodeListBox(29);
                    //a[p++] = b[pb + ib];
                    b[pb + ib].BackColor = ThamSo.MauNenNode;
                    b[pb + ib].NodeDown();
                    b[pb + ib].NodeRightLeft(p);
                    b[pb + ib].vitriHienTai = p;

                    a[p] = b[pb + ib];
                    p = p + 1;

                    ib++;

                    ChonDongChoCodeListBox(30);
                    if (ib == kb)
                    {
                        ChonDongChoCodeListBox(32);
                        for (; ic < kc; ic++)
                        {
                            ChonDongChoCodeListBox(33);
                            //a[p++] = c[pc + ic];
                            c[pc + ic].BackColor = ThamSo.MauNenNode;
                            c[pc + ic].NodeUp();
                            c[pc + ic].NodeRightLeft(p);
                            c[pc + ic].vitriHienTai = p;

                            a[p] = c[pc + ic];
                            p = p + 1;

                            ChonDongChoCodeListBox(32);
                        }
                        ChonDongChoCodeListBox(32);

                        pb += kb; pc += kc; ib = ic = 0;
                        nb -= kb; nc -= kc;
                    }
                }
                else
                {
                    ChonDongChoCodeListBox(40);
                    //a[p++] = c[pc + ic];
                    c[pc + ic].BackColor = ThamSo.MauNenNode;
                    c[pc + ic].NodeUp();
                    c[pc + ic].NodeRightLeft(p);
                    c[pc + ic].vitriHienTai = p;

                    a[p] = c[pc + ic];
                    p = p + 1;

                    ic++;

                    ChonDongChoCodeListBox(41);
                    if (ic == kc)
                    {
                        ChonDongChoCodeListBox(43);
                        for (; ib < kb; ib++)
                        {
                            ChonDongChoCodeListBox(44);
                            //a[p++] = b[pb + ib];
                            b[pb + ib].BackColor = ThamSo.MauNenNode;
                            b[pb + ib].NodeDown();
                            b[pb + ib].NodeRightLeft(p);
                            b[pb + ib].vitriHienTai = p;


                            a[p] = b[pb + ib];
                            p = p + 1;

                            ChonDongChoCodeListBox(43);
                        }
                        ChonDongChoCodeListBox(43);

                        pb += kb; pc += kc; ib = ic = 0;
                        nb -= kb; nc -= kc;
                    }
                }

                ChonDongChoCodeListBox(24);
            }  // while
            ChonDongChoCodeListBox(24);

            if (a.Count % 2 == 1 && (k != (a.Count - 1)))
            {
                if (nb > nc)
                {
                    ChonDongChoCodeListBox(44);
                    b[pb].BackColor = ThamSo.MauNenNode;
                    b[pb].NodeDown();
                    b[pb].NodeRightLeft(a.Count - 1);
                    b[pb].vitriHienTai = a.Count - 1;

                }

            }
            if (a.Count % 2 == 0 && Math.Abs(nb - nc) == 2)
            {

                ChonDongChoCodeListBox(44);
                b[pb].BackColor = ThamSo.MauNenNode;
                b[pb].NodeDown();
                b[pb].NodeRightLeft(a.Count - 2);
                b[pb].vitriHienTai = a.Count - 2;

                ChonDongChoCodeListBox(44);
                b[pb + 1].BackColor = ThamSo.MauNenNode;
                b[pb + 1].NodeDown();
                b[pb + 1].NodeRightLeft(a.Count - 1);
                b[pb + 1].vitriHienTai = a.Count - 1;


            }

            ;
        }
        void ThucHienMergeSort(List<Node> a, int N)
        {
            for (int i = 0; i < int.Parse(soPhanTuTextBox.Text); i++)
            {
                b.Add(new Node(i, 0));
                c.Add(new Node(i, 0));
            }
            int k;

            ChonDongChoCodeListBox(54);
            for (k = 1; k < N; k *= 2)
            {
                bienArr["k"].Location = new Point(root.X + 420, 11);
                bienArr["k"].Text = "k = " + k;
                bienArr["k"].Visible = true;
                ChonDongChoCodeListBox(56);
                Distribute(a, N, ref nb, ref nc, k);

                ChonDongChoCodeListBox(57);
                Merge(a, nb, nc, k);

                ChonDongChoCodeListBox(54);
            }
            ChonDongChoCodeListBox(54);
        }

        




        /*
private void InitializeComponent()
{
   this.SuspendLayout();
   // 
   // MainFormExtend
   // 
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Name = "MainFormExtend";
   this.Text = "MainFormExtend";
   this.ResumeLayout(false);

}*/

        void MergeSort()
        {
            yTuongTextBox.Clear();

            bienArr["a:"].Location = new Point(0, root.Y - 5);
            bienArr["b:"].Location = new Point(0, root.Y - ThamSo.KhoangCachTrenDuoiNode - 5);
            bienArr["c:"].Location = new Point(0, root.Y + ThamSo.KhoangCachTrenDuoiNode - 5);
            bienArr["a:"].Text = "a:";
            bienArr["b:"].Text = "b:";
            bienArr["c:"].Text = "c:";
            bienArr["a:"].SendToBack();
            bienArr["b:"].SendToBack();
            bienArr["c:"].SendToBack();
            bienArr["a:"].Visible = bienArr["b:"].Visible = bienArr["c:"].Visible = true;


            ChonDongChoCodeListBox(51);
            ThucHienMergeSort(nodeArr, nodeArr.Count);

            foreach (Node node in nodeArr)
            {
                node.BackColor = ThamSo.MauNodeDaXetQua;
            }

            SortRunOrStop(false);
            if (nodeArr.Count != 0)               // Nếu mảng bị huy trong lúc chạy thì k cần in ra kết quả
                MessageBox.Show("Sắp xếp hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #endregion
        
        #region Button
        public int couterbutton = 0;
        private void taoNgauNghienButton_Click(object sender, EventArgs e)
        {

            if (couterbutton == 0)
            {
                XoaMang();
                gtbd_textBox.Enabled = gtkt_textBox.Enabled = true;
                gtbd_textBox.Text = gtkt_textBox.Text = "0";
                taoNgauNghienButton.Text = "Tiếp tục";
            }
            if (couterbutton == 1)
            {
                taoNgauNghienButton.Text = "Tạo Ngẫu Nhiên";
                
                if (int.Parse(gtbd_textBox.Text) == 0 && int.Parse(gtkt_textBox.Text) == 0)
                {
                    TaoMangNgauNhien(int.Parse(soPhanTuTextBox.Text));
                    gtbd_textBox.Text = "0";
                    gtkt_textBox.Text = "99";
                    gtbd_textBox.Enabled = gtkt_textBox.Enabled = false;
                    couterbutton = 0;
                    return;
                }
                else
                {
                    TaoMangNgauNhien2(int.Parse(soPhanTuTextBox.Text), int.Parse(gtbd_textBox.Text), int.Parse(gtkt_textBox.Text));
                    gtbd_textBox.Enabled = gtkt_textBox.Enabled = false;
                    couterbutton = -1;
                }
            }
            couterbutton += 1;
        }

        private void nhapTayButton_Click(object sender, EventArgs e)
        {
            NhapTay(int.Parse(soPhanTuTextBox.Text));
        }

        private void nhapMotDayButton_Click(object sender, EventArgs e)
        {
            NhapMang nhapMotDayForm = new NhapMang();
            DialogResult rs = nhapMotDayForm.ShowDialog();
            if (rs == DialogResult.OK)
            {
                soPhanTuTextBox.Text = nhapMotDayForm.dayCanNhap.Count.ToString();
                NhapMotDay(nhapMotDayForm.dayCanNhap);

            }
        }

        private void destroyButton_Click(object sender, EventArgs e)
        {
            XoaMang();
            batDauButton.Enabled = false;
        }

        private void batDauButton_Click(object sender, EventArgs e)
        {
            BatDauSapXep();
        }

        private void tamDungButton_Click(object sender, EventArgs e)
        {
            TamDung();
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            HuyQuaTrinh(nodeArr.Count);
        }
        #endregion

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void soPhanTuTextBox_TextChanged(object sender, EventArgs e)
        {
            if (soPhanTuTextBox.Text != "")
            {
                int soPhanTu = int.Parse(soPhanTuTextBox.Text);
                if (mergeSortRadioButton.Checked == true && soPhanTu > 10)
                {
                    soPhanTuTextBox.Text = "10";
                }
                if (soPhanTu > ThamSo.SoLuongNodeToiDa)
                {
                    soPhanTuTextBox.Text = ThamSo.SoLuongNodeToiDa.ToString();
                }
            }
        }

        private void soPhanTuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void speedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ThamSo.TocDo = speedTrackBar.Maximum - speedTrackBar.Value;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            soPhanTuTextBox.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    if (nodeArr.Count == 0)
                    {
                        taoNgauNghienButton.PerformClick();
                        return true;
                    }
                    else
                    {
                        batDauButton.PerformClick();
                        return true;
                    }
                case Keys.F1:
                    taoNgauNghienButton.PerformClick();
                    return true;
                case Keys.F2:
                    nhapTayButton.PerformClick();
                    return true;
                case Keys.F3:
                    nhapMotDayButton.PerformClick();
                    return true;
                case Keys.F4:
                    batDauButton.PerformClick();
                    return true;
                case Keys.F5:
                    tamDungButton.PerformClick();
                    return true;
                case Keys.F6:
                    destroyButton.PerformClick();
                    return true;

                case Keys.F7:
                    huyButton.PerformClick();
                    return true;
                case Keys.Escape:
                    this.Close();
                    return true;
                case Keys.Up:
                    if (speedTrackBar.Value < speedTrackBar.Maximum)
                        speedTrackBar.Value += 1;
                    return true;
                case Keys.Down:
                    if (speedTrackBar.Value > speedTrackBar.Minimum)
                        speedTrackBar.Value -= 1;
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                CapNhatYTuongVaCode();
            }

        }

        private void unsortedPanel_MouseClick(object sender, MouseEventArgs e)
        {
            batDauButton.Focus();
        }

        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinPhanMem frmThongTinPhanMem = new ThongTinPhanMem();
            frmThongTinPhanMem.Show();
        }

        private void thoiGianChayTimer_Tick(object sender, EventArgs e)
        {
            if (int.Parse(thoiGianChay_GiayLabel.Text) == 59)
            {
                thoiGianChay_GiayLabel.Text = "00";
                thoiGianChay_PhutLabel.Text = (int.Parse(thoiGianChay_PhutLabel.Text) + 1).ToString("00");
            }
            else
            {
                thoiGianChay_GiayLabel.Text = (int.Parse(thoiGianChay_GiayLabel.Text) + 1).ToString("00");
            }
        }
    }
    public class MySR : ToolStripSystemRenderer
    {
        public MySR() { }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

        }
    }
}
