namespace quanlychungcu
{
    partial class ThemBienLai
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
            this.dataGridView_canho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.combobox_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nguoilap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tongtienthanhtoan = new System.Windows.Forms.TextBox();
            this.btn_taobienlai = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phidichvu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_phicanho = new System.Windows.Forms.TextBox();
            this.datepicker_thoigianlap = new System.Windows.Forms.DateTimePicker();
            this.combobox_tinhtrangcanho = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_macanho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_canho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_canho
            // 
            this.dataGridView_canho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_canho.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_canho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_canho.Location = new System.Drawing.Point(12, 163);
            this.dataGridView_canho.Name = "dataGridView_canho";
            this.dataGridView_canho.Size = new System.Drawing.Size(618, 342);
            this.dataGridView_canho.TabIndex = 0;
            this.dataGridView_canho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_canho_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(387, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thêm biên lai thanh toán cho căn hộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(159, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn căn hộ cần tạo biên lai thanh toán";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gray;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(547, 124);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 33);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(458, 124);
            this.btn_search.Name = "btn_search";
            this.btn_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // combobox_search
            // 
            this.combobox_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_search.FormattingEnabled = true;
            this.combobox_search.Items.AddRange(new object[] {
            "Mã căn hộ",
            "Tên căn hộ",
            "Tình trạng",
            "Khoảng giá cả"});
            this.combobox_search.Location = new System.Drawing.Point(223, 131);
            this.combobox_search.Name = "combobox_search";
            this.combobox_search.Size = new System.Drawing.Size(117, 21);
            this.combobox_search.TabIndex = 26;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(16, 131);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(201, 20);
            this.txt_search.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_nguoilap);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_tongtienthanhtoan);
            this.panel1.Controls.Add(this.btn_taobienlai);
            this.panel1.Controls.Add(this.btn_lammoi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_phidichvu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_phicanho);
            this.panel1.Controls.Add(this.datepicker_thoigianlap);
            this.panel1.Controls.Add(this.combobox_tinhtrangcanho);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_macanho);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(652, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 381);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(43, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Người lập";
            // 
            // txt_nguoilap
            // 
            this.txt_nguoilap.Enabled = false;
            this.txt_nguoilap.Location = new System.Drawing.Point(205, 297);
            this.txt_nguoilap.Name = "txt_nguoilap";
            this.txt_nguoilap.Size = new System.Drawing.Size(242, 20);
            this.txt_nguoilap.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label9.Location = new System.Drawing.Point(43, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tổng tiền thanh toán";
            // 
            // txt_tongtienthanhtoan
            // 
            this.txt_tongtienthanhtoan.Enabled = false;
            this.txt_tongtienthanhtoan.Location = new System.Drawing.Point(205, 257);
            this.txt_tongtienthanhtoan.Name = "txt_tongtienthanhtoan";
            this.txt_tongtienthanhtoan.Size = new System.Drawing.Size(242, 20);
            this.txt_tongtienthanhtoan.TabIndex = 39;
            // 
            // btn_taobienlai
            // 
            this.btn_taobienlai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_taobienlai.Enabled = false;
            this.btn_taobienlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taobienlai.ForeColor = System.Drawing.Color.White;
            this.btn_taobienlai.Location = new System.Drawing.Point(62, 334);
            this.btn_taobienlai.Name = "btn_taobienlai";
            this.btn_taobienlai.Size = new System.Drawing.Size(195, 33);
            this.btn_taobienlai.TabIndex = 38;
            this.btn_taobienlai.Text = "Tạo biên lai";
            this.btn_taobienlai.UseVisualStyleBackColor = false;
            this.btn_taobienlai.Click += new System.EventHandler(this.btn_taobienlai_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.Gray;
            this.btn_lammoi.Enabled = false;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.ForeColor = System.Drawing.Color.White;
            this.btn_lammoi.Location = new System.Drawing.Point(285, 334);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(195, 33);
            this.btn_lammoi.TabIndex = 37;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(43, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Phí dịch vụ";
            // 
            // txt_phidichvu
            // 
            this.txt_phidichvu.Enabled = false;
            this.txt_phidichvu.Location = new System.Drawing.Point(205, 220);
            this.txt_phidichvu.Name = "txt_phidichvu";
            this.txt_phidichvu.Size = new System.Drawing.Size(242, 20);
            this.txt_phidichvu.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(43, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Phí căn hộ";
            // 
            // txt_phicanho
            // 
            this.txt_phicanho.Enabled = false;
            this.txt_phicanho.Location = new System.Drawing.Point(205, 184);
            this.txt_phicanho.Name = "txt_phicanho";
            this.txt_phicanho.Size = new System.Drawing.Size(242, 20);
            this.txt_phicanho.TabIndex = 33;
            // 
            // datepicker_thoigianlap
            // 
            this.datepicker_thoigianlap.CustomFormat = "dd/MM/yyyy";
            this.datepicker_thoigianlap.Enabled = false;
            this.datepicker_thoigianlap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_thoigianlap.Location = new System.Drawing.Point(205, 147);
            this.datepicker_thoigianlap.Name = "datepicker_thoigianlap";
            this.datepicker_thoigianlap.Size = new System.Drawing.Size(242, 20);
            this.datepicker_thoigianlap.TabIndex = 32;
            this.datepicker_thoigianlap.ValueChanged += new System.EventHandler(this.datepicker_thoigianlap_ValueChanged);
            // 
            // combobox_tinhtrangcanho
            // 
            this.combobox_tinhtrangcanho.Enabled = false;
            this.combobox_tinhtrangcanho.FormattingEnabled = true;
            this.combobox_tinhtrangcanho.Items.AddRange(new object[] {
            "Trống",
            "Thuê",
            "Mua góp",
            "Mua"});
            this.combobox_tinhtrangcanho.Location = new System.Drawing.Point(205, 105);
            this.combobox_tinhtrangcanho.Name = "combobox_tinhtrangcanho";
            this.combobox_tinhtrangcanho.Size = new System.Drawing.Size(242, 21);
            this.combobox_tinhtrangcanho.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(43, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thời gian lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(43, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tình trạng căn hộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(43, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã căn hộ";
            // 
            // txt_macanho
            // 
            this.txt_macanho.Enabled = false;
            this.txt_macanho.Location = new System.Drawing.Point(205, 65);
            this.txt_macanho.Name = "txt_macanho";
            this.txt_macanho.Size = new System.Drawing.Size(242, 20);
            this.txt_macanho.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(104, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thông tin biên lai thanh toán";
            // 
            // ThemBienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1224, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.combobox_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_canho);
            this.Name = "ThemBienLai";
            this.Text = "ThemBienLai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_canho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_canho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox combobox_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_phidichvu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_phicanho;
        private System.Windows.Forms.ComboBox combobox_tinhtrangcanho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_macanho;
        private System.Windows.Forms.Button btn_taobienlai;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tongtienthanhtoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nguoilap;
        private System.Windows.Forms.DateTimePicker datepicker_thoigianlap;
    }
}