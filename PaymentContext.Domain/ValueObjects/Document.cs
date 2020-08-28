using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public string Number { get; private set; }
        public DocumentType Type { get; private set; }

        public Document(string number, DocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract().Requires().IsFalse(Validate(), "Document.Number", "Documento inválido"));
        }

        private bool Validate()
        {
            if ((Type == DocumentType.CNPJ && Number.Length < 14) ||
                (Type == DocumentType.CPF && Number.Length < 11))
                return false;

            return true;
        }
    }
}