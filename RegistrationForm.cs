using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    public partial class RegistrationForm : Form
    {
        bool isImageSelected = false;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseManagemntSystem_DBDataSet2.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.courseManagemntSystem_DBDataSet2.Registration);

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            registrationBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            registrationBindingSource.EndEdit();
            registrationTableAdapter.Update(courseManagemntSystem_DBDataSet2.Registration);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            registrationBindingSource.RemoveCurrent();
            registrationTableAdapter.Update(courseManagemntSystem_DBDataSet2.Registration);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            registrationBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            registrationBindingSource.MoveNext();
        }

        private void btnshowstudent_Click(object sender, EventArgs e)
        {
            StudentForm studentform = new StudentForm();
            //student.MaximizeBox = true;
            studentform.Show();
        }
        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.pbImage.ImageLocation = ofd.FileName;
                isImageSelected = true;
            }
            else
                MessageBox.Show("No Image File Selected!");
        }

        private void btnshowcourse_Click(object sender, EventArgs e)
        {
            CourseForm courseform = new CourseForm();
            //student.MaximizeBox = true;
            courseform.Show();
        }
    }
}
