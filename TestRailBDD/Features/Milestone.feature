Feature: Milestone

Background: 
	Given The user entered the admin login and password

@GUI @Admin
Scenario: Add milestone
	Given The user navigated to the project milestones
	When The user added the milestone
	* filled the milestone data
	Then a success added message was displayed

@GUI @Admin
Scenario: Edit milestone
	Given The user navigated to the project milestones
	When The user clicked Milestones menu
	* the user clicked Edit milestone
	* changed milestone title
	Then a success updated message was displayed

@GUI @Admin
Scenario: Delete milestone
	Given The user navigated to the project milestones
	When The user clicked Milestones menu
	* the user deleted milestone
	Then a success deleted message was displayed