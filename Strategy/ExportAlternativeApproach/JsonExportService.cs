using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Export
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class JsonExportServiceAlternativeApproachOrder : IExportServiceAlternativeApproachOrder
    {
        public void Export(AlternativeApproachOrder order)
        {
            Console.WriteLine($"Exporting {order.Name} to Json.");
        }
    }
}
