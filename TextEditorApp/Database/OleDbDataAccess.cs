using System.Data.OleDb;
using System.Data;

namespace TextEditorApp.Database
{
    public class OleDbDataAccess
    {
        string ConnectionString { get; set; } = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Aamir\\Documents\\EmptyDB.accdb";
        OleDbConnection Connection { get; set; }
        OleDbCommand Command { get; set; }
        
        public OleDbDataAccess()
        {
            Connection = new OleDbConnection(ConnectionString);
        }
        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            Connection.Open();
            OleDbDataAdapter adapter= new OleDbDataAdapter("SELECT * FROM tblProject", Connection);
            adapter.Fill(ds);
            return ds;
        }
    }
}
