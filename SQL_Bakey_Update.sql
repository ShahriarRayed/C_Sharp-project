CREATE DATABASE Rodelicious;

DROP DATABASE Rodelicious;

use Rodelicious;

CREATE TABLE Ingredient (
    IngredientID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Unit NVARCHAR(50) NOT NULL,
    QuantityAvailable FLOAT NOT NULL,
    ReorderLevel FLOAT NULL,
    CostPerUnit FLOAT NOT NULL
);

INSERT INTO Ingredient(Name, Unit, QuantityAvailable, ReorderLevel, CostPerUnit)
values('EGG', 'pcs', '30','5' , '12.5');



select* from Products;
SELECT * FROM Ingredient
SELECT * FROM PRODUCTS;


CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(MAX) NULL
);

CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
	Quantity INT NOT NULL,
	UnitPrice INT NOT NULL,
    TotalAmount FLOAT NULL
   
);

ALTER TABLE Orders 
DROP COLUMN TotalAmount; -- Remove existing column (if needed)

ALTER TABLE Orders 
ADD TotalAmount AS (Quantity * UnitPrice) PERSISTED;

SELECT 
    COUNT(OrderID) AS TotalOrders, 
    SUM(TotalAmount) AS TotalIncome
FROM Orders;


select* from Orders;
Drop TABLE Orders;

CREATE TABLE OrderDetail (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderID),
    ProductID INT NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL,
    SubTotal FLOAT NOT NULL
);

CREATE TABLE Sale (
    SaleID INT IDENTITY(1,1) PRIMARY KEY,
    SaleDate DATE NOT NULL DEFAULT GETDATE(),
    TotalSales FLOAT NULL
);

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NULL,
    Size NVARCHAR(50) NULL,
    Price FLOAT NOT NULL,
    Description NVARCHAR(MAX) NULL
);


CREATE TABLE Admin(
	AdminID INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	UserName NVARCHAR(100) NOT NULL UNIQUE,
	PassWord NVARCHAR(200) NOT NULL,
	Email NVARCHAR(100) NOT NULL UNIQUE,
	Phone NVARCHAR(11) NULL
);
DROP TABLE Admin;


CREATE TABLE Employee1(
	EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(200) NOT NULL,
	Role NVARCHAR(100) NOT NULL,
	Status NVARCHAR(100) NOT NULL,
	HireDate DATE  NULL DEFAULT GETDATE(),
	Salary FLOAT NULL,
	Phone NVARCHAR(11) NULL,
);
DROP TABLE Employee1;

