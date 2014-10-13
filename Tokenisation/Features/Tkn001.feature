Feature: 01A: Logged in customer with no saved cards pays with valid card
  As a logged in online customer with no saved payment cards
  I want to be able to save my card details when I am paying with a valid card
  so that I can complete my next online order quicker

  Background: Customer pays with valid card
    Given an online customer with no saved payment cards adds one or more items to their shopping bag
    And they checkout
    And they login with their email and password
    And they are presented with payment options
    And they select to pay by card
    And they see the default form for entering new payment card details
	And they input valid card details
    And an option to save their card details is not selected
	
  Scenario: 01: Card saved when option selected
    And they select the option to save their card details
    When they submit payment
    And payment is approved
    Then the card details are saved to their account as the default payment card
    And they are informed that their order has been created and their details have been saved

  Scenario: 02: Card not saved when option not selected
    When they submit payment
    And payment is approved
    Then the card details are not saved to their account
    And they are informed that their order has been created
