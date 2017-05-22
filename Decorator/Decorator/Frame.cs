using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Frame : ModulerWindow
    {
        ModulerWindow mWindow;
        public Frame(ModulerWindow addedframe)
        {
            mWindow = addedframe;
        }
        public override string Build()
        {
            return "Çerçeve oluşturuldu";

        }
    }
}
