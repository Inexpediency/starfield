using System;

namespace Starfield
{
    class Controller
    {
        private Star[] stars;
        private Random random = new Random();
        
        public void InitStars(int count, int fieldWidth, int fieldHeight)
        {
            for (int i = 0; i < count; i++)
            {
                stars[i] = new Star()
                {
                    X = random.Next(-fieldWidth, fieldWidth),
                    Y = random.Next(-fieldHeight, fieldHeight),
                    Z = random.Next(1, fieldWidth),
                };
            }
        }

        public float ChangeCoordinateSystem(float n, float start1, float stop1, float start2, float stop2)
        {
            return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
    }
}
