Feature: PetStoreModels

@PetStoreModels
Scenario: Add,Update,Get and Delete a pet from store
	Given Pet <id> added
	When Pet <id> is modified
	And Pet <id> is deleted
	Then Pet <id> is cleared

Examples:
  | id  |
  | 1   |
  | 2   |