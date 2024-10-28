namespace ScoreManageSystem
{
    partial class TeacherWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.studentInfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stuName = new System.Windows.Forms.Label();
            this.addStuBtn = new System.Windows.Forms.Button();
            this.stuIDCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stuInfoGrid = new System.Windows.Forms.DataGridView();
            this.idCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexCell = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.removeCell = new System.Windows.Forms.DataGridViewButtonColumn();
            this.scoreInfo = new System.Windows.Forms.TabPage();
            this.scoreInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBtnCell = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statisInfo = new System.Windows.Forms.TabPage();
            this.rankDetail = new System.Windows.Forms.Label();
            this.rankInfoGrid = new System.Windows.Forms.DataGridView();
            this.rankCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subTitle = new System.Windows.Forms.Label();
            this.editPassBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.studentInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuInfoGrid)).BeginInit();
            this.scoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreInfoGrid)).BeginInit();
            this.statisInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.studentInfo);
            this.tabControl.Controls.Add(this.scoreInfo);
            this.tabControl.Controls.Add(this.statisInfo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 108);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(30, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 669);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // studentInfo
            // 
            this.studentInfo.Controls.Add(this.panel1);
            this.studentInfo.Controls.Add(this.stuInfoGrid);
            this.studentInfo.Location = new System.Drawing.Point(4, 41);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.studentInfo.Size = new System.Drawing.Size(784, 624);
            this.studentInfo.TabIndex = 0;
            this.studentInfo.Text = "学生选课";
            this.studentInfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.stuName);
            this.panel1.Controls.Add(this.addStuBtn);
            this.panel1.Controls.Add(this.stuIDCombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 67);
            this.panel1.TabIndex = 4;
            // 
            // stuName
            // 
            this.stuName.AutoSize = true;
            this.stuName.Location = new System.Drawing.Point(418, 20);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(0, 28);
            this.stuName.TabIndex = 3;
            // 
            // addStuBtn
            // 
            this.addStuBtn.Enabled = false;
            this.addStuBtn.Location = new System.Drawing.Point(597, 16);
            this.addStuBtn.Name = "addStuBtn";
            this.addStuBtn.Size = new System.Drawing.Size(151, 37);
            this.addStuBtn.TabIndex = 2;
            this.addStuBtn.Text = "添加学生";
            this.addStuBtn.UseVisualStyleBackColor = true;
            this.addStuBtn.Click += new System.EventHandler(this.addStuBtn_Click);
            // 
            // stuIDCombo
            // 
            this.stuIDCombo.FormattingEnabled = true;
            this.stuIDCombo.Location = new System.Drawing.Point(109, 17);
            this.stuIDCombo.Name = "stuIDCombo";
            this.stuIDCombo.Size = new System.Drawing.Size(286, 36);
            this.stuIDCombo.TabIndex = 1;
            this.stuIDCombo.SelectedValueChanged += new System.EventHandler(this.stuIDCombo_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号";
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
            this.removeCell});
            this.stuInfoGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.stuInfoGrid.Location = new System.Drawing.Point(3, 3);
            this.stuInfoGrid.Name = "stuInfoGrid";
            this.stuInfoGrid.RowHeadersWidth = 72;
            this.stuInfoGrid.RowTemplate.Height = 36;
            this.stuInfoGrid.Size = new System.Drawing.Size(778, 545);
            this.stuInfoGrid.TabIndex = 0;
            this.stuInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stuInfoGrid_CellContentClick);
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
            this.nameCell.MinimumWidth = 9;
            this.nameCell.Name = "nameCell";
            this.nameCell.ReadOnly = true;
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
            this.sexCell.ReadOnly = true;
            this.sexCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sexCell.Width = 175;
            // 
            // removeCell
            // 
            this.removeCell.HeaderText = "";
            this.removeCell.MinimumWidth = 9;
            this.removeCell.Name = "removeCell";
            this.removeCell.Text = "移除选课";
            this.removeCell.Width = 175;
            // 
            // scoreInfo
            // 
            this.scoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.scoreInfo.Controls.Add(this.scoreInfoGrid);
            this.scoreInfo.Location = new System.Drawing.Point(4, 41);
            this.scoreInfo.Name = "scoreInfo";
            this.scoreInfo.Padding = new System.Windows.Forms.Padding(3);
            this.scoreInfo.Size = new System.Drawing.Size(784, 624);
            this.scoreInfo.TabIndex = 1;
            this.scoreInfo.Text = "成绩录入";
            // 
            // scoreInfoGrid
            // 
            this.scoreInfoGrid.AllowUserToAddRows = false;
            this.scoreInfoGrid.AllowUserToDeleteRows = false;
            this.scoreInfoGrid.BackgroundColor = System.Drawing.Color.White;
            this.scoreInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.scoreCell,
            this.commentBtnCell});
            this.scoreInfoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreInfoGrid.Location = new System.Drawing.Point(3, 3);
            this.scoreInfoGrid.Name = "scoreInfoGrid";
            this.scoreInfoGrid.RowHeadersWidth = 72;
            this.scoreInfoGrid.RowTemplate.Height = 36;
            this.scoreInfoGrid.Size = new System.Drawing.Size(778, 618);
            this.scoreInfoGrid.TabIndex = 1;
            this.scoreInfoGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.scoreInfoGrid_CellBeginEdit);
            this.scoreInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreInfoGrid_CellContentClick);
            this.scoreInfoGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreInfoGrid_CellEndEdit);
            this.scoreInfoGrid.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.GridSortCompare);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "学号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // scoreCell
            // 
            this.scoreCell.HeaderText = "成绩";
            this.scoreCell.MinimumWidth = 9;
            this.scoreCell.Name = "scoreCell";
            this.scoreCell.Width = 175;
            // 
            // commentBtnCell
            // 
            this.commentBtnCell.HeaderText = "";
            this.commentBtnCell.MinimumWidth = 9;
            this.commentBtnCell.Name = "commentBtnCell";
            this.commentBtnCell.Text = "评语";
            this.commentBtnCell.Width = 175;
            // 
            // statisInfo
            // 
            this.statisInfo.BackColor = System.Drawing.Color.Transparent;
            this.statisInfo.Controls.Add(this.rankDetail);
            this.statisInfo.Controls.Add(this.rankInfoGrid);
            this.statisInfo.Location = new System.Drawing.Point(4, 41);
            this.statisInfo.Name = "statisInfo";
            this.statisInfo.Padding = new System.Windows.Forms.Padding(3);
            this.statisInfo.Size = new System.Drawing.Size(784, 624);
            this.statisInfo.TabIndex = 2;
            this.statisInfo.Text = "成绩统计";
            // 
            // rankDetail
            // 
            this.rankDetail.AutoSize = true;
            this.rankDetail.Location = new System.Drawing.Point(25, 560);
            this.rankDetail.Name = "rankDetail";
            this.rankDetail.Size = new System.Drawing.Size(585, 28);
            this.rankDetail.TabIndex = 3;
            this.rankDetail.Text = "平均分：60，最高分：95，最低分：0，已录入：15/20(75%)";
            // 
            // rankInfoGrid
            // 
            this.rankInfoGrid.AllowUserToAddRows = false;
            this.rankInfoGrid.AllowUserToDeleteRows = false;
            this.rankInfoGrid.BackgroundColor = System.Drawing.Color.White;
            this.rankInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankCell,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.pointCell});
            this.rankInfoGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.rankInfoGrid.Location = new System.Drawing.Point(3, 3);
            this.rankInfoGrid.Name = "rankInfoGrid";
            this.rankInfoGrid.RowHeadersWidth = 72;
            this.rankInfoGrid.RowTemplate.Height = 36;
            this.rankInfoGrid.Size = new System.Drawing.Size(778, 532);
            this.rankInfoGrid.TabIndex = 2;
            this.rankInfoGrid.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.GridSortCompare);
            // 
            // rankCell
            // 
            this.rankCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rankCell.Frozen = true;
            this.rankCell.HeaderText = "排名";
            this.rankCell.MinimumWidth = 9;
            this.rankCell.Name = "rankCell";
            this.rankCell.ReadOnly = true;
            this.rankCell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rankCell.Width = 101;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "学号";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "成绩";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // pointCell
            // 
            this.pointCell.HeaderText = "绩点";
            this.pointCell.MinimumWidth = 9;
            this.pointCell.Name = "pointCell";
            this.pointCell.ReadOnly = true;
            this.pointCell.Width = 125;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(116, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(180, 28);
            this.title.TabIndex = 3;
            this.title.Text = "晚上好，王老师！";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Location = new System.Drawing.Point(116, 56);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(144, 28);
            this.subTitle.TabIndex = 4;
            this.subTitle.Text = "当前任课：C#";
            // 
            // editPassBtn
            // 
            this.editPassBtn.Location = new System.Drawing.Point(627, 31);
            this.editPassBtn.Name = "editPassBtn";
            this.editPassBtn.Size = new System.Drawing.Size(128, 35);
            this.editPassBtn.TabIndex = 5;
            this.editPassBtn.Text = "修改密码";
            this.editPassBtn.UseVisualStyleBackColor = true;
            this.editPassBtn.Click += new System.EventHandler(this.editPassBtn_Click);
            // 
            // TeacherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 777);
            this.Controls.Add(this.editPassBtn);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师后台管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherWindow_FormClosing);
            this.Load += new System.EventHandler(this.TeacherWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.studentInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuInfoGrid)).EndInit();
            this.scoreInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoreInfoGrid)).EndInit();
            this.statisInfo.ResumeLayout(false);
            this.statisInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl;
        private TabPage studentInfo;
        private TabPage scoreInfo;
        private Label title;
        private PictureBox pictureBox1;
        private TabPage statisInfo;
        private DataGridView stuInfoGrid;
        private Panel panel1;
        private Label stuName;
        private Button addStuBtn;
        private ComboBox stuIDCombo;
        private Label label2;
        private Label subTitle;
        private DataGridView scoreInfoGrid;
        private Label rankDetail;
        private DataGridView rankInfoGrid;
        private DataGridViewTextBoxColumn rankCell;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn pointCell;
        private DataGridViewTextBoxColumn idCell;
        private DataGridViewTextBoxColumn nameCell;
        private DataGridViewComboBoxColumn sexCell;
        private DataGridViewButtonColumn removeCell;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn scoreCell;
        private DataGridViewButtonColumn commentBtnCell;
        private Button editPassBtn;
    }
}