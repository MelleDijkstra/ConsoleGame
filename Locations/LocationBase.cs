using System.Media;

namespace ConsoleGame
{
    abstract class LocationBase
    {
        // variables for registering Locations
        public static int instanceCounter;
        private readonly int _instanceId;
        private string name;
        private SoundPlayer sound;

        public LocationBase()
        {
            _instanceId = ++instanceCounter;
            LocationManager.RegisterLocation(this);
        }

        public int getId()
        {
            return _instanceId;
        }
    }
}
