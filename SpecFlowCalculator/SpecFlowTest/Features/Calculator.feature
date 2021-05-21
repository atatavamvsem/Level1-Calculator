Feature: Calculator

Background: 
Given The calculator is opened

@mytag
Scenario: Calculator test with various view
	Given Calculator is opened in the '<View>' style
	When I enter number 12
		And I sum the number 999
		And I enter operand Memory add
		And I enter number 19
		And I sum with number in memory
	Then The result is 1030
	Examples:
	| View       |
	| Standard   |
	| Scientific |