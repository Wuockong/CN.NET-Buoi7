namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBac1 = new System.Windows.Forms.RadioButton();
            this.rbBac2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.txbC = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn vui lòng chọn";
            // 
            // rbBac1
            // 
            this.rbBac1.AutoSize = true;
            this.rbBac1.Checked = true;
            this.rbBac1.Location = new System.Drawing.Point(52, 66);
            this.rbBac1.Name = "rbBac1";
            this.rbBac1.Size = new System.Drawing.Size(130, 17);
            this.rbBac1.TabIndex = 2;
            this.rbBac1.TabStop = true;
            this.rbBac1.Text = "Phương trình bậc nhất";
            this.rbBac1.UseVisualStyleBackColor = true;
            this.rbBac1.CheckedChanged += new System.EventHandler(this.rbBac1_CheckedChanged);
            // 
            // rbBac2
            // 
            this.rbBac2.AutoSize = true;
            this.rbBac2.Location = new System.Drawing.Point(52, 89);
            this.rbBac2.Name = "rbBac2";
            this.rbBac2.Size = new System.Drawing.Size(123, 17);
            this.rbBac2.TabIndex = 3;
            this.rbBac2.Text = "Phương trình bậc hai";
            this.rbBac2.UseVisualStyleBackColor = true;
            this.rbBac2.CheckedChanged += new System.EventHandler(this.rbBac2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập b";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(75, 114);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 6;
            this.txbA.TextChanged += new System.EventHandler(this.txbC_TextChanged);
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(75, 140);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 7;
            this.txbB.TextChanged += new System.EventHandler(this.txbC_TextChanged);
            // 
            // btnGiai
            // 
            this.btnGiai.Enabled = false;
            this.btnGiai.Location = new System.Drawing.Point(181, 114);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(75, 36);
            this.btnGiai.TabIndex = 8;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // txbC
            // 
            this.txbC.Enabled = false;
            this.txbC.Location = new System.Drawing.Point(75, 166);
            this.txbC.Name = "txbC";
            this.txbC.Size = new System.Drawing.Size(100, 20);
            this.txbC.TabIndex = 10;
            this.txbC.TextChanged += new System.EventHandler(this.txbC_TextChanged);
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Enabled = false;
            this.lbC.Location = new System.Drawing.Point(28, 169);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(42, 13);
            this.lbC.TabIndex = 9;
            this.lbC.Text = "Nhập c";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(181, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kết quả";
            // 
            // txbKQ
            // 
            this.txbKQ.Enabled = false;
            this.txbKQ.Location = new System.Drawing.Point(75, 192);
            this.txbKQ.Multiline = true;
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(181, 57);
            this.txbKQ.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txbC);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbBac2);
            this.Controls.Add(this.rbBac1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBac1;
        private System.Windows.Forms.RadioButton rbBac2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.TextBox txbC;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbKQ;
    }
}