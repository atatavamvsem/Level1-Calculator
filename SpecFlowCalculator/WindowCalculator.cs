using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    class WindowCalculator
    {
        private static WindowCalculator instance;

        public static WindowCalculator GetInstance()
        {
            if (instance == null)
            {
                instance = new WindowCalculator();
                return instance;
            }
            return instance;
        }

        private Button Add => new Button("Add", "AddButton");
        private Button EqualsOperand => new Button("Equals", "EqualsButton");
        private Button Mr => new Button("Memory recall", "MRButton");
        private Button Ma => new Button("Memory add", "MAButton");
        private Menu Menu => new Menu("View", "ViewButton");
        private Label ResultLabel => new Label("150", "ResultLabel"); 

        private Button GetDigit(string digit)
        {
            return new Button(digit, digit);
        }

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
            Add.Click();
        }

        public void ClickOperandEquals()
        {
            EqualsOperand.Click();
        }

        public void ClickOperandMR()
        {
            Mr.Click();
        }

        public void ClickOperandMA()
        {
            Ma.Click();
        }

        public int GetResult()
        {
            return int.Parse(ResultLabel.GetText());
        }

        public void ChooseView(string typeView)
        {
            Menu.Click();
            GetElementMenu(typeView).Click();
        }

    }
}
