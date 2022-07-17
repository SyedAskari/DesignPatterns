using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Export
{
    public class CSVExportServiceAlternativeApproachOrder : IExportServiceAlternativeApproachOrder
    {
        public void Export(AlternativeApproachOrder order)
        {
            Console.WriteLine($"Exporting {order.Name} to CSV.");
        }
    }
}
