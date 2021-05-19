using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        [Then("The result is (\\d+)")]
        public void ThenTheResultIs(int result)
        {
            WindowCalculator.GetResult().Should().Be(result);
        }

        [When(@"I enter number (\d+)")]
        public void WhenIEnterNumber(int number)
        {
            WindowCalculator.ClickNumber(number);
        }


        [When(@"I sum the number (\d+)")]
        public void WhenISumTheNumber(int number)
        {
            WindowCalculator.ClickSymbol("Add");
            WindowCalculator.ClickNumber(number);
            WindowCalculator.ClickSymbol("Equals");
        }

        [When(@"I sum with number in memory")]
        public void WhenISumWithNumberInMemory()
        {
            WindowCalculator.ClickSymbol("Add");
            WindowCalculator.ClickSymbol("Memory recall");
            WindowCalculator.ClickSymbol("Equals");
        }

        [When(@"I enter operand (.*)")]
        public void WhenIEnterOperand(string operand)
        {
            WindowCalculator.ClickSymbol(operand);
        }

        [Given(@"I choose the view '(.*)'")]
        public void GivenIOpenTheCalculator(string view)
        {
            WindowCalculator.ChooseView(view);
        }

        [Given(@"I open the calculator")]
        public void GivenIOpenTheCalculator()
        {
            AppCalculator.GetCalculator();
        }

        [Then(@"The calculator is opened")]
        public void ThenTheCalculatorIsOpened()
        {
            AppCalculator.IsOpened().Should().Be(true);
        }

    }
}