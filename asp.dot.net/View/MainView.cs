using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asp.dot.net.Controller;
using asp.dot.net.Entity;


namespace asp.dot.net.View
{
    public class MainView
    {
        private AcauntContoller acauntController = new AcauntContoller();
        public void InitialInterface()
        {

            /*Base initial Interface(Menu) */
            /*
            1 - Show all acaunts
            2 - Get Acaunt by ID
            3 - Get Acaunts statistics

            0 - exit
           */
            // if can user input == 1
            showAllAcaunts();
        }
        public void showAllAcaunts() {
            List<Acaunt> acaunts = acauntController.getAllAcaunts();
            acaunts.ForEach(acaunt => Console.WriteLine(acaunt.Name + " " + acaunt.Email));

        }
    }
}
