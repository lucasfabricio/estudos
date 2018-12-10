using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IEnemyAttack
    {
        void FireGun();
        void Move();
        void Drive(string driver);
    }
}
