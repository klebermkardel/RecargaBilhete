using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecargaBilhete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LbTitle.Text = "Seja bem vindo ao Sistema RecargaBilhete";
            LbOrder1.Text = "Insira o número do seu bilhete:";
            BtnConfirmNumber.Visible = false;
            BtnCancelNumber.Visible = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string ticketNumber = TbTicketNumber.Text;
            LbTicketNumber.Text = $"Número do bilhete: {ticketNumber}";
            LbConfirmNumber.Text = "O número inserido está correto?";
            BtnConfirmNumber.Visible = true;
            BtnCancelNumber.Visible = true;
        }
    }
}
