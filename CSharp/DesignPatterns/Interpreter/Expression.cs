﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public abstract class Expression
    {
        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiply();

        public void Interpreter(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiply());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiply());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiply());
                context.Input = context.Input.Substring(1);
            }
            else if (context.Input.StartsWith(Nine()))
            {
                context.Output += (1 * Multiply());
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One()))
            {
                context.Output += (1 * Multiply());
                context.Input = context.Input.Substring(1);
            }
        }
    }
}
