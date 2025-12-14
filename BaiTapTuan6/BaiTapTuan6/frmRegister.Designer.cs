namespace BaiTapTuan6
{
    partial class frmRegister
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
            this.lblDKChuyenNganh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDKChuyenNganh
            // 
            this.lblDKChuyenNganh.AutoSize = true;
            this.lblDKChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKChuyenNganh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDKChuyenNganh.Location = new System.Drawing.Point(197, 9);
            this.lblDKChuyenNganh.Name = "lblDKChuyenNganh";
            this.lblDKChuyenNganh.Size = new System.Drawing.Size(389, 39);
            this.lblDKChuyenNganh.TabIndex = 0;
            this.lblDKChuyenNganh.Text = "Đăng ký chuyên ngành";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(148, 61);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(148, 131);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(76, 13);
            this.lblChuyenNganh.TabIndex = 2;
            this.lblChuyenNganh.Text = "Chuyên ngành";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.colMssv,
            this.colHoTen,
            this.colKhoa,
            this.colDTB});
            this.dgvStudent.Location = new System.Drawing.Point(34, 180);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(737, 216);
            this.dgvStudent.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(34, 415);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(254, 66);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(286, 21);
            this.cbbKhoa.TabIndex = 7;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // cbbChuyenNganh
            // 
            this.cbbChuyenNganh.FormattingEnabled = true;
            this.cbbChuyenNganh.Location = new System.Drawing.Point(254, 131);
            this.cbbChuyenNganh.Name = "cbbChuyenNganh";
            this.cbbChuyenNganh.Size = new System.Drawing.Size(286, 21);
            this.cbbChuyenNganh.TabIndex = 8;
            // 
            // chk
            // 
            this.chk.HeaderText = "Chọn";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMssv
            // 
            this.colMssv.HeaderText = "MSSV";
            this.colMssv.Name = "colMssv";
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
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.cbbChuyenNganh);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lblChuyenNganh);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblDKChuyenNganh);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDKChuyenNganh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbChuyenNganh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
    }
}