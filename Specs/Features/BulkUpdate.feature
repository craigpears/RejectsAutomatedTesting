Feature: BulkUpdate
	In order to be efficient
	As a supervisor
	I want to be able to bulk add and change rejects

Scenario: I should be able to use bulk update to add packs
	Given I am at the rejects tab
	And There are 0 rejects
	When I bulk update packs 1 - 10 to Good
	And Save Changes
	And Refresh
	Then I should see packs
	| Status  | Pack Number |
	| Good    | 1           |
	| Good    | 2           |
	| Good    | 3           |
	| Good    | 4           |
	| Good    | 5           |
	| Good    | 6           |
	| Good    | 7           |
	| Good    | 8           |
	| Good    | 9           |
	| Good    | 10          |

Scenario: I should be able to use bulk update to override packs
	Given I am at the rejects tab
	And There are rejects
	| Status  | Pack Number |
	| Good    | 1           |
	| Good    | 2           |
	| Good    | 3           |
	| Good    | 4           |
	| Good    | 5           |
	| Good    | 6           |
	| Good    | 7           |
	| Good    | 8           |
	| Good    | 9           |
	| Good    | 10          |
	When I bulk update packs 5 - 8 to Pulled
	And Save Changes
	And Refresh
	Then I should see packs	
	| Status  | Pack Number |
	| Good    | 1           |
	| Good    | 2           |
	| Good    | 3           |
	| Good    | 4           |
	| Pulled  | 5           |
	| Pulled  | 6           |
	| Pulled  | 7           |
	| Pulled  | 8           |
	| Good    | 9           |
	| Good    | 10          |
