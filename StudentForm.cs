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
    public partial class StudentForm : Form
    {
        bool isImageSelected = false;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseManagemntSystem_DBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.courseManagemntSystem_DBDataSet.Student);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            studentBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            studentTableAdapter.Update(courseManagemntSystem_DBDataSet.Student);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string message = "Delete student registration first otherwise it will not delete permanenetly.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    studentBindingSource.RemoveCurrent();
                    studentTableAdapter.Update(courseManagemntSystem_DBDataSet.Student);
                }
                catch (Exception ex) { }
            }
            else
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            studentBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveNext();
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
    }
}
