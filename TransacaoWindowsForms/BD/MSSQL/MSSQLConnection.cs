using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace BD.MSSQL
{
    public class MSSQLConnection
    {
        //Data Source = SERVER,PORT; 
        //Initial Catalog = BD;
        //User Id = USER; 
        //Password=PASS;";
        //String de conexão com o banco

        private static string _MSSQLServer;
        private static string _MSSQLPort;
        private static string _MSSQLUser;
        private static string _MSSQLPass;

        public string MSSQLServer { get => _MSSQLServer; set => _MSSQLServer = value; }
        public string MSSQLPort { get => _MSSQLPort; set => _MSSQLPort = value; }
        public string MSSQLUser { get => _MSSQLUser; set => _MSSQLUser = value; }
        public string MSSQLPass { get => _MSSQLPass; set => _MSSQLPass = value; }

        private static SqlConnection SQLCon;
        private static SqlTransaction SQLTran;
        private static SqlCommand SQLCmd;
        private string SQLStringCon;

        public void TransacaoMSSQL(string[] cmds)
        {
            SQLStringCon =
            @"Data Source ="+_MSSQLServer+","+_MSSQLPort+";" +
            "Initial Catalog = testetransacao;" +
            "User Id ="+_MSSQLUser+";" +
            "Password ="+_MSSQLPass+";";

            using (SQLCon = new SqlConnection())
            {

                try
                {
                    SQLCon.ConnectionString = SQLStringCon;
                    SQLCon.Open();
                    SQLTran = SQLCon.BeginTransaction();

                    try
                    {
                        foreach (string cmdTxt in cmds)
                        {
                            SQLCmd = SQLCon.CreateCommand();
                            SQLCmd.CommandText = cmdTxt;
                            SQLCmd.Transaction = SQLTran;
                            SQLCmd.ExecuteNonQuery();
                        }
                        SQLTran.Commit();
                        MessageBox.Show("Transação realizada com sucesso", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex1)
                    {
                        SQLTran.Rollback();
                        MessageBox.Show(ex1.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        SQLCon.Close();
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
