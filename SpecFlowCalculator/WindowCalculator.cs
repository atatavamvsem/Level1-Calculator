using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    class WindowCalculator
    {
        private static readonly Window Window = AppCalculator.GetWindow();

        public static void ClickNumber(int number)
        {
            foreach (var ch in number.ToString())
            {
                Window.Get<Button>(SearchCriteria.ByText(ch.ToString())).Click();
            }
        }

        public static void ClickSymbol(string operand)
        {
            Window.Get<Button>(SearchCriteria.ByText(operand.ToString())).Click();
        }

        public static int GetResult()
        {
            return int.Parse(Window.Get<Label>(SearchCriteria.ByAutomationId("150")).Text);
        }

        public static void ChooseView(string view)
        {
            Window.Get<Menu>(SearchCriteria.ByText("View")).Click();
            Window.Get<Menu>(SearchCriteria.ByText(view)).Click();
        }
    }
}
