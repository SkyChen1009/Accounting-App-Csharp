# Accounting App
## Overview
This Accounting App allows users to track their income and expenses by categorizing them under various types, providing a simple UI for input and a straightforward record display interface.

## Requirements
- Windows Forms
- .NET Framework
- Basic knowledge of C#

## Project Structure
The main components include:

- Form1: Main entry form for user login.
- Form2: User dashboard for managing categories.
- Form3: Form for adding new records.
- Form4: Form for displaying existing records with filtering options.

## Classes and Components
### Categories
Handles predefined categories for income and expenses, such as "Food," "Transportation," "Entertainment," etc.

### Records
Manages the list of records, each representing a single transaction with attributes like date, category, and amount.

## Detailed Form Descriptions
- Login Form (Form1)
  - Purpose: Enables users to log in or create an account.
  - Functionality:
    - Reads and stores user credentials from User.txt.
    - Checks if the username exists; if not, prompts for account creation.
    - Verifies password correctness and proceeds to the main menu upon successful login.
    - 
- Main Menu Form (Form2)
  - Purpose: Acts as the main navigation interface.
  - Functionality:
    - Greets the user and loads the user's personal transaction history.
    - Provides options to add a new transaction (opens Form3), view records (opens Form4), or exit the application.
    - Upon exiting, saves the updated transaction list to a file named after the user's username.

- Add New Record (Form3)
  - Purpose: Enables users to add new records by selecting from a list of categories and subcategories, inputting an amount, and providing additional details.
  - Functionality:
    - Initializes the form with default date settings.
    - Validates and saves a new transaction record based on user input, categorizing it appropriately.
    - Dynamically stores selected button text for easy reference and categorization.
   
- View and Filter Records (Form4)
  - Purpose: Displays a list of records and allows filtering based on category.
  - Functionality:
    - Provides a nested structure for filtering:
      - 支出 (Expenses):
        - 食物 (Food): Breakfast, Lunch, Dinner, Snacks, Drinks, Night Meals, etc.
        - 交通 (Transportation): Gas, Bus, Metro, Train, etc.
        - 娛樂 (Entertainment): Movies, Clothing, Travel, etc.
        - 生活 (Living): Rent, Utilities, Telecom.
      - 收入 (Income): Salary, Bonus, and others.
     
## Data Storage and Management
The app stores user credentials in User.txt, while each user’s transaction records are saved in a separate text file, named according to the username. Transaction records include the category, description, amount, and timestamp.
