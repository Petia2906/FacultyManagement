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
    public partial class EditTeacherForm : Form
    {
        public EditTeacherForm()
        {
            InitializeComponent();
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                try
                {
                    int ID = int.Parse(txtID.Text);
                    Teacher teacher = context.Teachers.Find(ID);
                    teacher.FirstName = txtFirstName.Text;
                    teacher.LastName = txtLastName.Text;
                    teacher.Salary = decimal.Parse(txtSalary.Text);
                    teacher.HireDate = DateTime.Parse(dateTimePicker1.Value.ToString());
                    context.SaveChanges();
                }
                catch(Exception)
                {
                    MessageBox.Show("Incorrect or missing data!");
                }
                Close();
            }
        }
        public DataGridViewRow selectedRow;
        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            using (FacultyManagementDBEntities2 context = new FacultyManagementDBEntities2())
            {
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtFirstName.Text = selectedRow.Cells[1].Value.ToString();
                txtLastName.Text = selectedRow.Cells[2].Value.ToString();
                txtSalary.Text = selectedRow.Cells[4].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells[5].Value.ToString());
            }
        }
    }
}
