using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfield
{
    public class Star
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public void Draw(Graphics graphics, int fieldWidth, int fieldHeight)
        {
            float starSize = 7;

            float x = ChangeCoordinateSystem(this.X / this.Z, 0, 1, 0, fieldWidth) + fieldWidth / 2;
            float y = ChangeCoordinateSystem(this.Y / this.Z, 0, 1, 0, fieldHeight) + fieldHeight / 2;

            graphics.FillEllipse(Brushes.BlueViolet, x, y, starSize, starSize);
        }

        public void Move(Random random, int fieldWidth, int fieldHeight)
        {
            this.Z -= 30;
            if (this.Z < 1)
            {
                this.Z = random.Next(1, fieldWidth);
            }
        }

        private float ChangeCoordinateSystem(float n, float start1, float stop1, float start2, float stop2)
        {
            return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
    }    
}
