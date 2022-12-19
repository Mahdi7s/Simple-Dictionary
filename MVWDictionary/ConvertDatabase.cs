namespace MVWDictionary
{
    public class ConvertDatabase
    {
        private DictionarySerializing GetDictionary(System.Data.Common.DbDataAdapter adapter)
        {
            System.Data.DataTable DicTable = new System.Data.DataTable();
            adapter.Fill(DicTable);
            if (DicTable.Rows.Count <= 0) return null;
            DictionarySerializing ResDic = new DictionarySerializing();
            System.Collections.Generic.List<string> keys = new System.Collections.Generic.List<string>();
            System.Collections.Generic.List<string> values = new System.Collections.Generic.List<string>();
            foreach (System.Data.DataRow r in DicTable.Rows)
            {
                keys.Add(r[0].ToString()); values.Add(r[1].ToString());
            }
            ResDic.Keys = keys.ToArray(); ResDic.Values = values.ToArray();
            return ResDic;
        }

        public DictionarySerializing
            GetDictionaryFromAccessDatabase(string AccessProvider, string AccessDbPath, string TableName)
        {
            System.Data.OleDb.OleDbConnectionStringBuilder OCSB = new System.Data.OleDb.OleDbConnectionStringBuilder();
            OCSB.Provider = AccessProvider; OCSB.DataSource = AccessDbPath;
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(OCSB.ConnectionString);
            System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
            command.Connection = connection;
            command.CommandText = string.Format("Select * From {0};", TableName);
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(command);
            return GetDictionary(adapter);
        }

        public DictionarySerializing GetDictionaryFromSqlDatabase
            (string SqlDataSource, string SqlDatabaseName, string TableName)
        {
            System.Data.SqlClient.SqlConnectionStringBuilder SCSB = new System.Data.SqlClient.SqlConnectionStringBuilder();
            SCSB.DataSource = SqlDataSource; SCSB.InitialCatalog = SqlDatabaseName;
            SCSB.IntegratedSecurity = true;
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(SCSB.ConnectionString);
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            command.Connection = connection;
            command.CommandText = string.Format("Select * From {0}", TableName);
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(command);
            return GetDictionary(adapter);
        }

    }
}
