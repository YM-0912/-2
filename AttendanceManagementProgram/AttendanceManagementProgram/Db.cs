using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AttendanceManagementProgram
{
    /// <summary>
    /// クラス：データベース
    /// </summary>
    class Db
    {
        //パラメータ
        public string Name { get; set; }        //氏名
        public string Id { get; set; }          //社員番号
        public string Pass { get; set; }        //パスワード

        public void DbData(string id,string pw)
        {

            DataTable table = new DataTable("Table");

            this.Id = id;
            this.Pass = pw;

            //カラム
            table.Columns.Add(this.Name);
            table.Columns.Add(this.Id);
            table.Columns.Add(this.Pass);

            //行データを追加
            table.Rows.Add("田中一郎", "0001", "11111111");
            table.Rows.Add("山田二郎", "0002", "22222222");
            table.Rows.Add("木村三郎", "0003", "33333333");
            table.Rows.Add("大阪花子", "0004", "44444444");
            table.Rows.Add("神戸良子", "0005", "55555555");
            table.Rows.Add("岡山智子", "0006", "66666666");

        }
    }
}
