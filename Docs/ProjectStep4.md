Feature: Individual User Accounts

### Gives the application a way to differentiate between separate users.
	-Individual users have their own repository of recipes, stored on user hard drive
	-Stretch Goal: Cloud Storage for recipes, to prevent any conceivable "cost" to the user, in terms of memory.
	
	Scenario:
		-A new user attempts to use the application.
		-Given the user has an email address.
		-Then the user is prompted to Sign In (previous users) or Sign Up (new users).
		-Given the user does not have an account previously.
		-Then the user signs up with their email address.
		-Then the application prompts the user to pick a "User Name."
		-Then the application prompts the user to generate a Password.
		-Given that no previous instance of the User Name is saved
		 locally, the User Name is saved for future sign ins.
			-Stretch Goal: Online Accounts for remote log in, User Names
			 will have to be re-selected to determine individuality
		
Feature: Print Function

### Utilizes the built in functionality of many popular cooking websites, which have a "Print" button located on individual recipes. The application will act as a PDF Printer, and save the recipe to the user's hard drive in PDF format for later utilization.

	Scenario:
		-A user searches the web for a new recipe.
		-Given the recipe the user decides upon has a 'print' button on
		 the webpage.
		-Then the user clicks Print, and selects the application as their
		 designated printer.
		-Then the application will prompt the user to generate a name for the recipe file to be saved under.
		-Then the application prints the recipe in PDF format to a
		 designated repository on the User Hard Drive.
		-Then the application prompts the user to add any applicable 'Tags' to the recipe.
		
Feature: User Tags

### Short Descriptors that can be applied by the user at any time to add more descriptors, by which the user may search or sort individual or groups (by tag) recipes

	Scenario:
		-Given a user has just printed a recipe to their memory repository.
		-Then the application prompts the user to add any applicable 'Tags' to the recipe.
		-Then the user can add any descriptors they feel apply (i.e. 'tasty', 'cheap', 'easy to make')
		-Then the application applies the tags to the recipe for future
		 search queries, and sorting into lists.
		 
Feature: List Generation

### Allows the user to group and save lists of previously saved recipes for recalling later as a unit.

	Scenario:
		-The user has multiple recipes that they would like to group together for future use. They are bringing together a list for all the dishes for 'Thanksgiving Dinner' in this case. 
		-The user selects "Create List" from the front page of the application.
		-Then the application prompts the user to create a List name.
		-Then the application prompts the user to select recipes (via Search functionality) to add to the new list. 
		
Feature: Search Function

### Allows the user to browse their recipe collection by using a search bar to search through their repository by either Save File name or user applied Tags.

	Scenario:
		-The user is looking for a recipe tagged with the 'Fast Cooking Time' Tag to make a quick dinner.
		-by typing 'Fast Cooking Time' the search function will return all recipes tagged with the 'Fast Cooking Time' tag, separated by the Save File Name.
		 
		