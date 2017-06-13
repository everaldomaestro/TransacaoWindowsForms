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
        private string SQLStringCon = @"Data Source = x,x; Initial Catalog = x; User Id = x; Password = x;";
        private static SqlConnection SQLCon;
        private static SqlTransaction SQLTran;
        private static SqlCommand SQLCmd;

        public void TransacaoMSSQL(string[] cmds)
        {
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
