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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            materialInput.SelectedIndexChanged += new System.EventHandler(this.MaterialInput_Change);
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
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            List<MaterialType> MaterialTypeList = Enum.GetValues(typeof(MaterialType)).Cast<MaterialType>().ToList();
            materialInput.DataSource = MaterialTypeList;
            materialInput.SelectedIndex = -1;
        }
        private void MaterialInput_Change(object sender, EventArgs e)
        {
            quotesView.Rows.Clear();
            List<DeskQuote> quotes = JsonStorageUtils.GetDeskQuotes();
            foreach (var quote in quotes)
            {
                if(materialInput.SelectedItem == null)
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
                    continue;
                }
                var selected = materialInput.SelectedItem.ToString();
                MaterialType material;
                try
                {
                    Enum.TryParse(selected, out material);
                }
                catch
                {
                    return;
                }
                if (material == quote.Desk.MaterialType)
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
    }
}
