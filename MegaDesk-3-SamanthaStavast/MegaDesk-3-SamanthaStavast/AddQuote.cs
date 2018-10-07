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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void button_CancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void getQuote_Click(object sender, EventArgs e)
        {
            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            Hide();
        }
    }

}
