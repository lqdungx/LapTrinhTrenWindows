namespace BaiTapTuan3
{
    partial class From1
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastName,
            this.firstName,
            this.phone});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(409, 169);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 141;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 139;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 152;
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.CausesValidation = false;
            this.lbl1.Location = new System.Drawing.Point(5, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(103, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Detail";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 16);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(58, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Last Name";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(7, 55);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "First Name";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(7, 95);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(38, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Phone";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(9, 32);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(211, 20);
            this.txtLast.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(10, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(211, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // btnName
            // 
            this.btnName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnName.Location = new System.Drawing.Point(146, 142);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 9;
            this.btnName.Text = "Add Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // lbl5
            // 
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5.Location = new System.Drawing.Point(5, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(647, 19);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "File     View      Format ListView";
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.txtFirst);
            this.grb1.Controls.Add(this.btnName);
            this.grb1.Controls.Add(this.lbl2);
            this.grb1.Controls.Add(this.txtPhone);
            this.grb1.Controls.Add(this.lbl4);
            this.grb1.Controls.Add(this.txtLast);
            this.grb1.Controls.Add(this.lbl3);
            this.grb1.Location = new System.Drawing.Point(420, 45);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(232, 174);
            this.grb1.TabIndex = 11;
            this.grb1.TabStop = false;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(10, 72);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(210, 20);
            this.txtFirst.TabIndex = 7;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(655, 227);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grb1);
            this.Name = "From1";
            this.Text = "ListView Demo";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TextBox txtFirst;
    }
}

