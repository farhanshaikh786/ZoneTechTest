Feature: Order
As a Tester 
I want to check end to end functionaltity of site 

 
Scenario: Verify Your logo link exist 
Given Client is navigated to Your logo page 
When Client select T-shirt link
Then Client returns back to Your logo page



Scenario: Verify the E2E site functionality 
Given Client is navigated to Yourlogo Site page
When Client click on Printed Dress  
And Client on Add Chart 
And Client proceed to checkout
And Client to checkout
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



