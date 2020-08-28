using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // var subscription = new Subscription(DateTime.Now.Add(new TimeSpan(365,0,0)));
            // var student = new Student("Rodrigo", "Cocate", "29.614.194-X", "rodrigo.cocate@hotmail.com");
            // student.AddSubscription(subscription);
            var name = new Name("Teste", "Teste");
            // foreach (var notification in name.Notifications)
            // {
            //     notification.Message;
            // }

        }
    }
}