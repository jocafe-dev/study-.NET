using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Emuns;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable<Notification>, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }

        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
        
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string PayerDocument { get; set; }
        public EDocumentType PayerDocumentType { get; set; }
        public string PayerEmail { get; set; }

        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract<CreateBoletoSubscriptionCommand>()
                .Requires()
                .IsLowerThan(FirstName, 2, "Name.FirstName", "Nome deve conter pelo menos 2 caracteres")
                .IsLowerThan(LastName, 2, "Name.LastName", "Sobrenome deve conter pelo menos 2 caracteres")
                .IsGreaterThan(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                .IsGreaterThan(LastName, 80, "Name.LastName", "Sobrenome deve conter até 80 caracteres")
            );
        }
    }
}