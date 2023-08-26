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
            this.LbOrder1 = new System.Windows.Forms.Label();
            this.TbTicketNumber = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LbTicketNumber = new System.Windows.Forms.Label();
            this.LbConfirmNumber = new System.Windows.Forms.Label();
            this.BtnCancelNumber = new System.Windows.Forms.Button();
            this.BtnConfirmNumber = new System.Windows.Forms.Button();
            this.LbMsgEqual0 = new System.Windows.Forms.Label();
            this.LbMsgMinor9 = new System.Windows.Forms.Label();
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
            // LbOrder1
            // 
            this.LbOrder1.AutoSize = true;
            this.LbOrder1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOrder1.Location = new System.Drawing.Point(327, 125);
            this.LbOrder1.Name = "LbOrder1";
            this.LbOrder1.Size = new System.Drawing.Size(0, 23);
            this.LbOrder1.TabIndex = 1;
            // 
            // TbTicketNumber
            // 
            this.TbTicketNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTicketNumber.Location = new System.Drawing.Point(351, 163);
            this.TbTicketNumber.Name = "TbTicketNumber";
            this.TbTicketNumber.Size = new System.Drawing.Size(221, 30);
            this.TbTicketNumber.TabIndex = 2;
            this.TbTicketNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LbTicketNumber
            // 
            this.LbTicketNumber.AutoSize = true;
            this.LbTicketNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTicketNumber.Location = new System.Drawing.Point(317, 322);
            this.LbTicketNumber.Name = "LbTicketNumber";
            this.LbTicketNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbTicketNumber.Size = new System.Drawing.Size(0, 24);
            this.LbTicketNumber.TabIndex = 4;
            // 
            // LbConfirmNumber
            // 
            this.LbConfirmNumber.AutoSize = true;
            this.LbConfirmNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConfirmNumber.Location = new System.Drawing.Point(305, 373);
            this.LbConfirmNumber.Name = "LbConfirmNumber";
            this.LbConfirmNumber.Size = new System.Drawing.Size(0, 24);
            this.LbConfirmNumber.TabIndex = 5;
            // 
            // BtnCancelNumber
            // 
            this.BtnCancelNumber.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelNumber.ForeColor = System.Drawing.Color.White;
            this.BtnCancelNumber.Location = new System.Drawing.Point(488, 413);
            this.BtnCancelNumber.Name = "BtnCancelNumber";
            this.BtnCancelNumber.Size = new System.Drawing.Size(136, 59);
            this.BtnCancelNumber.TabIndex = 7;
            this.BtnCancelNumber.Text = "NÃO";
            this.BtnCancelNumber.UseVisualStyleBackColor = false;
            this.BtnCancelNumber.Click += new System.EventHandler(this.BtnCancelNumber_Click);
            // 
            // BtnConfirmNumber
            // 
            this.BtnConfirmNumber.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConfirmNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirmNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmNumber.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmNumber.Location = new System.Drawing.Point(309, 413);
            this.BtnConfirmNumber.Name = "BtnConfirmNumber";
            this.BtnConfirmNumber.Size = new System.Drawing.Size(136, 59);
            this.BtnConfirmNumber.TabIndex = 6;
            this.BtnConfirmNumber.Text = "SIM";
            this.BtnConfirmNumber.UseVisualStyleBackColor = false;
            // 
            // LbMsgEqual0
            // 
            this.LbMsgEqual0.AutoSize = true;
            this.LbMsgEqual0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMsgEqual0.Location = new System.Drawing.Point(312, 322);
            this.LbMsgEqual0.Name = "LbMsgEqual0";
            this.LbMsgEqual0.Size = new System.Drawing.Size(0, 24);
            this.LbMsgEqual0.TabIndex = 8;
            // 
            // LbMsgMinor9
            // 
            this.LbMsgMinor9.AutoSize = true;
            this.LbMsgMinor9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMsgMinor9.Location = new System.Drawing.Point(246, 322);
            this.LbMsgMinor9.Name = "LbMsgMinor9";
            this.LbMsgMinor9.Size = new System.Drawing.Size(0, 24);
            this.LbMsgMinor9.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 580);
            this.Controls.Add(this.LbMsgMinor9);
            this.Controls.Add(this.LbMsgEqual0);
            this.Controls.Add(this.BtnCancelNumber);
            this.Controls.Add(this.BtnConfirmNumber);
            this.Controls.Add(this.LbConfirmNumber);
            this.Controls.Add(this.LbTicketNumber);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TbTicketNumber);
            this.Controls.Add(this.LbOrder1);
            this.Controls.Add(this.LbTitle);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label LbOrder1;
        private System.Windows.Forms.TextBox TbTicketNumber;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label LbTicketNumber;
        private System.Windows.Forms.Label LbConfirmNumber;
        private System.Windows.Forms.Button BtnCancelNumber;
        private System.Windows.Forms.Button BtnConfirmNumber;
        private System.Windows.Forms.Label LbMsgEqual0;
        private System.Windows.Forms.Label LbMsgMinor9;
    }
}

