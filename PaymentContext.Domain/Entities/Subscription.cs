using System;
using System.Collections.Generic;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity
    {
        private IList<Payment> _payments;
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Active { get; set; }
        public List<Payment> Payments { get; set; }

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public void AddPayment(Payment payment)
        {
            AddNotifications(new Contract().Requires().IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.PaidDate", "Data de pagamento deve ser futura"));
            // if (Valid)
            _payments.Add(payment);

        }

        public void ChangeActiveStatus(bool active)
        {
            Active = active;
            ExpireDate = DateTime.Now;
        }
    }

}