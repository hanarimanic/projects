CREATE DATABASE SneakerShop
GO

USE SneakerShop
GO

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY,
    CategoryActivity NVARCHAR(50) NOT NULL
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    CustomerName NVARCHAR(255) NOT NULL,
    ContactSurname NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(50),
    Email NVARCHAR(255)
);
EXEC sp_rename 'Customers.ContactSurname', 'CustomerSurname', 'COLUMN';
SELECT*FROM Customers


CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(255) NOT NULL,
    UnitPrice DECIMAL(18, 2),
    UnitsInStock INT,
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID)
);
ALTER TABLE Products
ADD Brand NVARCHAR(100) NOT NULL;
ALTER TABLE Products
ADD Size NVARCHAR(10);
ALTER TABLE Products
ADD Model NVARCHAR(100);
ALTER TABLE Products
ADD Color NVARCHAR(50);


CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY,
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    OrderDate DATE NOT NULL,
    ShipDate DATE,
    TotalAmount DECIMAL(18, 2),
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY,
    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18, 2) NOT NULL,
);

INSERT INTO Categories (CategoryActivity) VALUES 
('Running Shoes'),
('Basketball Shoes'),
('Casual Shoes'),
('Training Shoes'),
('Walking Shoes'),
('Hiking Shoes'),
('Tennis Shoes'),
('Skateboarding Shoes'),
('Football Shoes'),
('Golf Shoes');

INSERT INTO Products (ProductName, CategoryID, UnitPrice, UnitsInStock, Size, Color, Model, Brand) VALUES
('Air Max 270', 1, 150.00, 20, '42', 'Red', 'AM270', 'Nike'),
('Air Jordan 1', 2, 200.00, 15, '43', 'Black', 'AJ1', 'Nike'),
('Classic Slip-On', 3, 50.00, 30, '40', 'White', 'CSO', 'Vans'),
('Metcon 5', 4, 130.00, 25, '44', 'Blue', 'MC5', 'Nike'),
('UltraBoost', 5, 180.00, 18, '41', 'Grey', 'UB', 'Adidas'),
('Terrex Free Hiker', 6, 220.00, 10, '45', 'Green', 'TFH', 'Adidas'),
('Court Lite', 7, 90.00, 22, '39', 'Pink', 'CL', 'Nike'),
('SB Dunk Low', 8, 110.00, 28, '42', 'Yellow', 'SBDL', 'Nike'),
('Phantom GT', 9, 250.00, 12, '43', 'Blue', 'PGT', 'Nike'),
('Tour360', 10, 210.00, 14, '44', 'Black', 'T360', 'Adidas');


INSERT INTO Customers (CustomerName, CustomerSurname, Phone, Email) VALUES
('Ivan', 'Ivanović', '123-456-7890', 'ivan.ivanovic@example.com'),
('Ana', 'Anić', '234-567-8901', 'ana.anic@example.com'),
('Marko', 'Marković', '345-678-9012', 'marko.markovic@example.com'),
('Petra', 'Petrović', '456-789-0123', 'petra.petrovic@example.com'),
('Josip', 'Josipović', '567-890-1234', 'josip.josipovic@example.com'),
('Marija', 'Marić', '678-901-2345', 'marija.maric@example.com'),
('Stjepan', 'Stjepanović', '789-012-3456', 'stjepan.stjepanovic@example.com'),
('Jelena', 'Jelenić', '890-123-4567', 'jelena.jelenic@example.com'),
('Ante', 'Antić', '901-234-5678', 'ante.antic@example.com'),
('Katarina', 'Katarinić', '012-345-6789', 'katarina.katarinic@example.com');


INSERT INTO Orders (CustomerID, OrderDate, ShipDate, TotalAmount) VALUES
(1, '2023-01-01', '2023-01-05', 300.00),
(2, '2023-01-02', '2023-01-06', 400.00),
(3, '2023-01-03', '2023-01-07', 150.00),
(4, '2023-01-04', '2023-01-08', 220.00),
(5, '2023-01-05', '2023-01-09', 180.00),
(6, '2023-01-06', '2023-01-10', 250.00),
(7, '2023-01-07', '2023-01-11', 130.00),
(8, '2023-01-08', '2023-01-12', 90.00),
(9, '2023-01-09', '2023-01-13', 210.00),
(10, '2023-01-10', '2023-01-14', 300.00);

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 2, 150.00),
(2, 2, 2, 200.00),
(3, 3, 3, 50.00),
(4, 4, 2, 130.00),
(5, 5, 1, 180.00),
(6, 6, 1, 220.00),
(7, 7, 2, 90.00),
(8, 8, 1, 110.00),
(9, 9, 1, 250.00),
(10, 10, 1, 210.00),
(1, 2, 1, 200.00),
(2, 3, 2, 50.00),
(3, 4, 1, 130.00),
(4, 5, 2, 180.00),
(5, 6, 1, 220.00),
(6, 7, 2, 90.00),
(7, 8, 1, 110.00),
(8, 9, 1, 250.00),
(9, 10, 1, 210.00),
(10, 1, 2, 150.00);

SELECT*FROM Orders
SELECT*FROM OrderDetails