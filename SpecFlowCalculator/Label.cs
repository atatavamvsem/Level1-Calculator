using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    internal class Label : BaseElement
    {
        public Label(string criteria, string name) : base(criteria, name)
        {
        }

        public string GetText()
        {
            return GetLabel().Text;
        }
    }
}
