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
    public partial class DisplayQuote : Form
    {

        public DisplayQuote(string id)
        {
            InitializeComponent();
            List<DeskQuote> quotes = JsonStorageUtils.GetDeskQuotes();
            foreach (DeskQuote quote in quotes)
            {
                if (quote != null && quote.QuoteUUID == id)
                {
                    NameDetailLabel.Text = quote.CustomerName;
                    WidthDetailLabel.Text = ((int)quote.Desk.Width).ToString();
                    DepthDetailLabel.Text = ((int)quote.Desk.Depth).ToString();
                    DrawerDetailLabel.Text = quote.Desk.DrawerCount.ToString();
                    MaterialDetailLabel.Text = quote.Desk.MaterialType.ToString();
                    RushDetailLabel.Text = quote.RushDay.ToString();
                    DateDetailLabel.Text = quote.Date.ToShortDateString().ToString();
                    PriceDetailLabel.Text = ((int)quote.Price).ToString();
                }
            }
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            MegaDeskContextHolder.MainMenu.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
