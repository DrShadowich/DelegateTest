using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Grenate
    {
        private string _name;
        private int _damage;
        public string Name { get { return _name; } }
        public int Damage { get { return _damage; } }
        public Explosion explosion;
        public Grenate(string name, int damage)
        {
            _name = name;
            _damage = damage;
        }
        public Grenate()
        {
            Console.WriteLine("Название гранаты: ");
            _name = Console.ReadLine();
            Console.WriteLine("Урон гранаты: ");
            _damage = int.Parse(Console.ReadLine());
        }
    }
}
