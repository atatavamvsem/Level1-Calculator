using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly WindowCalculator _calculator = new WindowCalculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.GetResult();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Given(@"click a number (.*)")]
        public void GivenClickANumber(int number)
        {
            _calculator.ClickNumber(number);
        }

        [Given(@"click symbol '(.*)'")]
        public void GivenClickSymbol(string symbol)
        {
            _calculator.ClickSymbol(symbol);
        }

        [Given(@"the user inputs number (\d+) and operand '(.*)'")]
        public void GivenTheUserInputsNumberAndOperand(int number, string operand)
        {
            _calculator.ClickNumber(number);
            _calculator.ClickSymbol(operand);
        }


    }
}