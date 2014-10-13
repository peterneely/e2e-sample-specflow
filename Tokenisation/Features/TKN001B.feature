Feature: 01B: Logged in customer with no saved cards pays with invalid card
  As a logged in online customer with no saved payment cards
  I want to be notified when I am paying with an invalid card
  so that I can enter another card and check out quicker next time

  Scenario Outline: 01: Card not saved when payment declined
    Given an online customer with no saved payment cards adds one or more items to their shopping bag
    And they checkout
    And they login with their email and password
    And they are presented with payment options
    And they select to pay by card
    And they see the default form for entering new payment card details
	And they input invalid card details
    And an option to save their card details is not selected
    And they "<select_or_not_select>" that option
    When they submit payment
    And payment is declined
    Then the card details are not saved to their account

  Examples:
    | select_or_not_select |
    | select               |
    | do not select        |
