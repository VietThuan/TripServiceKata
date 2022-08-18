using System.Collections.Generic;

namespace MISA.UT.LegacyCode.TripServiceKata.Trip
{
    public interface ITripDAO
    {
        List<Trip> FindTripsBy(User.User user);
    }
}