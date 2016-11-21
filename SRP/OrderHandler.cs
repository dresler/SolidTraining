using System;
using System.Net.Mail;

namespace SolidTraining.SRP
{
    public class OrderHandler
    {
        private readonly StockAvailableAmountProvider _stockAvailableAmountProvider;
        private readonly ExpeditionController _expeditionController;

        public OrderHandler()
        {
            _stockAvailableAmountProvider = new StockAvailableAmountProvider();
            _expeditionController = new ExpeditionController();
        }

        public void HandleOnlineOrder(OnlineOrder onlineOrder)
        {
            ReserveInStock(onlineOrder.ItemId, onlineOrder.Amount);
            SendMoveToExpeditionNotification(onlineOrder.EmailAddress);
            PrepareInvoice(onlineOrder);
        }

        private void PrepareInvoice(OnlineOrder onlineOrder)
        {
            var invoicePdfCreator = new InvoicePdfCreator();
            var invoiceInPdf = invoicePdfCreator.Create(onlineOrder);
            // Put the invoice into a document storage
            throw new NotImplementedException();
        }

        private void SendMoveToExpeditionNotification(string emailAddress)
        {
            var smtpClient = new SmtpClient();
            var message = new ExpeditionMailCreator().Create(emailAddress);
            smtpClient.Send(message);
        }

        private void ReserveInStock(string itemId, int amount)
        {
            var availableAmount = _stockAvailableAmountProvider.AvailableAmount(itemId);
            if (amount > availableAmount) throw new InvalidOperationException($"Insufficent amount of item {itemId}.");
            _expeditionController.MoveToExpedition(itemId, amount);
        }

        public void HandleInternalOrder(InternalOrder internalOrder)
        {
            CheckDepartmentAnnualLimit(internalOrder);
            ReserveInStock(internalOrder.ItemId, internalOrder.Amount);
            DeliverToDepartment(internalOrder);
        }

        private void DeliverToDepartment(InternalOrder internalOrder)
        {
            throw new NotImplementedException();
        }

        private void CheckDepartmentAnnualLimit(InternalOrder internalOrder)
        {
            // Get annual limit for the item and department.
            // Get spending of the item for the year.
            // Compare.
            throw new NotImplementedException();
        }
    }
}