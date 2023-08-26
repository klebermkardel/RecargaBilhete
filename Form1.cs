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

        string ticketNumber = "";
        public Form1()
        {
            InitializeComponent();

            LbTitle.Text = "Seja bem vindo ao Sistema RecargaBilhete";
            LbOrder1.Text = "Insira o número do seu bilhete:";
            BtnConfirmNumber.Visible = false;
            BtnCancelNumber.Visible = false;
            LbConfirmNumber.Visible = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ticketNumber = TbTicketNumber.Text;
            LbTicketNumber.Text = $"Número do bilhete: {ticketNumber}";
            LbConfirmNumber.Text = "O número inserido está correto?";
            LbConfirmNumber.Visible = true;
            BtnConfirmNumber.Visible = true;
            BtnCancelNumber.Visible = true;
        }

        private void BtnCancelNumber_Click(object sender, EventArgs e)
        {
            TbTicketNumber.Text = "";

            ticketNumber = "";
            LbTicketNumber.Text = "";

            LbConfirmNumber.Visible = false;
            BtnConfirmNumber.Visible = false;
            BtnCancelNumber.Visible = false;
            
        }
    }
}
