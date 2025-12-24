using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapTuan6
{
    public partial class frmRegister : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();

        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadFaculty();

            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.MultiSelect = false;
            dgvStudent.ReadOnly = false;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void LoadFaculty()
        {
            var list = facultyService.GetAll();
            list.Insert(0, new Faculty
            {
                FacultyID = 0,
                FacultyName = "-- Chọn khoa --"
            });

            cbbKhoa.DataSource = list;
            cbbKhoa.DisplayMember = "FacultyName";
            cbbKhoa.ValueMember = "FacultyID";
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedIndex <= 0)
            {
                dgvStudent.Rows.Clear();
                cbbChuyenNganh.DataSource = null;
                return;
            }

            int facultyID = Convert.ToInt32(cbbKhoa.SelectedValue);

            var majors = majorService.GetAllByFaculty(facultyID);
            FillMajorCombobox(majors);

            var students = studentService.GetAllHasNoMajor(facultyID);
            BindGrid(students);
        }

        private void FillMajorCombobox(List<Major> listMajors)
        {
            listMajors.Insert(0, new Major
            {
                MajorID = 0,
                Name = "-- Chọn chuyên ngành --"
            });

            cbbChuyenNganh.DataSource = listMajors;
            cbbChuyenNganh.DisplayMember = "Name";
            cbbChuyenNganh.ValueMember = "MajorID";
        }

        private void BindGrid(List<Student> listStudents)
        {
            dgvStudent.Rows.Clear();

            foreach (var s in listStudents)
            {
                int row = dgvStudent.Rows.Add();

                dgvStudent.Rows[row].Cells["chk"].Value = false;
                dgvStudent.Rows[row].Cells["colMssv"].Value = s.StudentID;
                dgvStudent.Rows[row].Cells["colHoTen"].Value = s.FullName;
                dgvStudent.Rows[row].Cells["colDTB"].Value = s.AverageScore;
                dgvStudent.Rows[row].Cells["colKhoa"].Value =
                    s.Faculty != null ? s.Faculty.FacultyName : "";
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvStudent.Columns[e.ColumnIndex].Name == "chk")
            {
                foreach (DataGridViewRow row in dgvStudent.Rows)
                    row.Cells["chk"].Value = false;

                dgvStudent.Rows[e.RowIndex].Cells["chk"].Value = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvStudent.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => Convert.ToBoolean(r.Cells["chk"].Value));

            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!");
                return;
            }

            if (cbbChuyenNganh.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành!");
                return;
            }

            string studentID = selectedRow.Cells["colMssv"].Value.ToString();
            int majorID = Convert.ToInt32(cbbChuyenNganh.SelectedValue);

            Student student = studentService.FindById(studentID);
            if (student == null) return;

            student.MajorID = majorID;
            studentService.InsertUpdate(student);

            MessageBox.Show("Đăng ký chuyên ngành thành công!");

            int facultyID = Convert.ToInt32(cbbKhoa.SelectedValue);
            BindGrid(studentService.GetAllHasNoMajor(facultyID));
        }
    }
}
