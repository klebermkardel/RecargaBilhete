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
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(171, 45);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(594, 33);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Seja bem vindo ao Sistema RecargaBilhete";
            // 
            // LbTicketNumber
            // 
            this.LbTicketNumber.AutoSize = true;
            this.LbTicketNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTicketNumber.Location = new System.Drawing.Point(327, 125);
            this.LbTicketNumber.Name = "LbTicketNumber";
            this.LbTicketNumber.Size = new System.Drawing.Size(281, 23);
            this.LbTicketNumber.TabIndex = 1;
            this.LbTicketNumber.Text = "Insira o número do seu bilhete:";
            // 
            // TbTicketNumber
            // 
            this.TbTicketNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTicketNumber.Location = new System.Drawing.Point(351, 163);
            this.TbTicketNumber.Name = "TbTicketNumber";
            this.TbTicketNumber.Size = new System.Drawing.Size(221, 30);
            this.TbTicketNumber.TabIndex = 2;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(354, 223);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(217, 59);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "CONFIRMAR";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número do bilhete:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirm);
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
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label1;
    }
}

