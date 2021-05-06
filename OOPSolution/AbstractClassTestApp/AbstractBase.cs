using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    abstract class AbstractBase
    {
        protected void ProtectedMeThod()
        {
            Console.WriteLine("AbstractBase.PrivateBaseMeThod() 실행!");
        }
        public void PublicMeThod()
        {
            Console.WriteLine("AbstractBase.PublicMeThod() 실행!");
        }
        public abstract void AbstractMeThod();
    }
}
