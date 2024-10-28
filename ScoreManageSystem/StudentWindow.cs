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
    public partial class StudentWindow : Form
    {
        public int StudentUserID;
        public int StudentID;

        private const string queryCmd = @"SELECT [Course].Id, [Course].Name, [Score].Score, [Score].Comment FROM [Class]
                                          INNER JOIN [Course] ON [Course].Id = [Class].CourseID
                                          LEFT JOIN [Score] ON [Score].CourseID = [Class].CourseID AND [Score].StudentID = @id
                                          WHERE [Class].StudentID = @id";

        public StudentWindow()
        {
            InitializeComponent();
        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {
            Database.QueryFirst("SELECT * FROM [Student] WHERE UserID = @id".ToSqlCommand(("id", StudentUserID)), (r) =>
            {
                StudentID = r.Get<int>("Id");
                title.Text = $"欢迎使用，{r.Get<string>("Name").Trim()}同学！";
            });

            var points = new List<double>();
            Database.Query(queryCmd.ToSqlCommand(("id", StudentID)), (r) =>
            {
                var row = infoGrid.Rows[infoGrid.Rows.Add()];
                row.SetValues(
                    r.Get<string>("Name").Trim(),
                    r.IsDBNull("Score") ? "未录入" : r.Get<int>("Score"),
                    r.IsDBNull("Score") ? "未录入" : DataModel.GetScorePoint(r.Get<int>("Score")),
                    "查看评语"
                );
                if (!r.IsDBNull("Score"))
                {
                    points.Add(DataModel.GetScorePoint(r.Get<int>("Score")));
                }
                row.Cells[^1].Tag = r.Get<int>("Id");
            });

            if (points.Count == 0) 
            {
                subTitle.Text = $"总绩点：-";
                return;
            }
            subTitle.Text = $"总绩点：{points.Average():F1}";
        }

        private void StudentWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出当前账号吗？", "退出登录", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            LoginWindow.Instance.Show();
        }

        private void infoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 || e.RowIndex < 0)
            {
                return;
            }

            var row = infoGrid.Rows[e.RowIndex];
            new CommentWindow()
            {
                EditMode = false,
                StudentID = StudentID,
                CourseID = (int)row.Cells[^1].Tag
            }.ShowDialog();
        }

        private void infoGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            double value1 = e.CellValue1 is string ? -1 : Convert.ToDouble(e.CellValue1);
            double value2 = e.CellValue2 is string ? -1 : Convert.ToDouble(e.CellValue2);

            e.SortResult = value1.CompareTo(value2);
            e.Handled = true;
        }

        private void editPassBtn_Click(object sender, EventArgs e)
        {
            new PasswordResetWindow()
            {
                UserID = StudentUserID
            }.ShowDialog();
        }
    }
}
