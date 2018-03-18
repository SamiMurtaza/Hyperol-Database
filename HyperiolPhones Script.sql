Use HyperiolPhones
GO

CREATE TABLE Products (
  ProductID INTEGER NOT NULL,
  Model VARCHAR NULL,
  Make VARCHAR NULL,
  Name VARCHAR NULL,
  UnitPrice INT NULL,
  Quantity_available INT NULL,
  PRIMARY KEY(ProductID)
);

CREATE TABLE Supplier (
  SupplierID INTEGER NOT NULL,
  Name VARCHAR NULL,
  Contact VARCHAR NULL,
  Email VARCHAR NULL,
  City VARCHAR NULL,
  Postal_Code VARCHAR NULL,
  Country VARCHAR NULL,
  Street VARCHAR NULL,
  PRIMARY KEY(SupplierID)
);

CREATE TABLE Customer (
  CustomerID INTEGER NOT NULL,
  Name VARCHAR NULL,
  Email VARCHAR NULL,
  Contact VARCHAR NULL,
  Street VARCHAR NULL,
  City VARCHAR NULL,
  Postal_Code INTEGER NULL,
  Country VARCHAR NULL,
  PRIMARY KEY(CustomerID)
);

CREATE TABLE Orders (
  OrdersID INTEGER NOT NULL,
  Customer_CustomerID INTEGER NOT NULL,
  Shipped_Date DATE NULL,
  Order_Date DATE NULL,
  Ship_Name VARCHAR NULL,
  Ship_Address VARCHAR NULL,
  Ship_City VARCHAR NULL,
  Ship_Postal_Code VARCHAR NULL,
  Ship_Country VARCHAR NULL,
  Expected_Date DATE NULL,
  PRIMARY KEY(OrdersID),
  INDEX Orders_FKIndex1(Customer_CustomerID),
  FOREIGN KEY(Customer_CustomerID)
    REFERENCES Customer(CustomerID)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Order_Details (
  Order_DetailsID INTEGER NOT NULL,
  Orders_OrdersID INTEGER NULL,
  Products_ProductID INTEGER NULL,
  UnitPrice INTEGER NULL,
  Quantity INTEGER NULL,
  PRIMARY KEY(Order_DetailsID),
  INDEX Order_Details_FKIndex1(Products_ProductID),
  INDEX Order_Details_FKIndex2(Orders_OrdersID),
  FOREIGN KEY(Products_ProductID)
    REFERENCES Products(ProductID)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Orders_OrdersID)
    REFERENCES Orders(OrdersID)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Purchased (
  idPurchased INTEGER NOT NULL,
  Supplier_SupplierID INTEGER NULL,
  Products_ProductID INTEGER NULL,
  Quantity INTEGER NULL,
  PRIMARY KEY(idPurchased),
  INDEX Purchased_FKIndex1(Products_ProductID),
  INDEX Purchased_FKIndex2(Supplier_SupplierID),
  FOREIGN KEY(Products_ProductID)
    REFERENCES Products(ProductID)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Supplier_SupplierID)
    REFERENCES Supplier(SupplierID)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE [Return] (
  ReturnID INTEGER NOT NULL,
  Order_Details_Order_DetailsID INTEGER NULL,
  Return_Date DATE NULL,
  PRIMARY KEY(ReturnID),
  INDEX Return_FKIndex1(Order_Details_Order_DetailsID),
  FOREIGN KEY(Order_Details_Order_DetailsID)
    REFERENCES Order_Details(Order_DetailsID)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

