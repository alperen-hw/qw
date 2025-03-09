using _14bk.Services.Email;

namespace _14bk.Services.Email;
public class EmailSender : IEmailSender
{
    public MailStatus SendEmail(MailBody body)
    {
        return MailStatus.Sent;
    }
}