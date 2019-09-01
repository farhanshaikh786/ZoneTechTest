Feature: CreateAccount
As a Tester
I want a create an account
So that I can request the order. 

Scenario Outline: Verify Login functionality with email
Given Client is navigated to Yourlogo Site page 
And Client is click on Sign In
And Client entered the "<Email address>" 
And Client clicked on login button 
Then Client returns back to Home page
Examples: 
| Email address           |
| stuart.roach2@gmail.com | 


Scenario Outline: Verify personal information
Given Client is navigated to Yourlogo Site page
And Client is click on Sign In
And Client entered the "<Email>"
And Client clicked on login button
And Client click Mr on title 
And Client enters "<Firstname>" 
And Client could also add "<Lastname>"
And Client must add "<EmailAddress>"
And Client needs to "<Password>"
And Client enters again "<First name>"
And Client could also add again "<Last name>"
And Client also "<Address>"
And the Client "<City>"
And Client fills in "<State>"
And Client adds the "<Zip/Postal Code>"
And Client "<Country>"
And Client will select "<Mobile phone>"
And Client remember "<Assign an address alias for future reference.>"
Then Submit the Full form



Examples:
| Firstname | Lastname | Email                   | Password | First name | Last name | Address | City   | State   | Zip/Postal Code | Country | Mobile phone | Assign an address alias for future reference. |
| Sam       | Roach    | stuart.roach2@gmail.com | Password | Sam        | Roach     | 123     | Nwport | Newport | Np101GG         | USA     | 0752642654   | ABCD                                          |







