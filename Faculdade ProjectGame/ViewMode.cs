using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Faculdade_ProjectGame
{
    // Game Object - View Mode
    public partial class FormMain
    {
        Color grayColor = Color.FromArgb(45, 45, 48);
        Color darkColor = Color.FromArgb(27, 27, 28);

        void ViewMode()
        {
            ToolStripMenuItem[] objetos = { GameToolStripMenuItem, preferencesToolStripMenuItem, shopToolStripMenuItem, profileToolStripMenuItem, helpToolStripMenuItem, newGameToolStripMenuItem, exitToolStripMenuItem };

            if (Static._lightMode)
            {
                preferencesToolStripMenuItem.DropDown.Close();

                menuStrip1.Renderer = new ToolStripProfessionalRenderer(new LightColorTable());
                MenuStripColorChange(objetos);

                this.BackColor = Color.FromArgb(220, 220, 223);
                panel1.BackColor = Color.FromArgb(200, 200, 200);
                lb_coins.ForeColor = SystemColors.ControlText;
                lb_score.ForeColor = SystemColors.ControlText;
                lb_version.ForeColor = SystemColors.ControlText;
                menuStrip1.BackColor = SystemColors.Control;
                toolStripComboBox1.BackColor = SystemColors.Window;
                toolStripComboBox1.ForeColor = SystemColors.WindowText;
                musicOnOffToolStripMenuItem.ForeColor = SystemColors.ControlText;
            }
            else
            {
                preferencesToolStripMenuItem.DropDown.Close();

                menuStrip1.Renderer = new ToolStripProfessionalRenderer(new DarkColorTable());
                MenuStripColorChange(objetos);

                this.BackColor = Color.FromArgb(35, 35, 38);
                panel1.BackColor = Color.FromArgb(30, 30, 30);
                lb_coins.ForeColor = Color.White;
                lb_score.ForeColor = Color.White;
                lb_version.ForeColor = Color.White;
                menuStrip1.BackColor = grayColor;
                toolStripComboBox1.BackColor = darkColor;
                toolStripComboBox1.ForeColor = Color.White;
                musicOnOffToolStripMenuItem.ForeColor = Color.White;
            }
        }

        void MenuStripColorChange(ToolStripMenuItem[] objeto)
        {
            if (Static._lightMode)
            {
                for (int i = 0; i < objeto.Length; i++)
                {
                    objeto[i].ForeColor = SystemColors.ControlText;
                }
            }
            else
            {
                for (int i = 0; i < objeto.Length; i++)
                {
                    objeto[i].ForeColor = Color.White;
                }
            }
        }
    }

    #region DarkMode
    public class DarkColorTable : ProfessionalColorTable
    {
        Color grayColor = Color.FromArgb(45, 45, 48);
        Color darkColor = Color.FromArgb(27, 27, 28);
        Color lightColor = Color.FromArgb(51, 51, 52);

        public override Color MenuItemSelected
        {
            get { return lightColor; }
        }

        public override Color MenuItemBorder
        {
            get { return lightColor; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return darkColor; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return darkColor; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return darkColor; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return darkColor; }
        }

        public override Color MenuBorder
        {
            get { return grayColor; }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return darkColor; }
        }

        public override Color SeparatorDark
        {
            get { return grayColor; }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return darkColor; }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return darkColor; }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return darkColor; }
        }

        public override Color CheckBackground
        {
            get { return grayColor; }
        }
    }

    #endregion

    #region LightMode

    public class LightColorTable : ProfessionalColorTable
    {
        Color grayColor = SystemColors.Control;
        Color darkColor = Color.FromArgb(253, 253, 253);
        Color lightColor = Color.FromArgb(181, 215, 243);

        public override Color MenuItemSelected
        {
            get { return lightColor; }
        }
        public override Color MenuItemBorder
        {
            get { return lightColor; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return lightColor; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return lightColor; }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return lightColor; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return lightColor; }
        }
        public override Color MenuBorder
        {
            get { return grayColor; }
        }
        public override Color ToolStripDropDownBackground
        {
            get { return darkColor; }
        }
        public override Color SeparatorDark
        {
            get { return grayColor; }
        }
        public override Color ImageMarginGradientBegin
        {
            get { return darkColor; }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return darkColor; }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return darkColor; }
        }

        public override Color CheckBackground
        {
            get { return grayColor; }
        }
    }

    #endregion
}