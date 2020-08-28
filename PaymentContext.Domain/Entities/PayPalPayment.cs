using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; private set; }

        public PayPalPayment(
            string transactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Email email,
            Address address)
            : base(paidDate, expireDate, total, totalPaid, payer, document, email, address)
        {
            TransactionCode = transactionCode;
        }
    }
}