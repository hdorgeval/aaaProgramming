Feature: IsNullOrEmpty
	In order to avoid manipulating a null or empty string
	As a C# developper
	I want to be able to check once either of these states on any string object


Scenario: Should return true When Input string is null
	Given an input string object whose value is null
	When I call IsNullOrEmpty on this string
	Then the result should be true

Scenario: Should return true When Input string is empty
	Given an input string object whose value is empty
	When I call IsNullOrEmpty on this string
	Then the result should be true



