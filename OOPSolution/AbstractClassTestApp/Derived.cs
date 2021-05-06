using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    class Derived : AbstractBase
    {
        public override void AbstractMeThod()
        {
            Console.WriteLine("Derived.AbstractMeThod() 실행!");
            base.ProtectedMeThod();
        }
    }
}
