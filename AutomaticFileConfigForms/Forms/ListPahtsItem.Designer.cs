namespace AutomaticFileConfigForms.Forms
{
    partial class ListPahtsItem
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_DestinationPath = new System.Windows.Forms.TextBox();
            this.LBL_Caminho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_DestinationPath
            // 
            this.TXT_DestinationPath.Location = new System.Drawing.Point(46, 13);
            this.TXT_DestinationPath.Name = "TXT_DestinationPath";
            this.TXT_DestinationPath.Size = new System.Drawing.Size(405, 23);
            this.TXT_DestinationPath.TabIndex = 0;
            // 
            // LBL_Caminho
            // 
            this.LBL_Caminho.AutoSize = true;
            this.LBL_Caminho.Location = new System.Drawing.Point(3, 16);
            this.LBL_Caminho.Name = "LBL_Caminho";
            this.LBL_Caminho.Size = new System.Drawing.Size(37, 15);
            this.LBL_Caminho.TabIndex = 1;
            this.LBL_Caminho.Text = "Path :";
            // 
            // ListPahtsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LBL_Caminho);
            this.Controls.Add(this.TXT_DestinationPath);
            this.Name = "ListPahtsItem";
            this.Size = new System.Drawing.Size(470, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXT_DestinationPath;
        private Label LBL_Caminho;
    }
}
