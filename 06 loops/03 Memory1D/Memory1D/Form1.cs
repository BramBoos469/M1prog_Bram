namespace MenuDraw
{
    public partial class Form1 : Form
    {
        string[] names = { "1up", "star", "flower", "mushroom", "10coin", "20coin", "10coin", "20coin", "mushroom" };
        const int w = 22;
        const int h = 32;
        const int rows = 3;
        const int cols = 6;
        private readonly Rectangle cardback;
        Bitmap cardImg = new Bitmap("memory.png");
        Card[] cards;
        Dictionary<string, Rectangle> sprites = new Dictionary<string, Rectangle>()
        {
            {"1up", new Rectangle(172, 95, w, h) },
            { "star", new Rectangle(140, 95, w, h) },
            { "flower", new Rectangle(108, 95, w, h) },
            { "mushroom", new Rectangle(76, 95, w, h) },
            { "10coin", new Rectangle(44, 95, w, h) },
            { "20coin", new Rectangle(12, 95, w, h) },
            { "cardback", new Rectangle(12, 55, w, h) }
        };

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MakeCards();
            cardback = sprites["cardback"];
            MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            // 1) Maak hier een for loop, die over cards loopt
            for (int i = 0; i < cards.Length; i++)
            {
                // 2) Pak hier 1 card uit cards, die van [i]
                Card card = cards[i]; // Hier halen we de specifieke kaart op

                // 3) Maak een if die kijkt of de muis X en Y in card.placement zit
                if (card.placement.Contains(e.Location)) 
                {
                    
                    card.turned = true;
                }
            }
        }

        private void MakeCards()
        {
            int x = 0;
            int y = 0;
            cards = new Card[rows * cols];
            List<string> options = CreateOptions();

            Random random = new Random();
            for (int i = 0; i < cards.Length; i++)
            {
                int v = random.Next(options.Count);
                string type = options[v];
                options.RemoveAt(v);
                cards[i] = new Card(type, new Rectangle(x * w, y * h, w, h), sprites);
                x++;
                if (x == cols)
                {
                    y++;
                    x = 0;
                }
            }
        }

        private List<string> CreateOptions()
        {
            List<string> options = new List<string>();
            options.AddRange(names);
            options.AddRange(names);
            return options;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.Black);

            // 4) Maak hier een for loop, die over cards loopt
            for (int i = 0; i < cards.Length; i++)
            {
                // 5) Geef hier de card die in [i] zit door op de ????
                DrawCard(graphics, cards[i]); 
            }
        }

        private void DrawCard(Graphics graphics, Card card)
        {
            Rectangle frame = cardback;
            if (card.turned)
            {
                frame = card.frame;
            }

            graphics.DrawImage(cardImg, card.placement, frame, GraphicsUnit.Pixel);
        }

        internal void DoLogic(float frametime)
        {
            // Gebruiken we nu even niet
        }
    }
}
