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

        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            var fieldWidth = content.Width;
            var fieldHeight = content.Height;

            content.Image = new Bitmap(fieldWidth, fieldHeight);
            graphics = Graphics.FromImage(content.Image);

            controller = new Controller();
            controller.InitStars(STARSCOUNT, fieldWidth, fieldHeight);

            eventLoop.Start();
        }

        private void eventLoop_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);

            var fieldWidth = content.Width;
            var fieldHeight = content.Height;
            controller.RefreshField(graphics, fieldWidth, fieldHeight);

            content.Refresh();
        }
    }
}
