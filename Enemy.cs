using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Enemy
    {
        private string _name;
        private int _health;
        public int Health { get { return _health; } }
        public string Name { get { return _name; } }
        public Enemy(string name, int health)
        {
            _name = name;
            _health = health;
        }
        public Enemy(string name)
        {
            Random randint = new Random();
            _name = name;
            _health = randint.Next() % 100;
        }
        public Enemy()
        {
            Console.WriteLine("Имя противника: ");
            _name = Console.ReadLine();
            Console.WriteLine("Здоровье противника: ");
            _health = int.Parse(Console.ReadLine());
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine($"{_name} получил {damage} урона");
            _health -= damage;
        }
    }
}
