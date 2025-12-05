namespace Bai2_QLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.ccbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblQLTTSV = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblNu = new System.Windows.Forms.Label();
            this.grbTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTSV
            // 
            this.grbTTSV.Controls.Add(this.ccbChuyenNganh);
            this.grbTTSV.Controls.Add(this.txtDiemTB);
            this.grbTTSV.Controls.Add(this.rdbNu);
            this.grbTTSV.Controls.Add(this.rdbNam);
            this.grbTTSV.Controls.Add(this.txtHoten);
            this.grbTTSV.Controls.Add(this.txtMaSV);
            this.grbTTSV.Controls.Add(this.lblChuyenNganh);
            this.grbTTSV.Controls.Add(this.lblDiemTB);
            this.grbTTSV.Controls.Add(this.lblGioiTinh);
            this.grbTTSV.Controls.Add(this.lblHoTen);
            this.grbTTSV.Controls.Add(this.lblMaSV);
            this.grbTTSV.Location = new System.Drawing.Point(53, 102);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Size = new System.Drawing.Size(382, 232);
            this.grbTTSV.TabIndex = 0;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Thông Tin Sinh Viên";
            this.grbTTSV.Enter += new System.EventHandler(this.grbTTSV_Enter);
            // 
            // ccbChuyenNganh
            // 
            this.ccbChuyenNganh.FormattingEnabled = true;
            this.ccbChuyenNganh.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.ccbChuyenNganh.Location = new System.Drawing.Point(95, 181);
            this.ccbChuyenNganh.Name = "ccbChuyenNganh";
            this.ccbChuyenNganh.Size = new System.Drawing.Size(219, 21);
            this.ccbChuyenNganh.TabIndex = 13;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(95, 138);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(149, 20);
            this.txtDiemTB.TabIndex = 12;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Checked = true;
            this.rdbNu.Location = new System.Drawing.Point(186, 106);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 11;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(95, 106);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 10;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(95, 70);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(149, 20);
            this.txtHoten.TabIndex = 9;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(95, 31);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(149, 20);
            this.txtMaSV.TabIndex = 8;
            this.txtMaSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(6, 185);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(78, 13);
            this.lblChuyenNganh.TabIndex = 7;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(6, 142);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(48, 13);
            this.lblDiemTB.TabIndex = 6;
            this.lblDiemTB.Text = "Điểm TB";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(6, 108);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 74);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(6, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblMaSV.TabIndex = 3;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // lblQLTTSV
            // 
            this.lblQLTTSV.AutoSize = true;
            this.lblQLTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTTSV.ForeColor = System.Drawing.Color.Blue;
            this.lblQLTTSV.Location = new System.Drawing.Point(296, 37);
            this.lblQLTTSV.Name = "lblQLTTSV";
            this.lblQLTTSV.Size = new System.Drawing.Size(491, 33);
            this.lblQLTTSV.TabIndex = 1;
            this.lblQLTTSV.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoTen,
            this.colGioiTinh,
            this.colDTB,
            this.colKhoa});
            this.dgvSinhVien.Location = new System.Drawing.Point(461, 102);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(579, 242);
            this.dgvSinhVien.TabIndex = 2;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.Name = "colMSSV";
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "ĐTB";
            this.colDTB.Name = "colDTB";
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.Name = "colKhoa";
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(258, 344);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(75, 23);
            this.btnThemSua.TabIndex = 3;
            this.btnThemSua.Text = "Thêm / Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 344);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(797, 374);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(74, 13);
            this.lblNam.TabIndex = 5;
            this.lblNam.Text = "Tổng SV Nam";
            // 
            // lblNu
            // 
            this.lblNu.AutoSize = true;
            this.lblNu.Location = new System.Drawing.Point(897, 374);
            this.lblNu.Name = "lblNu";
            this.lblNu.Size = new System.Drawing.Size(21, 13);
            this.lblNu.TabIndex = 7;
            this.lblNu.Text = "Nữ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.lblNu);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.lblQLTTSV);
            this.Controls.Add(this.grbTTSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTTSV.ResumeLayout(false);
            this.grbTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.ComboBox ccbChuyenNganh;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblQLTTSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
    }
}

