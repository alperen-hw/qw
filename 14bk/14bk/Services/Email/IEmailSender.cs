using _14bk.Services.Email;

namespace _14bk.Services.Email;

public interface IEmailSender
{
    MailStatus SendEmail(MailBody body);
}