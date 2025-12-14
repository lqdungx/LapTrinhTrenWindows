using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapTuan6
{
    public partial class frmStudent : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();

        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudent);
                LoadFaculty();
                BindGrid(studentService.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadFaculty()
        {
            var list = facultyService.GetAll();
            list.Insert(0, new Faculty()); 

            cbbKhoa.DataSource = list;
            cbbKhoa.DisplayMember = "FacultyName";
            cbbKhoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value =
                    item.Faculty != null ? item.Faculty.FacultyName : "";
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
                dgvStudent.Rows[index].Cells[4].Value =
                    item.Major != null ? item.Major.Name : "";
            }
        }

        public void setGridViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }   

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string id = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            Student student = studentService.FindById(id);
            if (student == null) return;

            txtMaSV.Text = student.StudentID;
            txtHoTen.Text = student.FullName;
            txtDiemTB.Text = student.AverageScore?.ToString();

            if (student.FacultyID != null)
                cbbKhoa.SelectedValue = student.FacultyID;
            else
                cbbKhoa.SelectedIndex = 0;

            picAvatar.Tag = student.Avatar;
            ShowAvatar(student.Avatar);
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) ||
                string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            Student student = studentService.FindById(txtMaSV.Text);
            if (student == null)
            {
                student = new Student();
                student.StudentID = txtMaSV.Text;
            }

            student.FullName = txtHoTen.Text;

            double d;
            student.AverageScore = double.TryParse(txtDiemTB.Text, out d) ? d : (double?)null;

            if (cbbKhoa.SelectedIndex > 0)
                student.FacultyID = Convert.ToInt32(cbbKhoa.SelectedValue);
            else
                student.FacultyID = null;

            student.Avatar = picAvatar.Tag != null ? picAvatar.Tag.ToString() : null;

            studentService.InsertUpdate(student);

            UpdateDataGridView();
            MessageBox.Show("Lưu sinh viên thành công!");
        }

        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            BindGrid(chkUnregisterMajor.Checked ? studentService.GetAllHasNoMajor() : studentService.GetAll());
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên trước khi chọn ảnh!");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string root = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagesFolder = Path.Combine(root, "Images");

                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                string extension = Path.GetExtension(ofd.FileName).ToLower();

                string fileName = txtMaSV.Text + extension;
                string destPath = Path.Combine(imagesFolder, fileName);

                File.Copy(ofd.FileName, destPath, true);

                FileInfo fi = new FileInfo(destPath);
                fi.Attributes = FileAttributes.Normal;

                picAvatar.Tag = fileName;
                ShowAvatar(fileName);
            } 
        }

        private void ShowAvatar(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                picAvatar.Image = null;
                return;
            }

            string root = Directory.GetParent(
                AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

            string path = Path.Combine(root, "Images", imageName);
            if (!File.Exists(path))
            {
                picAvatar.Image = null;
                return;
            }

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                picAvatar.Image = Image.FromStream(fs);
            }
        }

        public void UpdateDataGridView()
        {
            BindGrid(studentService.GetAll());
        }

        private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            Student student = studentService.FindById(txtMaSV.Text);
            if (student == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            string root = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imagesFolder = Path.Combine(root, "Images");

            if (!string.IsNullOrEmpty(student.Avatar))
            {
                string imagePath = Path.Combine(imagesFolder, student.Avatar);
                if (File.Exists(imagePath))
                {
                    try
                    {
                        File.Delete(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa ảnh: " + ex.Message);
                    }
                }
            }

            studentService.Delete(student.StudentID);

            UpdateDataGridView();
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            cbbKhoa.SelectedIndex = 0;
            picAvatar.Image = null;
            picAvatar.Tag = null;

            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
