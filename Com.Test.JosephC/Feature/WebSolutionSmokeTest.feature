Feature: WebSolutionSmokeTest
	Simple calculator for adding two numbers

@mytag

Scenario: Order TShirt View Order in History
	Given The user has launched the website 
	And   The user enter their credentials if not already logged in
	And   The user clicks the Tshirt button on the navigation bar 
	And   The user selects a tshirt displayed and proceeds to checkout 
	And   The user completes all mandatory fields in order to successfully checkout
	Then  The user should successfully be able to view their order in the order history section

Scenario: Update Personal Information First Name in My Account
	Given The user has launched the website 
	And   The user enter their credentials if not already logged in
	And   The user clicks their name in the top right of the screen 
	And   The user updates their first name 
	Then  The website should successfully update with the changes 


