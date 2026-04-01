Problem Statement: Enterprise Pricing Calculator System
An Enterprise retail company requires a simple web-based system to calculate the final price of items purchased by a customer. The system must follow standard business rules used in real-world financial systems.
You have been assigned as a junior developer to build this system using ASP.NET MVC.
The system must allow a user to enter a subtotal amount and automatically calculate the final amount based on the following rules:
•	VAT is 15%
•	A promotional discount of 7.5% is applied before VAT
•	The final amount must be rounded to two decimal places

System Requirements
Your ASP.NET MVC application must:
1.	Accept a subtotal amount from the user.
2.	Calculate:
•	Discount amount
•	VAT amount
•	Final total after discount and VAT
3.	Display all calculated values clearly on the screen.
4.	Use banker’s rounding (round half to even) to two decimal places.
5.	Store all transaction results in a Local SQL Database (LocalDB).

Technical Requirements
•	Use ASP.NET MVC
•	Use Entity Framework (Code First or Database First)
•	Use Local SQL DB (LocalDB)
•	Create a table such as:
•	TransactionID
•	Subtotal
•	Discount
•	VAT
•	FinalTotal
•	Date

Submission Requirements
Before submitting your project, you must:
1.	Generate and include the database script
2.	Ensure your project runs correctly.
3.	Include all source code and database files.



