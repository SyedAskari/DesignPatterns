namespace TemplateMethod.Mail
{
    /// <summary>
    /// AbstractClass
    /// </summary>
    public abstract class MailParser
    {
        protected virtual void FindServer()
        {
            Console.WriteLine("Finding server...");
        }

        protected abstract void AuntenticateToServer();

        /// <summary>
        /// Template method
        /// </summary>
        public string ParseMailBody(string identifier)
        {
            Console.WriteLine("Parsing mail body in the template method...");
            FindServer();
            AuntenticateToServer();
            return ParseHtmlMailBody(identifier);
        }

        private string ParseHtmlMailBody(string identifier)
        {
            Console.WriteLine("Parsing HTML mail body...");
            var parsedMailBodyWithIdentifier = $"This is the body of the mail with id {identifier}";

            return parsedMailBodyWithIdentifier;
        }

    }
}
