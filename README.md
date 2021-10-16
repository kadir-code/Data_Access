# Data_Access
> Data access is a computer program that simply provides access to data stored in a consistent repository, an example of an entity-relationship database to this consistent repository.

## ORM
Object-Relational Mapping (ORM) is a technique that allows you to query and manipulate data from a database using the Object-oriented paradigm. It acts as a bridge between the database and the application. It is a structure that performs all database operations without the need for the application to access the database directly, by converting the tables in the database to classes, columns to properties, and records to objects.

<img src="https://miro.medium.com/max/2678/0*hPIVHv2kP28zTbvb.png" style="height: 300px; width:700px;"/>

### Advantages of using an ORM

* It gives the opportunity to write code in accordance with object-oriented programming standards.
* It provides the opportunity to perform database operations with minimum SQL knowledge.
* There is no database platform dependency.
* It reduces the time to write code.
* Increases code readability.

### Disadvantages of using an ORM
* It is slower in performance compared to manual coding.
* Since the database is modeled on objects, there is a connection between objects. There is a situation where the connection is disrupted by unconscious interventions.
* For first-time beginners, the syntax may be different.

### An ORM use case

* With hand coding
```
string sql = "SELECT FirstName FROM Accounts WHERE Id = 7";
DbCommand cmd = new DbCommand(connection, sql);
Result result = cmd.Execute();
string firstName = result[0]["FirstName"];
```
* With using an ORM tool
```
Account user = repository.GetAccount(7);
string name= user.FirstName;
```

### Frequently used ORM technologies by language
* C#: Entity Framework,  Dapper, ECO, XPO, Norm
* Java: Hibernate, Ebean, Torque, JPA,MyBattis
*Php: CakePHP, Codelgniter, RedBean, Doctrine,Propel, PdoMap
* Python: Django, South,Storm

## Entity Framework
Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is stored. With the Entity Framework, developers can work at a higher level of abstraction when they deal with data, and can create and maintain data-oriented applications with less code compared with traditional applications.

![alt text for screen readers](https://miro.medium.com/max/770/1*iKXY29vQETRAuxWOLSbq0w.jpeg "Text to show on mouseover").

## Entity Approaches

### 1. Database First
In this approach, the priority is on the database. First, the database is created, then the coding side is started.
### 2. Code First
Bu yaklaşımda design işlemlerinden çok kod yazma ön plandadır. Veritabanı işlemleri design işlemleri olarak değilde kod yazarak gerçekleştirilir. Geliştirici veritabanıyla ilgili tüm işlemleri kodlayarak oluşturur. Bu yaklaşımda hakimiyet tamamen sizdedir.
### 3. Model First
If you don't have a database, you can create a model directly from visual studio. In order to introduce the changes we have made here to sql, we need to click generate database from.

## Dapper
Dapper is a simple object mapper for .NET and owns the title of King of Micro ORM in terms of speed and is virtually as fast as using a raw ADO.NET data reader. An ORM is an Object Relational Mapper, which is responsible for mapping between database and programming language.


![alt text for screen readers](https://z2c2b4z9.stackpathcdn.com/images/logo256X256.png "Text to show on mouseover")



### How Dapper Works?
It is a three-step process.

* Create an IDbConnection object.
* Write a query to perform CRUD operations.
* Pass query as a parameter in the Execute method.














