using System.Windows.Forms;

namespace ConsoleGame
{
    public abstract class EntityBase
    {
        // variables for registering Entities withing class instead of entity manager
        public static int instanceCounter;
        private readonly int _instanceId;
        private double health;

        public EntityBase()
        {
            _instanceId = ++instanceCounter;
            EntityManager.RegisterEntity(this);
        }

        ~EntityBase()
        {
            EntityManager.removeEntity(this);
        }

        public int getID()
        {
            return _instanceId;
        }

        public void DecreaseHealth(double amount)
        {
            if (health > 0)
            {
                health -= amount;
            }
        }
    }
}
