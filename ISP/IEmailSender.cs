using System.Net.Mail;

namespace SolidTraining.ISP
{
    public interface IEmailSender
    {
        void Send(MailMessage message);
        void SendWithDelay(MailMessage message, int delayInMilliseconds);
    }
}