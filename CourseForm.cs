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
    public partial class CourseForm : Form
    {
        bool isImageSelected = false;
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseManagemntSystem_DBDataSet1.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.courseManagemntSystem_DBDataSet1.Course);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            courseBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            courseBindingSource.EndEdit();
            courseTableAdapter.Update(courseManagemntSystem_DBDataSet1.Course);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string message = "Delete course registration first otherwise it will not delete permanenetly.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    courseBindingSource.RemoveCurrent();
                    courseTableAdapter.Update(courseManagemntSystem_DBDataSet1.Course);
                }
                catch (Exception ex) { }
            }
            else
            {
                this.Close();
            }
         
        }
        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            courseBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            courseBindingSource.MoveNext();
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
