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
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 123);
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
            this.rbMSSQL.Location = new System.Drawing.Point(12, 66);
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
            this.rbMySQL.Location = new System.Drawing.Point(13, 90);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 163);
            this.Controls.Add(this.tbQuery2);
            this.Controls.Add(this.rbMySQL);
            this.Controls.Add(this.rbMSSQL);
            this.Controls.Add(this.tbQuery1);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbQuery1;
        private System.Windows.Forms.RadioButton rbMSSQL;
        private System.Windows.Forms.RadioButton rbMySQL;
        private System.Windows.Forms.TextBox tbQuery2;
    }
}

