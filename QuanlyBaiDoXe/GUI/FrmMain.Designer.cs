namespace QuanlyBaiDoXe.GUI
{
    partial class FrmMain
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
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtThoiGianVao = new System.Windows.Forms.TextBox();
            this.btnTaoVe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBienSoRa = new System.Windows.Forms.TextBox();
            this.btnXoaVe = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.btnMoCongRa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.btnMoCongVao = new System.Windows.Forms.Button();
            this.tlpSoDoBaiXe = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTrangThaiChon = new System.Windows.Forms.Label();
            this.lblLoaiXeChon = new System.Windows.Forms.Label();
            this.lblBienSoChon = new System.Windows.Forms.Label();
            this.lblViTriChon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienPhaiTra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Biển Số Xe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại Xe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời Gian Vào";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(185, 39);
            this.txtBienSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(167, 30);
            this.txtBienSo.TabIndex = 6;
            this.txtBienSo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtThoiGianVao
            // 
            this.txtThoiGianVao.Location = new System.Drawing.Point(185, 139);
            this.txtThoiGianVao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThoiGianVao.Name = "txtThoiGianVao";
            this.txtThoiGianVao.ReadOnly = true;
            this.txtThoiGianVao.Size = new System.Drawing.Size(167, 30);
            this.txtThoiGianVao.TabIndex = 7;
            // 
            // btnTaoVe
            // 
            this.btnTaoVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoVe.Location = new System.Drawing.Point(385, 39);
            this.btnTaoVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoVe.Name = "btnTaoVe";
            this.btnTaoVe.Size = new System.Drawing.Size(163, 65);
            this.btnTaoVe.TabIndex = 13;
            this.btnTaoVe.Text = "Tạo Vé";
            this.btnTaoVe.UseVisualStyleBackColor = true;
            this.btnTaoVe.Click += new System.EventHandler(this.btnTaoVe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTienPhaiTra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBienSoRa);
            this.groupBox1.Controls.Add(this.btnXoaVe);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.btnMoCongRa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 390);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(720, 388);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cửa ra";
            // 
            // txtBienSoRa
            // 
            this.txtBienSoRa.Location = new System.Drawing.Point(185, 57);
            this.txtBienSoRa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBienSoRa.Name = "txtBienSoRa";
            this.txtBienSoRa.Size = new System.Drawing.Size(167, 30);
            this.txtBienSoRa.TabIndex = 16;
            // 
            // btnXoaVe
            // 
            this.btnXoaVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaVe.Location = new System.Drawing.Point(385, 30);
            this.btnXoaVe.Name = "btnXoaVe";
            this.btnXoaVe.Size = new System.Drawing.Size(163, 65);
            this.btnXoaVe.TabIndex = 2;
            this.btnXoaVe.Text = "Xe Ra";
            this.btnXoaVe.UseVisualStyleBackColor = true;
            this.btnXoaVe.Click += new System.EventHandler(this.btnXoaVe_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(34, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(108, 26);
            this.label.TabIndex = 1;
            this.label.Text = "Biển số xe";
            // 
            // btnMoCongRa
            // 
            this.btnMoCongRa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoCongRa.Location = new System.Drawing.Point(556, 31);
            this.btnMoCongRa.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoCongRa.Name = "btnMoCongRa";
            this.btnMoCongRa.Size = new System.Drawing.Size(163, 65);
            this.btnMoCongRa.TabIndex = 0;
            this.btnMoCongRa.Text = "Mở Cổng";
            this.btnMoCongRa.UseVisualStyleBackColor = true;
            this.btnMoCongRa.Click += new System.EventHandler(this.btnMoCongRa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboLoaiXe);
            this.groupBox2.Controls.Add(this.btnMoCongVao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBienSo);
            this.groupBox2.Controls.Add(this.btnTaoVe);
            this.groupBox2.Controls.Add(this.txtThoiGianVao);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(720, 388);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cửa vào";
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Location = new System.Drawing.Point(185, 87);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(167, 30);
            this.cboLoaiXe.TabIndex = 15;
            this.cboLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cboLoaiXe_SelectedIndexChanged);
            // 
            // btnMoCongVao
            // 
            this.btnMoCongVao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoCongVao.Location = new System.Drawing.Point(556, 39);
            this.btnMoCongVao.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoCongVao.Name = "btnMoCongVao";
            this.btnMoCongVao.Size = new System.Drawing.Size(163, 65);
            this.btnMoCongVao.TabIndex = 14;
            this.btnMoCongVao.Text = "Mở Cổng";
            this.btnMoCongVao.UseVisualStyleBackColor = true;
            this.btnMoCongVao.Click += new System.EventHandler(this.btnMoCongVao_Click);
            // 
            // tlpSoDoBaiXe
            // 
            this.tlpSoDoBaiXe.ColumnCount = 2;
            this.tlpSoDoBaiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSoDoBaiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSoDoBaiXe.Location = new System.Drawing.Point(726, 230);
            this.tlpSoDoBaiXe.Name = "tlpSoDoBaiXe";
            this.tlpSoDoBaiXe.RowCount = 2;
            this.tlpSoDoBaiXe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSoDoBaiXe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSoDoBaiXe.Size = new System.Drawing.Size(651, 523);
            this.tlpSoDoBaiXe.TabIndex = 6;
            this.tlpSoDoBaiXe.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpSoDoBaiXe_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTrangThaiChon);
            this.groupBox3.Controls.Add(this.lblLoaiXeChon);
            this.groupBox3.Controls.Add(this.lblBienSoChon);
            this.groupBox3.Controls.Add(this.lblViTriChon);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(727, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 219);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Xe";
            // 
            // lblTrangThaiChon
            // 
            this.lblTrangThaiChon.AutoSize = true;
            this.lblTrangThaiChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiChon.Location = new System.Drawing.Point(52, 172);
            this.lblTrangThaiChon.Name = "lblTrangThaiChon";
            this.lblTrangThaiChon.Size = new System.Drawing.Size(0, 22);
            this.lblTrangThaiChon.TabIndex = 4;
            // 
            // lblLoaiXeChon
            // 
            this.lblLoaiXeChon.AutoSize = true;
            this.lblLoaiXeChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiXeChon.Location = new System.Drawing.Point(51, 130);
            this.lblLoaiXeChon.Name = "lblLoaiXeChon";
            this.lblLoaiXeChon.Size = new System.Drawing.Size(0, 22);
            this.lblLoaiXeChon.TabIndex = 3;
            this.lblLoaiXeChon.Click += new System.EventHandler(this.lblLoaiXeChon_Click);
            // 
            // lblBienSoChon
            // 
            this.lblBienSoChon.AutoSize = true;
            this.lblBienSoChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienSoChon.Location = new System.Drawing.Point(51, 87);
            this.lblBienSoChon.Name = "lblBienSoChon";
            this.lblBienSoChon.Size = new System.Drawing.Size(0, 22);
            this.lblBienSoChon.TabIndex = 2;
            this.lblBienSoChon.Click += new System.EventHandler(this.lblBienSoChon_Click);
            // 
            // lblViTriChon
            // 
            this.lblViTriChon.AutoSize = true;
            this.lblViTriChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTriChon.Location = new System.Drawing.Point(51, 40);
            this.lblViTriChon.Name = "lblViTriChon";
            this.lblViTriChon.Size = new System.Drawing.Size(0, 22);
            this.lblViTriChon.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(34, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tiền Phải Trả";
            // 
            // txtTienPhaiTra
            // 
            this.txtTienPhaiTra.Location = new System.Drawing.Point(185, 116);
            this.txtTienPhaiTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienPhaiTra.Name = "txtTienPhaiTra";
            this.txtTienPhaiTra.ReadOnly = true;
            this.txtTienPhaiTra.Size = new System.Drawing.Size(167, 30);
            this.txtTienPhaiTra.TabIndex = 18;
            this.txtTienPhaiTra.TextChanged += new System.EventHandler(this.txtTienPhaiTra_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 752);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tlpSoDoBaiXe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.TextBox txtThoiGianVao;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaoVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMoCongVao;
        private System.Windows.Forms.Button btnMoCongRa;
        private System.Windows.Forms.TableLayoutPanel tlpSoDoBaiXe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBienSoChon;
        private System.Windows.Forms.Label lblViTriChon;
        private System.Windows.Forms.Label lblTrangThaiChon;
        private System.Windows.Forms.Label lblLoaiXeChon;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtBienSoRa;
        private System.Windows.Forms.Button btnXoaVe;
        private System.Windows.Forms.TextBox txtTienPhaiTra;
        private System.Windows.Forms.Label label4;
    }
}