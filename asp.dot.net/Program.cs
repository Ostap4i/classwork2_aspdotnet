
using asp.dot.net.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.dot.net
{
    class Program
    {
        static void Main(string[] args)
        {
            MainView mainView = new MainView();
            mainView.InitialInterface();
            Thread.Sleep(5000);



        }
    }
}
