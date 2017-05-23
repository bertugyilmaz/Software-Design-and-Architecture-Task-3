using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WindowShadow : ModulerWindow
    {

        ModulerWindow mWindonw;

        public WindowShadow(ModulerWindow windowShadow)
        {
            mWindonw = windowShadow;
        }

        public override string Build()
        {
            return "Gölgelendirme eklendi";
        }
    }
}
