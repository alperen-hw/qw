using _14bk.Services.Email;

namespace _14bk.Services.Email
{
    public class SendGridEmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        private readonly string _apiKey;
        private readonly string _secretKey;

        public SendGridEmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiKey = _configuration["SendGrid:ApiKey"];
            _secretKey = _configuration["SendGrid:SecretKey"];
        }

        public bool SetSecure()
        {
            return true;
        }
        public MailStatus SendEmail(MailBody body)
        {
            throw new NotImplementedException();
        }
    }
}