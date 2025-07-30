using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Sealed
{
    internal class TypeA
    {
        public virtual int A { get; set; }

        public virtual void Myfun()
        {
            Console.WriteLine("My Fun From TypeA");
        }
    }
}
