namespace BD.Adapter
{
    public class SQLCommand
    {
        private string _MSSQLSelect;
        private string _MSSQLInsert;
        private string _MSSQLDelete;
        private string _MSSQLUpdate;
        private string _MSSQLFromTable;
        private string _MSSQLIntoTable;

        public string MSSQLSelect { get => _MSSQLSelect; set => _MSSQLSelect = "SELECT"; }
        public string MSSQLInsert { get => _MSSQLInsert; set => _MSSQLInsert = "INSERT"; }
        public string MSSQLDelete { get => _MSSQLDelete; set => _MSSQLDelete = "DELETE"; }
        public string MSSQLUpdate { get => _MSSQLUpdate; set => _MSSQLUpdate = "UPDATE"; }
        public string MSSQLFromTable { get => _MSSQLFromTable; set => _MSSQLFromTable = "FROM"; }
        public string MSSQLIntoTable { get => _MSSQLIntoTable; set => _MSSQLIntoTable = "INTO"; }

        private string _MySQLSelect;
        private string _MySQLInsert;
        private string _MySQLDelete;
        private string _MySQLUpdate;
        private string _MySQLFromTable;
        private string _MySQLIntoTable;

        public string MySQLSelect { get => _MySQLSelect; set => _MySQLSelect = "SELECT"; }
        public string MySQLInsert { get => _MySQLInsert; set => _MySQLInsert = "INSERT"; }
        public string MySQLDelete { get => _MySQLDelete; set => _MySQLDelete = "DELETE"; }
        public string MySQLUpdate { get => _MySQLUpdate; set => _MySQLUpdate = "UPDATE"; }
        public string MySQLFromTable { get => _MySQLFromTable; set => _MySQLFromTable = "FROM"; }
        public string MySQLIntoTable { get => _MySQLIntoTable; set => _MySQLIntoTable = "INTO"; }

        private string _PgSQLSelect;
        private string _PgSQLInsert;
        private string _PgSQLDelete;
        private string _PgSQLUpdate;
        private string _PgSQLFromTable;
        private string _PgSQLIntoTable;

        public string PgSQLSelect { get => _PgSQLSelect; set => _PgSQLSelect = "SELECT"; }
        public string PgSQLInsert { get => _PgSQLInsert; set => _PgSQLInsert = "INSERT"; }
        public string PgSQLDelete { get => _PgSQLDelete; set => _PgSQLDelete = "DELETE"; }
        public string PgSQLUpdate { get => _PgSQLUpdate; set => _PgSQLUpdate = "UPDATE"; }
        public string PgSQLFromTable { get => _PgSQLFromTable; set => _PgSQLFromTable = "FROM"; }
        public string PgSQLIntoTable { get => _PgSQLIntoTable; set => _PgSQLIntoTable = "INTO"; }

        private string _FbSQLSelect;
        private string _FbSQLInsert;
        private string _FbSQLDelete;
        private string _FbSQLUpdate;
        private string _FbSQLFromTable;
        private string _FbSQLIntoTable;

        public string FbSQLSelect { get => _FbSQLSelect; set => _FbSQLSelect = "SELECT"; }
        public string FbSQLInsert { get => _FbSQLInsert; set => _FbSQLInsert = "INSERT"; }
        public string FbSQLDelete { get => _FbSQLDelete; set => _FbSQLDelete = "DELETE"; }
        public string FbSQLUpdate { get => _FbSQLUpdate; set => _FbSQLUpdate = "UPDATE"; }
        public string FbSQLFromTable { get => _FbSQLFromTable; set => _FbSQLFromTable = "FROM"; }
        public string FbSQLIntoTable { get => _FbSQLIntoTable; set => _FbSQLIntoTable = "INTO"; }
    }
}
