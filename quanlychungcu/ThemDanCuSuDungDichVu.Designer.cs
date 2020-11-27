namespace quanlychungcu
{
    partial class ThemDanCuSuDungDichVu
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
            this.datagrid_dichvu = new System.Windows.Forms.DataGridView();
            this.datagrid_dancu = new System.Windows.Forms.DataGridView();
            this.btn_cleardv = new System.Windows.Forms.Button();
            this.btn_searchdv = new System.Windows.Forms.Button();
            this.combobox_searchdv = new System.Windows.Forms.ComboBox();
            this.txt_searchdv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cleardc = new System.Windows.Forms.Button();
            this.btn_searchdc = new System.Windows.Forms.Button();
            this.combobox_searchdc = new System.Windows.Forms.ComboBox();
            this.txt_searchdc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_clearformdancu = new System.Windows.Forms.Button();
            this.txt_macanho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_madancu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datepicker_thoigiansudung = new System.Windows.Forms.DateTimePicker();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tendichvu = new System.Windows.Forms.TextBox();
            this.btn_clearformdichvu = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_masodichvu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_dichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_dancu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_dichvu
            // 
            this.datagrid_dichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_dichvu.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_dichvu.Location = new System.Drawing.Point(73, 145);
            this.datagrid_dichvu.Name = "datagrid_dichvu";
            this.datagrid_dichvu.Size = new System.Drawing.Size(483, 150);
            this.datagrid_dichvu.TabIndex = 0;
            this.datagrid_dichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_dichvu_CellClick);
            // 
            // datagrid_dancu
            // 
            this.datagrid_dancu.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_dancu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_dancu.Location = new System.Drawing.Point(649, 145);
            this.datagrid_dancu.Name = "datagrid_dancu";
            this.datagrid_dancu.Size = new System.Drawing.Size(483, 150);
            this.datagrid_dancu.TabIndex = 1;
            this.datagrid_dancu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_dancu_CellClick);
            this.datagrid_dancu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_dancu_CellContentClick);
            // 
            // btn_cleardv
            // 
            this.btn_cleardv.BackColor = System.Drawing.Color.Gray;
            this.btn_cleardv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleardv.ForeColor = System.Drawing.Color.White;
            this.btn_cleardv.Location = new System.Drawing.Point(473, 106);
            this.btn_cleardv.Name = "btn_cleardv";
            this.btn_cleardv.Size = new System.Drawing.Size(83, 33);
            this.btn_cleardv.TabIndex = 20;
            this.btn_cleardv.Text = "Làm mới";
            this.btn_cleardv.UseVisualStyleBackColor = false;
            this.btn_cleardv.Click += new System.EventHandler(this.btn_cleardv_Click);
            // 
            // btn_searchdv
            // 
            this.btn_searchdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_searchdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchdv.ForeColor = System.Drawing.Color.White;
            this.btn_searchdv.Location = new System.Drawing.Point(384, 106);
            this.btn_searchdv.Name = "btn_searchdv";
            this.btn_searchdv.Size = new System.Drawing.Size(83, 33);
            this.btn_searchdv.TabIndex = 19;
            this.btn_searchdv.Text = "Tìm kiếm";
            this.btn_searchdv.UseVisualStyleBackColor = false;
            this.btn_searchdv.Click += new System.EventHandler(this.btn_searchdv_Click);
            // 
            // combobox_searchdv
            // 
            this.combobox_searchdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_searchdv.FormattingEnabled = true;
            this.combobox_searchdv.Items.AddRange(new object[] {
            "Mã số dịch vụ",
            "Tên dịch vụ",
            "Giá"});
            this.combobox_searchdv.Location = new System.Drawing.Point(271, 113);
            this.combobox_searchdv.Name = "combobox_searchdv";
            this.combobox_searchdv.Size = new System.Drawing.Size(92, 21);
            this.combobox_searchdv.TabIndex = 18;
            // 
            // txt_searchdv
            // 
            this.txt_searchdv.Location = new System.Drawing.Point(73, 113);
            this.txt_searchdv.Name = "txt_searchdv";
            this.txt_searchdv.Size = new System.Drawing.Size(192, 20);
            this.txt_searchdv.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label11.Location = new System.Drawing.Point(429, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(352, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Thêm dân cư sử dụng dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(256, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chọn dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(869, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Chọn dân cư";
            // 
            // btn_cleardc
            // 
            this.btn_cleardc.BackColor = System.Drawing.Color.Gray;
            this.btn_cleardc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleardc.ForeColor = System.Drawing.Color.White;
            this.btn_cleardc.Location = new System.Drawing.Point(1049, 106);
            this.btn_cleardc.Name = "btn_cleardc";
            this.btn_cleardc.Size = new System.Drawing.Size(83, 33);
            this.btn_cleardc.TabIndex = 27;
            this.btn_cleardc.Text = "Làm mới";
            this.btn_cleardc.UseVisualStyleBackColor = false;
            this.btn_cleardc.Click += new System.EventHandler(this.btn_cleardc_Click);
            // 
            // btn_searchdc
            // 
            this.btn_searchdc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(92)))));
            this.btn_searchdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchdc.ForeColor = System.Drawing.Color.White;
            this.btn_searchdc.Location = new System.Drawing.Point(960, 105);
            this.btn_searchdc.Name = "btn_searchdc";
            this.btn_searchdc.Size = new System.Drawing.Size(83, 33);
            this.btn_searchdc.TabIndex = 26;
            this.btn_searchdc.Text = "Tìm kiếm";
            this.btn_searchdc.UseVisualStyleBackColor = false;
            this.btn_searchdc.Click += new System.EventHandler(this.btn_searchdc_Click);
            // 
            // combobox_searchdc
            // 
            this.combobox_searchdc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_searchdc.FormattingEnabled = true;
            this.combobox_searchdc.Items.AddRange(new object[] {
            "Mã dân cư",
            "Họ và tên",
            "Ngày sinh",
            "Giới tính",
            "Chứng minh / Căn cước",
            "Số điện thoại",
            "Ngày chuyển vào",
            "Mã căn hộ"});
            this.combobox_searchdc.Location = new System.Drawing.Point(847, 112);
            this.combobox_searchdc.Name = "combobox_searchdc";
            this.combobox_searchdc.Size = new System.Drawing.Size(92, 21);
            this.combobox_searchdc.TabIndex = 25;
            // 
            // txt_searchdc
            // 
            this.txt_searchdc.Location = new System.Drawing.Point(649, 113);
            this.txt_searchdc.Name = "txt_searchdc";
            this.txt_searchdc.Size = new System.Drawing.Size(192, 20);
            this.txt_searchdc.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_clearformdancu);
            this.panel3.Controls.Add(this.txt_macanho);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_hovaten);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_madancu);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.datepicker_thoigiansudung);
            this.panel3.Controls.Add(this.txt_gia);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_tendichvu);
            this.panel3.Controls.Add(this.btn_clearformdichvu);
            this.panel3.Controls.Add(this.btn_xacnhan);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_masodichvu);
            this.panel3.Location = new System.Drawing.Point(73, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 286);
            this.panel3.TabIndex = 28;
            // 
            // btn_clearformdancu
            // 
            this.btn_clearformdancu.BackColor = System.Drawing.Color.Gray;
            this.btn_clearformdancu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearformdancu.ForeColor = System.Drawing.Color.White;
            this.btn_clearformdancu.Location = new System.Drawing.Point(808, 183);
            this.btn_clearformdancu.Name = "btn_clearformdancu";
            this.btn_clearformdancu.Size = new System.Drawing.Size(174, 33);
            this.btn_clearformdancu.TabIndex = 36;
            this.btn_clearformdancu.Text = "Làm mới dân cư";
            this.btn_clearformdancu.UseVisualStyleBackColor = false;
            this.btn_clearformdancu.Click += new System.EventHandler(this.btn_clearformdancu_Click);
            // 
            // txt_macanho
            // 
            this.txt_macanho.Enabled = false;
            this.txt_macanho.Location = new System.Drawing.Point(740, 146);
            this.txt_macanho.Name = "txt_macanho";
            this.txt_macanho.Size = new System.Drawing.Size(242, 20);
            this.txt_macanho.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(578, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Mã căn hộ";
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Enabled = false;
            this.txt_hovaten.Location = new System.Drawing.Point(740, 102);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(242, 20);
            this.txt_hovaten.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(578, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Họ và tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(578, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mã dân cư";
            // 
            // txt_madancu
            // 
            this.txt_madancu.Enabled = false;
            this.txt_madancu.Location = new System.Drawing.Point(740, 58);
            this.txt_madancu.Name = "txt_madancu";
            this.txt_madancu.Size = new System.Drawing.Size(242, 20);
            this.txt_madancu.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(36, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Thời gian sử dụng";
            // 
            // datepicker_thoigiansudung
            // 
            this.datepicker_thoigiansudung.CustomFormat = "dd/MM/yyyy";
            this.datepicker_thoigiansudung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_thoigiansudung.Location = new System.Drawing.Point(198, 196);
            this.datepicker_thoigiansudung.Name = "datepicker_thoigiansudung";
            this.datepicker_thoigiansudung.Size = new System.Drawing.Size(242, 20);
            this.datepicker_thoigiansudung.TabIndex = 28;
            // 
            // txt_gia
            // 
            this.txt_gia.Enabled = false;
            this.txt_gia.Location = new System.Drawing.Point(198, 146);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(242, 20);
            this.txt_gia.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá";
            // 
            // txt_tendichvu
            // 
            this.txt_tendichvu.Enabled = false;
            this.txt_tendichvu.Location = new System.Drawing.Point(198, 102);
            this.txt_tendichvu.Name = "txt_tendichvu";
            this.txt_tendichvu.Size = new System.Drawing.Size(242, 20);
            this.txt_tendichvu.TabIndex = 25;
            // 
            // btn_clearformdichvu
            // 
            this.btn_clearformdichvu.BackColor = System.Drawing.Color.Gray;
            this.btn_clearformdichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearformdichvu.ForeColor = System.Drawing.Color.White;
            this.btn_clearformdichvu.Location = new System.Drawing.Point(39, 240);
            this.btn_clearformdichvu.Name = "btn_clearformdichvu";
            this.btn_clearformdichvu.Size = new System.Drawing.Size(174, 33);
            this.btn_clearformdichvu.TabIndex = 16;
            this.btn_clearformdichvu.Text = "Làm mới dịch vụ";
            this.btn_clearformdichvu.UseVisualStyleBackColor = false;
            this.btn_clearformdichvu.Click += new System.EventHandler(this.btn_clearformdichvu_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_xacnhan.Enabled = false;
            this.btn_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhan.Location = new System.Drawing.Point(424, 240);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(237, 33);
            this.btn_xacnhan.TabIndex = 15;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(36, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên dịch vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(36, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mã số dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(306, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thông tin sử dụng dịch vụ được thêm";
            // 
            // txt_masodichvu
            // 
            this.txt_masodichvu.Enabled = false;
            this.txt_masodichvu.Location = new System.Drawing.Point(198, 58);
            this.txt_masodichvu.Name = "txt_masodichvu";
            this.txt_masodichvu.Size = new System.Drawing.Size(242, 20);
            this.txt_masodichvu.TabIndex = 5;
            // 
            // ThemDanCuSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1206, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_cleardc);
            this.Controls.Add(this.btn_searchdc);
            this.Controls.Add(this.combobox_searchdc);
            this.Controls.Add(this.txt_searchdc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_cleardv);
            this.Controls.Add(this.btn_searchdv);
            this.Controls.Add(this.combobox_searchdv);
            this.Controls.Add(this.txt_searchdv);
            this.Controls.Add(this.datagrid_dancu);
            this.Controls.Add(this.datagrid_dichvu);
            this.Name = "ThemDanCuSuDungDichVu";
            this.Text = "ThemDanCuSuDungDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_dichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_dancu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_dichvu;
        private System.Windows.Forms.DataGridView datagrid_dancu;
        private System.Windows.Forms.Button btn_cleardv;
        private System.Windows.Forms.Button btn_searchdv;
        private System.Windows.Forms.ComboBox combobox_searchdv;
        private System.Windows.Forms.TextBox txt_searchdv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cleardc;
        private System.Windows.Forms.Button btn_searchdc;
        private System.Windows.Forms.ComboBox combobox_searchdc;
        private System.Windows.Forms.TextBox txt_searchdc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_macanho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_madancu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datepicker_thoigiansudung;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tendichvu;
        private System.Windows.Forms.Button btn_clearformdichvu;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_masodichvu;
        private System.Windows.Forms.Button btn_clearformdancu;
    }
}