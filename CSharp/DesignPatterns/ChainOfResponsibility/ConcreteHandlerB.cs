using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 10 && request < 20)
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
