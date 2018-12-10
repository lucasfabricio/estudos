using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyTank tank = new EnemyTank();
            EnemyRobot robot = new EnemyRobot();

            IEnemyAttack robotAdapter = new EnemyRobotAdapter(robot);

            Console.WriteLine("======== ROBO ========");
            robot.React("FS34");
            robot.MoveForward();
            robot.Smash();

            Console.WriteLine("======== TANK ========");
            tank.Drive("FS34");
            tank.Move();
            tank.FireGun();

            Console.WriteLine("======== ROBOT ADPTER ========");
            robotAdapter.Drive("C3PO");
            robotAdapter.Move();
            robotAdapter.FireGun();

            Console.ReadKey();

        }
    }
}
