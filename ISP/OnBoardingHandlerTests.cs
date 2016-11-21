using System.Net.Mail;
using NUnit.Framework;
using Rhino.Mocks;

namespace SolidTraining.ISP
{
    [TestFixture]
    public class OnBoardingHandlerTests
    {
        [Test]
        public void Handle_ForCustomer_ShouldSendWellcomeMessage()
        {
            var brandedEmailCreator = MockRepository.GenerateMock<IBrandedEmailCreator>();
            var emailSender = MockRepository.GenerateMock<IEmailSender>();

            var customer = new Customer();
            var wellcomeMessage = new MailMessage();
            
            // ???
            var leavingMessage = new MailMessage();     

            brandedEmailCreator.Stub(x => x.CreateWellcomeMessage(customer)).Return(wellcomeMessage);

            // ???
            brandedEmailCreator.Stub(x => x.CreateLeavingMessage(customer)).Return(leavingMessage);

            var underTest = new OnBoardingHandler(brandedEmailCreator, emailSender);

            underTest.Handle(customer);

            emailSender.AssertWasCalled(x => x.Send(wellcomeMessage));

            // ???
            emailSender.AssertWasNotCalled(x => x.Send(leavingMessage));

            // ???
            emailSender.AssertWasNotCalled(x => 
                x.SendWithDelay(Arg<MailMessage>.Is.Equal(wellcomeMessage), Arg<int>.Is.Anything));
            
            // ???
            emailSender.AssertWasNotCalled(x => 
                x.SendWithDelay(Arg<MailMessage>.Is.Anything, Arg<int>.Is.Anything));
        }
    }
}