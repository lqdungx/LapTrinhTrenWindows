using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ccbChuyenNganh.SelectedIndex = 0;
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                if (dgvSinhVien.Rows[i].Cells[0].Value != null && dgvSinhVien.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }    
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvSinhVien.Rows[selectedRow].Cells[0].Value = txtMaSV.Text;
            dgvSinhVien.Rows[selectedRow].Cells[1].Value = txtHoten.Text;
            dgvSinhVien.Rows[selectedRow].Cells[2].Value = rdbNu.Checked ? "Nữ" : "Nam";
            dgvSinhVien.Rows[selectedRow].Cells[3].Value = float.Parse(txtDiemTB.Text).ToString();
            dgvSinhVien.Rows[selectedRow].Cells[4].Value = ccbChuyenNganh.Text;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaSV.Text == "" || txtHoten.Text == "" || txtDiemTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");

                int selectedRow = GetSelectedRow(txtMaSV.Text);
                if(selectedRow == -1)
                {
                    selectedRow = dgvSinhVien.Rows.Add();
                    InsertUpdate(selectedRow);
                    UpdateGenderCount();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }    
                else
                {
                    InsertUpdate(selectedRow);
                    UpdateGenderCount();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedRow = GetSelectedRow(txtMaSV.Text);
                if(selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xoá!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xoá ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvSinhVien.Rows.RemoveAt(selectedRow);
                        UpdateGenderCount();
                        MessageBox.Show("Xoá sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGenderCount()
        {
            int soNam = 0, soNu = 0;

            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.IsNewRow) continue;

                string gender = row.Cells[2].Value?.ToString();
                if (gender == "Nam") soNam++;
                else if (gender == "Nữ") soNu++;
            }

            lblNam.Text = "Tổng SV Nam: " + soNam;
            lblNu.Text = "Nữ: " + soNu;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoten.Text = row.Cells[1].Value.ToString();
                rdbNu.Checked = row.Cells[2].Value.ToString() == "Nữ";
                rdbNam.Checked = row.Cells[2].Value.ToString() == "Nam";
                txtDiemTB.Text = row.Cells[3].Value.ToString();
                ccbChuyenNganh.Text = row.Cells[4].Value.ToString();
            }
        }

        private void grbTTSV_Enter(object sender, EventArgs e)
        {

        }
    }
}
