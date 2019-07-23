using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementProgram
{
    /// <summary>
    /// クラス：メイン
    /// </summary>
    class MainProgram
    {
        //パラメータ
        public static string Id { get; set; }      //ID
        public static string Pw { get; set; }      //PW

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
