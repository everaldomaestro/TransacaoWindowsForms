using System;
using MySql.Data.MySqlClient;

namespace BD.MySQL
{
    public class MySQLConnection
    {
        private string MySQLStringCon = "server=x;port=x;database=x;uid=x;pwd=x;";
        private static MySqlConnection MySQLCon;
        private static MySqlTransaction MySQLTran;
        private static MySqlCommand MySQLCmd;

        public void TransacaoMySQL(string[] cmds)
        {
            using (MySQLCon = new MySqlConnection())
            {
                MySQLCon.ConnectionString = MySQLStringCon;
                MySQLCon.Open();
                MySQLTran = MySQLCon.BeginTransaction();

                try
                {
                    foreach (string cmdTxt in cmds)
                    {
                        MySQLCmd = MySQLCon.CreateCommand();
                        MySQLCmd.CommandText = cmdTxt;
                        MySQLCmd.Transaction = MySQLTran;
                        MySQLCmd.ExecuteNonQuery();
                    }

                    MySQLTran.Commit();
                }
                catch (MySqlException ex)
                {
                    MySQLTran.Rollback();
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MySQLCon.Close();
                }
            }
        }
    }
}
