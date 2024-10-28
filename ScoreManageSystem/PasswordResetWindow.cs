using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScoreManageSystem
{
    public partial class PasswordResetWindow : Form
    {
        public int UserID;

        private const string loginCmd = "SELECT * FROM [User] WHERE Id = @id AND Password = @password";

        public PasswordResetWindow()
        {
            InitializeComponent();
        }

        private void PasswordResetWindow_Load(object sender, EventArgs e)
        {

        }

        private void ShowToolTip(Control control, string content)
        {
            var pos = control.Location;
            var size = control.Size;
            pos.X += 20;
            pos.Y -= size.Height * 2 - 10;
            toolTip.Hide(this);
            toolTip.Show(content, this, pos, 3000);
        }


        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(srcPass.Text))
            {
                ShowToolTip(srcPass, "原密码不能为空。");
                return;
            }

            if (newPass.Text.Length < 3)
            {
                ShowToolTip(newPass, "新密码的位数应该不少于3位。");
                return;
            }

            if (newPass.Text != newPass2.Text)
            {
                ShowToolTip(newPass2, "再次输入的密码和新密码不匹配。");
                return;
            }

            Database.QueryFirst(loginCmd.ToSqlCommand(("id", UserID), ("password", srcPass.Text)), (r) =>
            {
                const string updatePass = "UPDATE [User] SET Password = @password WHERE Id = @id";
                Database.Execute(updatePass.ToSqlCommand(("id", UserID), ("password", newPass.Text)))
                .Then(() =>
                {
                    MessageBox.Show("密码修改成功！", "密码重置", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }).Else((ex) =>
                {
                    MessageBox.Show("无法重置密码：" + ex.Message, "密码重置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
            }).Else(() =>
            {
                ShowToolTip(srcPass, "原密码不正确。");
            });
        }

        private void newPassLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
