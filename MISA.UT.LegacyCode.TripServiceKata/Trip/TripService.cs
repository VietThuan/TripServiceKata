using System.Collections.Generic;
using MISA.UT.LegacyCode.TripServiceKata.Exception;
using MISA.UT.LegacyCode.TripServiceKata.User;

namespace MISA.UT.LegacyCode.TripServiceKata.Trip
{
    public class TripService
    {
        private readonly ITripDAO tripDao;

        public TripService(ITripDAO tripDao)
        {
            this.tripDao = tripDao;
        }

        public List<Trip> GetTripsByUser(User.User user, User.User userlogged)
        {
            //User.User loggedUser = GetLoggedUser();
            if (userlogged == null)
            {
                throw new UserNotLoggedInException();
            }

            return user.IsMyFriend(userlogged) ? tripDao.FindTripsBy(user) : new List<Trip>();

           
        }

    }
}
