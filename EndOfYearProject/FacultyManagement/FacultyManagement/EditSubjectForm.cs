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
    public partial class EditSubjectForm : Form
    {
        public EditSubjectForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                try
                {
                    int ID = int.Parse(txtID.Text);
                    Subject subject = context.Subjects.Find(ID);
                    subject.SubjectName = txtSubjectName.Text;
                    subject.NumberSemesters = int.Parse(txtSemesters.Text);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect or missing data!");
                }
                Close();
            }
        }
        public DataGridViewRow selectedRow;
        private void EditSubjectForm_Load(object sender, EventArgs e)
        {
            txtID.Text = selectedRow.Cells[0].Value.ToString();
            txtSubjectName.Text = selectedRow.Cells[1].Value.ToString();
            txtSemesters.Text = selectedRow.Cells[2].Value.ToString();
        }
    }
}
