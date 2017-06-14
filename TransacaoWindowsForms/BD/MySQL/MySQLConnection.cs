using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace BD.MySQL
{
    public class MySQLConnection
    {
        private static string _MySQLServer;
        private static string _MySQLPort;
        private static string _MySQLUser;
        private static string _MySQLPass;

        public string MySQLServer { get => _MySQLServer; set => _MySQLServer = value; }
        public string MySQLPort { get => _MySQLPort; set => _MySQLPort = value; }
        public string MySQLUser { get => _MySQLUser; set => _MySQLUser = value; }
        public string MySQLPass { get => _MySQLPass; set => _MySQLPass = value; }        

        private static MySqlConnection MySQLCon;
        private static MySqlTransaction MySQLTran;
        private static MySqlCommand MySQLCmd;
        private string MySQLStringCon;            


        public void TransacaoMySQL(string[] cmds)
        {
            MySQLStringCon = 
                "server=" + _MySQLServer + ";" +
                "port=" + _MySQLPort + ";" +
                "database=testetransacao;" +
                "uid=" + _MySQLUser + ";" +
                "pwd=" + _MySQLPass + ";";

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
