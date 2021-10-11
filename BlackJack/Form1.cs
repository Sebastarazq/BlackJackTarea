using BlackJack.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCarta_Click(object sender, EventArgs e)
        {
            Dealer d = new Dealer();
            d.Generate();

            rtxtResults.Text ="";
             
            foreach (Card c in d.GetDeck())
            {
                rtxtResults.Text += c.Symbol + c.Suit + " -score " + c.Score + "color:" + c.CardColor + "\n";
            }
        }
    }
}