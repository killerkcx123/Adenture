namespace ListView2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_TenMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sotinchi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.btn_ThemvaoDS = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TongSoTC = new System.Windows.Forms.TextBox();
            this.txt_TongDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ThemvaoDS);
            this.groupBox1.Controls.Add(this.txt_Diem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Sotinchi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_TenMH);
            this.groupBox1.Location = new System.Drawing.Point(37, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Thoat);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Tinh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_DiemTB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_TongDiem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_TongSoTC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(318, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các môn học";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbo_TenMH
            // 
            this.cbo_TenMH.FormattingEnabled = true;
            this.cbo_TenMH.Items.AddRange(new object[] {
            "Lập trình C",
            "Lập trình trực quan",
            "Thiết kế Cơ sở dữ liệu",
            "Phân tích thiết kế hệ thống",
            "..."});
            this.cbo_TenMH.Location = new System.Drawing.Point(18, 71);
            this.cbo_TenMH.Name = "cbo_TenMH";
            this.cbo_TenMH.Size = new System.Drawing.Size(222, 24);
            this.cbo_TenMH.TabIndex = 0;
            this.cbo_TenMH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tín chỉ";
            // 
            // txt_Sotinchi
            // 
            this.txt_Sotinchi.Location = new System.Drawing.Point(85, 112);
            this.txt_Sotinchi.Name = "txt_Sotinchi";
            this.txt_Sotinchi.Size = new System.Drawing.Size(155, 22);
            this.txt_Sotinchi.TabIndex = 3;
            this.txt_Sotinchi.TextChanged += new System.EventHandler(this.txt_Sotinchi_TextChanged);
            this.txt_Sotinchi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sotinchi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm";
            // 
            // txt_Diem
            // 
            this.txt_Diem.Location = new System.Drawing.Point(85, 152);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(111, 22);
            this.txt_Diem.TabIndex = 5;
            this.txt_Diem.TextChanged += new System.EventHandler(this.txt_Diem_TextChanged);
            this.txt_Diem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Diem_KeyPress);
            // 
            // btn_ThemvaoDS
            // 
            this.btn_ThemvaoDS.Location = new System.Drawing.Point(54, 216);
            this.btn_ThemvaoDS.Name = "btn_ThemvaoDS";
            this.btn_ThemvaoDS.Size = new System.Drawing.Size(142, 43);
            this.btn_ThemvaoDS.TabIndex = 6;
            this.btn_ThemvaoDS.Text = "Thêm vào DS";
            this.btn_ThemvaoDS.UseVisualStyleBackColor = true;
            this.btn_ThemvaoDS.Click += new System.EventHandler(this.btn_ThemvaoDS_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 255);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên môn học";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Số tín chỉ";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Điểm";
            this.columnHeader3.Width = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // txt_TongSoTC
            // 
            this.txt_TongSoTC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TongSoTC.Enabled = false;
            this.txt_TongSoTC.Location = new System.Drawing.Point(116, 287);
            this.txt_TongSoTC.Name = "txt_TongSoTC";
            this.txt_TongSoTC.Size = new System.Drawing.Size(100, 22);
            this.txt_TongSoTC.TabIndex = 2;
            // 
            // txt_TongDiem
            // 
            this.txt_TongDiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_TongDiem.Enabled = false;
            this.txt_TongDiem.Location = new System.Drawing.Point(355, 290);
            this.txt_TongDiem.Name = "txt_TongDiem";
            this.txt_TongDiem.Size = new System.Drawing.Size(100, 22);
            this.txt_TongDiem.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng số điểm";
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_DiemTB.Enabled = false;
            this.txt_DiemTB.Location = new System.Drawing.Point(116, 329);
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(191, 22);
            this.txt_DiemTB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Điểm trung bình";
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Location = new System.Drawing.Point(29, 373);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(75, 46);
            this.btn_Tinh.TabIndex = 8;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(141, 373);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 46);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(248, 373);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 46);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa khỏi DS";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(366, 373);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 46);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_TenMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ThemvaoDS;
        private System.Windows.Forms.TextBox txt_Diem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sotinchi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TongDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TongSoTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Label label7;
    }
}

