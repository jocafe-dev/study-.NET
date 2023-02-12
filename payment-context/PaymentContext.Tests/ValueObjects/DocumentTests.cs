using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Emuns;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor

        // [TestMethod]
        // public void ShouldReturnErrorWhenCNPJIsInvalid()
        // {
        //     var doc = new Document("123", EDocumentType.CNPJ);
        //     Assert.IsTrue(!doc.IsValid);
        // }

        // [TestMethod]
        // public void ShouldReturnSuccessWhenCNPJIsValid()
        // {
        //     var doc = new Document("34110468000150", EDocumentType.CNPJ);
        //     Assert.IsTrue(doc.IsValid);
        // }

        // [TestMethod]
        // public void ShouldReturnErrorWhenCPFIsInvalid()
        // {
        //     var doc = new Document("123", EDocumentType.CPF);
        //     Assert.IsTrue(!doc.IsValid);
        // }

        // [TestMethod]
        // [DataTestMethod]
        // [DataRow("34225545806")]
        // [DataRow("54139739347")]
        // [DataRow("01077284608")]
        // [DataRow("00000000000")]
        // [DataRow("11111111111")]
        // [DataRow("99999999999")]
        // public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        // {
        //     var doc = new Document(cpf, EDocumentType.CNPJ);
        //     Assert.IsTrue(doc.IsValid);
        // }
    }
}