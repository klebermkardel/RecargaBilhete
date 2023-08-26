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
        }
    }
}
