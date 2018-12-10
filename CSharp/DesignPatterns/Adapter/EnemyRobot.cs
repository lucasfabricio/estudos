using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyRobot
    {
        Random generator = new Random();

        public void Smash()
        {
            int attackDamage = this.generator.Next(10) + 1;
            Console.WriteLine($"Robô inimigo causou +{attackDamage} de dano!");
        }

        public void MoveForward()
        {
            int movement = this.generator.Next(10) + 1;
            Console.WriteLine($"Robô inimigo andou {movement} passos para frente.");
        }

        public void React(string driver)
        {
            Console.WriteLine($"O robô inimigo atacou {driver}!");
        }
    }
}
