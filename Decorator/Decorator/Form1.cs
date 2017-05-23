using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Window w = new Window();
            MessageBox.Show(w.Build());

            BackgroundColor bgc = new BackgroundColor(w);
            MessageBox.Show(bgc.Build());

            WindowHead wh = new WindowHead(w);
            MessageBox.Show(wh.Build());

            BackgroundImage bgi = new BackgroundImage(w);
            MessageBox.Show(bgi.Build());



            
        }
    }
}
