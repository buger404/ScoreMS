using System.Data.SqlClient;

namespace ScoreManageSystem
{
    public partial class AdminWindow : Form
    {
        private List<int> courseIDList = new();

        public AdminWindow()
        {
            InitializeComponent();
        }

        private void UpdateCourses()
        {
            courseCell.Items.Clear();
            courseIDList.Clear();
            courseInfoGrid.Rows.Clear();
            Database.Query("SELECT * FROM [Course]".ToSqlCommand(), (r) =>
            {
                courseCell.Items.Add(r.Get<int>("Id") + "." + r.Get<string>("Name").Trim());
                courseIDList.Add(r.Get<int>("Id"));
                var row = courseInfoGrid.Rows[courseInfoGrid.Rows.Add()];
                row.SetValues(
                    r.Get<int>("Id").ToString(),
                    r.Get<string>("Name").Trim(),
                    "删除课程"
                );
                row.Tag = courseIDList.Count - 1;
            });
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            Database.Query("SELECT * FROM [Student] INNER JOIN [User] ON [Student].UserID = [User].Id".ToSqlCommand(), (r) =>
            {
                var row = stuInfoGrid.Rows[stuInfoGrid.Rows.Add()];
                row.SetValues(
                    r.Get<int>("Id").ToString(),
                    r.Get<string>("Name").Trim(),
                    r.Get<int>("Sex") == 0 ? "男" : "女",
                    r.Get<string>("UserName").Trim(),
                    r.Get<string>("Password").Trim(),
                    "删除学生"
                );
            });

            UpdateCourses();

            Database.Query("SELECT * FROM [Teacher] INNER JOIN [User] ON [Teacher].UserID = [User].Id".ToSqlCommand(), (r) =>
            {
                var row = teacherInfoGrid.Rows[teacherInfoGrid.Rows.Add()];
                row.SetValues(
                    r.Get<int>("Id").ToString(),
                    r.Get<string>("Name").Trim(),
                    courseCell.Items[courseIDList.FindIndex(x => x == r.Get<int>("CourseID"))],
                    r.Get<string>("UserName").Trim(),
                    r.Get<string>("Password").Trim(),
                    "删除教师"
                );
            });
        }

        private void AdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出当前账号吗？", "退出登录", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            LoginWindow.Instance.Show();
        }

