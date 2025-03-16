using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FacultyManagement
{
    public partial class QueriesForm : Form
    {
        public QueriesForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QueriesForm_Load(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var alldata = context.TeachSubjects.Include(s => s.Teacher).Include(s => s.Subject).ToList();
                dgvFaculty.DataSource = alldata.Select(x => new
                {
                    x.ID,
                    x.Teacher.FullName,
                    x.Teacher.HireDate,
                    x.Teacher.Salary,
                    x.Subject.SubjectName,
                    x.Subject.NumberSemesters
                }).ToList();

                List<Subject> subject = context.Subjects.ToList();
                cbSubjects.DataSource = subject;
                cbSubjects.DisplayMember = "SubjectName";
                cbSubjects.ValueMember = "ID";
            }
        }

        private void btnLongSubjects_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var alldata = context.TeachSubjects.Include(s => s.Teacher).Include(s => s.Subject).ToList();
                dgvFaculty.DataSource = alldata.Select(x => new
                {
                    x.ID,
                    x.Teacher.FullName,
                    x.Subject.SubjectName,
                    x.Subject.NumberSemesters
                }).Where(x => x.NumberSemesters>2 ).ToList();
            }
        }

        private void btnSpecificSubject_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var alldata = context.TeachSubjects.Include(s => s.Teacher).Include(s => s.Subject).ToList();
                dgvFaculty.DataSource = alldata.Select(x => new
                {
                    x.ID,
                    x.Teacher.FullName,
                    x.Subject.SubjectName,
                    x.Subject.NumberSemesters
                }).Where(x => x.SubjectName == cbSubjects.Text).ToList();

            }
        }

        private void btnExpTeachers_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var alldata = context.TeachSubjects.Include(s => s.Teacher).Include(s => s.Subject).ToList();
                dgvFaculty.DataSource = alldata.Select(x => new
                {
                    x.ID,
                    x.Teacher.FullName,
                    x.Teacher.HireDate,
                    x.Subject.SubjectName,
                    x.Subject.NumberSemesters
                }).Where(x => (2024-x.HireDate.Year)>9 && (2024 - x.HireDate.Year)<16).ToList();

            }
        }
    }
}
