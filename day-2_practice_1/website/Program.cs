using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Site
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Register(1239945,"MARY","9994394123","HOUSE no.12","mary123",new DateTime(1994,6,12),"Female");
            C1.Display();


        }
    }
}
