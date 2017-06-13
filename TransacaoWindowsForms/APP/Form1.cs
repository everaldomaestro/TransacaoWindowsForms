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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmds[0] = tbQuery1.Text;
            cmds[1] = tbQuery2.Text;

            if (rbMySQL.Enabled == true)
            {
                MySQLConnection MySQLCon = new MySQLConnection();
                MySQLCon.TransacaoMySQL(cmds);
            }
            else if (rbMSSQL.Enabled == true)
            {
                MSSQLConnection MSSQLCon = new MSSQLConnection();
                MSSQLCon.TransacaoMSSQL(cmds);
            }
            else
            {
                MessageBox.Show("ERRO");
            }
        }
    }
}
