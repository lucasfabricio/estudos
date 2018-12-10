using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Manufacturer
    {
        public void Constructor(ICellphone cellphoneBuilder)
        {
            cellphoneBuilder.BuildBattery();
            cellphoneBuilder.BuildCamera();
            cellphoneBuilder.BuildDisplay();
            cellphoneBuilder.BuildSystem();
        }
    }
}
