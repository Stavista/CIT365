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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            var materials = new List<Desk.Material>();

            materials = Enum.GetValues(typeof(Desk.Material))
                   .Cast<Desk.Material>()
                   .ToList();

            search_material.DataSource = materials;
            search_material.SelectedIndex = -1;

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

        private void search_material_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Desk.Material material = (Desk.Material)search_material.SelectedItem;

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
                if (col[6] == material.ToString())
                {
                    grid.Rows.Add(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7]);
                }
            }

            dataGridView1.DataSource = grid;
            file.Close();

        }
    }
}
