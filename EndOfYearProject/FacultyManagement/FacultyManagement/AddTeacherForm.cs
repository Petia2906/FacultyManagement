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
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                try
                {
                    Teacher teacher = new Teacher();
                    teacher.FirstName = txtFirstName.Text;
                    teacher.LastName = txtLastName.Text;
                    teacher.Salary = decimal.Parse(txtSalary.Text);
                    teacher.HireDate = dateTimePicker1.Value;
                    context.Teachers.Add(teacher);
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
