using asp.dot.net.Repositoriy;
using asp.dot.net.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace asp.dot.net.Service
{
    class AcauntService
    {
        string connectionString = "Server=tcp:ostapserver.database.windows.net,1433;" +
        "Initial Catalog = Testdb; Persist Security Info=False;User ID = CloudSA713bc2aa;" +
     " Password={your_password MultipleActiveResultSets=False;Encrypt=True;" +
            "TrustServerCertificate=False;Connection Timeout = 30;";


        private AcauntRepositoriy acauntRepositoriy = new AcauntRepositoriy();
        public List<Acaunt> getAllAcaunts()
        {
            List<Acaunt> acaunts;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    acaunts = acauntRepositoriy.getAllAcaunts(connection);
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return acaunts;
        }

    }
}
