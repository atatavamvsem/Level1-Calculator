using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    class WindowCalculator
    {
        private readonly Window _window = Calculator.GetWindow();

        public void ClickNumber(int number)
        {
            foreach (char ch in number.ToString())
            {
                Button btn1 = _window.Get<Button>(SearchCriteria.ByText(ch.ToString()));
                btn1.Click();
            }
        }

        public void ClickSymbol(string operand)
        {
            Button btn1 = _window.Get<Button>(SearchCriteria.ByText(operand.ToString()));
            btn1.Click();
        }

        public int GetResult()
        {
            Label resultLabel = _window.Get<Label>(SearchCriteria.ByAutomationId("150"));
            return int.Parse(resultLabel.Text);
        }
    }
}
