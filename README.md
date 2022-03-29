# DnD-character-database
This project is the frontend for a dungeons and dragons character database. The database was built in SQL Server 2017 and has since been retired.

Please see dnd-char-db-presentation.pptx for an detailed explanation of features and the accompanying SQL Server database, including screenshots of the app and db schema.

Features
-Fully implemented user account system with authentication, registration, and password reset
-Character creation menus including race, class, background, spells, and inventory
-Character update including adding and removing spells and inventory items
-Stored proceedures and parameterized stored queries to prevent exposure of password hashes and SQL injection


Goals from Enterprise Statement
-UI application to facilitate usability and keep the database hidden from users
-Characters should be collected in player accounts, requiring account creation and authentication
-During character creation, minimal data should be saved to the character table with most entries consisting of foreign keys to other tables 
-Character creation options should be pulled from the database to maintain consistency and minimize app updates and local storage
-After character creation, data should be viewable and updatable from a centralized database to provide a portable character collection solution


Solution requirements:
-Create and store Dungeons and Dragons characters
-A player has a unique username and passphrase
-A player may have many characters
-A character has one race, class, and background
-A character may have more than one spell or item at their disposal
-Races, classes, backgrounds, spells, and items may belong to more than one character

