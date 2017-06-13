using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace BD.MySQL
{
    public class MySQLConnection
    {
        private string MySQLStringCon = "server=localhost;port=3306;database=testetransacao;uid=x;pwd=x;";
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
                        MessageBox.Show("Transação realizada com sucesso", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex1)
                    {
                        MySQLTran.Rollback();
                        MessageBox.Show(ex1.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        MySQLCon.Close();
                    }
                }
                catch(Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
