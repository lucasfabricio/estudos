using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 0 && request <= 10)
            {
                Console.WriteLine($"{this.GetType().Name} Handled request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
