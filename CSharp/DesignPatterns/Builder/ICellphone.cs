using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICellphone
    {
        void BuildDisplay();
        void BuildBattery();
        void BuildSystem();
        void BuildCamera();

        Cellphone Cellphone { get; }
    }
}
