namespace RecargaBilhete
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
            this.LbTitle = new System.Windows.Forms.Label();
            this.LbTicketNumber = new System.Windows.Forms.Label();
            this.TbTicketNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(171, 45);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(0, 33);
            this.LbTitle.TabIndex = 0;
            // 
            // LbTicketNumber
            // 
            this.LbTicketNumber.AutoSize = true;
            this.LbTicketNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTicketNumber.Location = new System.Drawing.Point(319, 102);
            this.LbTicketNumber.Name = "LbTicketNumber";
            this.LbTicketNumber.Size = new System.Drawing.Size(0, 23);
            this.LbTicketNumber.TabIndex = 1;
            // 
            // TbTicketNumber
            // 
            this.TbTicketNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTicketNumber.Location = new System.Drawing.Point(343, 140);
            this.TbTicketNumber.Name = "TbTicketNumber";
            this.TbTicketNumber.Size = new System.Drawing.Size(221, 30);
            this.TbTicketNumber.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 580);
            this.Controls.Add(this.TbTicketNumber);
            this.Controls.Add(this.LbTicketNumber);
            this.Controls.Add(this.LbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label LbTicketNumber;
        private System.Windows.Forms.TextBox TbTicketNumber;
    }
}

