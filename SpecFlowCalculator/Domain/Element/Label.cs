using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    internal class Label : BaseElement
    {
        private readonly string criteria;
        private static Window Window => AppManager.GetWindow(ConfData.GetString("WindowName"));
        private static readonly ResourceManager ConfData = Resources.ConfData.ResourceManager;

        public Label(string criteria, string name) : base(criteria, name)
        {
            this.criteria = criteria;
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
