using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementProgram
{
    public partial class LoginForm : Form
    {
        //プロパティ
        public string EmployeeNumber { get; set; }      //社員番号
        public string PassWord { get; set; }            //パスワード

        public LoginForm()
        {
            InitializeComponent();
            //イベントハンドラを登録：ログインボタン
            this.Click += new EventHandler(loginButton_Click);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// ログインボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            this.EmployeeNumber = employeeNumberBox.Text;       //入力された社員番号
            this.PassWord = PasswordBox.Text;                   //入力されたパスワード

            //クラス：ログイン認証可否判定のインスタンス生成
            var idPwCheck = new IdPwCheck();
            //LoginFormで入力されたID/PWを渡す
            //idPwCheck.OkNg(EmployeeNumber, PassWord);
        }
    }
}
