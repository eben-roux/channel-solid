using System.Net.Mail;

namespace SolidPrinciples.SRP.EMailing
{
    public interface IEMailGateway
    {
        void Send(MailMessage message);
    }
}