using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
                try
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
                    catch (MySqlException ex1)
                    {
                        MySQLTran.Rollback();
                        MessageBox.Show("Erro " + ex1.Message);
                    }
                    finally
                    {
                        MySQLCon.Close();
                    }
                }
                catch(MySqlException ex2)
                {
                    MessageBox.Show("Erro " + ex2.Message);
                }
            }
        }
    }
}
