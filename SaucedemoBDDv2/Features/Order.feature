Feature: Order

@GUI @StandartUser
Scenario: Make successfull order
	Given The user logged in with standart credentinals
	* The user opened the product catalogue page
	* The shopping cart is empty
	When The user added one item to the shopping cart
	* Went to the shopping cart
	* Went to checkout
	* Filled user data FIRSTNAME "Test", LASTNAME "Test" AND POSTAL_CODE "12578"
	* Went to second step checkout
	* Went to third step checkout
	Then Order is completed
