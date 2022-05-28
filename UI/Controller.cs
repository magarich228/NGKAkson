using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksonPriceList.UI
{
    internal class Controller
    {
        private Dictionary<string, Page> _Pages;

        public static int MedicamentNum;

        public void Run()
        {
            _Pages["StartMenu"].View();

            string pageName = _Pages["StartMenu"].Listen();

            while (pageName != "Сбой")
            {
                _Pages[pageName].View();
                pageName = _Pages[pageName].Listen();
            }

            Console.WriteLine("В программе произошла ошибка.");
        }

        public Controller()
        {
            _Pages = new Dictionary<string, Page>()
            {
                {
                    "StartMenu",
                    new Page()
                    {       
                        View = Render.StartMenu,
                        Listen = PageActions.StartMenu
                    }
                },
                {
                    "About",
                    new Page()
                    {
                        View = Render.About,
                        Listen = PageActions.About
                    }
                },
                {
                    "Exit",
                    new Page()
                    {
                        View = Render.Exit,
                        Listen = PageActions.Exit
                    }
                },
                {
                    "Price-list",
                    new Page()
                    {
                        View = Render.Price,
                        Listen = PageActions.Price
                    }
                },
                {
                    "New",
                    new Page()
                    {
                        View = Render.New,
                        Listen = PageActions.New
                    }
                },
                {
                    "Info",
                    new Page()
                    {
                        View = Render.Info,
                        Listen = PageActions.Info
                    }
                }
            };
        }
    }
}
