using Newtonsoft.Json;
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

namespace MegaDesk_Liu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            MegaDeskContextHolder.MainMenu = this;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewQuoteBtn_Click(object sender, EventArgs e)
        {
            new AddQuote().Show();
            Hide();
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            new ViewAllQuotes().Show();
            Hide();
        }

        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            new SearchQuotes().Show();
            Hide();
        }
    }

    public static class MegaDeskContextHolder
    {
        public static MainMenu MainMenu { get; set; }
    }
    public static class JsonStorageUtils
    {
        private static String filename = "quotes_data.json";
        public static void AddDeskQuote(DeskQuote quote)
        {
            List<DeskQuote> quotes = GetDeskQuotes();
            quotes.Add(quote);
            string jsonString = JsonConvert.SerializeObject(quotes);
            File.WriteAllText(filename, jsonString);
        }
        public static List<DeskQuote> GetDeskQuotes() 
        {
            try
            {
                string jsonString = File.ReadAllText(filename);
                List<DeskQuote> dataList = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonString);
                return dataList;
            }
            catch (Exception e)
            {
                return new List<DeskQuote>();
            }
        }
    }
}
