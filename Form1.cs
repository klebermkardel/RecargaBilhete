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
            LbMsgEqual0.Visible = false;
            LbMsgMinor9.Visible = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (TbTicketNumber.Text.Length == 9)
            {
                ticketNumber = TbTicketNumber.Text;
                LbTicketNumber.Text = $"Número do bilhete: {ticketNumber}";
                LbConfirmNumber.Text = "O número inserido está correto?";
                LbConfirmNumber.Visible = true;
                BtnConfirmNumber.Visible = true;
                BtnCancelNumber.Visible = true;
                LbMsgEqual0.Visible = false;
                LbMsgMinor9.Visible = false;
                TbTicketNumber.Text = ""; 
            }
            else if (TbTicketNumber.Text.Length == 0)
            {
                LbMsgEqual0.Visible = true;
                LbMsgEqual0.ForeColor = Color.Firebrick;
                LbMsgEqual0.Text = "Informe um número de 9 digítos";
                LbMsgMinor9.Visible = false;
                TbTicketNumber.Text = ""; 
            }
            else
            {
                LbMsgMinor9.Visible = true;
                LbMsgMinor9.ForeColor = Color.Firebrick;
                LbMsgMinor9.Text = "Número inválido! Por favor, digite novamente.";
                LbMsgEqual0.Visible = false;
                TbTicketNumber.Text = "";
            }
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
