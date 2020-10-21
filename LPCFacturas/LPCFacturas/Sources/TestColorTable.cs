using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPCFacturas.Sources
{
    public class TestColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.Thistle; }
        }
        Color culoare = Color.FromArgb(20, 20, 20);
        Color culoare1 = Color.FromArgb(36, 36, 36);

        public override Color MenuItemBorder
        {
            get { return culoare; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return culoare; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return culoare; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return culoare; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return culoare; }
        }
        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.Thistle; }
        }
    }
}
