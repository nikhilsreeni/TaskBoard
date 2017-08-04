Feature: Backlog Data list
	In order to access taskboard
	As application Administractor
	I want to see the tasks available


Scenario: Get all the backlogs available
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
