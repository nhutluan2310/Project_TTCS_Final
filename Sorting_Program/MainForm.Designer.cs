using System.Windows.Forms;

namespace Sorting_Program
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            DialogResult NB = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (NB == DialogResult.No)
            {
                return;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingPanel = new System.Windows.Forms.Panel();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.unsortedPanel = new System.Windows.Forms.Panel();
            this.originalLabel = new System.Windows.Forms.Label();
            this.codePanel = new System.Windows.Forms.Panel();
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.initializationPanel = new System.Windows.Forms.Panel();
            this.destroyButton = new System.Windows.Forms.Button();
            this.nhapMotDayButton = new System.Windows.Forms.Button();
            this.nhapTayButton = new System.Windows.Forms.Button();
            this.taoNgauNghienButton = new System.Windows.Forms.Button();
            this.soPhanTuTextBox = new System.Windows.Forms.TextBox();
            this.soPhanTuLabel = new System.Windows.Forms.Label();
            this.initializationLabel = new System.Windows.Forms.Label();
            this.SpeedPanel = new System.Windows.Forms.Panel();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.directionPanel = new System.Windows.Forms.Panel();
            this.giamRadioButton = new System.Windows.Forms.RadioButton();
            this.tangRadioButton = new System.Windows.Forms.RadioButton();
            this.directionLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.thoiGianChay_GiayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thoiGianChay_PhutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.huyButton = new System.Windows.Forms.Button();
            this.tamDungButton = new System.Windows.Forms.Button();
            this.batDauButton = new System.Windows.Forms.Button();
            this.controlLabel = new System.Windows.Forms.Label();
            this.sortPanel = new System.Windows.Forms.Panel();
            this.heapSortRadioButton = new System.Windows.Forms.RadioButton();
            this.quickSortRadioButton = new System.Windows.Forms.RadioButton();
            this.shakerSortRadioButton = new System.Windows.Forms.RadioButton();
            this.shellSortRadioButton = new System.Windows.Forms.RadioButton();
            this.selectionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.mergeSortRadioButton = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadioButton = new System.Windows.Forms.RadioButton();
            this.insertionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.interchangeSortRadioButton = new System.Windows.Forms.RadioButton();
            this.sortLabel = new System.Windows.Forms.Label();
            this.statePanel = new System.Windows.Forms.Panel();
            this.stateLabel = new System.Windows.Forms.Label();
            this.yTuongTextBox = new System.Windows.Forms.TextBox();
            this.thoiGianChayTimer = new System.Windows.Forms.Timer(this.components);
            this.gtbd_textBox = new System.Windows.Forms.TextBox();
            this.gtkt_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.unsortedPanel.SuspendLayout();
            this.codePanel.SuspendLayout();
            this.initializationPanel.SuspendLayout();
            this.SpeedPanel.SuspendLayout();
            this.directionPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.sortPanel.SuspendLayout();
            this.statePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropertiesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip.TabIndex = 23;
            this.menuStrip.Text = "Thanh Menu";
            // 
            // PropertiesToolStripMenuItem
            // 
            this.PropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.PropertiesToolStripMenuItem.Text = "Thông tin phần mềm";
            this.PropertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // sortingPanel
            // 
            this.sortingPanel.Location = new System.Drawing.Point(0, 27);
            this.sortingPanel.Name = "sortingPanel";
            this.sortingPanel.Size = new System.Drawing.Size(1173, 255);
            this.sortingPanel.TabIndex = 21;
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.LargeChange = 1;
            this.speedTrackBar.Location = new System.Drawing.Point(8, 36);
            this.speedTrackBar.Maximum = 0;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speedTrackBar.Size = new System.Drawing.Size(222, 45);
            this.speedTrackBar.TabIndex = 22;
            this.speedTrackBar.TickFrequency = 10;
            this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            this.speedTrackBar.ValueChanged += new System.EventHandler(this.speedTrackBar_ValueChanged);
            // 
            // unsortedPanel
            // 
            this.unsortedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.unsortedPanel.Controls.Add(this.originalLabel);
            this.unsortedPanel.Location = new System.Drawing.Point(8, 289);
            this.unsortedPanel.Name = "unsortedPanel";
            this.unsortedPanel.Size = new System.Drawing.Size(799, 100);
            this.unsortedPanel.TabIndex = 19;
            this.unsortedPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.unsortedPanel_MouseClick);
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.BackColor = System.Drawing.Color.Transparent;
            this.originalLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.originalLabel.Location = new System.Drawing.Point(4, 4);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(122, 18);
            this.originalLabel.TabIndex = 99;
            this.originalLabel.Text = "Dãy chưa sắp xếp";
            // 
            // codePanel
            // 
            this.codePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.codePanel.Controls.Add(this.codeListBox);
            this.codePanel.Controls.Add(this.codeLabel);
            this.codePanel.Location = new System.Drawing.Point(814, 396);
            this.codePanel.Name = "codePanel";
            this.codePanel.Size = new System.Drawing.Size(351, 325);
            this.codePanel.TabIndex = 18;
            // 
            // codeListBox
            // 
            this.codeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.codeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeListBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.codeListBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 19;
            this.codeListBox.Location = new System.Drawing.Point(8, 31);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.Size = new System.Drawing.Size(335, 285);
            this.codeListBox.TabIndex = 100;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.codeLabel.Location = new System.Drawing.Point(4, 4);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(68, 18);
            this.codeLabel.TabIndex = 99;
            this.codeLabel.Text = "Code C++";
            // 
            // initializationPanel
            // 
            this.initializationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.initializationPanel.Controls.Add(this.gtkt_textBox);
            this.initializationPanel.Controls.Add(this.gtbd_textBox);
            this.initializationPanel.Controls.Add(this.destroyButton);
            this.initializationPanel.Controls.Add(this.nhapMotDayButton);
            this.initializationPanel.Controls.Add(this.nhapTayButton);
            this.initializationPanel.Controls.Add(this.taoNgauNghienButton);
            this.initializationPanel.Controls.Add(this.soPhanTuTextBox);
            this.initializationPanel.Controls.Add(this.soPhanTuLabel);
            this.initializationPanel.Controls.Add(this.initializationLabel);
            this.initializationPanel.Location = new System.Drawing.Point(8, 396);
            this.initializationPanel.Name = "initializationPanel";
            this.initializationPanel.Size = new System.Drawing.Size(298, 199);
            this.initializationPanel.TabIndex = 14;
            // 
            // destroyButton
            // 
            this.destroyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.destroyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destroyButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destroyButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.destroyButton.Location = new System.Drawing.Point(156, 132);
            this.destroyButton.Name = "destroyButton";
            this.destroyButton.Size = new System.Drawing.Size(112, 42);
            this.destroyButton.TabIndex = 4;
            this.destroyButton.Text = "Xóa mảng";
            this.destroyButton.UseVisualStyleBackColor = false;
            this.destroyButton.Click += new System.EventHandler(this.destroyButton_Click);
            // 
            // nhapMotDayButton
            // 
            this.nhapMotDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nhapMotDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhapMotDayButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapMotDayButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.nhapMotDayButton.Location = new System.Drawing.Point(27, 132);
            this.nhapMotDayButton.Name = "nhapMotDayButton";
            this.nhapMotDayButton.Size = new System.Drawing.Size(112, 42);
            this.nhapMotDayButton.TabIndex = 100;
            this.nhapMotDayButton.Text = "Nhập một dãy";
            this.nhapMotDayButton.UseVisualStyleBackColor = false;
            this.nhapMotDayButton.Click += new System.EventHandler(this.nhapMotDayButton_Click);
            // 
            // nhapTayButton
            // 
            this.nhapTayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nhapTayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhapTayButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapTayButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.nhapTayButton.Location = new System.Drawing.Point(156, 74);
            this.nhapTayButton.Name = "nhapTayButton";
            this.nhapTayButton.Size = new System.Drawing.Size(112, 42);
            this.nhapTayButton.TabIndex = 33;
            this.nhapTayButton.Text = "Nhập bằng tay";
            this.nhapTayButton.UseVisualStyleBackColor = false;
            this.nhapTayButton.Click += new System.EventHandler(this.nhapTayButton_Click);
            // 
            // taoNgauNghienButton
            // 
            this.taoNgauNghienButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.taoNgauNghienButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taoNgauNghienButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taoNgauNghienButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.taoNgauNghienButton.Location = new System.Drawing.Point(27, 74);
            this.taoNgauNghienButton.Name = "taoNgauNghienButton";
            this.taoNgauNghienButton.Size = new System.Drawing.Size(112, 42);
            this.taoNgauNghienButton.TabIndex = 30;
            this.taoNgauNghienButton.Text = "Tạo ngẫu nhiên";
            this.taoNgauNghienButton.UseVisualStyleBackColor = false;
            this.taoNgauNghienButton.Click += new System.EventHandler(this.taoNgauNghienButton_Click);
            // 
            // soPhanTuTextBox
            // 
            this.soPhanTuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soPhanTuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soPhanTuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soPhanTuTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.soPhanTuTextBox.Location = new System.Drawing.Point(122, 33);
            this.soPhanTuTextBox.MaxLength = 2;
            this.soPhanTuTextBox.Name = "soPhanTuTextBox";
            this.soPhanTuTextBox.Size = new System.Drawing.Size(49, 26);
            this.soPhanTuTextBox.TabIndex = 0;
            this.soPhanTuTextBox.Text = "10";
            this.soPhanTuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.soPhanTuTextBox.TextChanged += new System.EventHandler(this.soPhanTuTextBox_TextChanged);
            this.soPhanTuTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soPhanTuTextBox_KeyPress);
            // 
            // soPhanTuLabel
            // 
            this.soPhanTuLabel.AutoSize = true;
            this.soPhanTuLabel.BackColor = System.Drawing.Color.Transparent;
            this.soPhanTuLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soPhanTuLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.soPhanTuLabel.Location = new System.Drawing.Point(29, 36);
            this.soPhanTuLabel.Name = "soPhanTuLabel";
            this.soPhanTuLabel.Size = new System.Drawing.Size(87, 19);
            this.soPhanTuLabel.TabIndex = 99;
            this.soPhanTuLabel.Text = "Số phần tử:";
            // 
            // initializationLabel
            // 
            this.initializationLabel.AutoSize = true;
            this.initializationLabel.BackColor = System.Drawing.Color.Transparent;
            this.initializationLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializationLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.initializationLabel.Location = new System.Drawing.Point(6, 7);
            this.initializationLabel.Name = "initializationLabel";
            this.initializationLabel.Size = new System.Drawing.Size(63, 18);
            this.initializationLabel.TabIndex = 99;
            this.initializationLabel.Text = "Khởi tạo";
            // 
            // SpeedPanel
            // 
            this.SpeedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SpeedPanel.Controls.Add(this.speedTrackBar);
            this.SpeedPanel.Controls.Add(this.SpeedLabel);
            this.SpeedPanel.Location = new System.Drawing.Point(814, 289);
            this.SpeedPanel.Name = "SpeedPanel";
            this.SpeedPanel.Size = new System.Drawing.Size(237, 100);
            this.SpeedPanel.TabIndex = 19;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.SpeedLabel.Location = new System.Drawing.Point(4, 4);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(53, 18);
            this.SpeedLabel.TabIndex = 99;
            this.SpeedLabel.Text = "Tốc Độ";
            // 
            // directionPanel
            // 
            this.directionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.directionPanel.Controls.Add(this.giamRadioButton);
            this.directionPanel.Controls.Add(this.tangRadioButton);
            this.directionPanel.Controls.Add(this.directionLabel);
            this.directionPanel.Location = new System.Drawing.Point(1058, 289);
            this.directionPanel.Name = "directionPanel";
            this.directionPanel.Size = new System.Drawing.Size(107, 100);
            this.directionPanel.TabIndex = 17;
            // 
            // giamRadioButton
            // 
            this.giamRadioButton.AutoSize = true;
            this.giamRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.giamRadioButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giamRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.giamRadioButton.Location = new System.Drawing.Point(17, 58);
            this.giamRadioButton.Name = "giamRadioButton";
            this.giamRadioButton.Size = new System.Drawing.Size(70, 27);
            this.giamRadioButton.TabIndex = 15;
            this.giamRadioButton.Text = "Giảm";
            this.giamRadioButton.UseVisualStyleBackColor = false;
            this.giamRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // tangRadioButton
            // 
            this.tangRadioButton.AutoSize = true;
            this.tangRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.tangRadioButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tangRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.tangRadioButton.Location = new System.Drawing.Point(17, 30);
            this.tangRadioButton.Name = "tangRadioButton";
            this.tangRadioButton.Size = new System.Drawing.Size(67, 27);
            this.tangRadioButton.TabIndex = 14;
            this.tangRadioButton.Text = "Tăng";
            this.tangRadioButton.UseVisualStyleBackColor = false;
            this.tangRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.BackColor = System.Drawing.Color.Transparent;
            this.directionLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.directionLabel.Location = new System.Drawing.Point(4, 4);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(60, 18);
            this.directionLabel.TabIndex = 99;
            this.directionLabel.Text = "Sắp xếp";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.controlPanel.Controls.Add(this.thoiGianChay_GiayLabel);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.thoiGianChay_PhutLabel);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.huyButton);
            this.controlPanel.Controls.Add(this.tamDungButton);
            this.controlPanel.Controls.Add(this.batDauButton);
            this.controlPanel.Controls.Add(this.controlLabel);
            this.controlPanel.Location = new System.Drawing.Point(8, 601);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(298, 120);
            this.controlPanel.TabIndex = 15;
            // 
            // thoiGianChay_GiayLabel
            // 
            this.thoiGianChay_GiayLabel.AutoSize = true;
            this.thoiGianChay_GiayLabel.BackColor = System.Drawing.Color.Transparent;
            this.thoiGianChay_GiayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thoiGianChay_GiayLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.thoiGianChay_GiayLabel.Location = new System.Drawing.Point(228, 39);
            this.thoiGianChay_GiayLabel.Name = "thoiGianChay_GiayLabel";
            this.thoiGianChay_GiayLabel.Size = new System.Drawing.Size(27, 20);
            this.thoiGianChay_GiayLabel.TabIndex = 107;
            this.thoiGianChay_GiayLabel.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(220, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = ":";
            // 
            // thoiGianChay_PhutLabel
            // 
            this.thoiGianChay_PhutLabel.AutoSize = true;
            this.thoiGianChay_PhutLabel.BackColor = System.Drawing.Color.Transparent;
            this.thoiGianChay_PhutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thoiGianChay_PhutLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.thoiGianChay_PhutLabel.Location = new System.Drawing.Point(198, 39);
            this.thoiGianChay_PhutLabel.Name = "thoiGianChay_PhutLabel";
            this.thoiGianChay_PhutLabel.Size = new System.Drawing.Size(27, 20);
            this.thoiGianChay_PhutLabel.TabIndex = 106;
            this.thoiGianChay_PhutLabel.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Thời gian thực hiện:";
            // 
            // huyButton
            // 
            this.huyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.huyButton.Enabled = false;
            this.huyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huyButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.huyButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.huyButton.Location = new System.Drawing.Point(205, 77);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(84, 36);
            this.huyButton.TabIndex = 3;
            this.huyButton.Text = "Hủy";
            this.huyButton.UseVisualStyleBackColor = false;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // tamDungButton
            // 
            this.tamDungButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tamDungButton.Enabled = false;
            this.tamDungButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamDungButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.tamDungButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.tamDungButton.Location = new System.Drawing.Point(108, 77);
            this.tamDungButton.Name = "tamDungButton";
            this.tamDungButton.Size = new System.Drawing.Size(85, 36);
            this.tamDungButton.TabIndex = 32;
            this.tamDungButton.Text = "Tạm Dừng";
            this.tamDungButton.UseVisualStyleBackColor = false;
            this.tamDungButton.Click += new System.EventHandler(this.tamDungButton_Click);
            // 
            // batDauButton
            // 
            this.batDauButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.batDauButton.Enabled = false;
            this.batDauButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batDauButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.batDauButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.batDauButton.Location = new System.Drawing.Point(8, 77);
            this.batDauButton.Name = "batDauButton";
            this.batDauButton.Size = new System.Drawing.Size(85, 36);
            this.batDauButton.TabIndex = 33;
            this.batDauButton.Text = "Bắt đầu";
            this.batDauButton.UseVisualStyleBackColor = false;
            this.batDauButton.Click += new System.EventHandler(this.batDauButton_Click);
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.BackColor = System.Drawing.Color.Transparent;
            this.controlLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.controlLabel.Location = new System.Drawing.Point(5, 5);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(111, 18);
            this.controlLabel.TabIndex = 99;
            this.controlLabel.Text = "Bảng điều khiển";
            // 
            // sortPanel
            // 
            this.sortPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.sortPanel.Controls.Add(this.heapSortRadioButton);
            this.sortPanel.Controls.Add(this.quickSortRadioButton);
            this.sortPanel.Controls.Add(this.shakerSortRadioButton);
            this.sortPanel.Controls.Add(this.shellSortRadioButton);
            this.sortPanel.Controls.Add(this.selectionSortRadioButton);
            this.sortPanel.Controls.Add(this.mergeSortRadioButton);
            this.sortPanel.Controls.Add(this.bubbleSortRadioButton);
            this.sortPanel.Controls.Add(this.insertionSortRadioButton);
            this.sortPanel.Controls.Add(this.interchangeSortRadioButton);
            this.sortPanel.Controls.Add(this.sortLabel);
            this.sortPanel.Location = new System.Drawing.Point(313, 396);
            this.sortPanel.Name = "sortPanel";
            this.sortPanel.Size = new System.Drawing.Size(494, 152);
            this.sortPanel.TabIndex = 3;
            // 
            // heapSortRadioButton
            // 
            this.heapSortRadioButton.AutoSize = true;
            this.heapSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.heapSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heapSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.heapSortRadioButton.Location = new System.Drawing.Point(334, 98);
            this.heapSortRadioButton.Name = "heapSortRadioButton";
            this.heapSortRadioButton.Size = new System.Drawing.Size(95, 25);
            this.heapSortRadioButton.TabIndex = 108;
            this.heapSortRadioButton.TabStop = true;
            this.heapSortRadioButton.Text = "Heap sort";
            this.heapSortRadioButton.UseVisualStyleBackColor = false;
            this.heapSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // quickSortRadioButton
            // 
            this.quickSortRadioButton.AutoSize = true;
            this.quickSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.quickSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.quickSortRadioButton.Location = new System.Drawing.Point(204, 98);
            this.quickSortRadioButton.Name = "quickSortRadioButton";
            this.quickSortRadioButton.Size = new System.Drawing.Size(100, 25);
            this.quickSortRadioButton.TabIndex = 107;
            this.quickSortRadioButton.TabStop = true;
            this.quickSortRadioButton.Text = "Quick sort";
            this.quickSortRadioButton.UseVisualStyleBackColor = false;
            this.quickSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // shakerSortRadioButton
            // 
            this.shakerSortRadioButton.AutoSize = true;
            this.shakerSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.shakerSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shakerSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.shakerSortRadioButton.Location = new System.Drawing.Point(336, 36);
            this.shakerSortRadioButton.Name = "shakerSortRadioButton";
            this.shakerSortRadioButton.Size = new System.Drawing.Size(107, 25);
            this.shakerSortRadioButton.TabIndex = 106;
            this.shakerSortRadioButton.TabStop = true;
            this.shakerSortRadioButton.Text = "Shaker sort";
            this.shakerSortRadioButton.UseVisualStyleBackColor = false;
            this.shakerSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // shellSortRadioButton
            // 
            this.shellSortRadioButton.AutoSize = true;
            this.shellSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.shellSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.shellSortRadioButton.Location = new System.Drawing.Point(336, 67);
            this.shellSortRadioButton.Name = "shellSortRadioButton";
            this.shellSortRadioButton.Size = new System.Drawing.Size(93, 25);
            this.shellSortRadioButton.TabIndex = 105;
            this.shellSortRadioButton.TabStop = true;
            this.shellSortRadioButton.Text = "Shell sort";
            this.shellSortRadioButton.UseVisualStyleBackColor = false;
            this.shellSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // selectionSortRadioButton
            // 
            this.selectionSortRadioButton.AutoSize = true;
            this.selectionSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.selectionSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectionSortRadioButton.Location = new System.Drawing.Point(204, 36);
            this.selectionSortRadioButton.Name = "selectionSortRadioButton";
            this.selectionSortRadioButton.Size = new System.Drawing.Size(123, 25);
            this.selectionSortRadioButton.TabIndex = 104;
            this.selectionSortRadioButton.TabStop = true;
            this.selectionSortRadioButton.Text = "Selection sort";
            this.selectionSortRadioButton.UseVisualStyleBackColor = false;
            this.selectionSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // mergeSortRadioButton
            // 
            this.mergeSortRadioButton.AutoSize = true;
            this.mergeSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.mergeSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.mergeSortRadioButton.Location = new System.Drawing.Point(204, 67);
            this.mergeSortRadioButton.Name = "mergeSortRadioButton";
            this.mergeSortRadioButton.Size = new System.Drawing.Size(104, 25);
            this.mergeSortRadioButton.TabIndex = 103;
            this.mergeSortRadioButton.TabStop = true;
            this.mergeSortRadioButton.Text = "Merge sort";
            this.mergeSortRadioButton.UseVisualStyleBackColor = false;
            this.mergeSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // bubbleSortRadioButton
            // 
            this.bubbleSortRadioButton.AutoSize = true;
            this.bubbleSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.bubbleSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.bubbleSortRadioButton.Location = new System.Drawing.Point(56, 98);
            this.bubbleSortRadioButton.Name = "bubbleSortRadioButton";
            this.bubbleSortRadioButton.Size = new System.Drawing.Size(108, 25);
            this.bubbleSortRadioButton.TabIndex = 102;
            this.bubbleSortRadioButton.TabStop = true;
            this.bubbleSortRadioButton.Text = "Bubble sort";
            this.bubbleSortRadioButton.UseVisualStyleBackColor = false;
            this.bubbleSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // insertionSortRadioButton
            // 
            this.insertionSortRadioButton.AutoSize = true;
            this.insertionSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.insertionSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertionSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.insertionSortRadioButton.Location = new System.Drawing.Point(56, 67);
            this.insertionSortRadioButton.Name = "insertionSortRadioButton";
            this.insertionSortRadioButton.Size = new System.Drawing.Size(121, 25);
            this.insertionSortRadioButton.TabIndex = 101;
            this.insertionSortRadioButton.TabStop = true;
            this.insertionSortRadioButton.Text = "Insertion sort";
            this.insertionSortRadioButton.UseVisualStyleBackColor = false;
            this.insertionSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // interchangeSortRadioButton
            // 
            this.interchangeSortRadioButton.AutoSize = true;
            this.interchangeSortRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.interchangeSortRadioButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interchangeSortRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.interchangeSortRadioButton.Location = new System.Drawing.Point(56, 36);
            this.interchangeSortRadioButton.Name = "interchangeSortRadioButton";
            this.interchangeSortRadioButton.Size = new System.Drawing.Size(142, 25);
            this.interchangeSortRadioButton.TabIndex = 100;
            this.interchangeSortRadioButton.TabStop = true;
            this.interchangeSortRadioButton.Text = "Interchange sort";
            this.interchangeSortRadioButton.UseVisualStyleBackColor = false;
            this.interchangeSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.sortLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.sortLabel.Location = new System.Drawing.Point(4, 4);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(173, 18);
            this.sortLabel.TabIndex = 99;
            this.sortLabel.Text = "Các phương pháp sắp xếp";
            // 
            // statePanel
            // 
            this.statePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.statePanel.Controls.Add(this.stateLabel);
            this.statePanel.Controls.Add(this.yTuongTextBox);
            this.statePanel.Location = new System.Drawing.Point(313, 554);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(494, 167);
            this.statePanel.TabIndex = 17;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.Color.Transparent;
            this.stateLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.stateLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.stateLabel.Location = new System.Drawing.Point(4, 4);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(134, 18);
            this.stateLabel.TabIndex = 99;
            this.stateLabel.Text = "Ý tưởng thuật toán";
            // 
            // yTuongTextBox
            // 
            this.yTuongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.yTuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yTuongTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.yTuongTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.yTuongTextBox.Location = new System.Drawing.Point(9, 31);
            this.yTuongTextBox.Multiline = true;
            this.yTuongTextBox.Name = "yTuongTextBox";
            this.yTuongTextBox.ReadOnly = true;
            this.yTuongTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.yTuongTextBox.Size = new System.Drawing.Size(480, 130);
            this.yTuongTextBox.TabIndex = 1;
            // 
            // thoiGianChayTimer
            // 
            this.thoiGianChayTimer.Interval = 1000;
            this.thoiGianChayTimer.Tick += new System.EventHandler(this.thoiGianChayTimer_Tick);
            // 
            // gtbd_textBox
            // 
            this.gtbd_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gtbd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gtbd_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbd_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gtbd_textBox.Location = new System.Drawing.Point(177, 33);
            this.gtbd_textBox.MaxLength = 2;
            this.gtbd_textBox.Name = "gtbd_textBox";
            this.gtbd_textBox.Size = new System.Drawing.Size(49, 26);
            this.gtbd_textBox.TabIndex = 101;
            this.gtbd_textBox.Text = "0";
            this.gtbd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gtkt_textBox
            // 
            this.gtkt_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gtkt_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gtkt_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtkt_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gtkt_textBox.Location = new System.Drawing.Point(232, 33);
            this.gtkt_textBox.MaxLength = 2;
            this.gtkt_textBox.Name = "gtkt_textBox";
            this.gtkt_textBox.Size = new System.Drawing.Size(49, 26);
            this.gtkt_textBox.TabIndex = 102;
            this.gtkt_textBox.Text = "0";
            this.gtkt_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1173, 726);
            this.Controls.Add(this.statePanel);
            this.Controls.Add(this.sortPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.directionPanel);
            this.Controls.Add(this.SpeedPanel);
            this.Controls.Add(this.initializationPanel);
            this.Controls.Add(this.codePanel);
            this.Controls.Add(this.unsortedPanel);
            this.Controls.Add(this.sortingPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Simulation";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.unsortedPanel.ResumeLayout(false);
            this.unsortedPanel.PerformLayout();
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.initializationPanel.ResumeLayout(false);
            this.initializationPanel.PerformLayout();
            this.SpeedPanel.ResumeLayout(false);
            this.SpeedPanel.PerformLayout();
            this.directionPanel.ResumeLayout(false);
            this.directionPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.sortPanel.ResumeLayout(false);
            this.sortPanel.PerformLayout();
            this.statePanel.ResumeLayout(false);
            this.statePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem PropertiesToolStripMenuItem;
        private System.Windows.Forms.Panel sortingPanel;
        public System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Panel unsortedPanel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Panel codePanel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Panel initializationPanel;
        private System.Windows.Forms.Panel SpeedPanel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Panel directionPanel;
        private System.Windows.Forms.RadioButton giamRadioButton;
        private System.Windows.Forms.RadioButton tangRadioButton;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Button nhapMotDayButton;
        private System.Windows.Forms.Button nhapTayButton;
        private System.Windows.Forms.Button taoNgauNghienButton;
        private System.Windows.Forms.TextBox soPhanTuTextBox;
        private System.Windows.Forms.Label soPhanTuLabel;
        private System.Windows.Forms.Label initializationLabel;
        private System.Windows.Forms.Button destroyButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label thoiGianChay_GiayLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label thoiGianChay_PhutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.Button tamDungButton;
        private System.Windows.Forms.Button batDauButton;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.ListBox codeListBox;
        private System.Windows.Forms.Panel sortPanel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox yTuongTextBox;
        private RadioButton heapSortRadioButton;
        private RadioButton quickSortRadioButton;
        private RadioButton shakerSortRadioButton;
        private RadioButton shellSortRadioButton;
        private RadioButton selectionSortRadioButton;
        private RadioButton mergeSortRadioButton;
        private RadioButton bubbleSortRadioButton;
        private RadioButton insertionSortRadioButton;
        private RadioButton interchangeSortRadioButton;
        private Timer thoiGianChayTimer;
        private TextBox gtkt_textBox;
        private TextBox gtbd_textBox;
    }
}

