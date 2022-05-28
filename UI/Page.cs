using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksonPriceList.UI
{
    internal class Page
    {
        public View View { get; set; }

        public Listen Listen { get; set; }
    }


    public delegate string Listen();

    public delegate void View();
}
