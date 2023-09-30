using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_Liu
{

    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            List<MaterialType> MaterialTypeList = Enum.GetValues(typeof(MaterialType)).Cast<MaterialType>().ToList();
            materialInput.DataSource = MaterialTypeList;
            materialInput.SelectedIndex = -1;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Length == 0)
            {
                NameErrorProvider.SetError(nameInput, "Name mush provide.");
                nameInput.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                NameErrorProvider.Clear();
                nameInput.BackColor = default(Color);
            }

            if (deskWidthInput.Text.Length == 0)
            {
                WidthErrorProvider.SetError(deskWidthInput, "Width mush provide.");
                deskWidthInput.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                WidthErrorProvider.Clear();
                deskWidthInput.BackColor = default(Color);
            }

            if (deskDepthInput.Text.Length == 0)
            {
                DepthErrorProvider.SetError(deskDepthInput, "Depth mush provide.");
                deskDepthInput.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                DepthErrorProvider.Clear();
                deskDepthInput.BackColor = default(Color);
            }

            if (materialInput.SelectedItem == null)
            {
                MaterialErrorProvider.SetError(materialInput, "Material mush provide.");
                materialInput.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                MaterialErrorProvider.Clear();
                materialInput.BackColor = default(Color);
            }

            if (rushInput.SelectedItem == null)
            {
                RushErrorProvider.SetError(rushInput, "Rush day mush provide.");
                rushInput.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                RushErrorProvider.Clear();
                rushInput.BackColor = default(Color);
            }

            String name = nameInput.Text;
            decimal width = decimal.Parse(deskWidthInput.Text);
            decimal depth = decimal.Parse(deskDepthInput.Text);
            int numberOfDrawer = Int32.Parse(drawerCountInput.Text);
            String materialTx = materialInput.SelectedItem.ToString();
            String rushTx = rushInput.SelectedItem.ToString();

            MaterialType material;
            try
            {
                Enum.TryParse(materialTx, out material);
            }
            catch
            {
                MaterialErrorProvider.SetError(materialInput, "Material mush provide.");
                materialInput.BackColor = Color.LightCoral;
                return;
            }

            int rushDays = 0;
            switch (rushTx)
            {
                case "3 Days":
                    rushDays = 3;
                    break;
                case "5 Days":
                    rushDays = 5;
                    break;
                case "7 Days":
                    rushDays = 7;
                    break;
                default:
                    rushDays = 0;
                    break;
            }

            DeskQuote deskQuote = new DeskQuote(width,depth, numberOfDrawer,material, DateTime.Now, rushDays, name);
            JsonStorageUtils.AddDeskQuote(deskQuote);
            Close();
            new DisplayQuote(deskQuote.QuoteUUID).Show();
        }
        private void ValidatingWidthInput(object sender, CancelEventArgs e)
        {
            string content = deskWidthInput.Text;
            string errorMsg;
            if (!ValidateNumbericStringInBoundary(content, (int)Desk.MIN_WIDTH, (int)Desk.MAX_WIDTH, out errorMsg))
            {
                e.Cancel = true;
                deskWidthInput.Select(0, deskWidthInput.Text.Length);
                WidthErrorProvider.SetError(deskWidthInput, errorMsg);
                deskWidthInput.BackColor = Color.LightCoral;
            }
        }
        private void ValidatingDepthInput(object sender, CancelEventArgs e)
        {
            string content = deskDepthInput.Text;
            string errorMsg;
            if (!ValidateNumbericStringInBoundary(content, (int)Desk.MIN_DEPTH, (int)Desk.MAX_DEPTH, out errorMsg))
            {
                e.Cancel = true;
                deskDepthInput.Select(0, deskDepthInput.Text.Length);
                DepthErrorProvider.SetError(deskDepthInput, errorMsg);
                deskDepthInput.BackColor = Color.LightCoral;
            }
        }
        private Boolean ValidateNumbericStringInBoundary(String input, int min, int max, out string errorMessage)
        {
            if(input == null || input.Length == 0) 
            {
                errorMessage = "You mush input a size number.";
                return false;
            }
            if (int.TryParse(input, out int numericValue))
            {
                if (numericValue >= min && numericValue <= max)
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "Must between " + min +" inches and " + max + " inches.";
            return false;
        }
        private void Depth_Validated(object sender, EventArgs e)
        {
            DepthErrorProvider.Clear();
            deskDepthInput.BackColor = default(Color);
        }
        private void Width_Validated(object sender, EventArgs e)
        {
            WidthErrorProvider.Clear();
            deskWidthInput.BackColor = default(Color);
        }
        private void CharValidation(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            MegaDeskContextHolder.MainMenu.Show();
        }

    }
}
