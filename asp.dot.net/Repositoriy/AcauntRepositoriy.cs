using asp.dot.net.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.dot.net.Repositoriy
{
    class AcauntRepositoriy
    {
        public List<Acaunt> getAllAcaunts()
        {
            Acaunt acaunt = new Acaunt(1, "name", "email", "pass");

            List<Acaunt> acaunts = new List<Acaunt>();
            acaunts.Add(acaunt);
            return acaunts;
        }
    }
}
