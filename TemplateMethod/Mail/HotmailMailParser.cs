namespace TemplateMethod.Mail
{
    public class HotmailMailParser : MailParser
    {
        protected override void AuntenticateToServer()
        {
            Console.WriteLine("Connecting to hotmail server...");
        }
    }
}
