namespace CourseManagementSystem
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseManagemntSystem_DBDataSet = new CourseManagementSystem.CourseManagemntSystem_DBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentROLLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPICTUREDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.studentDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableAdapter = new CourseManagementSystem.CourseManagemntSystem_DBDataSetTableAdapters.StudentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentPhoneNo = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblStudentRollNo = new System.Windows.Forms.Label();
            this.lblPhoneNO = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStudentDOB = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cbStudentGender = new System.Windows.Forms.ComboBox();
            this.dtpStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseManagemntSystem_DBDataSet)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 52;
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
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.courseManagemntSystem_DBDataSet;
            // 
            // courseManagemntSystem_DBDataSet
            // 
            this.courseManagemntSystem_DBDataSet.DataSetName = "CourseManagemntSystem_DBDataSet";
            this.courseManagemntSystem_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentROLLNODataGridViewTextBoxColumn,
            this.studentNAMEDataGridViewTextBoxColumn,
            this.studentEMAILDataGridViewTextBoxColumn,
            this.studentADDRESSDataGridViewTextBoxColumn,
            this.studentGENDERDataGridViewTextBoxColumn,
            this.studentPHONENUMBERDataGridViewTextBoxColumn,
            this.studentPICTUREDataGridViewImageColumn,
            this.studentDOBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 150);
            this.dataGridView1.TabIndex = 104;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentROLLNODataGridViewTextBoxColumn
            // 
            this.studentROLLNODataGridViewTextBoxColumn.DataPropertyName = "student_ROLLNO";
            this.studentROLLNODataGridViewTextBoxColumn.HeaderText = "student_ROLLNO";
            this.studentROLLNODataGridViewTextBoxColumn.Name = "studentROLLNODataGridViewTextBoxColumn";
            // 
            // studentNAMEDataGridViewTextBoxColumn
            // 
            this.studentNAMEDataGridViewTextBoxColumn.DataPropertyName = "student_NAME";
            this.studentNAMEDataGridViewTextBoxColumn.HeaderText = "student_NAME";
            this.studentNAMEDataGridViewTextBoxColumn.Name = "studentNAMEDataGridViewTextBoxColumn";
            // 
            // studentEMAILDataGridViewTextBoxColumn
            // 
            this.studentEMAILDataGridViewTextBoxColumn.DataPropertyName = "student_EMAIL";
            this.studentEMAILDataGridViewTextBoxColumn.HeaderText = "student_EMAIL";
            this.studentEMAILDataGridViewTextBoxColumn.Name = "studentEMAILDataGridViewTextBoxColumn";
            // 
            // studentADDRESSDataGridViewTextBoxColumn
            // 
            this.studentADDRESSDataGridViewTextBoxColumn.DataPropertyName = "student_ADDRESS";
            this.studentADDRESSDataGridViewTextBoxColumn.HeaderText = "student_ADDRESS";
            this.studentADDRESSDataGridViewTextBoxColumn.Name = "studentADDRESSDataGridViewTextBoxColumn";
            // 
            // studentGENDERDataGridViewTextBoxColumn
            // 
            this.studentGENDERDataGridViewTextBoxColumn.DataPropertyName = "student_GENDER";
            this.studentGENDERDataGridViewTextBoxColumn.HeaderText = "student_GENDER";
            this.studentGENDERDataGridViewTextBoxColumn.Name = "studentGENDERDataGridViewTextBoxColumn";
            // 
            // studentPHONENUMBERDataGridViewTextBoxColumn
            // 
            this.studentPHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "student_PHONENUMBER";
            this.studentPHONENUMBERDataGridViewTextBoxColumn.HeaderText = "student_PHONENUMBER";
            this.studentPHONENUMBERDataGridViewTextBoxColumn.Name = "studentPHONENUMBERDataGridViewTextBoxColumn";
            // 
            // studentPICTUREDataGridViewImageColumn
            // 
            this.studentPICTUREDataGridViewImageColumn.DataPropertyName = "student_PICTURE";
            this.studentPICTUREDataGridViewImageColumn.HeaderText = "student_PICTURE";
            this.studentPICTUREDataGridViewImageColumn.Name = "studentPICTUREDataGridViewImageColumn";
            // 
            // studentDOBDataGridViewTextBoxColumn
            // 
            this.studentDOBDataGridViewTextBoxColumn.DataPropertyName = "student_DOB";
            this.studentDOBDataGridViewTextBoxColumn.HeaderText = "student_DOB";
            this.studentDOBDataGridViewTextBoxColumn.Name = "studentDOBDataGridViewTextBoxColumn";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 50);
            this.label1.TabIndex = 128;
            this.label1.Text = "Student Login";
            // 
            // txtStudentPhoneNo
            // 
            this.txtStudentPhoneNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_PHONENUMBER", true));
            this.txtStudentPhoneNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPhoneNo.Location = new System.Drawing.Point(240, 222);
            this.txtStudentPhoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentPhoneNo.Name = "txtStudentPhoneNo";
            this.txtStudentPhoneNo.Size = new System.Drawing.Size(229, 22);
            this.txtStudentPhoneNo.TabIndex = 127;
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_ADDRESS", true));
            this.txtStudentAddress.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAddress.Location = new System.Drawing.Point(240, 165);
            this.txtStudentAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(229, 23);
            this.txtStudentAddress.TabIndex = 126;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(72, 161);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(139, 19);
            this.lblAddress.TabIndex = 125;
            this.lblAddress.Text = "Student Address:";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "student_PICTURE", true));
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(510, 85);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(255, 148);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 123;
            this.pbImage.TabStop = false;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.BackColor = System.Drawing.Color.LightYellow;
            this.btnBrowseImg.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImg.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseImg.Location = new System.Drawing.Point(565, 236);
            this.btnBrowseImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(132, 34);
            this.btnBrowseImg.TabIndex = 124;
            this.btnBrowseImg.Text = "Browse Image";
            this.btnBrowseImg.UseVisualStyleBackColor = false;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightYellow;
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(482, 283);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 33);
            this.btnExit.TabIndex = 122;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightYellow;
            this.btnRemove.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(406, 283);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 33);
            this.btnRemove.TabIndex = 121;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightYellow;
            this.btnNext.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(558, 283);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 33);
            this.btnNext.TabIndex = 120;
            this.btnNext.Text = ">>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightYellow;
            this.btnSave.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(330, 283);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 33);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.LightYellow;
            this.btnPrev.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(178, 283);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(68, 33);
            this.btnPrev.TabIndex = 119;
            this.btnPrev.Text = "<<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightYellow;
            this.btnNew.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(254, 283);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 33);
            this.btnNew.TabIndex = 118;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblStudentRollNo
            // 
            this.lblStudentRollNo.AutoSize = true;
            this.lblStudentRollNo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRollNo.ForeColor = System.Drawing.Color.Black;
            this.lblStudentRollNo.Location = new System.Drawing.Point(72, 85);
            this.lblStudentRollNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentRollNo.Name = "lblStudentRollNo";
            this.lblStudentRollNo.Size = new System.Drawing.Size(133, 19);
            this.lblStudentRollNo.TabIndex = 116;
            this.lblStudentRollNo.Text = "Student Roll No:";
            // 
            // lblPhoneNO
            // 
            this.lblPhoneNO.AutoSize = true;
            this.lblPhoneNO.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNO.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNO.Location = new System.Drawing.Point(72, 222);
            this.lblPhoneNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNO.Name = "lblPhoneNO";
            this.lblPhoneNO.Size = new System.Drawing.Size(149, 19);
            this.lblPhoneNO.TabIndex = 113;
            this.lblPhoneNO.Text = "Student Phone No:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(72, 193);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(132, 19);
            this.lblGender.TabIndex = 111;
            this.lblGender.Text = "Student Gender:";
            // 
            // lblStudentDOB
            // 
            this.lblStudentDOB.AutoSize = true;
            this.lblStudentDOB.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDOB.ForeColor = System.Drawing.Color.Black;
            this.lblStudentDOB.Location = new System.Drawing.Point(72, 251);
            this.lblStudentDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentDOB.Name = "lblStudentDOB";
            this.lblStudentDOB.Size = new System.Drawing.Size(111, 19);
            this.lblStudentDOB.TabIndex = 110;
            this.lblStudentDOB.Text = "Student DOB:";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.ForeColor = System.Drawing.Color.Black;
            this.lblStudentEmail.Location = new System.Drawing.Point(72, 137);
            this.lblStudentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(120, 19);
            this.lblStudentEmail.TabIndex = 109;
            this.lblStudentEmail.Text = "Student Email:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(72, 111);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(121, 19);
            this.lblStudentName.TabIndex = 112;
            this.lblStudentName.Text = "Student Name:";
            // 
            // cbStudentGender
            // 
            this.cbStudentGender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbStudentGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_GENDER", true));
            this.cbStudentGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentGender.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentGender.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbStudentGender.FormattingEnabled = true;
            this.cbStudentGender.Items.AddRange(new object[] {
            "Male",
            "FeMale"});
            this.cbStudentGender.Location = new System.Drawing.Point(240, 193);
            this.cbStudentGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStudentGender.Name = "cbStudentGender";
            this.cbStudentGender.Size = new System.Drawing.Size(229, 24);
            this.cbStudentGender.TabIndex = 115;
            // 
            // dtpStudentDOB
            // 
            this.dtpStudentDOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_DOB", true));
            this.dtpStudentDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStudentDOB.Location = new System.Drawing.Point(240, 251);
            this.dtpStudentDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStudentDOB.Name = "dtpStudentDOB";
            this.dtpStudentDOB.Size = new System.Drawing.Size(229, 22);
            this.dtpStudentDOB.TabIndex = 114;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_EMAIL", true));
            this.txtStudentEmail.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.Location = new System.Drawing.Point(240, 137);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(229, 23);
            this.txtStudentEmail.TabIndex = 108;
            // 
            // txtStudentId
            // 
            this.txtStudentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_ROLLNO", true));
            this.txtStudentId.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(240, 85);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(229, 23);
            this.txtStudentId.TabIndex = 106;
            // 
            // txtStudentName
            // 
            this.txtStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_NAME", true));
            this.txtStudentName.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(240, 111);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(229, 23);
            this.txtStudentName.TabIndex = 107;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(944, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentPhoneNo);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblStudentRollNo);
            this.Controls.Add(this.lblPhoneNO);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblStudentDOB);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.cbStudentGender);
            this.Controls.Add(this.dtpStudentDOB);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseManagemntSystem_DBDataSet)).EndInit();
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
        private CourseManagemntSystem_DBDataSet courseManagemntSystem_DBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private CourseManagemntSystem_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentROLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn studentPICTUREDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentPhoneNo;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblStudentRollNo;
        private System.Windows.Forms.Label lblPhoneNO;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStudentDOB;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cbStudentGender;
        private System.Windows.Forms.DateTimePicker dtpStudentDOB;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
    }
}

