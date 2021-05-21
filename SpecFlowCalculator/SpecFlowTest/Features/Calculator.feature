Feature: Calculator

Background: 
Given The calculator is opened

@mytag
Scenario: Calculator test with various view
	Given I choose the view '<View>'
	When I enter number 12
	* I sum the number 999
	* I enter operand Memory add
	* I enter number 19
	* I sum with number in memory
	Then The result is 1030
	Examples:
	| View       |
	| Standard   |
	| Scientific |