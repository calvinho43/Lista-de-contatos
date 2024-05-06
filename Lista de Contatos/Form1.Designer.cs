namespace Lista_de_Contatos
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
            this.labelnome = new System.Windows.Forms.Label();
            this.labeltel = new System.Windows.Forms.Label();
            this.labelsobre = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobre = new System.Windows.Forms.TextBox();
            this.textBoxTele = new System.Windows.Forms.TextBox();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(12, 39);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(65, 22);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "Nome";
            // 
            // labeltel
            // 
            this.labeltel.AutoSize = true;
            this.labeltel.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltel.Location = new System.Drawing.Point(12, 167);
            this.labeltel.Name = "labeltel";
            this.labeltel.Size = new System.Drawing.Size(92, 22);
            this.labeltel.TabIndex = 1;
            this.labeltel.Text = "Telefone";
            this.labeltel.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelsobre
            // 
            this.labelsobre.AutoSize = true;
            this.labelsobre.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsobre.Location = new System.Drawing.Point(12, 108);
            this.labelsobre.Name = "labelsobre";
            this.labelsobre.Size = new System.Drawing.Size(117, 22);
            this.labelsobre.TabIndex = 2;
            this.labelsobre.Text = "Sobrenome";
            this.labelsobre.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(146, 40);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(152, 20);
            this.textBoxNome.TabIndex = 3;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxSobre
            // 
            this.textBoxSobre.Location = new System.Drawing.Point(146, 108);
            this.textBoxSobre.Name = "textBoxSobre";
            this.textBoxSobre.Size = new System.Drawing.Size(152, 20);
            this.textBoxSobre.TabIndex = 4;
            this.textBoxSobre.TextChanged += new System.EventHandler(this.textBoxSobre_TextChanged);
            // 
            // textBoxTele
            // 
            this.textBoxTele.Location = new System.Drawing.Point(146, 167);
            this.textBoxTele.Name = "textBoxTele";
            this.textBoxTele.Size = new System.Drawing.Size(152, 20);
            this.textBoxTele.TabIndex = 5;
            this.textBoxTele.TextChanged += new System.EventHandler(this.textBoxTele_TextChanged);
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 22;
            this.listBoxContatos.Location = new System.Drawing.Point(321, 39);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(268, 378);
            this.listBoxContatos.TabIndex = 6;
            this.listBoxContatos.SelectedIndexChanged += new System.EventHandler(this.listBoxContatos_SelectedIndexChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("News706 BT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(16, 247);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(282, 161);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.textBoxTele);
            this.Controls.Add(this.textBoxSobre);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelsobre);
            this.Controls.Add(this.labeltel);
            this.Controls.Add(this.labelnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labeltel;
        private System.Windows.Forms.Label labelsobre;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobre;
        private System.Windows.Forms.TextBox textBoxTele;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button buttonSalvar;
    }
}

