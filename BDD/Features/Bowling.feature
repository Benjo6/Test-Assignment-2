Feature: Bowling

A short summary of the feature

Scenario: Test Gutter Game
	Given player start a new game
	When player roll everytime in the gutter
	Then the result should be 0
	
Examples:
	| score                         | result |
	| --,--,--,--,--,--,--,--,--,-- | 0      |

Scenario: Test All Ones
	Given player start a new game
	When the player hit one pin every roll
	Then the result should be 20

Examples:
	| score                         | result |
	| 11,11,11,11,11,11,11,11,11,11 | 20     |


Scenario: Test One Spare
	Given player start a new game
	When player did a score with one spare
	Then the result should be 67

Examples:
	| score                         | result |
	| 5/,33,33,33,33,33,33,33,33,33 | 67     |

Scenario: Test One Strike
	Given player start a new game
	When player did a score with one strike
	Then the result should be 50

Examples:
	| score                        | result|
	| x,22,22,22,22,22,22,22,22,22 | 50    |

Scenario: Test Perfect Game
	Given player start a new game
	When player had a perfect game
	Then the result should be 300

Examples:
	| score                          | result  |
	| xx,xx,xx,xx,xx,xx,xx,xx,xx,xxx | 300     |
