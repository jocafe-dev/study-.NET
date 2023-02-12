using PaymentContext.Shared.ValueObjects;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {

        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract<Email>()
                .Requires()
                .IsEmail(Address, "Email.Address", "E-mail Inválido")
            );
        }

        public string Address { get; private set; }
    }
}