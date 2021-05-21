using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    public class WindowCalculator
    {
        private Button AddButton => new Button("Add", "AddButton");
        private Button EqualsButton => new Button("Equals", "EqualsButton");
        private Button MrButton => new Button("Memory recall", "MRButton");
        private Button MaButton => new Button("Memory add", "MAButton");
        private Menu MenuButton => new Menu("View", "ViewButton");
        private Label ResultLabel => new Label("150", "ResultLabel"); 

        private Digit GetDigit(string digit) => new Digit(digit, digit);

        private Menu GetElementMenu(string typeView)
        {
            return new Menu(typeView, typeView); 
        }

        public void ClickNumber(int number)
        {
            foreach (var ch in number.ToString())
            {
                GetDigit(ch.ToString()).ClickDigit();
            }
        }

        public void ClickOperandAdd()
        {
            AddButton.Click();
        }

        public void ClickOperandEquals()
        {
            EqualsButton.Click();
        }

        public void ClickOperandMR()
        {
            MrButton.Click();
        }

        public void ClickOperandMA()
        {
            MaButton.Click();
        }

        public int GetResult()
        {
            return int.Parse(ResultLabel.GetText());
        }

        public void ChooseView(string typeView)
        {
            MenuButton.Click();
            GetElementMenu(typeView).Click();
        }

    }
}
