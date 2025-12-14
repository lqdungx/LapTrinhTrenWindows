namespace BaiTapTuan6
{
    partial class frmStudent
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
            this.lblQuanLySinhVien = new System.Windows.Forms.Label();
            this.grpThongTinSV = new System.Windows.Forms.GroupBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.lblAnhDaiDien = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkUnregisterMajor = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýChuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuanLySinhVien
            // 
            this.lblQuanLySinhVien.AutoSize = true;
            this.lblQuanLySinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLySinhVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuanLySinhVien.Location = new System.Drawing.Point(342, 24);
            this.lblQuanLySinhVien.Name = "lblQuanLySinhVien";
            this.lblQuanLySinhVien.Size = new System.Drawing.Size(299, 39);
            this.lblQuanLySinhVien.TabIndex = 0;
            this.lblQuanLySinhVien.Text = "Quản lý sinh viên";
            // 
            // grpThongTinSV
            // 
            this.grpThongTinSV.Controls.Add(this.btnSelectImage);
            this.grpThongTinSV.Controls.Add(this.btnDelete);
            this.grpThongTinSV.Controls.Add(this.txtDiemTB);
            this.grpThongTinSV.Controls.Add(this.btnAddUpdate);
            this.grpThongTinSV.Controls.Add(this.txtHoTen);
            this.grpThongTinSV.Controls.Add(this.txtMaSV);
            this.grpThongTinSV.Controls.Add(this.picAvatar);
            this.grpThongTinSV.Controls.Add(this.cbbKhoa);
            this.grpThongTinSV.Controls.Add(this.lblAnhDaiDien);
            this.grpThongTinSV.Controls.Add(this.lblDiemTB);
            this.grpThongTinSV.Controls.Add(this.lblKhoa);
            this.grpThongTinSV.Controls.Add(this.lblHoTen);
            this.grpThongTinSV.Controls.Add(this.lblMaSV);
            this.grpThongTinSV.Location = new System.Drawing.Point(0, 81);
            this.grpThongTinSV.Name = "grpThongTinSV";
            this.grpThongTinSV.Size = new System.Drawing.Size(300, 342);
            this.grpThongTinSV.TabIndex = 1;
            this.grpThongTinSV.TabStop = false;
            this.grpThongTinSV.Text = "Thông Tin Sinh Viên";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(262, 236);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(34, 23);
            this.btnSelectImage.TabIndex = 14;
            this.btnSelectImage.Text = "...";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(104, 156);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(100, 20);
            this.txtDiemTB.TabIndex = 12;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(49, 303);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 3;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(104, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(152, 20);
            this.txtHoTen.TabIndex = 11;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(104, 35);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(152, 20);
            this.txtMaSV.TabIndex = 6;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(104, 194);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(152, 101);
            this.picAvatar.TabIndex = 10;
            this.picAvatar.TabStop = false;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(104, 118);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(152, 21);
            this.cbbKhoa.TabIndex = 9;
            // 
            // lblAnhDaiDien
            // 
            this.lblAnhDaiDien.Location = new System.Drawing.Point(12, 194);
            this.lblAnhDaiDien.Name = "lblAnhDaiDien";
            this.lblAnhDaiDien.Size = new System.Drawing.Size(67, 20);
            this.lblAnhDaiDien.TabIndex = 5;
            this.lblAnhDaiDien.Text = "Ảnh đại diện";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(12, 159);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(86, 13);
            this.lblDiemTB.TabIndex = 4;
            this.lblDiemTB.Text = "Điểm Trung Bình";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(12, 118);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 76);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(12, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoTen,
            this.colKhoa,
            this.colDTB,
            this.colChuyenNganh});
            this.dgvStudent.Location = new System.Drawing.Point(326, 88);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(697, 319);
            this.dgvStudent.TabIndex = 2;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
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
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.Name = "colKhoa";
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "DTB";
            this.colDTB.Name = "colDTB";
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.HeaderText = "Chuyên ngành";
            this.colChuyenNganh.Name = "colChuyenNganh";
            // 
            // chkUnregisterMajor
            // 
            this.chkUnregisterMajor.AutoSize = true;
            this.chkUnregisterMajor.Location = new System.Drawing.Point(883, 65);
            this.chkUnregisterMajor.Name = "chkUnregisterMajor";
            this.chkUnregisterMajor.Size = new System.Drawing.Size(140, 17);
            this.chkUnregisterMajor.TabIndex = 4;
            this.chkUnregisterMajor.Text = "Chưa ĐK chuyên ngành";
            this.chkUnregisterMajor.UseVisualStyleBackColor = true;
            this.chkUnregisterMajor.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýChuyênNgànhToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngKýChuyênNgànhToolStripMenuItem
            // 
            this.đăngKýChuyênNgànhToolStripMenuItem.Name = "đăngKýChuyênNgànhToolStripMenuItem";
            this.đăngKýChuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.đăngKýChuyênNgànhToolStripMenuItem.Text = "Đăng ký chuyên ngành";
            this.đăngKýChuyênNgànhToolStripMenuItem.Click += new System.EventHandler(this.đăngKýChuyênNgànhToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.chkUnregisterMajor);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.grpThongTinSV);
            this.Controls.Add(this.lblQuanLySinhVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudent";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.grpThongTinSV.ResumeLayout(false);
            this.grpThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLySinhVien;
        private System.Windows.Forms.GroupBox grpThongTinSV;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.CheckBox chkUnregisterMajor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label lblAnhDaiDien;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ToolStripMenuItem đăngKýChuyênNgànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

