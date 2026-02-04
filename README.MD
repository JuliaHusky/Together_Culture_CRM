# Together Culture CRM System

University **second-year group project** focused on designing and implementing a **Customer Relationship Management (CRM) system** for *Together Culture*.

## Components Developed Individually

- Login page  
- Register page  
- Account settings  
- Event management  
- Create event functionality  
- Constants class  
- MySQL database connection (`MySQLdb`)  
- Database validation (`DbValidation`)  

---

## System Requirements

- **.NET Framework:** 4.7.2  
- **NuGet Package:** `MySql.Data` version **9.1.0**  
- **Database:** MariaDB  
- **Database Management Tool:** phpMyAdmin (version **5.2.1**)  

---

## Database Configuration

The application uses a MySQL/MariaDB database.

### Default Connection String
```text
Server=localhost;Database=tc_crm;User=root;```

Please modify in classes: MySQLdb and Database if different

---

## Login Details for Testing Purposes

Password hashing has been applied to the database:
For testing purposes the dummy account sign-ins are:
email= 1 & password= 1 for userID = 1 
email= 2 & password= 2 for userID = 2 
email= 3 & password= 3 for userID = 3 




