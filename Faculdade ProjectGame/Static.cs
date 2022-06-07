using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Faculdade_ProjectGame
{
    // Static Class
    static class Static
    {
        public static Color _playerColor;
        public static int _bestScore = 0, _coins = 0, _gamesPlayed = 0;
        public static bool _lightMode = false;

        //Shop
        public static bool[] itemsPurchased = new bool[4];
        public static int itemEquiped;

        public static void Walk(ref PictureBox objeto, int direction)
        {
            switch (direction)
            {
                case 0:
                    objeto.Location = new Point(objeto.Location.X, objeto.Location.Y -25);
                    break;
                case 1:
                    objeto.Location = new Point(objeto.Location.X -25, objeto.Location.Y);
                    break;
                case 2:
                    objeto.Location = new Point(objeto.Location.X, objeto.Location.Y + 25);
                    break;
                case 3:
                    objeto.Location = new Point(objeto.Location.X +25, objeto.Location.Y);
                    break;
            }

            if (objeto.Location.X < 0)
                objeto.Location = new Point(375, objeto.Location.Y);
            if (objeto.Location.X > 375)
                objeto.Location = new Point(0, objeto.Location.Y);
            if (objeto.Location.Y < 0)
                objeto.Location = new Point(objeto.Location.X, 375);
            if (objeto.Location.Y > 375)
                objeto.Location = new Point(objeto.Location.X, 0);
        }
    }
}