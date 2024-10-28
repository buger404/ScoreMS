namespace ScoreManageSystem
{
    partial class CommentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentWindow));
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.limitText = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(98, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(192, 28);
            this.title.TabIndex = 3;
            this.title.Text = "来自 陈老师 的评语";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // limitText
            // 
            this.limitText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limitText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.limitText.Location = new System.Drawing.Point(568, 33);
            this.limitText.Name = "limitText";
            this.limitText.Size = new System.Drawing.Size(201, 28);
            this.limitText.TabIndex = 4;
            this.limitText.Text = "0/250字";
            this.limitText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comment
            // 
            this.comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comment.Location = new System.Drawing.Point(29, 87);
            this.comment.MaxLength = 250;
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(740, 262);
            this.comment.TabIndex = 5;
            this.comment.TextChanged += new System.EventHandler(this.comment_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 87);
            this.panel1.TabIndex = 6;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(606, 19);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(163, 43);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // CommentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.limitText);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "评语";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommentWindow_FormClosing);
            this.Load += new System.EventHandler(this.CommentWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private PictureBox pictureBox1;
        private Label limitText;
        private TextBox comment;
        private Panel panel1;
        private Button okBtn;
    }
}