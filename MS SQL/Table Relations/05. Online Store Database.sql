CREATE DATABASE [Online Store]
GO 
USE [Online Store]
--Send to judge only CREATE

CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Birthday DATE NOT NULL,
	CityID INT REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY,
	CustomerID INT REFERENCES Customers(CustomerID)
)

CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(5) NOT NULL,
)

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	ItemTypeID INT REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems
(
	OrderID INT REFERENCES Orders(OrderID),
	ItemID INT REFERENCES Items(ItemID)
	CONSTRAINT FK_OrderID_ItemID_Composite PRIMARY KEY (OrderID, ItemID)
)