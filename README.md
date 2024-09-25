# Inventory Management System

## Project Overview
This C# Windows Forms Application provides a simple interface for managing an inventory of items. It allows users to add, update, and delete items from a database, including details such as the item name, category, quantity, price, and manufacturer.

## Features
- **Add Item**: Allows the user to input new inventory items with relevant details.
- **Update Item**: Enables the user to modify existing inventory items.
- **Delete Item**: Provides functionality to remove items from the inventory.

### User Interface Elements
The main form includes the following components:

1. **Item Name**: A text input for the name of the item.
2. **Category**: A dropdown list (ComboBox) to select the item category.
3. **Quantity**: A text input field to enter the number of items in stock.
4. **Price**: A text input for the item's price.
5. **Manufacturer**: A text field for entering the manufacturer of the item.
6. **Buttons**:
   - **Add Item**: Button to add the current details as a new item.
   - **Update**: Button to update the details of an existing item.
   - **Delete**: Button to remove an item from the inventory.
7. **Data Grid**: A grid at the bottom of the form for displaying the current list of items in the inventory.

## Prerequisites
- .NET Framework 4.7.2 or higher
- Visual Studio 2019 or later
- Windows OS

## Getting Started
1. Clone this repository:
   ```bash
   git clone https://github.com/your-repo/inventory-management-system.git
   ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the project to restore dependencies.
4. Run the project by pressing `F5` in Visual Studio.

## Usage
1. Start the application.
2. Enter the details of the inventory item in the provided input fields.
3. Click on **Add Item** to add the new item to the list.
4. To update an item, select it from the list, modify the details, and click **Update**.
5. To delete an item, select it from the list and click **Delete**.

## Project Structure
- **Forms**
  - `Form1.cs`: Contains the main logic for the inventory management system interface and functionality.
  
- **Components**
  - `ComboBox`: For selecting the category.
  - `TextBox`: For entering the item name, quantity, price, and manufacturer.
  - `DataGridView`: For displaying the inventory items.

## Future Improvements
- Implement database storage to save inventory data persistently.
- Add validation for user input.
- Improve UI design for better user experience.
