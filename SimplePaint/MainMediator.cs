using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class MainMediator
    {
        public MainWindow View { get; private set; }
        public Canva ModelCanva { get; private set; }

        public MainMediator()
        {
            View = new MainWindow(this);
            ModelCanva = new Canva(this);

        }

    }
}
