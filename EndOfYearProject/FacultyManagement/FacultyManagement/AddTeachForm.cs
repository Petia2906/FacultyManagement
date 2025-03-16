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
    public partial class AddTeachForm : Form
    {
        public AddTeachForm()
        {
            InitializeComponent();
        }

        private void AddTeachForm_Load(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                List<Teacher> teachers = context.Teachers.ToList();
                List<Subject> subject = context.Subjects.ToList();

                cbTeachers.DataSource = teachers;
                cbTeachers.DisplayMember = "FullName";
                cbTeachers.ValueMember = "ID";

                cbSubjects.DataSource = subject;
                cbSubjects.DisplayMember = "SubjectName";
                cbSubjects.ValueMember = "ID";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                TeachSubject ts = new TeachSubject();
                ts.TeacherID = int.Parse(cbTeachers.SelectedValue.ToString());
                ts.SubjectID = int.Parse(cbSubjects.SelectedValue.ToString());
                context.TeachSubjects.Add(ts);
                context.SaveChanges();
                Close();
            }
        }
    }
}
