using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyRobotAdapter : IEnemyAttack
    {
        EnemyRobot _enemyRobot;

        public EnemyRobotAdapter(EnemyRobot enemyRobot)
        {
            _enemyRobot = enemyRobot;
        }

        public void Drive(string driver)
        {
            _enemyRobot.React(driver);
        }

        public void FireGun()
        {
            _enemyRobot.Smash();
        }

        public void Move()
        {
            _enemyRobot.MoveForward();
        }
    }
}
