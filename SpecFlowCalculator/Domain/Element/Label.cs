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
        private static Window Window => AppManager.GetWindow();

        public Label(string criteria, string name) : base(criteria, name)
        {
        }

        public string GetText()
        {
            return GetLabel().Text;
        }

        public TestStack.White.UIItems.Label GetLabel()
        {
            return Window.Get<TestStack.White.UIItems.Label>(SearchCriteria.ByAutomationId(this.criteria));
        }
    }
}
