namespace Sorting_Program
{
    partial class NhapMang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dayCanNhapTextBox = new System.Windows.Forms.TextBox();
            this.luuDayCheckBox = new System.Windows.Forms.CheckBox();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập dãy";
            // 
            // dayCanNhapTextBox
            // 
            this.dayCanNhapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dayCanNhapTextBox.Location = new System.Drawing.Point(122, 33);
            this.dayCanNhapTextBox.Name = "dayCanNhapTextBox";
            this.dayCanNhapTextBox.Size = new System.Drawing.Size(291, 26);
            this.dayCanNhapTextBox.TabIndex = 122;
            this.dayCanNhapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayCanNhapTextBox_KeyPress);
            // 
            // luuDayCheckBox
            // 
            this.luuDayCheckBox.AutoSize = true;
            this.luuDayCheckBox.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.luuDayCheckBox.Location = new System.Drawing.Point(336, 65);
            this.luuDayCheckBox.Name = "luuDayCheckBox";
            this.luuDayCheckBox.Size = new System.Drawing.Size(77, 22);
            this.luuDayCheckBox.TabIndex = 125;
            this.luuDayCheckBox.Text = "Lưu dãy";
            this.luuDayCheckBox.UseVisualStyleBackColor = true;
            // 
            // capNhatButton
            // 
            this.capNhatButton.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.capNhatButton.Location = new System.Drawing.Point(135, 87);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(75, 33);
            this.capNhatButton.TabIndex = 123;
            this.capNhatButton.Text = "Tạo";
            this.capNhatButton.UseVisualStyleBackColor = true;
            this.capNhatButton.Click += new System.EventHandler(this.TaoButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.button2.Location = new System.Drawing.Point(216, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 124;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // NhapMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 131);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.capNhatButton);
            this.Controls.Add(this.luuDayCheckBox);
            this.Controls.Add(this.dayCanNhapTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapMang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dãy cần nhập";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhapMang_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dayCanNhapTextBox;
        private System.Windows.Forms.CheckBox luuDayCheckBox;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.Button button2;    
    }
}