using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    internal class BaseElement
    {
        private static Window window = AppManager.GetWindow();

        public static void GetWindow()
        {
            window = AppManager.GetWindow();
        }

        private readonly string criteria;
        private readonly string name;
        public BaseElement(string criteria, String name)
        {
            this.criteria = criteria;
            this.name = name;
        }

        public UIItem GetElementByText()
        {
            return (UIItem)window.Get(SearchCriteria.ByText(this.criteria));
        }

        public void Click()
        {
            GetElementByText().Click();
        }

        public UIItem GetNumber()
        {
            return (UIItem)window.Get(SearchCriteria.ByAutomationId((int.Parse(this.criteria)+130).ToString()));
        }

        public TestStack.White.UIItems.Label GetLabel()
        {
            return window.Get<TestStack.White.UIItems.Label>(SearchCriteria.ByAutomationId(this.criteria));
        }
       
        
    }
}
