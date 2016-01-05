namespace ConsoleGame
{
    class NPCBase : EntityBase
    {
        public override string ToString()
        {
            return GetType().Name + " with id: " + getID();
        }
    }
}
