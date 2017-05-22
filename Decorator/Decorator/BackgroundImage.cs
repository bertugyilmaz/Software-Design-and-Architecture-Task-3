using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BackgroundImage : ModulerWindow
    {
        ModulerWindow mWindow;
        public BackgroundImage(ModulerWindow backgroundImage)
        {
            mWindow = backgroundImage;
        }

        public override string Build()
        {
            return "Changed Background Image";
        }
    }
}
