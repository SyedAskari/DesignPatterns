using TemplateMethod.Mail;

Console.Title = "Template Method";

HotmailMailParser hotmailMailParser = new();
Console.WriteLine(hotmailMailParser.ParseMailBody("identifier-homtail-yyy-123"));
Console.WriteLine();

GmailMailParser gmailMailParser = new();
Console.WriteLine(gmailMailParser.ParseMailBody("identifier-gmail-yyy-123"));
Console.WriteLine();

YahooMailParser yahooMailParser = new();
Console.WriteLine(yahooMailParser.ParseMailBody("identifier-yahoo-yyy-123"));

Console.ReadKey();