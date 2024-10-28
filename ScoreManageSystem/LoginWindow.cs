using System.Data.SqlClient;

namespace ScoreManageSystem
{
    public partial class LoginWindow : Form
    {
        public static LoginWindow Instance = null!;

        private const string loginCmd = "SELECT * FROM [User] WHERE UserName = @username AND Password = @password";
        public LoginWindow()
        {
            InitializeComponent();
            Instance = this;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPassword.Checked ? (char)0 : '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("用户名或密码不能为空。", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Database.QueryFirst(loginCmd.ToSqlCommand(("username", userName.Text), ("password", password.Text)), (r) =>
            {
                MessageBox.Show("登录成功！", "成绩管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (r.Get<DataModel.AccountType>("Type"))
                {
                    case DataModel.AccountType.Administrator:
                        new AdminWindow().Show();
                        break;
                    case DataModel.AccountType.Teacher:
                        new TeacherWindow()
                        {
                            TeacherUserID = r.Get<int>("Id")
                        }.Show();
                        break;
                    case DataModel.AccountType.Student:
                        new StudentWindow()
                        {
                            StudentUserID = r.Get<int>("Id")
                        }.Show();
                        break;
                }
                Hide();
            }).Else(() =>
            {
                MessageBox.Show("账号或密码错误！", "登录失败", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            });
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}