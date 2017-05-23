using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class VerticalScrollBar : ModulerWindow
    {
        ModulerWindow mWindow;

        public VerticalScrollBar(ModulerWindow verticalScrollBar)
        {
            mWindow = verticalScrollBar;
        }

        public override string Build()
        {
            return "Düşey Scroll Bar Eklendi";
        }
    }
}
