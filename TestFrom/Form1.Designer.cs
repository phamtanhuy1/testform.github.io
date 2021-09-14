
namespace TestFrom
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnTich = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập C";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(122, 62);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(165, 22);
            this.txtNhapA.TabIndex = 3;
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(122, 117);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(165, 22);
            this.txtNhapB.TabIndex = 4;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(122, 168);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(165, 22);
            this.txtKetqua.TabIndex = 5;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(359, 60);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(117, 48);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.Location = new System.Drawing.Point(540, 62);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(117, 48);
            this.btnHieu.TabIndex = 7;
            this.btnHieu.Text = "Hiệu";
            this.btnHieu.UseVisualStyleBackColor = true;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnTich
            // 
            this.btnTich.Location = new System.Drawing.Point(337, 142);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(117, 48);
            this.btnTich.TabIndex = 8;
            this.btnTich.Text = "Tích";
            this.btnTich.UseVisualStyleBackColor = true;
            this.btnTich.Click += new System.EventHandler(this.btnTich_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Location = new System.Drawing.Point(518, 142);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(117, 48);
            this.btnThuong.TabIndex = 9;
            this.btnThuong.Text = "Thương";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(359, 210);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(276, 36);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Tổng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnTich;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
    }
}

