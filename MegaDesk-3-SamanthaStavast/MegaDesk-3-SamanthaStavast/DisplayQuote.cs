using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_SamanthaStavast
{
    public partial class DisplayQuote : Form
    {
        public DeskQuote incomingQuote;
        protected DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            this.incomingQuote = quote;
            labelUsername.Text = quote.UserName + "'s Desk:";
            double price = quote.calculateQuotePrice();
            label_QuotePrice.Text = price.ToString("C");
            label_depth.Text = quote.desk.depth.ToString();
            label_width.Text = quote.desk.width.ToString();
            label_drawers.Text = quote.desk.drawers.ToString();
            label_surfaceMaterial.Text = quote.desk.getSurfaceString(quote.desk.surfaceMaterial);
            label_date.Text = quote.date.ToString();
            label_rush.Text = quote.rush.ToString();

        }

        private void label_depth_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            
        }

        private void returnHome_Click(object sender, EventArgs e)
        {

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
