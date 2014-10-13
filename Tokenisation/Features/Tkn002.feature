Feature: 02: Logged in customer with one saved cards wants to pay with it
  As a logged in online customer with one saved payment card
  I want to be able to pay with this card
  so that I can complete my order quicker

  Scenario: 01: Card valid
    Given an online customer with one saved payment card that has not expired
	And they add one or more items to their shopping bag
    And they are checking out
    And they log in with their email and password
    When they are presented with payment options
    Then display:
      | card_details       |
      | card type          |
      | masked card number |
      | name on card       |
      | expiry date        |
      | CVV input field    |
    And show the option to input a new payment method
	And do not show the option to choose another existing payment method
    And show the option to make a payment
    And disable this option
    And enable it when the customer inputs three digits of their CVV

  Scenario: 02: Card expired
    Given an online customer with one saved payment card that has expired
	And they add one or more items to their shopping bag
    And they are checking out
    And they log in with their email and password
    When they are presented with payment options
    Then display:
      | card_details       |
      | card type          |
      | masked card number |
      | name on card       |
      | "EXPIRED"          |
    And show the option to input a new payment method
    And show the option to make a payment
    And disable this option

  Scenario: 03: Payment approved
    Given an online customer with one saved payment card that will be approved
	And they add one or more items to their shopping bag
    And they are checking out
    And they log in with their email and password
    When they are presented with payment options
    And they enter the first three digits of their CVV
    When they select the option to make a payment
    And their payment is approved
    Then they are informed that their order has been created

  Scenario: 04: Payment declined
    Given an online customer with one saved payment card that will be declined
	And they add one or more items to their shopping bag
    And they are checking out
    And they log in with their email and password
    When they are presented with payment options
    And they enter the first three digits of their CVV
    When they select the option to make a payment
    Then their payment is declined

