using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAc4y.Class;


namespace CSAc4yLibraryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Ac4yContext())
            {
                var a = new Ac4y();

                ctx.Ac4ys.Add(a);
                ctx.SaveChanges();
            }
        }
    }
}
