namespace SolidTraining.ISP
{
    public class OnBoardingHandler
    {
        private IBrandedEmailCreator _brandedEmailCreator;
        private IEmailSender _emailSender;

        public OnBoardingHandler(IBrandedEmailCreator brandedEmailCreator, IEmailSender emailSender)
        {
            _brandedEmailCreator = brandedEmailCreator;
            _emailSender = emailSender;
        }

        public void Handle(Customer customer)
        {
            // Step 1
            // ...
            // Step n

            SendWellcomeMessage(customer);
        }

        private void SendWellcomeMessage(Customer customer)
        {
            var message = _brandedEmailCreator.CreateWellcomeMessage(customer);
            _emailSender.Send(message);
        }
    }
}