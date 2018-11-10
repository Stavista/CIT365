using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            //populate materials
            var materials = new List<Desk.Material>();

            materials = Enum.GetValues(typeof(Desk.Material))
                   .Cast<Desk.Material>()
                   .ToList();

            surface_comboBox.DataSource = materials;
            surface_comboBox.SelectedIndex = -1;
        }

        private void button_CancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        public void getQuote_Click(object sender, EventArgs e)
        {
            Desk.Material selectedSurface = (Desk.Material)surface_comboBox.SelectedItem;

            //var selectedSurface = surface_comboBox.ValueMember;
            Desk newDesk = new Desk((int)numericUpDown_Width.Value, (int)numericUpDown_Depth.Value, (int)numericUpDown_Drawers.Value, selectedSurface);

            int rush = getSelectedRush();
            DeskQuote quote = new DeskQuote(rush, userName.Text, newDesk);
            double price = quote.calculateQuotePrice();

            TextWriter file = new StreamWriter(@"../QuoteHistory.txt", true);
            file.WriteLine(quote.rush + "," + quote.UserName + "," + quote.date + "," + newDesk.width + "," + newDesk.depth + "," + newDesk.drawers + "," + newDesk.surfaceMaterial + "," + price);
            file.Close();

            DisplayQuote displayQuoteForm = new DisplayQuote(quote);
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            Hide();
        }

        private int getSelectedRush()
        {
            if (radioButton14.Checked)
            {
                return 14;
            }
            if (radioButton7.Checked)
            {
                return 7;
            }
            if (radioButton5.Checked)
            {
                return 5;
            }
            if (radioButton3.Checked)
            {
                return 3;
            }
            return -1;
        }
    }

}
