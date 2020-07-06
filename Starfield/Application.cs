using System;
using System.Drawing;
using System.Windows.Forms;

namespace Starfield
{
    public partial class Application : Form
    {
        private Graphics graphics;
        private Controller controller;
        private int STARSCOUNT = 15000;

        private int fieldWidth, fieldHeight;

        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            fieldWidth = content.Width;
            fieldHeight = content.Height;

            content.Image = new Bitmap(fieldWidth, fieldHeight);
            graphics = Graphics.FromImage(content.Image);

            controller = new Controller();
            controller.InitStars(STARSCOUNT, fieldWidth, fieldHeight);

            eventLoop.Start();
        }

        private void eventLoop_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);

            controller.RefreshField(graphics, fieldWidth, fieldHeight);

            content.Refresh();
        }
    }
}
