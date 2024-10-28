using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManageSystem
{
    public partial class CommentWindow : Form
    {
        public bool EditMode;
        public int StudentID, CourseID;

        private bool dirty = false;
        private string originalText;

        private const string scoreInfo = "SELECT * FROM [Score] WHERE StudentID = @stuId AND CourseID = @courseId";

        public CommentWindow()
        {
            InitializeComponent();
        }

        private void comment_TextChanged(object sender, EventArgs e)
        {
            limitText.Text = $"{comment.Text.Length}/250字";
            if (comment.Text != originalText && EditMode)
            {
                dirty = true;
                this.Text = "*评语(已修改)";
            }
            else
            {
                dirty = false;
                this.Text = "评语";
            }
        }

        private void CommentWindow_Load(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                limitText.Visible = false;
                comment.ReadOnly = true;
                Database.QueryFirst("SELECT * FROM [Teacher] WHERE CourseID = @id".ToSqlCommand(("id", CourseID)), (r) =>
                {
                    title.Text = $"来自 {r.Get<string>("Name").Trim()} 的评价";
                });
            }
            else
            {
                Database.QueryFirst("SELECT * FROM [Student] WHERE Id = @id".ToSqlCommand(("id", StudentID)), (r) =>
                {
                    title.Text = $"对学生 {r.Get<string>("Name").Trim()} 的评价";
                });
            }

            Database.QueryFirst(scoreInfo.ToSqlCommand(("stuId", StudentID), ("courseId", CourseID)), (r) =>
            {
                originalText = r.IsDBNull("Comment") ? "" : r.Get<string>("Comment").Trim();
                comment.Text = originalText;
            }).Else(() =>
            {
                EditMode = false;
                comment.Text = "成绩尚未录入";
                comment.ReadOnly = true;
                okBtn.Enabled = false;
                limitText.Visible = false;
            });
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                Close();
                return;
            }

            const string updateComment = "UPDATE [Score] SET Comment = @comment WHERE StudentID = @stuId AND CourseID = @courseId";
            Database.Execute(updateComment.ToSqlCommand(("stuId", StudentID), ("courseId", CourseID), ("comment", comment.Text)))
                .Then(() =>
                {
                    dirty = false;
                    Close();
                })
                .Else((ex) =>
                {
                    MessageBox.Show($"更新评语失败：" + ex.Message, "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
        }

        private void CommentWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!EditMode || !dirty)
            {
                return;
            }

            if (MessageBox.Show("你确定要放弃评语修改吗？\n修改将会丢失，评语将保持原样。", "退出评语修改", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
