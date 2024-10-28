namespace ScoreManageSystem
{
    partial class AdminWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addStuBtn = new System.Windows.Forms.Button();
            this.stuInfoGrid = new System.Windows.Forms.DataGridView();
            this.idCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexCell = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeCell = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.teacherInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCell = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.courseInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuInfoGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "管理员后台管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 655);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addStuBtn);
            this.tabPage1.Controls.Add(this.stuInfoGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1233, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "学生信息管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addStuBtn
            // 
            this.addStuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStuBtn.Location = new System.Drawing.Point(1005, 554);
            this.addStuBtn.Name = "addStuBtn";
            this.addStuBtn.Size = new System.Drawing.Size(206, 37);
            this.addStuBtn.TabIndex = 2;
            this.addStuBtn.Text = "添加新学生";
            this.addStuBtn.UseVisualStyleBackColor = true;
            this.addStuBtn.Click += new System.EventHandler(this.addStuBtn_Click);
            // 
            // stuInfoGrid
            // 
            this.stuInfoGrid.AllowUserToAddRows = false;
            this.stuInfoGrid.AllowUserToDeleteRows = false;
            this.stuInfoGrid.BackgroundColor = System.Drawing.Color.White;
            this.stuInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCell,
            this.nameCell,
            this.sexCell,
            this.Column1,
            this.Column3,
            this.removeCell});
            this.stuInfoGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.stuInfoGrid.Location = new System.Drawing.Point(3, 3);
            this.stuInfoGrid.Name = "stuInfoGrid";
            this.stuInfoGrid.RowHeadersWidth = 72;
            this.stuInfoGrid.RowTemplate.Height = 36;
            this.stuInfoGrid.Size = new System.Drawing.Size(1227, 539);
            this.stuInfoGrid.TabIndex = 1;
            this.stuInfoGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.stuInfoGrid_CellBeginEdit);
            this.stuInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stuInfoGrid_CellContentClick);
            this.stuInfoGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.stuInfoGrid_CellEndEdit);
            // 
            // idCell
            // 
            this.idCell.HeaderText = "学号";
            this.idCell.MinimumWidth = 9;
            this.idCell.Name = "idCell";
            this.idCell.ReadOnly = true;
            this.idCell.Width = 175;
            // 
            // nameCell
            // 
            this.nameCell.HeaderText = "姓名";
            this.nameCell.MaxInputLength = 30;
            this.nameCell.MinimumWidth = 9;
            this.nameCell.Name = "nameCell";
            this.nameCell.Width = 175;
            // 
            // sexCell
            // 
            this.sexCell.HeaderText = "性别";
            this.sexCell.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexCell.MinimumWidth = 9;
            this.sexCell.Name = "sexCell";
            this.sexCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sexCell.Width = 175;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "登录账号";
            this.Column1.MaxInputLength = 30;
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "密码";
            this.Column3.MaxInputLength = 30;
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // removeCell
            // 
            this.removeCell.HeaderText = "";
            this.removeCell.MinimumWidth = 9;
            this.removeCell.Name = "removeCell";
            this.removeCell.ReadOnly = true;
            this.removeCell.Text = "删除学生";
            this.removeCell.Width = 175;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addTeacherBtn);
            this.tabPage2.Controls.Add(this.teacherInfoGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1233, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教师信息管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTeacherBtn.Location = new System.Drawing.Point(1007, 555);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(206, 37);
            this.addTeacherBtn.TabIndex = 4;
            this.addTeacherBtn.Text = "添加新教师";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.addTeacherBtn_Click);
            // 
            // teacherInfoGrid
            // 
            this.teacherInfoGrid.AllowUserToAddRows = false;
            this.teacherInfoGrid.AllowUserToDeleteRows = false;
            this.teacherInfoGrid.BackgroundColor = System.Drawing.Color.White;
            this.teacherInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.courseCell,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewButtonColumn1});
            this.teacherInfoGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherInfoGrid.Location = new System.Drawing.Point(3, 3);
            this.teacherInfoGrid.Name = "teacherInfoGrid";
            this.teacherInfoGrid.RowHeadersWidth = 72;
            this.teacherInfoGrid.RowTemplate.Height = 36;
            this.teacherInfoGrid.Size = new System.Drawing.Size(1227, 539);
            this.teacherInfoGrid.TabIndex = 3;
            this.teacherInfoGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.teacherInfoGrid_CellBeginEdit);
            this.teacherInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherInfoGrid_CellContentClick);
            this.teacherInfoGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherInfoGrid_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "工号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // courseCell
            // 
            this.courseCell.HeaderText = "任课课程";
            this.courseCell.MinimumWidth = 9;
            this.courseCell.Name = "courseCell";
            this.courseCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.courseCell.Width = 275;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "登录账号";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "密码";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 9;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "删除教师";
            this.dataGridViewButtonColumn1.Width = 175;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addCourseBtn);
            this.tabPage3.Controls.Add(this.courseInfoGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1233, 608);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "课程信息管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCourseBtn.Location = new System.Drawing.Point(1007, 556);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(206, 37);
            this.addCourseBtn.TabIndex = 6;
            this.addCourseBtn.Text = "添加新课程";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // courseInfoGrid
            // 
            this.courseInfoGrid.AllowUserToAddRows = false;
            this.courseInfoGrid.AllowUserToDeleteRows = false;
            this.courseInfoGrid.BackgroundColor = System.Drawing.Color.White;
            this.courseInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn2});
            this.courseInfoGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseInfoGrid.Location = new System.Drawing.Point(3, 3);
            this.courseInfoGrid.Name = "courseInfoGrid";
            this.courseInfoGrid.RowHeadersWidth = 72;
            this.courseInfoGrid.RowTemplate.Height = 36;
            this.courseInfoGrid.Size = new System.Drawing.Size(1227, 539);
            this.courseInfoGrid.TabIndex = 5;
            this.courseInfoGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.courseInfoGrid_CellBeginEdit);
            this.courseInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseInfoGrid_CellContentClick);
            this.courseInfoGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseInfoGrid_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "编号";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "课程名称";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 275;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 9;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "删除课程";
            this.dataGridViewButtonColumn2.Width = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "如需录入成绩或者查看成绩，请使用教师/学生账号登录本系统";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员后台管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminWindow_FormClosing);
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stuInfoGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView stuInfoGrid;
        private Button addStuBtn;
        private Label label2;
        private DataGridViewTextBoxColumn idCell;
        private DataGridViewTextBoxColumn nameCell;
        private DataGridViewComboBoxColumn sexCell;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn removeCell;
        private Button addTeacherBtn;
        private DataGridView teacherInfoGrid;
        private TabPage tabPage3;
        private Button addCourseBtn;
        private DataGridView courseInfoGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn courseCell;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}