##User Story : RPN Calculator

##Acceptance Criteria : validate all inputs

Feature: RPN calculation
Scenario Outline: calculate RPN result
	Given <Input>
	Then Output will be <Output>
	
  Examples:
    | Input             | Output |
    | 1,2,3,+,-         | -4     |
    | 6,2,*,3,/         | 4      |
    | 5,1,2,+,4,*,+,3,- | 14     |