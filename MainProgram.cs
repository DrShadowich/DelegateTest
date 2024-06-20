using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HW10
{
    // Куда надо девать делегаты, они же тоже классы в каком-то отношении.
    // Отдельные файлы, как с интерфейсами? С классом, где он используется?
    public delegate void Explosion(int damage);
    
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Grenate grenate = new Grenate("Осколочная граната", 30);
            Grenate explosiveThing = new Grenate("Взрывающая штучка", 1);

            List<Enemy> enemies = new List<Enemy>()
            {
                new Enemy("Зомби", 52),
                new Enemy("Робот", 65),
                new Enemy("Темный рыцарь", 53),
                new Enemy("Дэвид"),
                new Enemy("Люцифер", 100),
                new Enemy()
            };

            foreach (Enemy i in enemies)
            {
                grenate.explosion += i.GetDamage;
                explosiveThing.explosion += i.GetDamage;
            }


            grenate.explosion(grenate.Damage);
            explosiveThing.explosion(explosiveThing.Damage);

            foreach(Enemy i in enemies)
            {
                if(i.Health <= 0) Console.WriteLine($"{i.Name} был убит.");
                else Console.WriteLine($"У {i.Name} осталось {i.Health} здоровья.");
            }
        }
    }
}
