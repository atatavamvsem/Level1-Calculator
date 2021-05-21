using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    internal class Digit : BaseElement
    {
        private static readonly ResourceManager ConfData = Resources.ConfData.ResourceManager;

        private static Window Window => AppManager.GetWindow();
        public Digit(string criteria, string name) : base(criteria, name)
        {
        }

        public void ClickDigit()
        {
            GetDigit().Click();
        }

        public UIItem GetDigit()
        {
            return (UIItem)Window.Get(SearchCriteria.ByAutomationId((int.Parse(this.criteria) + int.Parse(ConfData.GetString("DeltaDigitId"))).ToString()));
        }
    }
}
