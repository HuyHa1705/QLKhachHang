namespace QL_KhachHang
{
    partial class ThucDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbGia = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLMon = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txbMaMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.boxMaDH = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.txbGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txbGia
            // 
            this.txbGia.Controls.Add(this.label3);
            this.txbGia.Controls.Add(this.txtSLMon);
            this.txbGia.Controls.Add(this.lb);
            this.txbGia.Controls.Add(this.label1);
            this.txbGia.Controls.Add(this.txtGia);
            this.txbGia.Controls.Add(this.txbMaMon);
            this.txbGia.Controls.Add(this.label2);
            this.txbGia.Location = new System.Drawing.Point(294, 256);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(536, 182);
            this.txbGia.TabIndex = 7;
            this.txbGia.TabStop = false;
            this.txbGia.Text = "Thông tin";
            this.txbGia.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã đơn hàng:";
            // 
            // txtSLMon
            // 
            this.txtSLMon.Location = new System.Drawing.Point(392, 116);
            this.txtSLMon.Name = "txtSLMon";
            this.txtSLMon.Size = new System.Drawing.Size(125, 27);
            this.txtSLMon.TabIndex = 7;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(286, 119);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(72, 20);
            this.lb.TabIndex = 6;
            this.lb.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã món ăn:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(127, 116);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(125, 27);
            this.txtGia.TabIndex = 5;
            // 
            // txbMaMon
            // 
            this.txbMaMon.Location = new System.Drawing.Point(127, 47);
            this.txbMaMon.Name = "txbMaMon";
            this.txbMaMon.Size = new System.Drawing.Size(125, 27);
            this.txbMaMon.TabIndex = 2;
            this.txbMaMon.TextChanged += new System.EventHandler(this.txtMaMon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(33, 398);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(111, 40);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(887, 359);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(152, 40);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // boxMaDH
            // 
            this.boxMaDH.FormattingEnabled = true;
            this.boxMaDH.Location = new System.Drawing.Point(845, 265);
            this.boxMaDH.Name = "boxMaDH";
            this.boxMaDH.Size = new System.Drawing.Size(285, 28);
            this.boxMaDH.TabIndex = 11;
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.boxMaDH);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txbGia);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThucDon";
            this.Text = "Thực Đơn";
            this.Load += new System.EventHandler(this.ThucDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.txbGia.ResumeLayout(false);
            this.txbGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox txbGia;
        private Label label3;
        private TextBox txtSLMon;
        private Label lb;
        private Label label1;
        private TextBox txtGia;
        private TextBox txbMaMon;
        private Label label2;
        private Button btnQuayLai;
        private Button btnThanhToan;
        private ComboBox boxMaDH;
    }
}