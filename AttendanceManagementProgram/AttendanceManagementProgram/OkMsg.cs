using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementProgram
{
    /// <summary>
    /// クラス：ポップアップ一覧
    /// </summary>
    class OkMsg
    {
        //ログイン認証時：IDとPWが一致しました
        public void IdPwOk()
        {
            MessageBox.Show("IDとPWが一致しました","ログイン認証結果",MessageBoxButtons.OK);
        }
    }
}
