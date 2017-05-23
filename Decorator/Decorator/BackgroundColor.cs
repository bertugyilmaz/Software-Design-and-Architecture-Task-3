using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BackgroundColor : ModulerWindow
    {
        ModulerWindow mwindow;
        public BackgroundColor(ModulerWindow backgroundColor)
        {
            mwindow = backgroundColor;
        }
        public override string Build()
        {
            throw new NotImplementedException();
        }
    }
}