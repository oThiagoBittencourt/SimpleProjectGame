using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Faculdade_ProjectGame
{
    static class Save
    {
        public static void Write()
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Save"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Save");
            }

            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\Save\save.dat", false, Encoding.Default);

            object[] objects = { Static._lightMode, Static._bestScore, Static._gamesPlayed, Static._coins };

            foreach (object item in objects)
            {
                writer.WriteLine(item);
            }

            writer.WriteLine(Static._playerColor.R);
            writer.WriteLine(Static._playerColor.G);
            writer.WriteLine(Static._playerColor.B);

            for (int i = 0; i < Static.itemsPurchased.Length; i++)
            {
                writer.WriteLine(Static.itemsPurchased[i]);
            }

            writer.WriteLine(Static.itemEquiped);
            writer.WriteLine(Static._musicIsPlaying);

            writer.Dispose();
        }

        public static void Read()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Save\save.dat"))
            {
                try
                {
                    StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Save\save.dat", Encoding.Default);

                    Static._lightMode = bool.Parse(reader.ReadLine());
                    Static._bestScore = int.Parse(reader.ReadLine());
                    Static._gamesPlayed = int.Parse(reader.ReadLine());
                    Static._coins = int.Parse(reader.ReadLine());

                    int r = int.Parse(reader.ReadLine());
                    int g = int.Parse(reader.ReadLine());
                    int b = int.Parse(reader.ReadLine());

                    Static._playerColor = Color.FromArgb(r, g, b);

                    for (int i = 0; i < Static.itemsPurchased.Length; i++)
                    {
                        Static.itemsPurchased[i] = bool.Parse(reader.ReadLine());
                    }

                    Static.itemEquiped = int.Parse(reader.ReadLine());
                    Static._musicIsPlaying = bool.Parse(reader.ReadLine());

                    reader.Dispose();
                }
                catch
                {
                    Basevalues();
                }
            }
            else
                Basevalues();
        }

        static void Basevalues()
        {
            Static.itemsPurchased[0] = true;
            Static.itemsPurchased[1] = Static.itemsPurchased[2] = Static.itemsPurchased[3] = false;
            Static.itemEquiped = 0;
            Static._playerColor = Color.FromArgb(0, 192, 0);
        }
    }
}
