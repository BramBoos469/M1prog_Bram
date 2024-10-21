
namespace UpAndDown
{
    public partial class Form1 : Form
    {

        int score = 0;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // 1) Tel 1 bij de score op wanneer de spatiebalk wordt ingedrukt
                score += 1;
            }
            if (e.KeyCode == Keys.E)
            {
                // 2) Tel 5 bij de score op wanneer de 'E'-toets wordt ingedrukt
                score += 5;
            }
            if (e.KeyCode == Keys.W)
            {
                // 3) Tel zelf gekozen aantal (bijv. 10) bij de score op wanneer de 'W'-toets wordt ingedrukt
                score += 10;
            }
            if (e.KeyCode == Keys.Delete)
            {
                // 4) Haal een zelf gekozen aantal (bijv. 3) van de score af wanneer de 'Delete'-toets wordt ingedrukt
                score -= 3;
            }

            // Herteken de interface om de bijgewerkte score weer te geven
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);

            e.Graphics.DrawString("Score: " + score, Font, Brushes.White, 50, 50);

        }

        public void DoLogic(float frametime)
        {
        }
    }
}
