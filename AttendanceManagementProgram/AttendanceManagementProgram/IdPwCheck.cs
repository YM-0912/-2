using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementProgram
{
    /// <summary>
    /// クラス：ログイン認証可否判定
    /// </summary>
    class IdPwCheck
    {
        //プロパティ
        public string Id { get; set; }      //ID
        public string Pw { get; set; }      //PW

        //LoginFormで入力されたIDとPWの一致・不一致を確認
        public bool OkNg(string id,string pw)
        {
            this.Id = id;
            this.Pw = pw;

            //クラス：データベースに接続のインスタンスを生成
            var dbCon = new DbConnect();
            dbCon.IdPwGet(this.Id,this.Pw);

            if (dbCon.Id == this.Id && dbCon.Pw == this.Pw)
            {
                var okMsg = new OkMsg();
                okMsg.IdPwOk();
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
