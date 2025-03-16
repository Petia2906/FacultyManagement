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
    public partial class EditTeachForm : Form
    {
        public EditTeachForm()
        {
            InitializeComponent();
        }
        public DataGridViewRow selectedRow;
        private void EditTeachForm_Load(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Teacher> teachers = context.Teachers.ToList();
                List<Subject> subject = context.Subjects.ToList();

                txtID.Text = selectedRow.Cells[0].Value.ToString();

                cbTeachers.DataSource = teachers;
                cbTeachers.DisplayMember = "FullName";
                cbTeachers.ValueMember = "ID";

                cbSubjects.DataSource = subject;
                cbSubjects.DisplayMember = "SubjectName";
                cbSubjects.ValueMember = "ID";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                    int ID = int.Parse(txtID.Text);
                    TeachSubject ts = context.TeachSubjects.Find(ID);
                    ts.TeacherID = int.Parse(cbTeachers.SelectedValue.ToString());
                    ts.SubjectID = int.Parse(cbSubjects.SelectedValue.ToString());
                    context.SaveChanges();
                
                Close();
            }
        }
    }
}
