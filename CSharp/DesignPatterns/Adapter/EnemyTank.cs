using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyTank : IEnemyAttack
    {
        Random generator = new Random();

        public void Drive(string driver)
        {
            Console.WriteLine($"{driver} está no comando do tanque!");
        }

        public void FireGun()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine($"Tanque inimigo fez +{attackDamage} de dano.");
        }

        public void Move()
        {
            int movement = this.generator.Next(5) + 1;
            Console.WriteLine($"Tanque inimigo movimentou {movement} passos.");
        }
    }
}
