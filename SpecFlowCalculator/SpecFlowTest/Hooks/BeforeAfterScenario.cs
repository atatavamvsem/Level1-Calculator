using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Hooks
{
    [Binding]
    public sealed class BeforeAfterScenario
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            AppManager.CloseAllInstants();
            AppManager.GetApplication();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            AppManager.Close();
        }
    }
}
