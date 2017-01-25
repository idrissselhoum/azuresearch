Feature: SearchJob
	In order to find a new job
	as an employee
	I want to search the available jobs based on my request

@HomePage
Scenario: search a new job
	Given I navigate on the home page
	When I have entered Analyst in the request form and press search button
	Then the result shall return at least 1 job






