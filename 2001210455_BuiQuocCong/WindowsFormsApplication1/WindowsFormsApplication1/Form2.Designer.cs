namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.txbNhap = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.grbSapXep = new System.Windows.Forms.GroupBox();
            this.rbTang = new System.Windows.Forms.RadioButton();
            this.rbGiam = new System.Windows.Forms.RadioButton();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.rbGiaTriTim = new System.Windows.Forms.RadioButton();
            this.rbViTriTim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txbGiaTriTim = new System.Windows.Forms.TextBox();
            this.txbViTriTim = new System.Windows.Forms.TextBox();
            this.txbKetQuaTim = new System.Windows.Forms.TextBox();
            this.gbXoa = new System.Windows.Forms.GroupBox();
            this.txbViTriXoa = new System.Windows.Forms.TextBox();
            this.txbGiaTriXoa = new System.Windows.Forms.TextBox();
            this.rbViTriXoa = new System.Windows.Forms.RadioButton();
            this.rbGiaTriXoa = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gbThem = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbViTriThem = new System.Windows.Forms.TextBox();
            this.rbGiaTriThem = new System.Windows.Forms.RadioButton();
            this.txbGiaTriThem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbThayThe = new System.Windows.Forms.GroupBox();
            this.txbSoThayThe = new System.Windows.Forms.TextBox();
            this.txbViTriThayThe = new System.Windows.Forms.TextBox();
            this.txbGiaTriThayThe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbViTriThayThe = new System.Windows.Forms.RadioButton();
            this.rbGiaTriThayThe = new System.Windows.Forms.RadioButton();
            this.grbSapXep.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.gbXoa.SuspendLayout();
            this.gbThem.SuspendLayout();
            this.gbThayThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng Số Nguyên";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 44);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập mảng";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // txbNhap
            // 
            this.txbNhap.Location = new System.Drawing.Point(93, 46);
            this.txbNhap.Name = "txbNhap";
            this.txbNhap.Size = new System.Drawing.Size(442, 20);
            this.txbNhap.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(541, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết quả mảng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txbKetQua
            // 
            this.txbKetQua.Enabled = false;
            this.txbKetQua.Location = new System.Drawing.Point(93, 70);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(442, 20);
            this.txbKetQua.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 98);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 37);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Thực hiện";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // grbSapXep
            // 
            this.grbSapXep.Controls.Add(this.rbGiam);
            this.grbSapXep.Controls.Add(this.rbTang);
            this.grbSapXep.Location = new System.Drawing.Point(93, 98);
            this.grbSapXep.Name = "grbSapXep";
            this.grbSapXep.Size = new System.Drawing.Size(523, 37);
            this.grbSapXep.TabIndex = 8;
            this.grbSapXep.TabStop = false;
            this.grbSapXep.Text = "Sắp xếp";
            // 
            // rbTang
            // 
            this.rbTang.AutoSize = true;
            this.rbTang.Location = new System.Drawing.Point(55, 14);
            this.rbTang.Name = "rbTang";
            this.rbTang.Size = new System.Drawing.Size(88, 17);
            this.rbTang.TabIndex = 0;
            this.rbTang.TabStop = true;
            this.rbTang.Text = "Sắp xếp tăng";
            this.rbTang.UseVisualStyleBackColor = true;
            this.rbTang.CheckedChanged += new System.EventHandler(this.rbTang_CheckedChanged);
            // 
            // rbGiam
            // 
            this.rbGiam.AutoSize = true;
            this.rbGiam.Location = new System.Drawing.Point(149, 14);
            this.rbGiam.Name = "rbGiam";
            this.rbGiam.Size = new System.Drawing.Size(89, 17);
            this.rbGiam.TabIndex = 1;
            this.rbGiam.TabStop = true;
            this.rbGiam.Text = "Sắp xếp giảm";
            this.rbGiam.UseVisualStyleBackColor = true;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txbKetQuaTim);
            this.grbTimKiem.Controls.Add(this.txbViTriTim);
            this.grbTimKiem.Controls.Add(this.txbGiaTriTim);
            this.grbTimKiem.Controls.Add(this.label3);
            this.grbTimKiem.Controls.Add(this.rbViTriTim);
            this.grbTimKiem.Controls.Add(this.rbGiaTriTim);
            this.grbTimKiem.Location = new System.Drawing.Point(17, 141);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(140, 85);
            this.grbTimKiem.TabIndex = 9;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // rbGiaTriTim
            // 
            this.rbGiaTriTim.AutoSize = true;
            this.rbGiaTriTim.Location = new System.Drawing.Point(6, 19);
            this.rbGiaTriTim.Name = "rbGiaTriTim";
            this.rbGiaTriTim.Size = new System.Drawing.Size(107, 17);
            this.rbGiaTriTim.TabIndex = 0;
            this.rbGiaTriTim.TabStop = true;
            this.rbGiaTriTim.Text = "Tìm giá trị cần tìm";
            this.rbGiaTriTim.UseVisualStyleBackColor = true;
            // 
            // rbViTriTim
            // 
            this.rbViTriTim.AutoSize = true;
            this.rbViTriTim.Location = new System.Drawing.Point(6, 42);
            this.rbViTriTim.Name = "rbViTriTim";
            this.rbViTriTim.Size = new System.Drawing.Size(103, 17);
            this.rbViTriTim.TabIndex = 1;
            this.rbViTriTim.TabStop = true;
            this.rbViTriTim.Text = "Tìm vị trí cần tìm";
            this.rbViTriTim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tìm được là";
            // 
            // txbGiaTriTim
            // 
            this.txbGiaTriTim.Location = new System.Drawing.Point(115, 19);
            this.txbGiaTriTim.Name = "txbGiaTriTim";
            this.txbGiaTriTim.Size = new System.Drawing.Size(23, 20);
            this.txbGiaTriTim.TabIndex = 3;
            // 
            // txbViTriTim
            // 
            this.txbViTriTim.Location = new System.Drawing.Point(115, 41);
            this.txbViTriTim.Name = "txbViTriTim";
            this.txbViTriTim.Size = new System.Drawing.Size(23, 20);
            this.txbViTriTim.TabIndex = 4;
            // 
            // txbKetQuaTim
            // 
            this.txbKetQuaTim.Enabled = false;
            this.txbKetQuaTim.Location = new System.Drawing.Point(115, 64);
            this.txbKetQuaTim.Name = "txbKetQuaTim";
            this.txbKetQuaTim.Size = new System.Drawing.Size(23, 20);
            this.txbKetQuaTim.TabIndex = 5;
            // 
            // gbXoa
            // 
            this.gbXoa.Controls.Add(this.label4);
            this.gbXoa.Controls.Add(this.txbViTriXoa);
            this.gbXoa.Controls.Add(this.rbGiaTriXoa);
            this.gbXoa.Controls.Add(this.txbGiaTriXoa);
            this.gbXoa.Controls.Add(this.rbViTriXoa);
            this.gbXoa.Enabled = false;
            this.gbXoa.Location = new System.Drawing.Point(163, 141);
            this.gbXoa.Name = "gbXoa";
            this.gbXoa.Size = new System.Drawing.Size(149, 85);
            this.gbXoa.TabIndex = 10;
            this.gbXoa.TabStop = false;
            this.gbXoa.Text = "Xóa";
            // 
            // txbViTriXoa
            // 
            this.txbViTriXoa.Location = new System.Drawing.Point(123, 41);
            this.txbViTriXoa.Name = "txbViTriXoa";
            this.txbViTriXoa.Size = new System.Drawing.Size(23, 20);
            this.txbViTriXoa.TabIndex = 9;
            // 
            // txbGiaTriXoa
            // 
            this.txbGiaTriXoa.Location = new System.Drawing.Point(123, 19);
            this.txbGiaTriXoa.Name = "txbGiaTriXoa";
            this.txbGiaTriXoa.Size = new System.Drawing.Size(23, 20);
            this.txbGiaTriXoa.TabIndex = 8;
            // 
            // rbViTriXoa
            // 
            this.rbViTriXoa.AutoSize = true;
            this.rbViTriXoa.Location = new System.Drawing.Point(6, 42);
            this.rbViTriXoa.Name = "rbViTriXoa";
            this.rbViTriXoa.Size = new System.Drawing.Size(107, 17);
            this.rbViTriXoa.TabIndex = 7;
            this.rbViTriXoa.TabStop = true;
            this.rbViTriXoa.Text = "Tìm vị trí cần xóa";
            this.rbViTriXoa.UseVisualStyleBackColor = true;
            // 
            // rbGiaTriXoa
            // 
            this.rbGiaTriXoa.AutoSize = true;
            this.rbGiaTriXoa.Location = new System.Drawing.Point(6, 19);
            this.rbGiaTriXoa.Name = "rbGiaTriXoa";
            this.rbGiaTriXoa.Size = new System.Drawing.Size(111, 17);
            this.rbGiaTriXoa.TabIndex = 6;
            this.rbGiaTriXoa.TabStop = true;
            this.rbGiaTriXoa.Text = "Tìm giá trị cần xóa";
            this.rbGiaTriXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cần sắp xếp tăng";
            // 
            // gbThem
            // 
            this.gbThem.Controls.Add(this.label6);
            this.gbThem.Controls.Add(this.label5);
            this.gbThem.Controls.Add(this.txbViTriThem);
            this.gbThem.Controls.Add(this.rbGiaTriThem);
            this.gbThem.Controls.Add(this.txbGiaTriThem);
            this.gbThem.Enabled = false;
            this.gbThem.Location = new System.Drawing.Point(318, 141);
            this.gbThem.Name = "gbThem";
            this.gbThem.Size = new System.Drawing.Size(149, 85);
            this.gbThem.TabIndex = 11;
            this.gbThem.TabStop = false;
            this.gbThem.Text = "Thêm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cần sắp xếp tăng";
            // 
            // txbViTriThem
            // 
            this.txbViTriThem.Location = new System.Drawing.Point(123, 41);
            this.txbViTriThem.Name = "txbViTriThem";
            this.txbViTriThem.Size = new System.Drawing.Size(23, 20);
            this.txbViTriThem.TabIndex = 9;
            // 
            // rbGiaTriThem
            // 
            this.rbGiaTriThem.AutoSize = true;
            this.rbGiaTriThem.Location = new System.Drawing.Point(6, 19);
            this.rbGiaTriThem.Name = "rbGiaTriThem";
            this.rbGiaTriThem.Size = new System.Drawing.Size(117, 17);
            this.rbGiaTriThem.TabIndex = 6;
            this.rbGiaTriThem.TabStop = true;
            this.rbGiaTriThem.Text = "Tìm giá trị cần thêm";
            this.rbGiaTriThem.UseVisualStyleBackColor = true;
            // 
            // txbGiaTriThem
            // 
            this.txbGiaTriThem.Location = new System.Drawing.Point(123, 19);
            this.txbGiaTriThem.Name = "txbGiaTriThem";
            this.txbGiaTriThem.Size = new System.Drawing.Size(23, 20);
            this.txbGiaTriThem.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tại vị trí cần thêm";
            // 
            // gbThayThe
            // 
            this.gbThayThe.Controls.Add(this.txbSoThayThe);
            this.gbThayThe.Controls.Add(this.txbViTriThayThe);
            this.gbThayThe.Controls.Add(this.txbGiaTriThayThe);
            this.gbThayThe.Controls.Add(this.label7);
            this.gbThayThe.Controls.Add(this.rbViTriThayThe);
            this.gbThayThe.Controls.Add(this.rbGiaTriThayThe);
            this.gbThayThe.Location = new System.Drawing.Point(473, 141);
            this.gbThayThe.Name = "gbThayThe";
            this.gbThayThe.Size = new System.Drawing.Size(143, 85);
            this.gbThayThe.TabIndex = 10;
            this.gbThayThe.TabStop = false;
            this.gbThayThe.Text = "Thay thế";
            // 
            // txbSoThayThe
            // 
            this.txbSoThayThe.Location = new System.Drawing.Point(115, 64);
            this.txbSoThayThe.Name = "txbSoThayThe";
            this.txbSoThayThe.Size = new System.Drawing.Size(23, 20);
            this.txbSoThayThe.TabIndex = 5;
            // 
            // txbViTriThayThe
            // 
            this.txbViTriThayThe.Location = new System.Drawing.Point(115, 41);
            this.txbViTriThayThe.Name = "txbViTriThayThe";
            this.txbViTriThayThe.Size = new System.Drawing.Size(23, 20);
            this.txbViTriThayThe.TabIndex = 4;
            // 
            // txbGiaTriThayThe
            // 
            this.txbGiaTriThayThe.Location = new System.Drawing.Point(115, 16);
            this.txbGiaTriThayThe.Name = "txbGiaTriThayThe";
            this.txbGiaTriThayThe.Size = new System.Drawing.Size(23, 20);
            this.txbGiaTriThayThe.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số thay thế là";
            // 
            // rbViTriThayThe
            // 
            this.rbViTriThayThe.AutoSize = true;
            this.rbViTriThayThe.Location = new System.Drawing.Point(6, 42);
            this.rbViTriThayThe.Name = "rbViTriThayThe";
            this.rbViTriThayThe.Size = new System.Drawing.Size(109, 17);
            this.rbViTriThayThe.TabIndex = 1;
            this.rbViTriThayThe.TabStop = true;
            this.rbViTriThayThe.Text = "Vị trí cần thay thế";
            this.rbViTriThayThe.UseVisualStyleBackColor = true;
            // 
            // rbGiaTriThayThe
            // 
            this.rbGiaTriThayThe.AutoSize = true;
            this.rbGiaTriThayThe.Location = new System.Drawing.Point(6, 19);
            this.rbGiaTriThayThe.Name = "rbGiaTriThayThe";
            this.rbGiaTriThayThe.Size = new System.Drawing.Size(114, 17);
            this.rbGiaTriThayThe.TabIndex = 0;
            this.rbGiaTriThayThe.TabStop = true;
            this.rbGiaTriThayThe.Text = "Giá trị cần thay thế";
            this.rbGiaTriThayThe.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 319);
            this.Controls.Add(this.gbThayThe);
            this.Controls.Add(this.gbThem);
            this.Controls.Add(this.gbXoa);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbSapXep);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txbNhap);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grbSapXep.ResumeLayout(false);
            this.grbSapXep.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.gbXoa.ResumeLayout(false);
            this.gbXoa.PerformLayout();
            this.gbThem.ResumeLayout(false);
            this.gbThem.PerformLayout();
            this.gbThayThe.ResumeLayout(false);
            this.gbThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txbNhap;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbKetQua;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox grbSapXep;
        private System.Windows.Forms.RadioButton rbGiam;
        private System.Windows.Forms.RadioButton rbTang;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbViTriTim;
        private System.Windows.Forms.RadioButton rbGiaTriTim;
        private System.Windows.Forms.TextBox txbKetQuaTim;
        private System.Windows.Forms.TextBox txbViTriTim;
        private System.Windows.Forms.TextBox txbGiaTriTim;
        private System.Windows.Forms.GroupBox gbXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbViTriXoa;
        private System.Windows.Forms.RadioButton rbGiaTriXoa;
        private System.Windows.Forms.TextBox txbGiaTriXoa;
        private System.Windows.Forms.RadioButton rbViTriXoa;
        private System.Windows.Forms.GroupBox gbThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbViTriThem;
        private System.Windows.Forms.RadioButton rbGiaTriThem;
        private System.Windows.Forms.TextBox txbGiaTriThem;
        private System.Windows.Forms.GroupBox gbThayThe;
        private System.Windows.Forms.TextBox txbSoThayThe;
        private System.Windows.Forms.TextBox txbViTriThayThe;
        private System.Windows.Forms.TextBox txbGiaTriThayThe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbViTriThayThe;
        private System.Windows.Forms.RadioButton rbGiaTriThayThe;
    }
}