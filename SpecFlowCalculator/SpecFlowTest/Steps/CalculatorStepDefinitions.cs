using FluentAssertions;
using System.Resources;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private static readonly ResourceManager ConfData = Resources.ConfData.ResourceManager;
        private static readonly WindowCalculator window = new WindowCalculator(); 

        [Then("The result is (\\d+)")]
        public void ThenTheResultIs(int result)
        {
            window.GetResult().Should().Be(result);
        }

        [When(@"I enter number (\d+)")]
        public void WhenIEnterNumber(int number)
        {
            window.ClickNumber(number);
        }

        [When(@"I sum the number (\d+)")]
        public void WhenISumTheNumber(int number)
        {
            window.ClickOperandAdd();
            window.ClickNumber(number);
            window.ClickOperandEquals();
        }

        [When(@"I sum with number in memory")]
        public void WhenISumWithNumberInMemory()
        {
            window.ClickOperandAdd();
            window.ClickOperandMR();
            window.ClickOperandEquals();
        }

        [When(@"I enter operand Memory add")]
        public void WhenIEnterOperandMemoryAdd()
        {
            window.ClickOperandMA();
        }

        [Given(@"I choose the view '(.*)'")]
        public void GivenIOpenTheCalculator(string view)
        {
            window.ChooseView(view);
        }

        [Given(@"The calculator is opened")]
        public void GivenTheCalculatorIsOpened()
        {
            AppManager.GetWindowName().Should().Be(ConfData.GetString("WindowName"));
        }

    }
}