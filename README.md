SQL COMPILER

This project is a simple SQL compiler developed using C#. It allows users to run SQL queries by retrieving data from tables in the selected database. The application is designed with an easy-to-use interface and includes the following features:

Features
- Database Selection: A combo box on the main form allows the user to select from available databases.
- Table Listing: The tables of the selected database are displayed on the second combo box.
- Query Writing and Execution: Users can create their SQL queries using a text box.
- Result Display: The results of the executed SQL query are shown in a DataGridView on the application screen.
- About SQL Page: Clicking the About SQL button opens a form providing information about SQL queries. Additionally, a link at the bottom of the form redirects the user to the source of the information. For more information, visit the [source here](https://www.w3schools.com/sql/sql_syntax.asp).

Usage
- Run the application.
- Select a database from the first combo box.
- Choose a table from the second combo box that corresponds to the selected database.
- Write the SQL query in the query text box and press the "Execute Query" button.
- Watch the results displayed in the DataGridView.
- Use the Clear button to clear the query before moving to another query or database.

Requirements
- .NET Framework.
- An appropriate SQL Server or database driver for database connection.
