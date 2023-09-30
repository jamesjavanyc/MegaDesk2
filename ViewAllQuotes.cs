using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Liu
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            List<DeskQuote> quotes = JsonStorageUtils.GetDeskQuotes();
            quotesView.ColumnCount = 8;
            quotesView.AllowUserToAddRows = false;
            quotesView.Columns[0].HeaderText = "Name";
            quotesView.Columns[1].HeaderText = "Date";
            quotesView.Columns[2].HeaderText = "Rush";
            quotesView.Columns[3].HeaderText = "Material";
            quotesView.Columns[4].HeaderText = "Width";
            quotesView.Columns[5].HeaderText = "Depth";
            quotesView.Columns[6].HeaderText = "Drawer";
            quotesView.Columns[7].HeaderText = "Price";
            foreach (var quote in quotes)
            {
                quotesView.Rows.Add(
                    quote.CustomerName,
                    quote.Date.ToShortDateString().ToString(),
                    quote.RushDay.ToString(),
                    quote.Desk.MaterialType.ToString(),
                    ((int)quote.Desk.Width).ToString(),
                    ((int)quote.Desk.Depth).ToString(),
                    quote.Desk.DrawerCount.ToString(),
                    ((int)quote.Price).ToString()
                    );
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            MegaDeskContextHolder.MainMenu.Show();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quotesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
