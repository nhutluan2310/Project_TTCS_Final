namespace Sorting_Program
{
    partial class NhapGT
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
            this.Giatribatdau_TextBox = new System.Windows.Forms.TextBox();
            this.Giatriketthuc_TextBox = new System.Windows.Forms.TextBox();
            this.giatribd_label = new System.Windows.Forms.Label();
            this.giatrikt_label = new System.Windows.Forms.Label();
            this.CapNhatButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Giatribatdau_TextBox
            // 
            this.Giatribatdau_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Giatribatdau_TextBox.Location = new System.Drawing.Point(150, 33);
            this.Giatribatdau_TextBox.Name = "Giatribatdau_TextBox";
            this.Giatribatdau_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Giatribatdau_TextBox.TabIndex = 111;
            // 
            // Giatriketthuc_TextBox
            // 
            this.Giatriketthuc_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Giatriketthuc_TextBox.Location = new System.Drawing.Point(150, 84);
            this.Giatriketthuc_TextBox.Name = "Giatriketthuc_TextBox";
            this.Giatriketthuc_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Giatriketthuc_TextBox.TabIndex = 1;
            // 
            // giatribd_label
            // 
            this.giatribd_label.AutoSize = true;
            this.giatribd_label.Font = new System.Drawing.Font("Corbel", 12F);
            this.giatribd_label.ForeColor = System.Drawing.Color.Black;
            this.giatribd_label.Location = new System.Drawing.Point(40, 37);
            this.giatribd_label.Name = "giatribd_label";
            this.giatribd_label.Size = new System.Drawing.Size(104, 19);
            this.giatribd_label.TabIndex = 2;
            this.giatribd_label.Text = "Giá trị bắt đầu";
            // 
            // giatrikt_label
            // 
            this.giatrikt_label.AutoSize = true;
            this.giatrikt_label.Font = new System.Drawing.Font("Corbel", 12F);
            this.giatrikt_label.ForeColor = System.Drawing.Color.Black;
            this.giatrikt_label.Location = new System.Drawing.Point(40, 88);
            this.giatrikt_label.Name = "giatrikt_label";
            this.giatrikt_label.Size = new System.Drawing.Size(108, 19);
            this.giatrikt_label.TabIndex = 3;
            this.giatrikt_label.Text = "Giá trị kết thúc";
            // 
            // CapNhatButton
            // 
            this.CapNhatButton.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.CapNhatButton.Location = new System.Drawing.Point(73, 150);
            this.CapNhatButton.Name = "CapNhatButton";
            this.CapNhatButton.Size = new System.Drawing.Size(75, 33);
            this.CapNhatButton.TabIndex = 4;
            this.CapNhatButton.Text = "Tạo";
            this.CapNhatButton.UseVisualStyleBackColor = true;
            this.CapNhatButton.Click += new System.EventHandler(this.CapNhatButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.button2.Location = new System.Drawing.Point(154, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NhapGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 202);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CapNhatButton);
            this.Controls.Add(this.giatrikt_label);
            this.Controls.Add(this.giatribd_label);
            this.Controls.Add(this.Giatriketthuc_TextBox);
            this.Controls.Add(this.Giatribatdau_TextBox);
            this.MaximizeBox = false;
            this.Name = "NhapGT";
            this.ShowIcon = false;
            this.Text = "Nhập Giá trị Ngẫu nhiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Giatribatdau_TextBox;
        private System.Windows.Forms.TextBox Giatriketthuc_TextBox;
        private System.Windows.Forms.Label giatribd_label;
        private System.Windows.Forms.Label giatrikt_label;
        private System.Windows.Forms.Button CapNhatButton;
        private System.Windows.Forms.Button button2;
        
    }
}