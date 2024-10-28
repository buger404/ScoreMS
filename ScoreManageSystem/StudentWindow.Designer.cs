namespace ScoreManageSystem
{
    partial class StudentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentWindow));
            this.subTitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoGrid = new System.Windows.Forms.DataGridView();
            this.courseCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBtnCell = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editPassBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Location = new System.Drawing.Point(119, 60);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(125, 28);
            this.subTitle.TabIndex = 7;
            this.subTitle.Text = "总绩点：4.0";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(119, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(222, 28);
            this.title.TabIndex = 6;
            this.title.Text = "欢迎使用，小明同学！";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "成绩总览";
            // 
            // infoGrid
            // 
            this.infoGrid.AllowUserToAddRows = false;
            this.infoGrid.AllowUserToDeleteRows = false;
            this.infoGrid.BackgroundColor = System.Drawing.Color.White;
            this.infoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseCell,
            this.scoreCell,
            this.pointCell,
            this.commentBtnCell});
            this.infoGrid.Location = new System.Drawing.Point(39, 151);
            this.infoGrid.Name = "infoGrid";
            this.infoGrid.RowHeadersWidth = 72;
            this.infoGrid.RowTemplate.Height = 36;
            this.infoGrid.Size = new System.Drawing.Size(775, 468);
            this.infoGrid.TabIndex = 9;
            this.infoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infoGrid_CellContentClick);
            this.infoGrid.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.infoGrid_SortCompare);
            // 
            // courseCell
            // 
            this.courseCell.HeaderText = "课程";
            this.courseCell.MinimumWidth = 9;
            this.courseCell.Name = "courseCell";
            this.courseCell.ReadOnly = true;
            this.courseCell.Width = 175;
            // 
            // scoreCell
            // 
            this.scoreCell.HeaderText = "成绩";
            this.scoreCell.MinimumWidth = 9;
            this.scoreCell.Name = "scoreCell";
            this.scoreCell.ReadOnly = true;
            this.scoreCell.Width = 175;
            // 
            // pointCell
            // 
            this.pointCell.HeaderText = "绩点";
            this.pointCell.MinimumWidth = 9;
            this.pointCell.Name = "pointCell";
            this.pointCell.ReadOnly = true;
            this.pointCell.Width = 175;
            // 
            // commentBtnCell
            // 
            this.commentBtnCell.HeaderText = "查看评语";
            this.commentBtnCell.MinimumWidth = 9;
            this.commentBtnCell.Name = "commentBtnCell";
            this.commentBtnCell.ReadOnly = true;
            this.commentBtnCell.Width = 175;
            // 
            // editPassBtn
            // 
            this.editPassBtn.Location = new System.Drawing.Point(686, 44);
            this.editPassBtn.Name = "editPassBtn";
            this.editPassBtn.Size = new System.Drawing.Size(128, 35);
            this.editPassBtn.TabIndex = 10;
            this.editPassBtn.Text = "修改密码";
            this.editPassBtn.UseVisualStyleBackColor = true;
            this.editPassBtn.Click += new System.EventHandler(this.editPassBtn_Click);
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 670);
            this.Controls.Add(this.editPassBtn);
            this.Controls.Add(this.infoGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息查询系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentWindow_FormClosing);
            this.Load += new System.EventHandler(this.StudentWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label subTitle;
        private Label title;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView infoGrid;
        private DataGridViewTextBoxColumn courseCell;
        private DataGridViewTextBoxColumn scoreCell;
        private DataGridViewTextBoxColumn pointCell;
        private DataGridViewButtonColumn commentBtnCell;
        private Button editPassBtn;
    }
}