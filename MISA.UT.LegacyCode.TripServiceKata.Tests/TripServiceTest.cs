
using MISA.UT.LegacyCode.TripServiceKata.Exception;
using MISA.UT.LegacyCode.TripServiceKata.Trip;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;

namespace MISA.UT.LegacyCode.TripServiceKata.Tests
{
    
    public class TripServiceTest
    {
        private TripService tripService;
        private User.User OTHER_USER = new User.User();
        private User.User REGISTERED_USER = new User.User();
        private Trip.Trip TO_VIETNAM  = new Trip.Trip();
        private Trip.Trip TO_LAOS = new Trip.Trip();
        private readonly User.User OTHER_GUEST = null;
        private readonly User.User GUEST = null;
        private ITripDAO tripDAO;
        [SetUp]
        public void SetUp()
        {
             tripDAO = NSubstitute.Substitute.For<ITripDAO>();
            tripService = new TripService(tripDAO);
        }

        [Test]
        public void GetTripsByUser_UserNotLogin_ThrowAnException()
        {
            //Arrange
            //Act Assert
            Assert.Throws<UserNotLoggedInException>(() => tripService.GetTripsByUser(OTHER_GUEST, GUEST));
        }

        [Test]
        public void GetTripsByUser_UserAreNotFriend_ReturnAnyTrips()
        {
            //Arrange
            var friend = new User.User();
            //Act
            var friendTrips = tripService.GetTripsByUser(friend, REGISTERED_USER);
            //Assert
            Assert.Zero(friendTrips.Count);
        }

        [Test]
        public void GetTripsByUser_UserIsFriend_ReturnFriendTrips()
        {
            //Arrange
            var friend = new User.User();
            friend.AddFriend(REGISTERED_USER);
            tripDAO.FindTripsBy(Arg.Any<User.User>()).Returns(new List<Trip.Trip>() { TO_VIETNAM, TO_LAOS });
            //Act
            var friendTrips = tripService.GetTripsByUser(friend, REGISTERED_USER);
            //Assert
            Assert.IsTrue(friendTrips.Count == 2);
        }
    }

    
}
