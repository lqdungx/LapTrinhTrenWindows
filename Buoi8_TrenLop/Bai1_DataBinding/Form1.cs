using System;
using System.Linq;
using System.Windows.Forms;
using Bai1_DataBinding.Models;

namespace Bai1_DataBinding
{
    public partial class Form1 : Form
    {
        SchoolContext db = new SchoolContext();
        BindingSource bsStudent = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMajor();
            LoadData();

            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
        }

        private void LoadData()
        {
            bsStudent.DataSource = db.Students.ToList();

            dgvSinhVien.DataSource = bsStudent;
            bindingNavigator1.BindingSource = bsStudent;

            BindControls();
        }

        private void BindControls()
        {
            txtFullName.DataBindings.Clear();
            txtAge.DataBindings.Clear();
            cbbMajor.DataBindings.Clear();

            txtFullName.DataBindings.Add(
                "Text", bsStudent, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);

            txtAge.DataBindings.Add(
                "Text", bsStudent, "Age", true, DataSourceUpdateMode.OnPropertyChanged);

            cbbMajor.DataBindings.Add(
                "Text", bsStudent, "Major", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadMajor()
        {
            cbbMajor.Items.Clear();
            cbbMajor.Items.Add("Công nghệ thông tin");
            cbbMajor.Items.Add("Kế toán");
            cbbMajor.Items.Add("Quản trị kinh doanh");
            cbbMajor.Items.Add("Marketing");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Student sv = new Student
            {
                FullName = txtFullName.Text,
                Age = int.Parse(txtAge.Text),
                Major = cbbMajor.Text
            };

            db.Students.Add(sv);
            db.SaveChanges();
            LoadData();

            MessageBox.Show("Thêm sinh viên thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bsStudent.Current == null) return;

            Student sv = (Student)bsStudent.Current;

            db.Students.Remove(sv);
            db.SaveChanges();
            LoadData();

            MessageBox.Show("Xóa sinh viên thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (bsStudent.Current == null) return;

            Student sv = (Student)bsStudent.Current;

            sv.FullName = txtFullName.Text;
            sv.Age = int.Parse(txtAge.Text);
            sv.Major = cbbMajor.Text;

            db.SaveChanges();
            LoadData();

            MessageBox.Show("Cập nhật thành công!");
        }
    }
}
