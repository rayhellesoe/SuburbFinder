using SuburbFinder.Server.Models;
using SuburbFinder.Server.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace SuburbFinder.Server.Services
{
    public class SuburbService
    {
        private readonly SuburbRepository _suburbRepository;

        public SuburbService(SuburbRepository suburbRepository)
        {
            _suburbRepository = suburbRepository;
        }

        private static double ToRadians(double degree)
        {
            return degree * Math.PI / 180.0;
        }

        /* Calculate distance between two sets of coordinates using the Haversine formula */
        private static double calculateDistance(double inputLongitude, double inputLatitude, double suburbLongitude, double suburbLatitude)
        {
            const int EarthRadius = 6371;

            /* Calculate the differences in latitude and longitude */
            double longitudeDifference = ToRadians(suburbLongitude - inputLongitude);
            double latitudeDifference = ToRadians(suburbLatitude - inputLatitude);

            double a = Math.Sin(latitudeDifference / 2) * Math.Sin(latitudeDifference / 2) +
                Math.Cos(ToRadians(inputLatitude)) * Math.Cos(ToRadians(suburbLatitude)) *
                Math.Sin(longitudeDifference / 2) * Math.Sin(longitudeDifference / 2);

            double distance = EarthRadius * (2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a)));

            return distance;
        }

        public Suburb GetNearestSuburb(Coordinates inputCoordinates)
        {
            IEnumerable<Suburb> Suburbs = _suburbRepository.GetAllSuburbs();
            Suburb nearestSuburb = null;
            double nearestDistance = double.MaxValue;

            foreach (Suburb suburb in Suburbs)
            {
                if (nearestSuburb == null)
                    nearestSuburb = suburb;

                double distance = calculateDistance(inputCoordinates.Longitude, inputCoordinates.Latitude, suburb.Longitude, suburb.Latitude);

                if (nearestDistance > distance)
                {
                    nearestSuburb = suburb;
                    nearestDistance = distance;
                }
            }

            return nearestSuburb;
        }
    }
}
