using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WindowHead : ModulerWindow
    {

        ModulerWindow mWindow;
        public WindowHead(ModulerWindow head)
        {
            mWindow = head;
        }

        public override string Build()
        {
            return "Başlık Oluşturuldu";
        }


    }
}
