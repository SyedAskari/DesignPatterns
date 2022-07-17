
using Strategy.Export;

Console.Title = "Strategy";

var order = new Order(customer: "Jhon", amount: 5, name: "Visual Studio License");

order.ExportService = new CSVExportService();
order.Export();

order.ExportService = new JsonExportService();
order.Export();

Console.WriteLine();

var orderAlternativeApproach = new AlternativeApproachOrder(customer: "Jhon", amount: 5, name: "Visual Studio License");

orderAlternativeApproach.Export(new CSVExportServiceAlternativeApproachOrder());
orderAlternativeApproach.Export(new JsonExportServiceAlternativeApproachOrder());



Console.ReadKey();