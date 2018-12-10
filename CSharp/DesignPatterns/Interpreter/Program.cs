using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";

            Context context = new Context(roman);

            List<Expression> list = new List<Expression>();

            list.Add(new ThousandsExpression());
            list.Add(new HundredsExpression());
            list.Add(new DozensExpression());
            list.Add(new UnitExpression());

            foreach (var expression in list)
            {
                expression.Interpreter(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");
            Console.ReadKey();
        }
    }
}
