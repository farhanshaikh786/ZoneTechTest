Feature: Order
As a Tester 
I want to check end to end functionaltity of site 

@Welsh water Website 
Scenario: Verify Your logo link exist 
Given Client is navigated to Your logo page 
When Client select T-shirt link
Then Client returns back to Your logo page



Scenario: Verify the E2E site functionality 
Given Client is navigated to Your logo website page
When Client click on Printed Dress 
And Client one more quantity 
And Client on Add Chart 
And Client proceed to checkout
Then Client to checkout
