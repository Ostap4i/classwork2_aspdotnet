using asp.dot.net.Entity;
using asp.dot.net.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace asp.dot.net.Controller
{
    public class AcauntContoller
    {
        private AcauntService acauntService = new AcauntService();
        public List<Acaunt> getAllAcaunts()
        {
            return acauntService.getAllAcaunts();
        }
    }
}