        private void stuInfoGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var cell = stuInfoGrid[e.ColumnIndex, e.RowIndex];
            cell.Tag = cell.Value;
        }

        private bool IsUserNameValid(string name)
        {
            bool ret = false;
            Database.QueryFirst("SELECT * FROM [User] WHERE UserName = @name".ToSqlCommand(("name", name)), (r) =>
            {
                ret = false;
            }).Else(() => ret = true);
            return ret;
        }

        private void stuInfoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = stuInfoGrid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            var name = row.Cells[3].Value;
            var cell = stuInfoGrid[e.ColumnIndex, e.RowIndex];

            if (cell.Value == cell.Tag)
            {
                return;
            }

            bool valid = e.ColumnIndex switch
            {
                2 => cell.Value.ToString() == "男" || cell.Value.ToString() == "女",
                3 => !string.IsNullOrEmpty(cell.Value.ToString()) && IsUserNameValid(cell.Value.ToString()),
                _ => !string.IsNullOrEmpty(cell.Value.ToString()),
            };

            if (!valid)
            {
                if (e.ColumnIndex == 3)
                {
                    MessageBox.Show($"设置的新登录用户名'{cell.Value}'与其他用户重复，无法完成变更。", "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                cell.Value = cell.Tag;
                return;
            }

            SqlCommand cmd = e.ColumnIndex switch
            {
                1 => "UPDATE [Student] SET Name = @name WHERE Id = @id".ToSqlCommand(("id", id), ("name", cell.Value)),
                2 => "UPDATE [Student] SET Sex = @sex WHERE Id = @id".ToSqlCommand(("id", id), ("sex", cell.Value.ToString() == "男" ? 0 : 1)),
                3 => "UPDATE [User] SET UserName = @name WHERE UserName = @srcName".ToSqlCommand(("srcName", cell.Tag), ("name", cell.Value)),
                4 => "UPDATE [User] SET Password = @password WHERE UserName = @name".ToSqlCommand(("name", name), ("password", cell.Value)),
                _ => throw new ArgumentException(nameof(e.ColumnIndex))
            };

            Database.Execute(cmd)
                .Else((ex) =>
                {
                    cell.Value = cell.Tag;
                    MessageBox.Show($"信息更新失败：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
        }

        private void stuInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != 5)
            {
                return;
            }

            var row = stuInfoGrid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            var name = row.Cells[3].Value;
            if (MessageBox.Show($"你确定要删除学生'{row.Cells[1].Value}'吗？\n该学生关联的选课信息和成绩都将被删除，此操作不可逆。", "删除学生", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            Database.Execute(
                "DELETE FROM [Class] WHERE StudentID = @stuId".ToSqlCommand(("stuId", id)),
                "DELETE FROM [Score] WHERE StudentID = @stuId".ToSqlCommand(("stuId", id)),
                "DELETE FROM [Student] WHERE Id = @stuId".ToSqlCommand(("stuId", id)),
                "DELETE FROM [User] WHERE UserName = @name".ToSqlCommand(("name", name))
            ).Then(() =>
            {
                stuInfoGrid.Rows.RemoveAt(e.RowIndex);
            }).Else((ex) =>
            {
                MessageBox.Show($"无法删除学生：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            });
        }

        private void addStuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var uuid = Guid.NewGuid().ToString();
                Database.Execute(
                    "INSERT INTO [User](UserName, Password, Type) VALUES(@name, '123456', 2)".ToSqlCommand(("name", uuid))
                ).Else((ex) => throw ex);

                var userID = 0;
                Database.QueryFirst("SELECT * FROM [User] WHERE UserName = @name".ToSqlCommand(("name", uuid)), (r) =>
                {
                    userID = r.Get<int>("Id");
                });

                Database.Execute(
                    "INSERT INTO [Student](Name, UserID, Sex) VALUES(@name, @id, 0)"
                        .ToSqlCommand(("name", "未命名学生"), ("id", userID))
                ).Else((ex) => throw ex);

                Database.QueryFirst("SELECT * FROM [Student] WHERE UserID = @id".ToSqlCommand(("id", userID)), (r) =>
                {
                    var index = stuInfoGrid.Rows.Add();
                    var row = stuInfoGrid.Rows[index];
                    row.SetValues(
                        r.Get<int>("Id"),
                        "未命名学生",
                        "男",
                        uuid,
                        "123456",
                        "删除学生"
                    );

                    stuInfoGrid.ClearSelection();
                    row.Selected = true;
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show($"无法添加学生：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void teacherInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != 5)
            {
                return;
            }

            var row = teacherInfoGrid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            var name = row.Cells[3].Value;
            if (MessageBox.Show($"你确定要删除教师'{row.Cells[1].Value}'吗？\n此操作不会影响任课课程及其学生情况，但是此操作不可逆。", "删除教师", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            Database.Execute(
                "DELETE FROM [Teacher] WHERE Id = @id".ToSqlCommand(("id", id)),
                "DELETE FROM [User] WHERE UserName = @name".ToSqlCommand(("name", name))
            ).Then(() =>
            {
                teacherInfoGrid.Rows.RemoveAt(e.RowIndex);
            }).Else((ex) =>
            {
                MessageBox.Show($"无法删除教师：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            });
        }

        private void teacherInfoGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var cell = teacherInfoGrid[e.ColumnIndex, e.RowIndex];
            cell.Tag = cell.Value;
        }

        private void teacherInfoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = teacherInfoGrid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            var name = row.Cells[3].Value;
            var cell = teacherInfoGrid[e.ColumnIndex, e.RowIndex];

            if (cell.Value == cell.Tag)
            {
                return;
            }

            bool valid = e.ColumnIndex switch
            {
                2 => courseCell.Items.Contains(cell.Value),
                3 => !string.IsNullOrEmpty(cell.Value.ToString()) && IsUserNameValid(cell.Value.ToString()),
                _ => !string.IsNullOrEmpty(cell.Value.ToString()),
            };

            if (!valid)
            {
                if (e.ColumnIndex == 3)
                {
                    MessageBox.Show($"设置的新登录用户名'{cell.Value}'与其他用户重复，无法完成变更。", "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                cell.Value = cell.Tag;
                return;
            }

            SqlCommand cmd = e.ColumnIndex switch
            {
                1 => "UPDATE [Teacher] SET Name = @name WHERE Id = @id".ToSqlCommand(("id", id), ("name", cell.Value)),
                2 => "UPDATE [Teacher] SET CourseID = @course WHERE Id = @id".ToSqlCommand(("id", id), ("course", courseIDList[courseCell.Items.IndexOf(cell.Value)])),
                3 => "UPDATE [User] SET UserName = @name WHERE UserName = @srcName".ToSqlCommand(("srcName", cell.Tag), ("name", cell.Value)),
                4 => "UPDATE [User] SET Password = @password WHERE UserName = @name".ToSqlCommand(("name", name), ("password", cell.Value)),
                _ => throw new ArgumentException(nameof(e.ColumnIndex))
            };

            Database.Execute(cmd)
                .Else((ex) =>
                {
                    cell.Value = cell.Tag;
                    MessageBox.Show($"信息更新失败：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var uuid = Guid.NewGuid().ToString();
                Database.Execute(
                    "INSERT INTO [User](UserName, Password, Type) VALUES(@name, '123456', 2)".ToSqlCommand(("name", uuid))
                ).Else((ex) => throw ex);

                var userID = 0;
                Database.QueryFirst("SELECT * FROM [User] WHERE UserName = @name".ToSqlCommand(("name", uuid)), (r) =>
                {
                    userID = r.Get<int>("Id");
                });

                Database.Execute(
                    "INSERT INTO [Teacher](Name, UserID, CourseID) VALUES(@name, @id, @course)"
                        .ToSqlCommand(("name", "未命名老师"), ("id", userID), ("course", courseIDList[0]))
                ).Else((ex) => throw ex);

                Database.QueryFirst("SELECT * FROM [Teacher] WHERE UserID = @id".ToSqlCommand(("id", userID)), (r) =>
                {
                    var index = teacherInfoGrid.Rows.Add();
                    var row = teacherInfoGrid.Rows[index];
                    row.SetValues(
                        r.Get<int>("Id"),
                        "未命名老师",
                        courseCell.Items[0],
                        uuid,
                        "123456",
                        "删除教师"
                    );

                    teacherInfoGrid.ClearSelection();
                    row.Selected = true;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法添加教师：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void courseInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != 2)
            {
                return;
            }

            if (courseInfoGrid.Rows.Count <= 1)
            {
                MessageBox.Show($"必须至少有一门课程，无法删除当前课程。", "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var row = courseInfoGrid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            if (MessageBox.Show($"你确定要删除课程'{row.Cells[1].Value}'吗？\n此操作将删除与之关联的全部成绩和选课信息，此操作不可逆。", "删除课程", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            var exit = false;
            Database.QueryFirst("SELECT * FROM [Teacher] WHERE CourseID = @id".ToSqlCommand(("id", id)), (r) =>
            {
                MessageBox.Show($"无法删除当前课程，因为教师'{r.Get<string>("Name").Trim()}'仍在教授它。", "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                exit = true;
            });
            if (exit)
            {
                return;
            }

            Database.Execute(
                "DELETE FROM [Class] WHERE CourseID = @id".ToSqlCommand(("id", id)),
                "DELETE FROM [Score] WHERE CourseID = @id".ToSqlCommand(("id", id)),
                "DELETE FROM [Course] WHERE Id = @id".ToSqlCommand(("id", id))
            ).Then(() =>
            {
                courseIDList.RemoveAt((int)row.Tag!);
                courseCell.Items.RemoveAt((int)row.Tag!);
                courseInfoGrid.Rows.RemoveAt(e.RowIndex);
            }).Else((ex) =>
            {
                MessageBox.Show($"无法删除课程：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            });
        }

        private void courseInfoGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var cell = courseInfoGrid[e.ColumnIndex, e.RowIndex];
            cell.Tag = cell.Value;
        }

        private void courseInfoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = courseInfoGrid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            var cell = courseInfoGrid[e.ColumnIndex, e.RowIndex];

            if (cell.Value == cell.Tag)
            {
                return;
            }

            bool valid = e.ColumnIndex switch
            {
                1 => !string.IsNullOrEmpty(cell.Value.ToString()),
                _ => !string.IsNullOrEmpty(cell.Value.ToString()),
            };

            if (!valid)
            {
                cell.Value = cell.Tag;
                return;
            }

            SqlCommand cmd = e.ColumnIndex switch
            {
                1 => "UPDATE [Course] SET Name = @name WHERE Id = @id".ToSqlCommand(("id", id), ("name", cell.Value)),
                _ => throw new ArgumentException(nameof(e.ColumnIndex))
            };

            Database.Execute(cmd)
                .Then(() => 
                {
                    courseCell.Items[(int)row.Tag!] = courseIDList[(int)row.Tag] + "." + cell.Value;
                }).Else((ex) =>
                {
                    cell.Value = cell.Tag;
                    MessageBox.Show($"信息更新失败：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                });
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Execute(
                    "INSERT INTO [Course](Name) VALUES(@name)".ToSqlCommand(("name", "未命名课程"))
                ).Else((ex) => throw ex);

                UpdateCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法添加课程：" + ex.Message, "管理系统", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
