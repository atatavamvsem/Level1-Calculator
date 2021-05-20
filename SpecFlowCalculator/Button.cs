using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculator
{
    internal class Button : BaseElement
    {
        public Button(string criteria, string name) : base(criteria, name)
        {
        }
        public void ClickDigit()
        {
            GetNumber().Click();
        }
    }
}
