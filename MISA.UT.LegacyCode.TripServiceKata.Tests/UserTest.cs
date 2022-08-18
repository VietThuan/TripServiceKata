using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.UT.LegacyCode.TripServiceKata.Tests
{
    public class UserTest
    {
        private User.User NTTUNG = new User.User();
        private User.User NDVIET = new User.User();

        [Test]
        public void IsMyFriend_NotMyFriend_ReturnFalse()
        {
            //Arrange
            var user  = new User.User();
            user.AddFriend(NTTUNG);
            //Act
            var isFriend = user.IsMyFriend(NDVIET);
            //Assert
            Assert.IsFalse(isFriend);
        }
    }
}
