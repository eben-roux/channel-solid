using System.Net.Mail;

namespace SolidPrinciples.SRP.EMailing
{
    public class DefaultEMailGateway : IEMailGateway
    {
        public void Send(MailMessage message)
        {
            throw new System.NotImplementedException();
        }
    }
}