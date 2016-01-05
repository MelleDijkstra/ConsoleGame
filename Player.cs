namespace ConsoleGame
{
    class Player : EntityBase
    {
        private static Player _instance;
        private Inventory inventory;
        public LocationBase location;

        private Player()
        {
            this.inventory = new Inventory();
        }

        public static Player Instance()
        {
            return _instance ?? (_instance = new Player());
        }

        public override string ToString()
        {
            return "Player with ID: " + getID();
        }

    }
}
