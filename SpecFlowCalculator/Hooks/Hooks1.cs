using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.Bricks;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.InputDevices;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Configuration;
using TestStack.White.UIItems;
using TestStack.White.WindowsAPI;

namespace SpecFlowCalculator.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            AppCalculator.CloseAllInstants();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            AppCalculator.Close();
        }
    }
}
