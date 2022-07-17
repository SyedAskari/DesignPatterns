namespace TemplateMethod.Mail
{
    public class YahooMailParser : MailParser
    {
        protected override void FindServer()
        {
            Console.WriteLine("Finding yahoo mail server using a custom algorithm");
        }
        protected override void AuntenticateToServer()
        {
            Console.WriteLine("Connecting to yahoo server...");
        }
    }
}
