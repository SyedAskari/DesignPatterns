namespace TemplateMethod.Mail
{
    public class GmailMailParser : MailParser
    {
        protected override void AuntenticateToServer()
        {
            Console.WriteLine("Connecting to gmail server...");
        }
    }
}
