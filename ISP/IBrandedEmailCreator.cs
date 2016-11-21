using System.Net.Mail;

namespace SolidTraining.ISP
{
    public interface IBrandedEmailCreator
    {
        MailMessage CreateWellcomeMessage(Customer customer);
        MailMessage CreateLeavingMessage(Customer customer);
    }
}