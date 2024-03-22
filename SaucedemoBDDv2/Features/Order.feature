Feature: Order

@GUI @StandartUser
Scenario: Make successfull order
	Given The user logged in with standart credentinals
	* The user opened the product catalogue page
	* The shopping cart is empty
	When The user added one item to the shopping cart
	* Navigated to the shopping cart
	* Navigated to checkout
	* Filled user data FIRSTNAME "Test", LASTNAME "Test" AND POSTAL_CODE "12578"
	* Navigated to second step checkout
	* Navigated to third step checkout
	Then Order is completed
