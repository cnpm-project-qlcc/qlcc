namespace quanlychungcu
{
    partial class QuanLyCanHo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_suathongtincanho = new System.Windows.Forms.Button();
            this.btn_xoacanho = new System.Windows.Forms.Button();
            this.combobox_tinhtrangcanho = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giacanho = new System.Windows.Forms.TextBox();
            this.txt_tencanho = new System.Windows.Forms.TextBox();
            this.txt_macanho = new System.Windows.Forms.TextBox();
            this.btn_clearsearh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.combobox_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.datagridview_quanlycanho = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_themcanho = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_giacanhomoi = new System.Windows.Forms.TextBox();
            this.txt_tencanhomoi = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_quanlycanho)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 475);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btn_clearsearh);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.combobox_search);
            this.tabPage1.Controls.Add(this.txt_search);
            this.tabPage1.Controls.Add(this.datagridview_quanlycanho);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý căn hộ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_lammoi);
            this.panel1.Controls.Add(this.btn_suathongtincanho);
            this.panel1.Controls.Add(this.btn_xoacanho);
            this.panel1.Controls.Add(this.combobox_tinhtrangcanho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_giacanho);
            this.panel1.Controls.Add(this.txt_tencanho);
            this.panel1.Controls.Add(this.txt_macanho);
            this.panel1.Location = new System.Drawing.Point(676, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 391);
            this.panel1.TabIndex = 11;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.Gray;
            this.btn_lammoi.Enabled = false;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.ForeColor = System.Drawing.Color.White;
            this.btn_lammoi.Location = new System.Drawing.Point(141, 336);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(242, 33);
            this.btn_lammoi.TabIndex = 18;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_suathongtincanho
            // 
            this.btn_suathongtincanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_suathongtincanho.Enabled = false;
            this.btn_suathongtincanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suathongtincanho.ForeColor = System.Drawing.Color.White;
            this.btn_suathongtincanho.Location = new System.Drawing.Point(140, 297);
            this.btn_suathongtincanho.Name = "btn_suathongtincanho";
            this.btn_suathongtincanho.Size = new System.Drawing.Size(144, 33);
            this.btn_suathongtincanho.TabIndex = 16;
            this.btn_suathongtincanho.Text = "Sửa thông tin căn hộ";
            this.btn_suathongtincanho.UseVisualStyleBackColor = false;
            this.btn_suathongtincanho.Click += new System.EventHandler(this.btn_suathongtincanho_Click);
            // 
            // btn_xoacanho
            // 
            this.btn_xoacanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(92)))));
            this.btn_xoacanho.Enabled = false;
            this.btn_xoacanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoacanho.ForeColor = System.Drawing.Color.White;
            this.btn_xoacanho.Location = new System.Drawing.Point(290, 297);
            this.btn_xoacanho.Name = "btn_xoacanho";
            this.btn_xoacanho.Size = new System.Drawing.Size(93, 33);
            this.btn_xoacanho.TabIndex = 15;
            this.btn_xoacanho.Text = "Xóa căn hộ";
            this.btn_xoacanho.UseVisualStyleBackColor = false;
            this.btn_xoacanho.Click += new System.EventHandler(this.btn_xoacanho_Click);
            // 
            // combobox_tinhtrangcanho
            // 
            this.combobox_tinhtrangcanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_tinhtrangcanho.FormattingEnabled = true;
            this.combobox_tinhtrangcanho.Items.AddRange(new object[] {
            "Trống",
            "Thuê",
            "Mua góp",
            "Mua"});
            this.combobox_tinhtrangcanho.Location = new System.Drawing.Point(141, 240);
            this.combobox_tinhtrangcanho.Name = "combobox_tinhtrangcanho";
            this.combobox_tinhtrangcanho.Size = new System.Drawing.Size(242, 21);
            this.combobox_tinhtrangcanho.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(41, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(41, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(41, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên căn hộ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(41, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(160, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quản lý căn hộ";
            // 
            // txt_giacanho
            // 
            this.txt_giacanho.Location = new System.Drawing.Point(141, 190);
            this.txt_giacanho.Name = "txt_giacanho";
            this.txt_giacanho.Size = new System.Drawing.Size(242, 20);
            this.txt_giacanho.TabIndex = 6;
            this.txt_giacanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giacanho_KeyPress);
            // 
            // txt_tencanho
            // 
            this.txt_tencanho.Location = new System.Drawing.Point(141, 140);
            this.txt_tencanho.Name = "txt_tencanho";
            this.txt_tencanho.Size = new System.Drawing.Size(242, 20);
            this.txt_tencanho.TabIndex = 5;
            // 
            // txt_macanho
            // 
            this.txt_macanho.Enabled = false;
            this.txt_macanho.Location = new System.Drawing.Point(141, 90);
            this.txt_macanho.Name = "txt_macanho";
            this.txt_macanho.Size = new System.Drawing.Size(242, 20);
            this.txt_macanho.TabIndex = 4;
            // 
            // btn_clearsearh
            // 
            this.btn_clearsearh.BackColor = System.Drawing.Color.Gray;
            this.btn_clearsearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearh.ForeColor = System.Drawing.Color.White;
            this.btn_clearsearh.Location = new System.Drawing.Point(572, 30);
            this.btn_clearsearh.Name = "btn_clearsearh";
            this.btn_clearsearh.Size = new System.Drawing.Size(83, 33);
            this.btn_clearsearh.TabIndex = 10;
            this.btn_clearsearh.Text = "Làm mới";
            this.btn_clearsearh.UseVisualStyleBackColor = false;
            this.btn_clearsearh.Click += new System.EventHandler(this.btn_clearsearh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(471, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 9;
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
            this.combobox_search.Location = new System.Drawing.Point(343, 38);
            this.combobox_search.Name = "combobox_search";
            this.combobox_search.Size = new System.Drawing.Size(92, 21);
            this.combobox_search.TabIndex = 8;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(16, 38);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(321, 20);
            this.txt_search.TabIndex = 7;
            // 
            // datagridview_quanlycanho
            // 
            this.datagridview_quanlycanho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_quanlycanho.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_quanlycanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_quanlycanho.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datagridview_quanlycanho.Location = new System.Drawing.Point(16, 69);
            this.datagridview_quanlycanho.Name = "datagridview_quanlycanho";
            this.datagridview_quanlycanho.Size = new System.Drawing.Size(639, 354);
            this.datagridview_quanlycanho.TabIndex = 6;
            this.datagridview_quanlycanho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_quanlycanho_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1165, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm căn hộ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_themcanho);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_giacanhomoi);
            this.panel2.Controls.Add(this.txt_tencanhomoi);
            this.panel2.Location = new System.Drawing.Point(200, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 376);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(233, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giá căn hộ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(233, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên căn hộ";
            // 
            // btn_themcanho
            // 
            this.btn_themcanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_themcanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themcanho.ForeColor = System.Drawing.Color.White;
            this.btn_themcanho.Location = new System.Drawing.Point(298, 292);
            this.btn_themcanho.Name = "btn_themcanho";
            this.btn_themcanho.Size = new System.Drawing.Size(187, 32);
            this.btn_themcanho.TabIndex = 4;
            this.btn_themcanho.Text = "Thêm căn hộ";
            this.btn_themcanho.UseVisualStyleBackColor = false;
            this.btn_themcanho.Click += new System.EventHandler(this.btn_themcanho_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(294, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thêm căn hộ mới";
            // 
            // txt_giacanhomoi
            // 
            this.txt_giacanhomoi.Location = new System.Drawing.Point(236, 220);
            this.txt_giacanhomoi.Name = "txt_giacanhomoi";
            this.txt_giacanhomoi.Size = new System.Drawing.Size(302, 20);
            this.txt_giacanhomoi.TabIndex = 1;
            this.txt_giacanhomoi.TextChanged += new System.EventHandler(this.txt_giacanhomoi_TextChanged);
            this.txt_giacanhomoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giacanhomoi_KeyPress);
            // 
            // txt_tencanhomoi
            // 
            this.txt_tencanhomoi.Location = new System.Drawing.Point(236, 156);
            this.txt_tencanhomoi.Name = "txt_tencanhomoi";
            this.txt_tencanhomoi.Size = new System.Drawing.Size(302, 20);
            this.txt_tencanhomoi.TabIndex = 0;
            // 
            // QuanLyCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1208, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyCanHo";
            this.Text = "QuanLyCanHo";
            this.Load += new System.EventHandler(this.QuanLyCanHo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_quanlycanho)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_suathongtincanho;
        private System.Windows.Forms.Button btn_xoacanho;
        private System.Windows.Forms.ComboBox combobox_tinhtrangcanho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giacanho;
        private System.Windows.Forms.TextBox txt_tencanho;
        private System.Windows.Forms.TextBox txt_macanho;
        private System.Windows.Forms.Button btn_clearsearh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox combobox_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView datagridview_quanlycanho;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_themcanho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_giacanhomoi;
        private System.Windows.Forms.TextBox txt_tencanhomoi;
    }
}