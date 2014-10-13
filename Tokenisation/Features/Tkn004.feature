Feature: 04: Logged in customer with saved cards wants to pay with new card
  As a logged in online customer with one or more saved payment cards
  I want to be able to add another
  so that I can pay with the correct card

  Scenario Outline: 01: Customer wants to pay with new card
    Given an online customer with "<number>" saved payment card adds one or more items to their shopping bag
    And they are checking out
    And they log in with their email and password
    And they are presented with payment options
    When they select the new payment method
    Then they see the default form for entering new payment card details
    And they must be presented with the option to save their card details
    And this option is selected by default
    And "<show_or_hide>" the option to select another saved card
    And the option to make a payment is enabled only when required form fields are completed

  Examples:
    | number | show_or_hide |
    | 1      | hide         |
    | 2      | show         |
    | 3      | show         |

  Scenario Outline: 02: Customer pays with new card and wants to save it
    Given an online customer with at least one saved payment cards adds one or more items to their shopping bag
    And they checkout
    And they login with their email and password
    And they are presented with payment options
    And they select the new payment method
    And they see the default form for entering new payment card details
    And an option to save their card details is selected
    And they complete all required form fields
    When they select the option to make a payment
    And their payment is "<response>"
    Then the card details are "<saved_or_not>" to their account as the default payment card
    And they are informed that "<message>"

  Examples:
    | response | saved_or_not | message                                                        |
    | approved | saved        | their order has been created and their details have been saved |
    | declined | not saved    | their payment has been declined                                |

  Scenario Outline: 03: Customer pays with new card but does not want to save it
    Given an online customer with at least one saved payment cards adds one or more items to their shopping bag
    And they checkout
    And they login with their email and password
    And they are presented with payment options
    And they select the new payment method
    And they see the default form for entering new payment card details
    And an option to save their card details is selected
    And they de-select this option
    And they complete all required form fields
    When they select the option to make a payment
    And their payment is "<response>"
    Then the card details are not saved to their account
    And they are informed that "<message>"

  Examples:
    | response | message                         |
    | approved | their order has been created    |
    | declined | their payment has been declined |
