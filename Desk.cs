namespace MegaDesk_Liu
{
    public class Desk
    {
        public static readonly decimal MIN_WIDTH = 24;
        public static readonly decimal MAX_WIDTH = 96;
        public static readonly decimal MIN_DEPTH = 12;
        public static readonly decimal MAX_DEPTH = 48;
        public static readonly int DRAWERS_MIN = 0;
        public static readonly int DRAWERS_MAX = 7;

        public decimal Width { get; set; }
        public decimal Depth { get; set;}
        public int DrawerCount { get; set;}
        public MaterialType MaterialType { get; set;}
        public string MaterialName { get { return this.MaterialType.ToString(); } set { } }

        public Desk(decimal width, decimal depth, int drawerCount, MaterialType materialType)
        {
            Width = width;
            Depth = depth;
            DrawerCount = drawerCount;
            MaterialType = materialType;
        }

    }

    public enum MaterialType
    {
        Pine = 50,
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125
    };
}
