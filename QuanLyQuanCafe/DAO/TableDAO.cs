using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 105;
        public static int TableHeight = 105;

        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[]{id1, id2});
        }
        public DataTable GetListTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT id, name FROM dbo.TableFood");
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public List<Table> SearchTableByName(string name)
        {

            List<Table> list = new List<Table>();

            string query = string.Format("SELECT * FROM dbo.TableFood WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }

            return list;
        }
        public void UpdateTableSatus1 (int id)
        {
            DataProvider.Instance.ExecuteQuery("Update TableFood set status = N'Có người' where id = " + id);
        }
        public void UpdateTableSatus0(int id)
        {
            DataProvider.Instance.ExecuteQuery("Update TableFood set status = N'Trống' where id = " + id);
        }

        public bool InsertTable(string name)
        {
            string query = string.Format("INSERT dbo.TableFood ( name )VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(int idTable, string name)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{0}' WHERE id = {1}", name, idTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int idTable)
        {

            string query = string.Format("Delete TableFood where id = {0}", idTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
