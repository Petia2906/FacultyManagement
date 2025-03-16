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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                try
                {
                    Subject subject = new Subject();
                    subject.SubjectName = txtSubjectName.Text;
                    subject.NumberSemesters = int.Parse(txtSemesters.Text);
                    context.Subjects.Add(subject);
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("There is missing or incorect data!");
                }
                Close();
            }
        }
    }
}
