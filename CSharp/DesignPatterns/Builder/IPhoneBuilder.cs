using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class IPhoneBuilder : ICellphone
    {
        Cellphone _cellphone;

        public IPhoneBuilder()
        {
            this._cellphone = new Cellphone("IPhone");
        }

        public void BuildBattery()
        {
            this._cellphone.Battery = "Mah 4000";
        }

        public void BuildCamera()
        {
            this._cellphone.Camera = "18 MP";
        }

        public void BuildDisplay()
        {
            this._cellphone.Display = "5.2\"";
        }

        public void BuildSystem()
        {
            this._cellphone.System = "iOS 10";
        }

        public Cellphone Cellphone
        {
            get
            {
                return this._cellphone;
            }
        }
    }
}
