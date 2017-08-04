@UserHooks
Feature: User management functionalities 

Background:
 Given Database connection is present


Scenario Outline: User Insert and Get
Given User details with username as <UserName>, password as <Password> and  dateofbirth as <DateOfBirth>
When I save
Then value shoud be saved to database
Examples: 
| UserName | Password  | DateOfBirth |
| test1    | test1pass | 21-11-1998  |
| test2    | test2pass | 11-07-2012  |
