using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace BD.Firebird
{
    public class FirebirdConnection
    {
        private static string _FirebirdServer;
        private static string _FirebirdPort;
        private static string _FirebirdUser;
        private static string _FirebirdPass;

        public string FirebirdServer { get => _FirebirdServer; set => _FirebirdServer = value; }
        public string FirebirdPort { get => _FirebirdPort; set => _FirebirdPort = value; }
        public string FirebirdUser { get => _FirebirdUser; set => _FirebirdUser = value; }
        public string FirebirdPass { get => _FirebirdPass; set => _FirebirdPass = value; }

        private static FbConnection FirebirdCon;
        private static FbTransaction FirebirdTran;
        private static FbCommand FirebirdCmd;
        private string FirebirdStringCon;

        public void TransacaoFirebird(string[] cmds)
        {
            FirebirdStringCon =
            "DataSource =" + _FirebirdServer + ";" + 
            "Port ="+_FirebirdPort + ";" +
            "Database = C:'\'Program Files'\'Firebird'\'Firebird_3_0'\'BD'\'testetransacao.fdb;" +
            "UserId =" + _FirebirdUser + ";" +
            "Dialect=3;" +
            "Charset=WIN1252;" +
            "Pwd =" + _FirebirdPass + ";";

            using (FirebirdCon = new FbConnection())
            {
                try
                {
                    FirebirdCon.ConnectionString = FirebirdStringCon;
                    FirebirdCon.Open();
                    FirebirdTran = FirebirdCon.BeginTransaction();

                    try
                    {
                        foreach (string cmdTxt in cmds)
                        {
                            FirebirdCmd = FirebirdCon.CreateCommand();
                            FirebirdCmd.CommandText = cmdTxt;
                            FirebirdCmd.Transaction = FirebirdTran;
                            FirebirdCmd.ExecuteNonQuery();
                        }
                        FirebirdTran.Commit();
                        MessageBox.Show("Transação realizada com sucesso", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FbException ex1)
                    {
                        FirebirdTran.Rollback();
                        MessageBox.Show(ex1.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        FirebirdCon.Close();
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
