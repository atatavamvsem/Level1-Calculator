
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
        private static Window Window => AppManager.GetWindow();
        //Logger logger = LogManager.GetCurrentClassLogger();
        public readonly string criteria;
        private readonly string name;

        public BaseElement(string criteria, String name)
        {
            this.criteria = criteria;
            this.name = name;
        }

        public UIItem GetElementByText()
        {
            //logger.Trace("trace message");
            return (UIItem)Window.Get(SearchCriteria.ByText(this.criteria));
        }

        public void Click()
        {
            GetElementByText().Click();
        }
    }
}
