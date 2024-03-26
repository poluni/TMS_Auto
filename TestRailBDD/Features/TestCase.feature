Feature: TestCase

Background: 
	Given The user entered the admin login and password

@GUI @Admin
Scenario Outline: Add test case
	Given The user navigated to the project test cases
	When The user clicked Add test case
	* filled the test case data: <Name>
	Then a success test case added message was displayed
	Examples:
          | Name             |
          | TestCaseName1    |

@GUI @Admin
Scenario: Edit test case
	Given The user navigated to the project test cases
	When The user selected test case
	* the user clicked Edit test case
	* changed test case title
	Then a success test case updated message was displayed

@GUI @Admin
Scenario: Delete test case
	Given The user navigated to the project test cases
	When The user selected test case
	* the user deleted test case
	Then a test case was deleted
