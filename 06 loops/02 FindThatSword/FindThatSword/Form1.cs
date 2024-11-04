namespace MenuDraw
{
    public partial class Form1 : Form
    {
        Equipment[] inventory;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            inventory = new Equipment[]
            {
                new Equipment("The minotaur", EquipmentType.Axe),
                new Equipment("The Grandfather", EquipmentType.Sword),
                new Equipment("corpsemourn", EquipmentType.ChestArmor),
                new Equipment("immortal kings pillar", EquipmentType.LegArmor)
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);

            // 1) Maak hier een for loop die over inventory loopt
            for (int i = 0; i < inventory.Length; i++)
            {
                // 2) Haal hier het item op [i] op
                Equipment item = inventory[i];

                // 3) Test hier of item.type gelijk is aan EquipmentType.Sword
                if (item.type == EquipmentType.Sword)
                {
                    
                    e.Graphics.DrawImage(item.image, 0, 0);
                }
            }
        }

        internal void DoLogic(float frametime)
        {
            // Gebruiken we nu even niet
        }
    }
}
