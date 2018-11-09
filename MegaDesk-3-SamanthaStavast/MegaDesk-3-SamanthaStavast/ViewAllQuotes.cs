using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_SamanthaStavast
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            DataTable grid = new DataTable();
            grid.Columns.Add("Shipping");
            grid.Columns.Add("Name");
            grid.Columns.Add("Date");
            grid.Columns.Add("Width");
            grid.Columns.Add("Depth");
            grid.Columns.Add("Drawers");
            grid.Columns.Add("Material");
            grid.Columns.Add("Price");

            StreamReader file = new StreamReader(@"../QuoteHistory.txt");
            while (!file.EndOfStream)
            {
                string[] col = file.ReadLine().Split(',');
                grid.Rows.Add(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7]);
            }

            dataGridView1.DataSource = grid;
            file.Close();

        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
