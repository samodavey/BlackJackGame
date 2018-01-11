Feature: BlackjackGame
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@BlackjackGame
Scenario: I am able to make a bet
	Given I have loaded the mainpage
	When I enter a player name
	When I join a room
	And I make a bet of 50 pounds
	Then I can see my current bet of 50 pounds
	Then I close the browser

@BlackjackGame
Scenario: I am able to deal a hand
	Given I have loaded the mainpage
	When I enter a player name
	When I join a room
	And I make a bet of 50 pounds
	And I can deal a hand
	Then I can see my cards have been dealt
	Then I close the browser

@BlackjackGame
Scenario: I am able to hit for another card
	Given I have loaded the mainpage
	When I enter a player name
	When I join a room
	And I make a bet of 50 pounds
	And I can deal a hand
	Then I hit for another card
	Then I close the browser

@BlackjackGame
Scenario: I am able to stand
	Given I have loaded the mainpage
	When I enter a player name
	When I join a room
	And I make a bet of 50 pounds
	And I can deal a hand
	Then I stand
	Then I close the browser