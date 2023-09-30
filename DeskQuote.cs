using System;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Liu
{

    public class DeskQuote
    {
         
        private const decimal BASE_PRICE = 200;
        private const decimal MAX_BASE_SIZE = 1000;
        private const decimal DRAWER_UNIT_PRICE = 50;
        private const decimal SURFACE_UNIT_PRICE = 1;
        private const int RUSH_OPTION_1 = 3;
        private const int RUSH_OPTION_2 = 5;
        private const int RUSH_OPTION_3 = 7;
        private const decimal RUSH_ORDER_MAX_SURFACE = 2000;
        private static decimal[,] RushPriceChart = GetRushOrderPrices();

        public String QuoteUUID { get; set; }
        public Desk Desk { get; set; }
        public DateTime Date { get; set; }
        public int RushDay { get; set; }
        public String CustomerName { get; set; }
        public decimal Price { get; set; }
        public decimal SurfaceArea { get;}

        public DeskQuote(Decimal width, Decimal depth, int drawerCount, MaterialType material, DateTime date, int rushDay, String customerName)
        {
            QuoteUUID = Guid.NewGuid().ToString();
            Desk = new Desk(width,depth,drawerCount,material);
            Date = date;
            RushDay = rushDay;
            CustomerName = customerName;
            SurfaceArea = Desk.Width * Desk.Depth;
            Price = CalculateTotalPrice();
        }

        public decimal CalculateTotalPrice()
        {
            return BASE_PRICE + SurfaceAreaCost() + DrawerCost() + (int)Desk.MaterialType + RushOrderCost();
        }

        public decimal SurfaceAreaCost()
        {
            if (SurfaceArea > MAX_BASE_SIZE)
            {
                return (SurfaceArea - MAX_BASE_SIZE) * SURFACE_UNIT_PRICE;

            }
            return 0;
        }

        public decimal DrawerCost()
        {
            return Desk.DrawerCount * DRAWER_UNIT_PRICE;
        }

        public decimal RushOrderCost()
        {
            if (RushDay == 0) return 0;

            decimal rushCost = 0;
            switch (RushDay)
            {
                case RUSH_OPTION_1:
                    if (SurfaceArea < MAX_BASE_SIZE)
                    {
                        rushCost = RushPriceChart[0, 0];
                    }
                    else if (SurfaceArea <= RUSH_ORDER_MAX_SURFACE)
                    {
                        rushCost = RushPriceChart[0, 1];
                    }
                    else
                    {
                        rushCost = RushPriceChart[0, 2];
                    }
                    break;

                case RUSH_OPTION_2:
                    if (SurfaceArea < MAX_BASE_SIZE)
                    {
                        rushCost = RushPriceChart[1, 0];
                    }
                    else if (SurfaceArea <= RUSH_ORDER_MAX_SURFACE)
                    {
                        rushCost = RushPriceChart[1, 1];
                    }
                    else
                    {
                        rushCost = RushPriceChart[1, 2];
                    }
                    break;

                case RUSH_OPTION_3:
                    if (SurfaceArea < MAX_BASE_SIZE)
                    {
                        rushCost = RushPriceChart[2, 0];
                    }
                    else if (SurfaceArea <= RUSH_ORDER_MAX_SURFACE)
                    {
                        rushCost = RushPriceChart[2, 1];
                    }
                    else
                    {
                        rushCost = RushPriceChart[2, 2];
                    }
                    break;
            }
            return rushCost;
        }
        private static decimal[,] GetRushOrderPrices()
        {
            decimal[,] rushPrices = new decimal[3, 3];
            int i = 0, j = 0;
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "rushOrderPrices.txt");

            try
            {
                string[] prices = File.ReadAllLines(filePath);

                foreach (var price in prices)
                {
                    decimal value;
                    if (Decimal.TryParse(price, out value))
                    {
                        rushPrices[i, j] = value;
                        j++;
                        if (j > 2)
                        {
                            i++;
                            j = 0;
                        }

                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Rush order price file not found.");
            }
            return rushPrices;
        }
    }
}
