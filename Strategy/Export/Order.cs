using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Export
{
    /// <summary>
    /// Context
    /// </summary>
    public class Order
    {
        public string Customer { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IExportService? ExportService { get; set; }
        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
        }

        public void Export()
        {
            if (ExportService is null)
            {
                throw new NullReferenceException(nameof(ExportService));
            }

            ExportService.Export(this);
        }
    }
}
