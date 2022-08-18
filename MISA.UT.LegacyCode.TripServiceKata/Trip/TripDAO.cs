using System.Collections.Generic;
using MISA.UT.LegacyCode.TripServiceKata.Exception;

namespace MISA.UT.LegacyCode.TripServiceKata.Trip
{
    public class TripDAO : ITripDAO
    {
        public static List<Trip> FindTripsByUser(User.User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                        "TripDAO should not be invoked on an unit test.");
        }

        public List<Trip> FindTripsBy(User.User user)
        {
            return FindTripsByUser(user);
        }
    }
}
