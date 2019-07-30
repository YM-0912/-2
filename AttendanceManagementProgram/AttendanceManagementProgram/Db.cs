using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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

        public void DataTable()
        {
            var dataset = new DataSet();

            var data1 = dataset.EmployeeData.NewEmployeeDataRow();
            data1.Name = "田中太郎";
            data1.Id = "0001";
            data1.PassWord = "11111111";

            dataset.EmployeeData.AddEmployeeDataRow(data1);

            var nameColumnName = dataset.EmployeeData.NameColumn.ColumnName;
            var idColumnName = dataset.EmployeeData.IdColumn.ColumnName;
            var passWordName = dataset.EmployeeData.PassWordColumn.ColumnName;

            var r = dataset.EmployeeData.Rows[0];

            MessageBox.Show($"{nameColumnName}:{r[nameColumnName]}" +
                            $"{idColumnName}:{r[idColumnName]}" +
                            $"{passWordName}:{r[passWordName]}");

        }

    }
}
