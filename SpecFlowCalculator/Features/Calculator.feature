Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the user inputs number 12 and operand 'Add'
	* the user inputs number 999 and operand 'Equals'
	* click symbol 'Memory add'
	* the user inputs number 19 and operand 'Add'
	* click symbol 'Memory recall'
	* click symbol 'Equals'
	When the two numbers are added
	Then the result should be 1030