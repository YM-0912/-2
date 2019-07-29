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


        //列を追加
        

        //public void DbData()
        //{
        //    カラム名と型を定義
        //    var name = new DataColumn("Name", typeof(string));
        //    table.Columns.Add(name);
        //    var id = new DataColumn("Id", typeof(string));
        //    table.Columns.Add(id);
        //    var pass = new DataColumn("Pass", typeof(string));
        //    table.Columns.Add(pass);

        //    datatableをdatasetに追加
        //    dataset.Tables.Add(table);

        //    DataRowの定義
        //    var table1 = table.NewRow();
        //    table1["Name"] = "田中一郎";
        //    table1["Id"] = "0001";
        //    table1["Pw"] = "11111111";

        //    var table2 = table.NewRow();
        //    table1[0] = "山田二郎";
        //    table1[1] = "0002";
        //    table1[2] = "22222222";

        //    var table3 = table.NewRow();
        //    table1[0] = "木村三郎";
        //    table1[1] = "0003";
        //    table1[2] = "33333333";

        //    datatableへ追加
        //    table.Rows.Add(table1);
        //    table.Rows.Add(table2);
        //    table.Rows.Add(table3);
        //}
    }
}
