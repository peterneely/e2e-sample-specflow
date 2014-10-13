Feature: 03: Logged in customer with saved cards wants to pay with alternative saved card
	As a logged in online customer with two or more saved payment cards
	I want to be able to pay with any of them
	so that I can complete my order quicker

	Scenario: 01: All saved cards are valid
	Given an online customer with at least two saved payment cards, all of which are valid
	And they add one or more items to their shopping bag
	And they are checking out
	And they log in with their email and password
	And they are presented with payment options
	And they select the saved cards option
	Then show:
		| details            |
		| card type          |
		| masked card number |
		| name on card       |
		| expiry date        |
	And show which card is currently selected
	And present an option for the customer to select another saved card
	And when they select another saved card the dialogue is dismissed
	And they see their newly selected payment card

	Scenario: 02: Some saved cards have expired
	Given an online customer with at least two saved payment cards, some of which have expired
	And they add one or more items to their shopping bag
	And they are checking out
	And they log in with their email and password
	And they are presented with payment options
	And they select the saved cards option
	Then show these details for valid cards:
		| details            |
		| card type          |
		| masked card number |
		| name on card       |
		| expiry date        |
	And show these details for invalid cards:
		| details            |
		| card type          |
		| masked card number |
		| name on card       |
		| "EXPIRED"          |
	And show which card is currently selected
	And present an option adjacent to each valid card for the customer to select it as the default payment card
	And when they select another saved card the dialogue is dismissed
	And they see their newly selected payment card

	Scenario: 03: All saved cards have expired
	Given an online customer with at least two saved payment cards, all of which have expired
	And they add one or more items to their shopping bag
	And they are checking out
	And they log in with their email and password
	And they are presented with payment options
	And they select the saved cards option
	Then show these details for each card:
		| details            |
		| card type          |
		| masked card number |
		| name on card       |
		| "EXPIRED"          |

