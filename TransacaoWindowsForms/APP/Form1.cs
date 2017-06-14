using System;
using System.Windows.Forms;
using BD.MSSQL;
using BD.MySQL;

namespace APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        string[] cmds = new string[2];
        string[] BD = new string[4];

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmds[0] = tbQuery1.Text;
            cmds[1] = tbQuery2.Text;

            if (rbMySQL.Checked == true)
            {
                MySQLConnection MySQLCon = new MySQLConnection();

                MySQLCon.MySQLServer = tbServidor.Text;
                MySQLCon.MySQLPort = tbPort.Text;
                MySQLCon.MySQLUser = tbUser.Text;
                MySQLCon.MySQLPass = tbPass.Text;

                MySQLCon.TransacaoMySQL(cmds);
            }
            else if (rbMSSQL.Checked == true)
            {
                MSSQLConnection MSSQLCon = new MSSQLConnection();

                MSSQLCon.MSSQLServer = tbServidor.Text;
                MSSQLCon.MSSQLPort = tbPort.Text;
                MSSQLCon.MSSQLUser = tbUser.Text;
                MSSQLCon.MSSQLPass = tbPass.Text;

                MSSQLCon.TransacaoMSSQL(cmds);
            }
            else
            {
                MessageBox.Show("ERRO");
            }
        }
    }
}
