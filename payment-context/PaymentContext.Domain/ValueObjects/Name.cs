
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsLowerThan(FirstName, 2, "Name.FirstName", "Nome deve conter pelo menos 2 caracteres")
                .IsLowerThan(LastName, 2, "Name.LastName", "Sobrenome deve conter pelo menos 2 caracteres")
                .IsGreaterThan(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                .IsGreaterThan(LastName, 80, "Name.LastName", "Sobrenome deve conter até 80 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}