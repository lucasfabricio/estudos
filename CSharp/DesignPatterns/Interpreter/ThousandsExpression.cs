using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class ThousandsExpression : Expression
    {
        public override string Five()
        {
            return "D";
        }

        public override string Four()
        {
            return " ";
        }

        public override int Multiply()
        {
            return 1000;
        }

        public override string Nine()
        {

            return " ";
        }

        public override string One()
        {
            return "M";
        }
    }
}
