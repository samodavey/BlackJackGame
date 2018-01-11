Feature: MainPage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@MainPage
Scenario: Enter Name and Join a room
	Given I have loaded the mainpage
	When I enter a player name
	When I join a room
	Then I see my player name on the main game
	Then I close the browser
