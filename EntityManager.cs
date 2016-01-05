using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public static class EntityManager
    {
        private static List<EntityBase> _entityList = new List<EntityBase>();

        public static void RegisterEntity(EntityBase entity)
        {
            _entityList.Add(entity);
            Console.WriteLine(entity.GetType().Name+" with ID: "+entity.getID()+" added to entity list");
        }

        public static EntityBase GetEntity(int index)
        {
            return _entityList[index];
        }

        public new static string ToString()
        {
            string rtn = "Entities: ";
            foreach (EntityBase entity in _entityList)
            {
                rtn += "\n" + entity.GetType().Name + ", with ID: " + entity.getID();
            }
            return rtn;
        }

        public static void removeEntity(EntityBase entity)
        {
            _entityList.Remove(entity);
        }
    }
}
