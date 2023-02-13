

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Emuns;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";

            command.BarCode = "123456789";
            command.BoletoNumber = "123456789";

            command.PaymentNumber = "123456";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now;
            command.Total = 10;
            command.TotalPaid = 10;
            command.Payer = "WAYNE CORP S/A";
            command.PayerDocument = "12345678910110";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "batman@dc.com";

            command.Street = "asdas";
            command.Number = "asdas";
            command.Neighborhood = "asdas";
            command.City = "asdas";
            command.State = "asdas";
            command.Country = "asdas";
            command.ZipCode = "12345678";

            handler.Handler(command);
            Assert.AreEqual(false, handler.IsValid);
        }
    }
}