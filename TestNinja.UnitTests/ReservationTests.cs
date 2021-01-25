using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    class ReservationTests
    {
        private Reservation _reservation;
        private Reservation _reservationMadeByUser;
        private User _user;
        private User _adminUser;

        [SetUp]
        public void SetUp()
        {
            _reservation = new Reservation();
            _user = new User();
            _adminUser = new User() {IsAdmin = true };
            _reservationMadeByUser = new Reservation() { MadeBy = _user };
        }

        [Test]
        public void CanBeCancelledBy_WhenCalledByAdmin_ReturnsTrue()
        {
            bool result = _reservation.CanBeCancelledBy(_adminUser);
            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_WhenCalledByMadeByUser_ReturnsTrue()
        {
            bool result = _reservationMadeByUser.CanBeCancelledBy(_user);
            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_WhenCalledByDifferentUser_ReturnsFalse()
        {
            bool result = _reservationMadeByUser.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
