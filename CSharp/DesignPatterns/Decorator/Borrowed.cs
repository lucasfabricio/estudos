using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Borrowed : Decorator
    {
        protected List<string> borroweds = new List<string>();

        public Borrowed(LibraryItem libraryItem) 
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            this.borroweds.Add(name);
            this.libraryItem.Copies--;
        }

        public void Return(string name)
        {
            this.borroweds.Remove(name);
            this.libraryItem.Copies++;
        }

        public override void Show()
        {
            base.Show();

            foreach (var item in this.borroweds)
            {
                Console.WriteLine($"\nEmprestado: {item}");
            }
        }
    }
}
