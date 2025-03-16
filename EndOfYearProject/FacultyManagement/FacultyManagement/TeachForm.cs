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
    public partial class TeachForm : Form
    {
        public TeachForm()
        {
            InitializeComponent();
        }

        private void dgvTeach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TeachForm_Load(object sender, EventArgs e)
        {
             using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var allData = context.TeachSubjects.ToList();
                dgvTeach.DataSource = allData;
                dgvTeach.Columns["Subject"].Visible = false;
                dgvTeach.Columns["Teacher"].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                int ID = int.Parse(dgvTeach.CurrentRow.Cells[0].Value.ToString());
                var item = context.TeachSubjects.Find(ID);

                if (MessageBox.Show($"Class {context.Subjects.Find(int.Parse(dgvTeach.CurrentRow.Cells[2].Value.ToString())).SubjectName} with teacher {context.Teachers.Find(int.Parse(dgvTeach.CurrentRow.Cells[1].Value.ToString())).FullName} will be permamently deleted!", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    context.TeachSubjects.Remove(item);
                    context.SaveChanges();
                    var allData = context.TeachSubjects.ToList();
                    dgvTeach.DataSource = allData;
                    dgvTeach.Columns["Subject"].Visible = false;
                    dgvTeach.Columns["Teacher"].Visible = false;
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTeachForm teachform = new AddTeachForm();
            teachform.ShowDialog();
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var allData = context.TeachSubjects.ToList();
                dgvTeach.DataSource = allData;
                dgvTeach.Columns["Subject"].Visible = false;
                dgvTeach.Columns["Teacher"].Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTeachForm editTeach = new EditTeachForm();
            editTeach.selectedRow = dgvTeach.CurrentRow;
            editTeach.ShowDialog();
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                var allData = context.TeachSubjects.ToList();
                dgvTeach.DataSource = allData;
                dgvTeach.Columns["Subject"].Visible = false;
                dgvTeach.Columns["Teacher"].Visible = false;
            }
        }

        private void btnSortByTeacherID_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txtID.Text);
                using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
                {
                    var allData = context.TeachSubjects.ToList();
                    dgvTeach.DataSource = allData.Select(x => new
                    {
                        x.ID,
                        x.TeacherID,
                        x.SubjectID
                    }).Where(x => x.TeacherID == ID).ToList();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect or missing data!");
            }
        }
    }
}
