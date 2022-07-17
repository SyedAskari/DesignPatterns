namespace Strategy.Export
{
    /// <summary>
    /// COntext
    /// </summary>
    public class AlternativeApproachOrder
    {
        public string Customer { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public AlternativeApproachOrder(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
        }

        public void Export(IExportServiceAlternativeApproachOrder exportService)
        {
            if (exportService is null)
            {
                throw new NullReferenceException(nameof(exportService));
            }

            exportService.Export(this);
        }
    }
}
