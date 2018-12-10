using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class LibraryItem
    {
        public int Copies { get; set; }

        public abstract void Show();
    }
}
