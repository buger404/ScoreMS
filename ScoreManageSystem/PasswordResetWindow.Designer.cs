namespace ScoreManageSystem
{
    partial class PasswordResetWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.srcPass = new System.Windows.Forms.TextBox();
            this.srcPassLabel = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.newPass2 = new System.Windows.Forms.TextBox();
            this.newPassLabel2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "密码重置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // srcPass
            // 
            this.srcPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.srcPass.Location = new System.Drawing.Point(218, 101);
            this.srcPass.MaxLength = 30;
            this.srcPass.Name = "srcPass";
            this.srcPass.PasswordChar = '*';
            this.srcPass.Size = new System.Drawing.Size(714, 34);
            this.srcPass.TabIndex = 7;
            // 
            // srcPassLabel
            // 
            this.srcPassLabel.AutoSize = true;
            this.srcPassLabel.Location = new System.Drawing.Point(33, 104);
            this.srcPassLabel.Name = "srcPassLabel";
            this.srcPassLabel.Size = new System.Drawing.Size(75, 28);
            this.srcPassLabel.TabIndex = 6;
            this.srcPassLabel.Text = "原密码";
            // 
            // newPass
            // 
            this.newPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newPass.Location = new System.Drawing.Point(218, 185);
            this.newPass.MaxLength = 30;
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '*';
            this.newPass.Size = new System.Drawing.Size(714, 34);
            this.newPass.TabIndex = 9;
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Location = new System.Drawing.Point(33, 188);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(75, 28);
            this.newPassLabel.TabIndex = 8;
            this.newPassLabel.Text = "新密码";
            // 
            // newPass2
            // 
            this.newPass2.Location = new System.Drawing.Point(218, 239);
            this.newPass2.MaxLength = 30;
            this.newPass2.Name = "newPass2";
            this.newPass2.PasswordChar = '*';
            this.newPass2.Size = new System.Drawing.Size(714, 34);
            this.newPass2.TabIndex = 11;
            // 
            // newPassLabel2
            // 
            this.newPassLabel2.AutoSize = true;
            this.newPassLabel2.Location = new System.Drawing.Point(33, 242);
            this.newPassLabel2.Name = "newPassLabel2";
            this.newPassLabel2.Size = new System.Drawing.Size(159, 28);
            this.newPassLabel2.TabIndex = 10;
            this.newPassLabel2.Text = "再次输入新密码";
            this.newPassLabel2.Click += new System.EventHandler(this.newPassLabel2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 106);
            this.panel1.TabIndex = 12;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(782, 27);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(171, 44);
            this.confirmBtn.TabIndex = 0;
            this.confirmBtn.Text = "确认重置";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.White;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip.ToolTipTitle = "密码重置";
            // 
            // PasswordResetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newPass2);
            this.Controls.Add(this.newPassLabel2);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.srcPass);
            this.Controls.Add(this.srcPassLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordResetWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码重置";
            this.Load += new System.EventHandler(this.PasswordResetWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox srcPass;
        private Label srcPassLabel;
        private TextBox newPass;
        private Label newPassLabel;
        private TextBox newPass2;
        private Label newPassLabel2;
        private Panel panel1;
        private Button confirmBtn;
        private ToolTip toolTip;
    }
}