using System.Collections.Generic;
using MISA.UT.LegacyCode.TripServiceKata.Exception;

namespace MISA.UT.LegacyCode.TripServiceKata.Trip
{
    public class TripDAO
    {
        public static List<Trip> FindTripsByUser(User.User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                        "TripDAO should not be invoked on an unit test.");
        }
    }
}
