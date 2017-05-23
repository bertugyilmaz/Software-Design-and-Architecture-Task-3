using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HorizantalScrollBar : ModulerWindow
    {
        ModulerWindow mWindow;

        public HorizantalScrollBar(ModulerWindow horizantalScrollBar)
        {
            mWindow = horizantalScrollBar;
        }

        public override string Build()
        {
            return "Yatay Scrool Bar Eklendi";
        }
    }
}
