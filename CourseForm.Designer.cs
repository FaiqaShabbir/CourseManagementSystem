namespace CourseManagementSystem
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseManagemntSystem_DBDataSet1 = new CourseManagementSystem.CourseManagemntSystem_DBDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursePREREQUISITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursePICTUREDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.courseCREDITHOURSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTIMEDURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTableAdapter = new CourseManagementSystem.CourseManagemntSystem_DBDataSet1TableAdapters.CourseTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbCourseCreditHours = new System.Windows.Forms.ComboBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoursePrerequisite = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cbCourseType = new System.Windows.Forms.ComboBox();
            this.dtpCourseTime = new System.Windows.Forms.DateTimePicker();
            this.txtCoursePrerequisite = new System.Windows.Forms.TextBox();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseManagemntSystem_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.tsNew,
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton2.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(35, 22);
            this.tsNew.Text = "New";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton1.Text = "Delete";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.courseManagemntSystem_DBDataSet1;
            // 
            // courseManagemntSystem_DBDataSet1
            // 
            this.courseManagemntSystem_DBDataSet1.DataSetName = "CourseManagemntSystem_DBDataSet1";
            this.courseManagemntSystem_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseCODEDataGridViewTextBoxColumn,
            this.courseTITLEDataGridViewTextBoxColumn,
            this.courseTYPEDataGridViewTextBoxColumn,
            this.coursePREREQUISITEDataGridViewTextBoxColumn,
            this.coursePICTUREDataGridViewImageColumn,
            this.courseCREDITHOURSDataGridViewTextBoxColumn,
            this.courseTIMEDURATIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 150);
            this.dataGridView1.TabIndex = 97;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseCODEDataGridViewTextBoxColumn
            // 
            this.courseCODEDataGridViewTextBoxColumn.DataPropertyName = "course_CODE";
            this.courseCODEDataGridViewTextBoxColumn.HeaderText = "course_CODE";
            this.courseCODEDataGridViewTextBoxColumn.Name = "courseCODEDataGridViewTextBoxColumn";
            // 
            // courseTITLEDataGridViewTextBoxColumn
            // 
            this.courseTITLEDataGridViewTextBoxColumn.DataPropertyName = "course_TITLE";
            this.courseTITLEDataGridViewTextBoxColumn.HeaderText = "course_TITLE";
            this.courseTITLEDataGridViewTextBoxColumn.Name = "courseTITLEDataGridViewTextBoxColumn";
            // 
            // courseTYPEDataGridViewTextBoxColumn
            // 
            this.courseTYPEDataGridViewTextBoxColumn.DataPropertyName = "course_TYPE";
            this.courseTYPEDataGridViewTextBoxColumn.HeaderText = "course_TYPE";
            this.courseTYPEDataGridViewTextBoxColumn.Name = "courseTYPEDataGridViewTextBoxColumn";
            // 
            // coursePREREQUISITEDataGridViewTextBoxColumn
            // 
            this.coursePREREQUISITEDataGridViewTextBoxColumn.DataPropertyName = "course_PREREQUISITE";
            this.coursePREREQUISITEDataGridViewTextBoxColumn.HeaderText = "course_PREREQUISITE";
            this.coursePREREQUISITEDataGridViewTextBoxColumn.Name = "coursePREREQUISITEDataGridViewTextBoxColumn";
            // 
            // coursePICTUREDataGridViewImageColumn
            // 
            this.coursePICTUREDataGridViewImageColumn.DataPropertyName = "course_PICTURE";
            this.coursePICTUREDataGridViewImageColumn.HeaderText = "course_PICTURE";
            this.coursePICTUREDataGridViewImageColumn.Name = "coursePICTUREDataGridViewImageColumn";
            // 
            // courseCREDITHOURSDataGridViewTextBoxColumn
            // 
            this.courseCREDITHOURSDataGridViewTextBoxColumn.DataPropertyName = "course_CREDITHOURS";
            this.courseCREDITHOURSDataGridViewTextBoxColumn.HeaderText = "course_CREDITHOURS";
            this.courseCREDITHOURSDataGridViewTextBoxColumn.Name = "courseCREDITHOURSDataGridViewTextBoxColumn";
            // 
            // courseTIMEDURATIONDataGridViewTextBoxColumn
            // 
            this.courseTIMEDURATIONDataGridViewTextBoxColumn.DataPropertyName = "course_TIMEDURATION";
            this.courseTIMEDURATIONDataGridViewTextBoxColumn.HeaderText = "course_TIMEDURATION";
            this.courseTIMEDURATIONDataGridViewTextBoxColumn.Name = "courseTIMEDURATIONDataGridViewTextBoxColumn";
            this.courseTIMEDURATIONDataGridViewTextBoxColumn.Width = 200;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(266, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 45);
            this.label4.TabIndex = 119;
            this.label4.Text = "Available Courses";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.courseBindingSource, "course_PICTURE", true));
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(510, 73);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(255, 128);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 117;
            this.pbImage.TabStop = false;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBrowseImg.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowseImg.Location = new System.Drawing.Point(571, 205);
            this.btnBrowseImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(132, 33);
            this.btnBrowseImg.TabIndex = 118;
            this.btnBrowseImg.Text = "Browse Image";
            this.btnBrowseImg.UseVisualStyleBackColor = false;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PeachPuff;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(449, 249);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 33);
            this.btnExit.TabIndex = 116;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(373, 249);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 33);
            this.btnRemove.TabIndex = 115;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(525, 249);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 33);
            this.btnNext.TabIndex = 114;
            this.btnNext.Text = ">>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(296, 249);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 33);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(144, 249);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(68, 33);
            this.btnPrev.TabIndex = 113;
            this.btnPrev.Text = "<<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(220, 249);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 33);
            this.btnNew.TabIndex = 112;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbCourseCreditHours
            // 
            this.cbCourseCreditHours.BackColor = System.Drawing.Color.White;
            this.cbCourseCreditHours.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course_CREDITHOURS", true));
            this.cbCourseCreditHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseCreditHours.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourseCreditHours.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbCourseCreditHours.FormattingEnabled = true;
            this.cbCourseCreditHours.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbCourseCreditHours.Location = new System.Drawing.Point(213, 218);
            this.cbCourseCreditHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCourseCreditHours.Name = "cbCourseCreditHours";
            this.cbCourseCreditHours.Size = new System.Drawing.Size(241, 24);
            this.cbCourseCreditHours.TabIndex = 110;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.ForeColor = System.Drawing.Color.White;
            this.lblCourseId.Location = new System.Drawing.Point(45, 73);
            this.lblCourseId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(110, 19);
            this.lblCourseId.TabIndex = 109;
            this.lblCourseId.Text = "Course Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 106;
            this.label3.Text = "Course CreditHours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 104;
            this.label2.Text = "Course Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 103;
            this.label1.Text = "Course Time:";
            // 
            // lblCoursePrerequisite
            // 
            this.lblCoursePrerequisite.AutoSize = true;
            this.lblCoursePrerequisite.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursePrerequisite.ForeColor = System.Drawing.Color.White;
            this.lblCoursePrerequisite.Location = new System.Drawing.Point(45, 127);
            this.lblCoursePrerequisite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoursePrerequisite.Name = "lblCoursePrerequisite";
            this.lblCoursePrerequisite.Size = new System.Drawing.Size(164, 19);
            this.lblCoursePrerequisite.TabIndex = 102;
            this.lblCoursePrerequisite.Text = "Course Prerequisite:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(45, 99);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(107, 19);
            this.lblCourseName.TabIndex = 105;
            this.lblCourseName.Text = "Course Title:";
            // 
            // cbCourseType
            // 
            this.cbCourseType.BackColor = System.Drawing.Color.White;
            this.cbCourseType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course_TYPE", true));
            this.cbCourseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourseType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbCourseType.FormattingEnabled = true;
            this.cbCourseType.Items.AddRange(new object[] {
            "CS",
            "IT",
            "SE"});
            this.cbCourseType.Location = new System.Drawing.Point(213, 186);
            this.cbCourseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCourseType.Name = "cbCourseType";
            this.cbCourseType.Size = new System.Drawing.Size(241, 24);
            this.cbCourseType.TabIndex = 108;
            // 
            // dtpCourseTime
            // 
            this.dtpCourseTime.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpCourseTime.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpCourseTime.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtpCourseTime.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtpCourseTime.CalendarTrailingForeColor = System.Drawing.Color.Gainsboro;
            this.dtpCourseTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course_TIMEDURATION", true));
            this.dtpCourseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCourseTime.Location = new System.Drawing.Point(213, 156);
            this.dtpCourseTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpCourseTime.Name = "dtpCourseTime";
            this.dtpCourseTime.Size = new System.Drawing.Size(241, 22);
            this.dtpCourseTime.TabIndex = 107;
            // 
            // txtCoursePrerequisite
            // 
            this.txtCoursePrerequisite.BackColor = System.Drawing.Color.White;
            this.txtCoursePrerequisite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course_PREREQUISITE", true));
            this.txtCoursePrerequisite.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoursePrerequisite.Location = new System.Drawing.Point(213, 127);
            this.txtCoursePrerequisite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCoursePrerequisite.Name = "txtCoursePrerequisite";
            this.txtCoursePrerequisite.Size = new System.Drawing.Size(241, 22);
            this.txtCoursePrerequisite.TabIndex = 101;
            // 
            // txtCourseId
            // 
            this.txtCourseId.BackColor = System.Drawing.Color.White;
            this.txtCourseId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course_CODE", true));
            this.txtCourseId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseId.Location = new System.Drawing.Point(213, 73);
            this.txtCourseId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(241, 22);
            this.txtCourseId.TabIndex = 99;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.BackColor = System.Drawing.Color.White;
            this.txtCourseTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course_TITLE", true));
            this.txtCourseTitle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseTitle.Location = new System.Drawing.Point(213, 99);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(241, 22);
            this.txtCourseTitle.TabIndex = 100;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1008, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cbCourseCreditHours);
            this.Controls.Add(this.lblCourseId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCoursePrerequisite);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.cbCourseType);
            this.Controls.Add(this.dtpCourseTime);
            this.Controls.Add(this.txtCoursePrerequisite);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseManagemntSystem_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CourseManagemntSystem_DBDataSet1 courseManagemntSystem_DBDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CourseManagemntSystem_DBDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursePREREQUISITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn coursePICTUREDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCREDITHOURSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTIMEDURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbCourseCreditHours;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoursePrerequisite;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cbCourseType;
        private System.Windows.Forms.DateTimePicker dtpCourseTime;
        private System.Windows.Forms.TextBox txtCoursePrerequisite;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCourseTitle;
    }
}