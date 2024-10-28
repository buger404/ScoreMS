using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManageSystem
{
    public partial class TeacherWindow : Form
    {
        public int TeacherUserID;
        public int CourseID;

        private const string teacherInfoCmd = "SELECT * FROM [Teacher] WHERE UserID = @userId";
        private const string courseInfoCmd = "SELECT * FROM [Course] WHERE Id = @id";
        private const string studentInfoCmd = @"SELECT [Student].Id, [Student].Name, [Student].Sex, [Score].Score AS Score FROM [Student] 
                                                INNER JOIN [Class] ON [Student].Id = [Class].StudentID 
                                                LEFT JOIN [Score] ON [Student].Id = [Score].StudentID AND [Class].CourseID = [Score].CourseID
                                                WHERE [Class].CourseID = @courseId 
                                                ORDER BY [Student].Id";
        private const string rankInfoCmd = @"SELECT [Student].Id, [Student].Name, [Student].Sex, [Score].Score AS Score FROM [Student] 
                                                INNER JOIN [Class] ON [Student].Id = [Class].StudentID 
                                                LEFT JOIN [Score] ON [Student].Id = [Score].StudentID AND [Class].CourseID = [Score].CourseID
                                                WHERE [Class].CourseID = @courseId 
                                                ORDER BY [Score].Score DESC";
        private const string singleScoreInfo = "SELECT * FROM [Score] WHERE [Score].StudentID = @studentId AND [Score].CourseId = @courseId";

        public TeacherWindow()
        {
            InitializeComponent();
        }

        private void TeacherWindow_Load(object sender, EventArgs e)
        {
            Database.QueryFirst(teacherInfoCmd.ToSqlCommand(("userId", TeacherUserID)), (r) =>
            {
                var time = DateTime.Now.Hour switch
                {
                    >= 6 and <= 11 => "早上",
                    > 11 and < 14 => "中午",
                    >= 14 and < 16 => "下午",
                    >= 16 and < 19 => "傍晚",
                    _ => "晚上"
                };
                title.Text = $"{time}好，{r.Get<string>("Name").Trim()}！";
                CourseID = r.Get<int>("CourseID");
            });

            Database.QueryFirst(courseInfoCmd.ToSqlCommand(("id", CourseID)), (r) =>
            {
                subTitle.Text = $"当前任课：{r.Get<string>("Name").Trim()}";
            });

            Database.Query(studentInfoCmd.ToSqlCommand(("courseId", CourseID)), (r) =>
            {
                var row = stuInfoGrid.Rows[stuInfoGrid.Rows.Add()];
                row.SetValues(
                    r.Get<int>("Id").ToString(),
                    r.Get<string>("Name").Trim(),
                    r.Get<int>("Sex") == 0 ? "男" : "女",
                    "移除选课"
                );
                row.Tag = r.Get<int>("Id");
                row = scoreInfoGrid.Rows[scoreInfoGrid.Rows.Add()];
                row.SetValues(
                    r.Get<int>("Id").ToString(),
                    r.Get<string>("Name").Trim(),
                    r.IsDBNull("Score") ? "未录入" : r.Get<int>("Score"),
                    "评语"
                );
                row.Tag = r.Get<int>("Id");
            });

            Database.Query("SELECT * FROM [Student]".ToSqlCommand(), (r) =>
            {
                stuIDCombo.Items.Add(r.Get<int>("Id").ToString());
            });
        }

        private void UpdateRanking()
        {
            int count = 0;
            var list = new List<int>();
            rankInfoGrid.Rows.Clear();
            Database.Query(rankInfoCmd.ToSqlCommand(("courseId", CourseID)), (r) =>
            {
                var index = rankInfoGrid.Rows.Add();
                var row = rankInfoGrid.Rows[index];
                row.SetValues(
                    (index + 1),
                    r.Get<int>("Id").ToString(),
                    r.Get<string>("Name").Trim(),
                    r.IsDBNull("Score") ? "未录入" : r.Get<int>("Score"),
                    r.IsDBNull("Score") ? "未录入" : DataModel.GetScorePoint(r.Get<int>("Score"))
                );
                count++;
                if (!r.IsDBNull("Score"))
                {
                    list.Add(r.Get<int>("Score"));
                }
            });

            if (list.Count == 0)
            {
                rankDetail.Text = "尚未录入任何成绩。";
                return;
            }
            rankDetail.Text = $"平均分：{list.Average():F2}，最高分：{list.Max()}，最低分：{list.Min()}，已录入：{list.Count}/{count} ({list.Count * 1.0 / count:P})";
        }

        private void AddStudent(int studentID)
        {
            Database.QueryFirst("SELECT * FROM [Student] WHERE Id = @id".ToSqlCommand(("id", studentID)), (r) =>
            {
                var row = stuInfoGrid.Rows[stuInfoGrid.Rows.Add()];
                row.SetValues(
                    r.Get<int>("Id").ToString(),
                    r.Get<string>("Name").Trim(),
                    r.Get<int>("Sex") == 0 ? "男" : "女",
                    "移除选课"
                );
                row.Tag = studentID;

                Database.QueryFirst(singleScoreInfo.ToSqlCommand(("studentId", studentID), ("courseId", CourseID)), (s) =>
                {
                    var row = scoreInfoGrid.Rows[scoreInfoGrid.Rows.Add()];
                    row.SetValues(
                        r.Get<int>("Id").ToString(),
                        r.Get<string>("Name").Trim(),
                        s.Get<int>("Score"),
                        "评语"
                    );
                    row.Tag = studentID;
                }).Else(() =>
                {
                    var row = scoreInfoGrid.Rows[scoreInfoGrid.Rows.Add()];
                    row.SetValues(
                        r.Get<int>("Id").ToString(),
                        r.Get<string>("Name").Trim(),
                        "未录入",
                        "评语"
                    );
                    row.Tag = studentID;
                });
            });


        }

        private void TeacherWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出当前账号吗？", "退出登录", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            LoginWindow.Instance.Show();
        }

        private void stuIDCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            addStuBtn.Enabled = false;
            Database.QueryFirst("SELECT * FROM [Student] WHERE Id = @id".ToSqlCommand(("id", stuIDCombo.SelectedItem)), (r) =>
            {
                stuName.Text = r.Get<string>("Name").Trim();
                addStuBtn.Enabled = true;
            }).Else(() =>
            {
                stuName.Text = "学生不存在！";
            });
        }

        private void addStuBtn_Click(object sender, EventArgs e)
        {
            if (stuIDCombo.SelectedItem == null)
            {
                stuName.Text = "学生不存在！";
                addStuBtn.Enabled = false;
                return;
            }

            const string isInClass = "SELECT * FROM [Class] WHERE StudentID = @stuId AND CourseID = @courseId";
            Database.QueryFirst(isInClass.ToSqlCommand(("stuId", stuIDCombo.SelectedItem), ("courseId", CourseID)), (r) =>
            {
                MessageBox.Show("该学生已在当前课程中，无法重复添加。", "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }).Else(() =>
            {
                const string addToClass = "INSERT INTO [Class](StudentID, CourseID) VALUES (@stuId, @courseId)";
                Database.Execute(addToClass.ToSqlCommand(("stuId", stuIDCombo.SelectedItem), ("courseId", CourseID)))
                .Then(() =>
                {
                    AddStudent(int.Parse((string)stuIDCombo.SelectedItem));
                    MessageBox.Show("已成功添加学生", "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                })
                .Else((ex) => 
                {
                    MessageBox.Show("无法添加学生：" + ex.Message, "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
            });
        }

        private void stuInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 || e.RowIndex < 0)
            {
                return;
            }

            var row = stuInfoGrid.Rows[e.RowIndex];
            if (MessageBox.Show($"你确定要取消学生'{row.Cells[1].Value}'的选课吗？", "取消选课", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            const string removeFromClass = "DELETE FROM [Class] WHERE StudentID = @stuId AND CourseID = courseId";
            Database.Execute(removeFromClass.ToSqlCommand(("stuId", row.Cells[0].Value), ("courseId", CourseID)))
            .Then(() =>
            {
                MessageBox.Show($"已取消学生'{row.Cells[1].Value}'的选课。", "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var index = -1;
                for(var i = 0; i < scoreInfoGrid.Rows.Count; i++)
                {
                    if (scoreInfoGrid.Rows[i].Tag!.Equals(row.Tag))
                    {
                        index = i;
                        break;
                    }
                }
                scoreInfoGrid.Rows.RemoveAt(index);
                stuInfoGrid.Rows.RemoveAt(e.RowIndex);
            })
            .Else((ex) =>
            {
                MessageBox.Show("无法移除学生的选课：" + ex.Message, "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            });
        }

        private void GridSortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            double value1 = e.CellValue1 is string ? -1 : Convert.ToDouble(e.CellValue1);
            double value2 = e.CellValue2 is string ? -1 : Convert.ToDouble(e.CellValue2);

            e.SortResult = value1.CompareTo(value2);
            e.Handled = true;
        }

        private void scoreInfoGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var cell = scoreInfoGrid[e.ColumnIndex, e.RowIndex];
            cell.Tag = cell.Value;
        }

        private void scoreInfoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = scoreInfoGrid[e.ColumnIndex, e.RowIndex];
            var row = scoreInfoGrid.Rows[e.RowIndex];
            if (e.RowIndex < 0 || cell.Value == null || !int.TryParse(cell.Value.ToString(), out var score))
            {
                cell.Value = cell.Tag;
                return;
            }

            Database.QueryFirst(singleScoreInfo.ToSqlCommand(("studentId", row.Cells[0].Value), ("courseId", CourseID)), (_) =>
            {
                const string updateScore = "UPDATE [Score] SET Score = @score WHERE StudentID = @stuId AND CourseID = @courseId";
                Database.Execute(
                    updateScore.ToSqlCommand(
                        ("stuId", row.Cells[0].Value), ("courseId", CourseID), ("score", score)
                    )
                ).Else((ex) =>
                {
                    cell.Value = cell.Tag;
                    MessageBox.Show($"更新学生'{row.Cells[1].Value}'成绩失败：" + ex.Message, "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
            }).Else(() =>
            {
                const string newScore = "INSERT INTO [Score](StudentID, CourseID, Score) VALUES (@stuId, @courseId, @score)";
                Database.Execute(
                    newScore.ToSqlCommand(
                        ("stuId", row.Cells[0].Value), ("courseId", CourseID), ("score", score)
                    )
                ).Else((ex) =>
                {
                    cell.Value = cell.Tag;
                    MessageBox.Show($"更新学生'{row.Cells[1].Value}'成绩失败：" + ex.Message, "学生信息管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
            });
        }

        private void scoreInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 || e.RowIndex < 0)
            {
                return;
            }

            var row = stuInfoGrid.Rows[e.RowIndex];
            new CommentWindow()
            {
                EditMode = true,
                StudentID = int.Parse(row.Cells[0].Value.ToString()),
                CourseID = CourseID
            }.ShowDialog();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                UpdateRanking();
            }
        }

        private void editPassBtn_Click(object sender, EventArgs e)
        {
            new PasswordResetWindow()
            {
                UserID = TeacherUserID
            }.ShowDialog();
        }
    }
}
