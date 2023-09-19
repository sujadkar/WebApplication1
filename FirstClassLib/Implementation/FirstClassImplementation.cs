using FirstClassLib.Interface;
using SecondClassLib.Implementation;
using SecondClassLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassLib.Implementation
{
    public class FirstClassImplementation : IFirstClass
    {
        public void SubmitRequest(int hello)
        {
            ISecondClass second = new SecondClassImplementation();
            throw new NotImplementedException();
        }
    }
}
