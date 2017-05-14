namespace teste
{
    partial class Fm_teste
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_teste = new System.Windows.Forms.Button();
            this.txt_teste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vai se fuder";
            // 
            // bt_teste
            // 
            this.bt_teste.Location = new System.Drawing.Point(40, 66);
            this.bt_teste.Name = "bt_teste";
            this.bt_teste.Size = new System.Drawing.Size(75, 23);
            this.bt_teste.TabIndex = 1;
            this.bt_teste.Text = "Gerar resposta";
            this.bt_teste.UseVisualStyleBackColor = true;
            this.bt_teste.Click += new System.EventHandler(this.bt_teste_Click);
            // 
            // txt_teste
            // 
            this.txt_teste.Location = new System.Drawing.Point(15, 40);
            this.txt_teste.Name = "txt_teste";
            this.txt_teste.Size = new System.Drawing.Size(100, 20);
            this.txt_teste.TabIndex = 2;
            // 
            // Fm_teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 138);
            this.Controls.Add(this.txt_teste);
            this.Controls.Add(this.bt_teste);
            this.Controls.Add(this.label1);
            this.Name = "Fm_teste";
            this.Text = "Teste";
            this.Activated += new System.EventHandler(this.Fm_teste_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_teste;
        private System.Windows.Forms.TextBox txt_teste;
    }
}

