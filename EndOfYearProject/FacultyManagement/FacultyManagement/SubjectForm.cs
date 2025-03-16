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
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Subject> subject = context.Subjects.ToList();
                dgvSubjects.DataSource = subject;
                dgvSubjects.Columns["TeachSubjects"].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSubjectForm addsubject = new AddSubjectForm();
            addsubject.ShowDialog();
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Subject> subject = context.Subjects.ToList();
                dgvSubjects.DataSource = subject;
                dgvSubjects.Columns["TeachSubjects"].Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSubjectForm editSubject= new EditSubjectForm();
            editSubject.selectedRow = dgvSubjects.CurrentRow;
            editSubject.ShowDialog();
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Subject> subject = context.Subjects.ToList();
                dgvSubjects.DataSource = subject;
                dgvSubjects.Columns["TeachSubjects"].Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                int ID = int.Parse(dgvSubjects.CurrentRow.Cells[0].Value.ToString());
                var item = context.Subjects.Find(ID);
                try
                {
                    if (MessageBox.Show($"Subject {dgvSubjects.CurrentRow.Cells[1].Value.ToString()} will be permamently deleted!", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        context.Subjects.Remove(item);
                        context.SaveChanges();
                        List<Subject> subject = context.Subjects.ToList();
                        dgvSubjects.DataSource = subject;
                        dgvSubjects.Columns["TeachSubjects"].Visible = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The subject could not be deleted because it is being actively taught in the moment.");
                }
            }
        }

        private void btnSortBySemesters_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var allData = context.Subjects.ToList();
                dgvSubjects.DataSource = allData.Select(x => new
                {
                    x.ID,
                    x.SubjectName,
                    x.NumberSemesters
                }).OrderByDescending(x => x.NumberSemesters).ToList();
            }   
        }
    }
}
