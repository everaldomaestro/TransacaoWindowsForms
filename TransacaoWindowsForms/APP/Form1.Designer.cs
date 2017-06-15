namespace APP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbQuery1 = new System.Windows.Forms.TextBox();
            this.rbMSSQL = new System.Windows.Forms.RadioButton();
            this.rbMySQL = new System.Windows.Forms.RadioButton();
            this.tbQuery2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.rbPgSQL = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 217);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbQuery1
            // 
            this.tbQuery1.Location = new System.Drawing.Point(12, 12);
            this.tbQuery1.Name = "tbQuery1";
            this.tbQuery1.Size = new System.Drawing.Size(317, 20);
            this.tbQuery1.TabIndex = 3;
            this.tbQuery1.Text = "INSERT INTO Teste (NOME, IDADE) VALUES (\'EVERALDO\',31);";
            // 
            // rbMSSQL
            // 
            this.rbMSSQL.AutoSize = true;
            this.rbMSSQL.Location = new System.Drawing.Point(3, 3);
            this.rbMSSQL.Name = "rbMSSQL";
            this.rbMSSQL.Size = new System.Drawing.Size(62, 17);
            this.rbMSSQL.TabIndex = 4;
            this.rbMSSQL.TabStop = true;
            this.rbMSSQL.Text = "MSSQL";
            this.rbMSSQL.UseVisualStyleBackColor = true;
            // 
            // rbMySQL
            // 
            this.rbMySQL.AutoSize = true;
            this.rbMySQL.Location = new System.Drawing.Point(78, 3);
            this.rbMySQL.Name = "rbMySQL";
            this.rbMySQL.Size = new System.Drawing.Size(60, 17);
            this.rbMySQL.TabIndex = 5;
            this.rbMySQL.TabStop = true;
            this.rbMySQL.Text = "MySQL";
            this.rbMySQL.UseVisualStyleBackColor = true;
            // 
            // tbQuery2
            // 
            this.tbQuery2.Location = new System.Drawing.Point(12, 38);
            this.tbQuery2.Name = "tbQuery2";
            this.tbQuery2.Size = new System.Drawing.Size(317, 20);
            this.tbQuery2.TabIndex = 6;
            this.tbQuery2.Text = "INSERT INTO Teste (NOME, IDADE) VALUES (\'BRUNO\',22);";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPgSQL);
            this.panel1.Controls.Add(this.rbMSSQL);
            this.panel1.Controls.Add(this.rbMySQL);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 24);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Porta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(55, 7);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(138, 20);
            this.tbServidor.TabIndex = 8;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(55, 34);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(63, 20);
            this.tbPort.TabIndex = 9;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(55, 60);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(138, 20);
            this.tbUser.TabIndex = 10;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(55, 86);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(138, 20);
            this.tbPass.TabIndex = 11;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbUser);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbPort);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbServidor);
            this.panel2.Location = new System.Drawing.Point(12, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 115);
            this.panel2.TabIndex = 8;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(130, 218);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Teste";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // rbPgSQL
            // 
            this.rbPgSQL.AutoSize = true;
            this.rbPgSQL.Location = new System.Drawing.Point(144, 3);
            this.rbPgSQL.Name = "rbPgSQL";
            this.rbPgSQL.Size = new System.Drawing.Size(59, 17);
            this.rbPgSQL.TabIndex = 6;
            this.rbPgSQL.TabStop = true;
            this.rbPgSQL.Text = "PgSQL";
            this.rbPgSQL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 253);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbQuery2);
            this.Controls.Add(this.tbQuery1);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbQuery1;
        private System.Windows.Forms.RadioButton rbMSSQL;
        private System.Windows.Forms.RadioButton rbMySQL;
        private System.Windows.Forms.TextBox tbQuery2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbServidor;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RadioButton rbPgSQL;
    }
}

