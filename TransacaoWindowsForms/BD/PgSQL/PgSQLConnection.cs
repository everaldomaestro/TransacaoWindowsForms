using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace BD.PgSQL
{
    public class PgSQLConnection
    {
        private static string _PgSQLServer;
        private static string _PgSQLPort;
        private static string _PgSQLUser;
        private static string _PgSQLPass;

        public string PgSQLServer { get => _PgSQLServer; set => _PgSQLServer = value; }
        public string PgSQLPort { get => _PgSQLPort; set => _PgSQLPort = value; }
        public string PgSQLUser { get => _PgSQLUser; set => _PgSQLUser = value; }
        public string PgSQLPass { get => _PgSQLPass; set => _PgSQLPass = value; }

        private static NpgsqlConnection PgSQLCon;
        private static NpgsqlTransaction PgSQLTran;
        private static NpgsqlCommand PgSQLCmd;
        private string PgSQLStringCon;


        public void TransacaoPgSQL(string[] cmds)
        {
            PgSQLStringCon =
                "Server="+_PgSQLServer+";" +
                "Port="+_PgSQLPort+";"+
                "Username="+_PgSQLUser+";" +
                "Password="+_PgSQLPass+";" +
                "Database=testetransacao";

            using (PgSQLCon = new NpgsqlConnection())
            {
                try
                {
                    PgSQLCon.ConnectionString = PgSQLStringCon;
                    PgSQLCon.Open();
                    PgSQLTran = PgSQLCon.BeginTransaction();

                    try
                    {
                        foreach (string cmdTxt in cmds)
                        {
                            PgSQLCmd = PgSQLCon.CreateCommand();
                            PgSQLCmd.CommandText = cmdTxt;
                            PgSQLCmd.Transaction = PgSQLTran;
                            PgSQLCmd.ExecuteNonQuery();
                        }

                        PgSQLTran.Commit();
                        MessageBox.Show("Transação realizada com sucesso", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (NpgsqlException ex1)
                    {
                        PgSQLTran.Rollback();
                        MessageBox.Show(ex1.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        PgSQLCon.Close();
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
