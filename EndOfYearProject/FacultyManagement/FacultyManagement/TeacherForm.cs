using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyManagement
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Teacher> teacher = context.Teachers.ToList();
                dgvTeachers.DataSource = teacher;
                dgvTeachers.Columns["TeachSubjects"].Visible = false;
                dgvTeachers.Columns["FullName"].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addteacher = new AddTeacherForm();
            addteacher.ShowDialog();
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Teacher> teacher = context.Teachers.ToList();
                dgvTeachers.DataSource = teacher;
                dgvTeachers.Columns["TeachSubjects"].Visible = false;
                dgvTeachers.Columns["FullName"].Visible = false;
            }
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            EditTeacherForm editTeacher = new EditTeacherForm();
            editTeacher.selectedRow = dgvTeachers.CurrentRow;
            editTeacher.ShowDialog();
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Teacher> teacher = context.Teachers.ToList();
                dgvTeachers.DataSource = teacher;
                dgvTeachers.Columns["TeachSubjects"].Visible = false;
                dgvTeachers.Columns["FullName"].Visible = false;
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            using(FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                int ID = int.Parse(dgvTeachers.CurrentRow.Cells[0].Value.ToString());
                var item = context.Teachers.Find(ID);
                try
                {
                    if (MessageBox.Show($"Teacher {dgvTeachers.CurrentRow.Cells[1].Value.ToString()} {dgvTeachers.CurrentRow.Cells[2].Value.ToString()} will be permamently deleted!", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        context.Teachers.Remove(item);
                        context.SaveChanges();
                        List<Teacher> teacher = context.Teachers.ToList();
                        dgvTeachers.DataSource = teacher;
                        dgvTeachers.Columns["TeachSubjects"].Visible = false;
                        dgvTeachers.Columns["FullName"].Visible = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The teacher could not be deleted because it is actively teaching in the moment.");
                }
            }
        }

        private void btnSortBySalary_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var allData = context.Teachers.ToList();
                dgvTeachers.DataSource = allData.Select(x => new
                {
                    x.ID,
                    x.FirstName,
                    x.LastName,
                    x.Salary,
                    x.HireDate
                }).OrderByDescending (x => x.Salary).ToList();
            }
        }
    }
}
