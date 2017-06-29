Feature: Add Rejects
	In order to record rejects
	As an operator
	I want to be able to add rejects

Scenario: Should be able to see a pack after adding one pack
	Given I am at the rejects tab
	And There are 0 rejects
	When I add 1 pack
	Then the result should be 1 pack on the screen

Scenario: Should be able to see multiple packs after adding multiple packs
	Given I am at the rejects tab
	And There are 0 rejects
	When I add 2 packs
	Then the result should be 2 packs on the screen

Scenario: Add single pack should persist after saving
	Given I am at the rejects tab
	And There are 0 rejects
	When I add 1 pack
	And Save Changes
	And Refresh
	Then the result should be 1 pack on the screen

Scenario: After adding multiple packs, they should be removed if I refresh before saving changes
	Given I am at the rejects tab
	And There are 0 rejects
	When I add 2 packs
	And Save Changes
	And Refresh
	Then the result should be 2 packs on the screen

Scenario: After adding a single pack, it should be removed if I refresh before saving changes
	Given I am at the rejects tab
	And There are 0 rejects
	When I add 1 pack
	Then the result should be 1 pack on the screen
	When I Refresh
	Then the result should be 0 pack on the screen

Scenario: Adding multiple packs should be removed when refreshing if not saved
	Given I am at the rejects tab
	And There are 0 rejects
	When I add 2 packs
	Then the result should be 2 packs on the screen
	When I Refresh
	Then the result should be 0 pack on the screen

Scenario: I should be able to specify the pack number correctly for each pack
	Given I am at the rejects tab
	And There are 0 rejects
	When I add packs
	| Pack Number |
	| 1           |
	| 2           |
	And Save Changes
	And Refresh
	Then I should see packs
	| Status | Pack Number |
	| Bad    | 1           |
	| Bad    | 2           |
