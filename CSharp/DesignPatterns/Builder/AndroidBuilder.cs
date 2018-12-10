using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class AndroidBuilder : ICellphone
    {
        Cellphone _cellphone;

        public AndroidBuilder()
        {
            this._cellphone = new Cellphone("Android");
        }

        public void BuildBattery()
        {
            this._cellphone.Battery = "Mah 3000";
        }

        public void BuildCamera()
        {
            this._cellphone.Camera = "15 MP";
        }

        public void BuildDisplay()
        {
            this._cellphone.Display = "5\"";
        }

        public void BuildSystem()
        {
            this._cellphone.System = "Android 8";
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
