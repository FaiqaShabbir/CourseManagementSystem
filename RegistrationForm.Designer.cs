namespace CourseManagementSystem
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseManagemntSystem_DBDataSet2 = new CourseManagementSystem.CourseManagemntSystem_DBDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registrationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationTableAdapter = new CourseManagementSystem.CourseManagemntSystem_DBDataSet2TableAdapters.RegistrationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnshowcourse = new System.Windows.Forms.Button();
            this.btnshowstudent = new System.Windows.Forms.Button();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblRegistrationCode = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRegistrationCode = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseManagemntSystem_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.toolStripSeparator1,
            this.tsSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(908, 25);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(35, 22);
            this.tsNew.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(35, 22);
            this.tsSave.Text = "Save";
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.courseManagemntSystem_DBDataSet2;
            // 
            // courseManagemntSystem_DBDataSet2
            // 
            this.courseManagemntSystem_DBDataSet2.DataSetName = "CourseManagemntSystem_DBDataSet2";
            this.courseManagemntSystem_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationIDDataGridViewTextBoxColumn,
            this.registrationCODEDataGridViewTextBoxColumn,
            this.registrationDATEDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(209, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 67;
            // 
            // registrationIDDataGridViewTextBoxColumn
            // 
            this.registrationIDDataGridViewTextBoxColumn.DataPropertyName = "registration_ID";
            this.registrationIDDataGridViewTextBoxColumn.HeaderText = "registration_ID";
            this.registrationIDDataGridViewTextBoxColumn.Name = "registrationIDDataGridViewTextBoxColumn";
            this.registrationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationCODEDataGridViewTextBoxColumn
            // 
            this.registrationCODEDataGridViewTextBoxColumn.DataPropertyName = "registration_CODE";
            this.registrationCODEDataGridViewTextBoxColumn.HeaderText = "registration_CODE";
            this.registrationCODEDataGridViewTextBoxColumn.Name = "registrationCODEDataGridViewTextBoxColumn";
            // 
            // registrationDATEDataGridViewTextBoxColumn
            // 
            this.registrationDATEDataGridViewTextBoxColumn.DataPropertyName = "registration_DATE";
            this.registrationDATEDataGridViewTextBoxColumn.HeaderText = "registration_DATE";
            this.registrationDATEDataGridViewTextBoxColumn.Name = "registrationDATEDataGridViewTextBoxColumn";
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 44);
            this.label1.TabIndex = 139;
            this.label1.Text = "COURSE MANAGEMENT SYSTEM";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(70, 104);
            this.pbImage.Margin = new System.Windows.Forms.Padding(6);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(183, 112);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 138;
            this.pbImage.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Azure;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(529, 241);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 29);
            this.btnExit.TabIndex = 137;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Azure;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(615, 241);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 29);
            this.btnNext.TabIndex = 136;
            this.btnNext.Text = ">>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(361, 241);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 29);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Azure;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(189, 241);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(74, 29);
            this.btnPrev.TabIndex = 135;
            this.btnPrev.Text = "<<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Azure;
            this.btnNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(275, 241);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 29);
            this.btnNew.TabIndex = 134;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnshowcourse
            // 
            this.btnshowcourse.BackColor = System.Drawing.Color.Azure;
            this.btnshowcourse.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowcourse.Location = new System.Drawing.Point(672, 160);
            this.btnshowcourse.Name = "btnshowcourse";
            this.btnshowcourse.Size = new System.Drawing.Size(110, 29);
            this.btnshowcourse.TabIndex = 132;
            this.btnshowcourse.Text = "Available Courses";
            this.btnshowcourse.UseVisualStyleBackColor = false;
            this.btnshowcourse.Click += new System.EventHandler(this.btnshowcourse_Click);
            // 
            // btnshowstudent
            // 
            this.btnshowstudent.BackColor = System.Drawing.Color.Azure;
            this.btnshowstudent.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowstudent.Location = new System.Drawing.Point(672, 199);
            this.btnshowstudent.Name = "btnshowstudent";
            this.btnshowstudent.Size = new System.Drawing.Size(110, 29);
            this.btnshowstudent.TabIndex = 131;
            this.btnshowstudent.Text = "Student Login";
            this.btnshowstudent.UseVisualStyleBackColor = false;
            this.btnshowstudent.Click += new System.EventHandler(this.btnshowstudent_Click);
            // 
            // txtCourseId
            // 
            this.txtCourseId.BackColor = System.Drawing.Color.White;
            this.txtCourseId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "course_ID", true));
            this.txtCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseId.Location = new System.Drawing.Point(421, 170);
            this.txtCourseId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(233, 23);
            this.txtCourseId.TabIndex = 130;
            // 
            // txtStudentId
            // 
            this.txtStudentId.BackColor = System.Drawing.Color.White;
            this.txtStudentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "student_ID", true));
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(421, 199);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(233, 23);
            this.txtStudentId.TabIndex = 129;
            // 
            // lblRegistrationCode
            // 
            this.lblRegistrationCode.AutoSize = true;
            this.lblRegistrationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCode.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrationCode.Location = new System.Drawing.Point(277, 111);
            this.lblRegistrationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationCode.Name = "lblRegistrationCode";
            this.lblRegistrationCode.Size = new System.Drawing.Size(143, 17);
            this.lblRegistrationCode.TabIndex = 128;
            this.lblRegistrationCode.Text = "Registration Code:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.Black;
            this.lblCourse.Location = new System.Drawing.Point(277, 170);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(64, 17);
            this.lblCourse.TabIndex = 124;
            this.lblCourse.Text = "Course:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.Black;
            this.lblStudent.Location = new System.Drawing.Point(280, 199);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(69, 17);
            this.lblStudent.TabIndex = 125;
            this.lblStudent.Text = "Student:";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrationDate.Location = new System.Drawing.Point(277, 140);
            this.lblRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(132, 17);
            this.lblRegistrationDate.TabIndex = 126;
            this.lblRegistrationDate.Text = "Regitration Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "registration_DATE", true));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(421, 140);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 23);
            this.dtpDate.TabIndex = 127;
            // 
            // txtRegistrationCode
            // 
            this.txtRegistrationCode.BackColor = System.Drawing.Color.White;
            this.txtRegistrationCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "registration_CODE", true));
            this.txtRegistrationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationCode.Location = new System.Drawing.Point(421, 111);
            this.txtRegistrationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrationCode.Name = "txtRegistrationCode";
            this.txtRegistrationCode.Size = new System.Drawing.Size(233, 23);
            this.txtRegistrationCode.TabIndex = 123;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Azure;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(445, 241);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 29);
            this.btnRemove.TabIndex = 122;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(908, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnshowcourse);
            this.Controls.Add(this.btnshowstudent);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblRegistrationCode);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtRegistrationCode);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseManagemntSystem_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CourseManagemntSystem_DBDataSet2 courseManagemntSystem_DBDataSet2;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private CourseManagemntSystem_DBDataSet2TableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnshowcourse;
        private System.Windows.Forms.Button btnshowstudent;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblRegistrationCode;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRegistrationCode;
        private System.Windows.Forms.Button btnRemove;
    }
}