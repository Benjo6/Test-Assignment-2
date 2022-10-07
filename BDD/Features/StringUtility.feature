Feature: StringUtility

A short summary of the feature

Scenario: Test Lowercase String
	Given the text string is "AbCdE"
	When I request the conversion of every letter in the text into lowercase
	Then the result of the conversion to lowercase will be "abcde"

Scenario: Test Uppercase String
	Given the text string is "AbCdE"
	When I request the conversion of every letter in the text into uppercase
	Then the result of the conversion to uppercase will be "ABCDE"

Scenario: Test Reverse String
	Given the text string is "AbCdE"
	When I request the reseravtion of the text
	Then the result of the reservation will be "EdCbA"
