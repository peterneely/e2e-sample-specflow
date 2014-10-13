Feature: 05: Logged in customer manages saved cards

  Scenario: 01: No saved cards
    Given an online customer with no saved payment cards has logged in to their account
    When they view their account details
    Then they should not see payment details

  Scenario: 02: One saved card, not expired
    Given an online customer with one saved payment card that has not expired
    And they log into their account
    And they view their account details
    When they view their payment details
    Then they should see:
      | card_details          |
      | card type             |
      | masked card number    |
      | name on card          |
      | expiry date           |
      | option to remove card |

  Scenario: 03: One saved card, expired
    Given an online customer with one saved payment card that has expired
    And they log into their account
    And they view their account details
    When they view their payment details
    Then they should see:
      | card_details          |
      | card type             |
      | masked card number    |
      | name on card          |
      | "EXPIRED"             |
      | option to remove card |

  Scenario: 04: More than one saved card, none expired
    Given an online customer with at least two saved payment cards, none of which have expired
    And they log into their account
    And they view their account details
    When they view their payment details
    Then they should see:
      | card_details          |
      | card type             |
      | masked card number    |
      | name on card          |
      | expiry date           |
      | option to remove card |
    And they should see which card is the default
    And they should be able to make another card the default

  Scenario: 05: More than one saved card, some expired
    Given an online customer with at least two saved payment cards, some of which have expired
    And they log into their account
    And they view their account details
    When they view their payment details
    Then they should see these details for valid cards:
      | card_details          |
      | card type             |
      | masked card number    |
      | name on card          |
      | expiry date           |
      | option to remove card |
    And they should see these details for invalid cards:
      | card_details          |
      | card type             |
      | masked card number    |
      | name on card          |
      | "EXPIRED"             |
      | option to remove card |
    And they should see which card is the default
    And only valid cards should have the option to make one of them the default

  Scenario: 06: More than one saved card, all expired
    Given an online customer with at least two saved payment cards, all of which have expired
    And they log into their account
    And they view their account details
    When they view their payment details
    Then they should see:
      | card_details          |
      | card type             |
      | masked card number    |
      | name on card          |
      | "EXPIRED"             |
      | option to remove card |
    And they should see which card was the default
    And no other card should have the option to make it the default

  Scenario Outline: 07: Remove valid non-default card
    Given an online customer with at least one saved payment card, at least one of which has not expired
    And they log into their account
    And they view their account details
    And they view their payment details
    And they choose to remove a valid card
    And they see a confirmation message
    When they choose to "<remove_or_not_remove>" it
    Then the message should be dismissed
    And the payment card "<should_or_should_not>" be removed from their account

  Examples:
    | remove_or_not_remove | should_or_should_not |
    | remove               | should               |
    | not remove           | should not           |

  Scenario Outline: 08: Remove valid default card
    Given an online customer with at least one saved payment card, at least one of which has not expired and one of which is the default
    And they log into their account
    And they view their account details
    And they view their payment details
    And they choose to remove the default, valid card
    And they see a confirmation message
    When they choose to "<remove_or_not_remove>" it
    Then the message should be dismissed
    And the payment card "<should_or_should_not>" be removed from their account
    And the newest added non expired card "<should_or_should_not>" become the default

  Examples:
    | remove_or_not_remove | should_or_should_not |
    | remove               | should               |
    | not remove           | should not           |

  Scenario: 09: Remove expired card
    Given an online customer with at least one saved payment card, at least one of which has expired
    And they log into their account
    And they view their account details
    And they view their payment details
    When they choose to remove an expired card
    Then the card should be removed immediately from their account
