-- USE master
-- GO

-- DROP DATABASE WatchStore
-- GO

CREATE DATABASE WatchStore
GO

USE WatchStore
GO

--===== CREATE TABLE =====--
CREATE TABLE Systems(
	username NVARCHAR(50) PRIMARY KEY,
	passwd NVARCHAR(50) NOT NULL,
	EmployeeID NVARCHAR(10) NOT NULL,
)
GO

CREATE TABLE JOBS(
	ID INT NOT NULL IDENTITY (1, 1),
	JobID AS 'JOB' + RIGHT(CAST(ID as nvarchar(10)),7) PERSISTED,
	JobName Nvarchar(50) NOT NULL,
	JobSalary int NOT NULL,

	CONSTRAINT PK_JOBS PRIMARY KEY (JobID)
)	
GO

CREATE TABLE Employees(
	ID INT NOT NULL IDENTITY (1, 1),
	EmployeeID AS 'EMP' + RIGHT(CAST(ID as nvarchar(10)),7) PERSISTED,
	EmployeeName NVARCHAR(50) NOT NULL,
	EmployeeGender NVARCHAR(10) NOT NULL,
	EmployeeDoB DATETIME NOT NULL,
	EmployeePhone NVARCHAR(20) NOT NULL,
	EmployeeAddress NVARCHAR(50) NOT NULL,
	EmployeeEmail NVARCHAR(50) NOT NULL,
	JobID NVARCHAR(10) NOT NULL,

	CONSTRAINT PK_EMPLOYEE PRIMARY KEY CLUSTERED (EmployeeID),
)
GO

CREATE TABLE Customers(
	ID INT NOT NULL IDENTITY (1, 1),
	CustomerID AS 'CUS' + RIGHT(CAST(ID as nvarchar(10)), 7) PERSISTED,
	CustomerName NVARCHAR(50) NOT NULL,
	CustomerGender NVARCHAR(10) NOT NULL,
	CustomerAddress NVARCHAR(50) NOT NULL,
	CustomerPhone NVARCHAR(20) NOT NULL,
	CustomerEmail NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_CUSTOMER PRIMARY KEY CLUSTERED (CustomerID),
)
GO

CREATE TABLE Orders(
	ID INT NOT NULL IDENTITY (1, 1),
	OrderID AS 'ORD' + RIGHT(CAST(ID as nvarchar(10)), 7) PERSISTED,
	EmployeeID NVARCHAR(10) NOT NULL,
	CustomerID NVARCHAR(10) NOT NULL,
	OrderDate DATETIME NOT NULL,
	Total INT NOT NULL,

	CONSTRAINT PK_ORDER PRIMARY KEY CLUSTERED (OrderID),
)
GO

CREATE TABLE OrderDetails(
	OrderID NVARCHAR(10) NOT NULL,
	ProductID NVARCHAR(10) NOT NULL,
	OrderQuantity int NOT NULL,
	UntilPrice INT  NULL,

	PRIMARY KEY(OrderID, ProductID),
)
GO

CREATE TABLE Products(
	ID INT NOT NULL IDENTITY (1, 1),
	ProductID AS 'PRO' + RIGHT(CAST(ID as nvarchar(10)), 7) PERSISTED,
	ProductName NVARCHAR(50) NOT NULL,
	CategoryID NVARCHAR(10) NOT NULL,
	QuantityProduct INT NOT NULL,
	UntilPrice INT NOT NULL,
	ProductColorID NVARCHAR(10) NOT NULL,
	ProductSizeID NVARCHAR(10) NOT NULL,
	ProductBrandID NVARCHAR(10) NOT NULL,

	CONSTRAINT PK_PRODUCT PRIMARY KEY CLUSTERED (ProductID),
)
GO

CREATE TABLE Categories(
	ID INT NOT NULL IDENTITY (1, 1),
	CategoryID AS 'CATE' + RIGHT(CAST(ID as nvarchar(10)), 6) PERSISTED,
	CategoryName NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_CATEGORY PRIMARY KEY CLUSTERED (CategoryID),
)
GO

CREATE TABLE ProductColor(
	ID INT NOT NULL IDENTITY (1, 1),
	ProductColorID AS 'PROCO' + RIGHT(CAST(ID as nvarchar(10)), 5) PERSISTED,
	ProductColorName NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_PRODUCTCOLOR PRIMARY KEY CLUSTERED (ProductColorID),
)
GO

CREATE TABLE ProductSize(
	ID INT NOT NULL IDENTITY (1, 1),
	ProductSizeID AS 'PROSI' + RIGHT(CAST(ID as nvarchar(10)), 5) PERSISTED,
	ProductSizeName NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_PRODUCTSIZE PRIMARY KEY CLUSTERED (ProductSizeID),
)
GO

CREATE TABLE ProductBrand(
	ID INT NOT NULL IDENTITY (1, 1),
	ProductBrandID AS 'PROBR' + RIGHT(CAST(ID as nvarchar(10)), 5) PERSISTED,
	ProductBrandName NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_PRODUCTBRAND PRIMARY KEY CLUSTERED (ProductBrandID),
)
GO
--===== END CREATE TABLE =====--

--===== CREATE CONSTRAINT =====--
-- Khi xóa nhân viên thì sẽ xóa luôn tài khoản nhân viên đó có trong hệ thống
ALTER TABLE Systems ADD CONSTRAINT FK_Systems_EmployeeID FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE;
--Nếu xóa 1 khách hàng hay nhân viên thì sẽ xóa luôn order tương ứng với khách hàng hay nhân viên đó
ALTER TABLE Orders ADD CONSTRAINT FK_Orders_EmployeeID FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE;
ALTER TABLE Orders ADD CONSTRAINT FK_Orders_CustomerID FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE;
-- Nếu xóa 1 order thì Details của Order đó sẽ xóa theo | Nếu xóa 1 product thì xóa những product đó có trong OrderDetails
ALTER TABLE OrderDetails ADD CONSTRAINT FK_OrderDetails_OrderID FOREIGN KEY(OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE;
ALTER TABLE OrderDetails ADD CONSTRAINT FK_OrderDetails_ProductID FOREIGN KEY(ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE;
-- Kết nối với dữ liệu cứng
ALTER TABLE Employees ADD CONSTRAINT FK_Employees_JobID FOREIGN KEY(JobID) REFERENCES JOBS(JobID);
ALTER TABLE Products ADD CONSTRAINT FK_Products_ProductBrandID FOREIGN KEY(ProductBrandID) REFERENCES ProductBrand(ProductBrandID);
ALTER TABLE Products ADD CONSTRAINT FK_Products_CategoryID FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID);
ALTER TABLE Products ADD CONSTRAINT FK_Products_ProductColorID FOREIGN KEY(ProductColorID) REFERENCES ProductColor(ProductColorID);
ALTER TABLE Products ADD CONSTRAINT FK_Products_ProductSizeID FOREIGN KEY(ProductSizeID) REFERENCES ProductSize(ProductSizeID);
GO
--===== END CREATE CONSTRAINT =====--

--===== CREATE TRIGGER ====--
--====== TẠO TRIGGER THÊM TÀI KHOẢN KHI THÊM NHÂN VIÊN =====----
CREATE TRIGGER TRG_AddAcount ON Employees AFTER INSERT AS
BEGIN
INSERT INTO Systems VALUES ((SELECT Employees.EmployeeName FROM inserted,Employees WHERE inserted.EmployeeID=Employees.EmployeeID),
(SELECT Employees.EmployeePhone FROM Employees,inserted WHERE inserted.EmployeeID=Employees.EmployeeID),

(SELECT Employees.EmployeeID FROM Employees,inserted WHERE inserted.EmployeeID=Employees.EmployeeID))
END
GO

--====== TẠO TRIGGER CẬP NHẬT SỐ LƯỢNG SẢN PHẨM CỦA BẢNG PRODUCTS VÀ ORDERDETAILS KHI THÊM SẢN PHẨM VÀO BẢNG ORDERDETAILS=====----
CREATE TRIGGER TRG_UpProduct_add ON OrderDetails INSTEAD OF INSERT AS
BEGIN
DECLARE @ORDERID NVARCHAR (10),
@PRODUCTID NVARCHAR(10),
@ORDERQUANTITY INT,
@UNTILPRICE INT

SET @ORDERID=(sELECT OrderID FROM inserted)
SET @PRODUCTID=(SELECT ProductID FROM inserted)
SET @ORDERQUANTITY=(SELECT OrderQuantity FROM inserted)
SET @UNTILPRICE= (SELECT UntilPrice FROM inserted)
		
		UPDATE Products SET QuantityProduct=Products.QuantityProduct-(SELECT OrderQuantity FROM inserted WHERE ProductID= Products.ProductID )
		FROM inserted
		WHERE Products.ProductID=inserted.ProductID
		
		UPDATE OrderDetails SET OrderDetails.UntilPrice=Products.UntilPrice
		FROM Products
		WHERE OrderDetails.ProductID=Products.ProductID
		
		UPDATE OrderDetails SET OrderDetails.OrderQuantity=OrderDetails.OrderQuantity+@ORDERQUANTITY
		FROM OrderDetails JOIN inserted ON OrderDetails.ProductID=inserted.ProductID  AND OrderDetails.OrderID=inserted.OrderID

		IF NOT EXISTS (SELECT OrderDetails.ProductID FROM OrderDetails,inserted
		WHERE OrderDetails.ProductID=inserted.ProductID AND OrderDetails.OrderID=inserted.OrderID)
		BEGIN
			INSERT INTO OrderDetails VALUES (@ORDERID,@PRODUCTID,@ORDERQUANTITY,@UNTILPRICE)
			UPDATE OrderDetails SET OrderDetails.UntilPrice=Products.UntilPrice
			FROM Products
			WHERE OrderDetails.ProductID=Products.ProductID
		END

END
GO
--====== TẠO TRIGGER CẬP NHẬT SỐ LƯỢNG SẢN PHẨM TRONG BẢNG PRODUCTS KHI XÓA SẢN PHẨM TRONG BẢNG ORDERDETAILS=====----
CREATE TRIGGER TRG_UpProduct_delete ON OrderDetails AFTER DELETE AS
BEGIN

		UPDATE Products SET QuantityProduct=Products.QuantityProduct+(SELECT OrderQuantity FROM deleted WHERE ProductID= Products.ProductID )
		FROM deleted
		WHERE Products.ProductID=deleted.ProductID
		
END
GO
--===== END CREATE TRIGGER ====--

--===== CREATE VIEW =====--
-- HIỂN THỊ TẤT CẢ PRODUCTS
CREATE VIEW SHOW_ALL_PRODUCT
AS
	SELECT ProductID, ProductName, CategoryName, QuantityProduct, UntilPrice, ProductColorName, ProductSizeName, ProductBrandName FROM dbo.Products
	INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
	INNER JOIN ProductColor ON Products.ProductColorID = ProductColor.ProductColorID
	INNER JOIN ProductSize ON Products.ProductSizeID = ProductSize.ProductSizeID
	INNER JOIN ProductBrand ON Products.ProductBrandID = ProductBrand.ProductBrandID;
GO
--===== END CREATE VIEW =====--

--===== CREATE PROCEDURE ====--
--====== TẠO PROCEDURE CẬP NHẬT TÀI KHOẢN ======----
CREATE PROC UPDATE_ACCOUNT
@passwd NVARCHAR(50),
@empID NVARCHAR(10)
as
	BEGIN
		UPDATE Systems 
		SET passwd = @passwd 
		WHERE EmployeeID = @empID
	END
GO
--====== TẠO PROCEDURE LẤY TÀI KHOẢN ======----
CREATE PROC GET_ACCOUNT
@username NVARCHAR(50),
@passwd NVARCHAR(50)
AS
	BEGIN
		SELECT *
		FROM Systems
		WHERE username = @username AND passwd = @passwd
	END
GO
--====== TẠO PROCEDURE TẠO HÓA ĐƠN ======----
CREATE PROC CREATE_RECEIPT
@idcus nvarchar(50),
@EMPID NVARCHAR(10)
AS
	BEGIN 
		INSERT INTO Orders VALUES (@EMPID,@idcus,GETDATE(),0)
	END
GO
--====== TẠO PROCEDURE LẤY MÃ HÓA ĐƠN MỚI TẠO======----
CREATE PROC SELECT_NEW_ORDER
AS
	BEGIN
		SELECT TOP 1 OrderID,EmployeeID,CustomerID FROM Orders ORDER BY OrderID DESC
	END
GO
--====== TẠO PROCEDURE XÓA HÓA ĐƠN======----
CREATE PROC DELETE_RECEPIT
@ORDERID NVARCHAR(10)
AS
	BEGIN
		DELETE FROM Orders WHERE OrderID=@ORDERID
	END
GO
--====== TẠO PROCEDURE ADD VÀO HÓA ĐƠN======----
CREATE PROC ADD_OrderDetails 
@ORDER_ID nvarchar(10),
@PRODUCT_ID NVARCHAR(10),
@QUANTITY INT
AS
	BEGIN	
		DECLARE @QTT_IN_STORED INT
		SET @QTT_IN_STORED=(SELECT QuantityProduct FROM Products WHERE ProductID=@PRODUCT_ID)
		BEGIN TRANSACTION;
		SAVE TRANSACTION MySavePoint;
		IF (@QUANTITY<@QTT_IN_STORED)
			BEGIN
				INSERT INTO OrderDetails(OrderID,ProductID,OrderQuantity) VALUES (@ORDER_ID,@PRODUCT_ID,@QUANTITY)
			END
		ELSE 
			BEGIN
				ROLLBACK TRAN MySavePoint
			END
		COMMIT TRANSACTION 	
	END
GO
--====== TẠO PROCEDURE HIỂN HIỂN THỊ CHI TIẾT HÓA ĐƠN THEO SẢN PHẨM======----
CREATE PROC SHOW_OrderDetails 
@ORDERID NVARCHAR(10)
AS
	BEGIN
		SELECT * FROM OrderDetails WHERE OrderID=@ORDERID
	END
GO
----====== THANH TOÁN HÓA ĐƠN======----
CREATE PROCEDURE THANHTOAN 
@ORDERID NVARCHAR(10)
as 
BEGIN
	
    BEGIN TRANSACTION;
	DECLARE @TIEN INT

    SAVE TRANSACTION MySavePoint;
	BEGIN TRY
		--SET @ORDERID=(SELECT TOP 1 ID 
		--		FROM HOADON 
		--		 ORDER BY ID DESC)
	SET @TIEN= (SELECT SUM(OrderDetails.UntilPrice*OrderDetails.OrderQuantity)
				FROM OrderDetails
				WHERE OrderDetails.OrderID=@ORDERID)
				UPDATE Orders SET Total=@TIEN WHERE OrderID=@ORDERID
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION MySavePoint; -- rollback to MySavePoint
        END
    END CATCH
END;
GO
----====== SHOW TOÀN BỘ HÓA ĐƠNI======----
CREATE PROC SHOW_Order
AS
BEGIN
SELECT * FROM Orders 
END
GO
----====== TÌM KIẾM HÓA ĐƠNI======----
CREATE PROC SHOW_Order_BYID
@ORDERID NVARCHAR(10)
AS
BEGIN
SELECT * FROM OrderDetails WHERE OrderID=@ORDERID
END
GO 
----====== TÌM KIẾM KHÁCH HÀNG THEO SỐ ĐIỆN THOẠI ======----
CREATE PROC FIND_CUS 
@PHONE nvarchar(20)
AS
BEGIN
	SELECT CustomerID,CustomerName,CustomerPhone
	FROM Customers
	WHERE CustomerPhone = @PHONE
END
GO
------====== THÊM NHÂN VIÊN ======----
CREATE PROC ADD_EMPLOYEE 
@NAME NVARCHAR(50),
@GENDER NVARCHAR(10),
@DOB DATETIME,
@PHONE NVARCHAR(20),
@ADDRESS NVARCHAR(50),
@JOBID NVARCHAR(10),
@EMAIL NVARCHAR(10)
AS
	BEGIN
		INSERT INTO Employees VALUES (@NAME,@GENDER,@DOB,@PHONE,@ADDRESS,@EMAIL,@JOBID)
	END
GO
------====== UPDATE NHÂN VIÊN======----
CREATE PROC UPDATE_EMPLOYEE
@EMPID NVARCHAR(10),
@NAME NVARCHAR(50),
@GENDER NVARCHAR(10),
@DOB DATETIME,
@PHONE NVARCHAR(20),
@ADDRESS NVARCHAR(50),
@EMAIL NVARCHAR(50),
@JOBID NVARCHAR(10)
AS
BEGIN		
UPDATE Employees
   SET EmployeeName = @NAME,
     EmployeeGender = @GENDER,
      EmployeeDoB = @DOB,
      EmployeePhone = @PHONE,
      EmployeeAddress = @ADDRESS,
	 EmployeeEmail = @EMAIL ,
	 JobID = @JOBID
WHERE EmployeeID = @EMPID
END
GO

------====== DELETE NHÂN VIÊN======----
CREATE PROC DELETE_EMPLOYEE
@ID NVARCHAR(10)
AS
BEGIN
DELETE FROM Employees
 WHERE EmployeeID = @ID;
 END
GO
------====== THÊM KHÁCH HÀNG======----
CREATE PROC ADD_CUSTOMER 
@NAME NVARCHAR(50),
@GENDER NVARCHAR(10),
@ADDRESS NVARCHAR(50),
@PHONE NVARCHAR(20),
@EMAIL NVARCHAR(50)
AS
BEGIN
INSERT INTO Customers VALUES (@NAME,@GENDER,@ADDRESS,@PHONE,@EMAIL)
END
GO
------====== UPDATE KHÁCH HÀNG======----
CREATE PROC UPDATE_CUSTOMER
@CUSID NVARCHAR(10),
@NAME NVARCHAR(50),
@GENDER NVARCHAR(10),
@ADDRESS NVARCHAR(50),
@PHONE NVARCHAR(20),
@EMAIL NVARCHAR(50)
AS
BEGIN
	UPDATE Customers SET 
		CustomerName = @NAME,
		CustomerGender = @GENDER,
		CustomerAddress = @ADDRESS,
		CustomerPhone = @PHONE,
		CustomerEmail = @EMAIL
	WHERE CustomerID = @CUSID
END
GO
------====== DELETE KHÁCH HÀNG======----
CREATE PROC DELETE_CUSTOMER 
@ID NVARCHAR(10)
AS
BEGIN
DELETE FROM Customers
 WHERE CustomerID = @ID;
 END
GO
------====== SHOW KHÁCH HÀNG======----
CREATE PROC SHOW_CUSTOMERS
as
	SELECT * FROM dbo.Customers;
GO
------====== SHOW NHÂN VIÊN======----
CREATE PROC SHOW_EMPLOYEE
As
	SELECT * FROM dbo.Employees
GO
------====== SEARCH NHÂN VIÊN======----
CREATE PROC FIND_EMPLOYEE
@NAME NVARCHAR(50)
AS
BEGIN
	SELECT EmployeeName, EmployeeGender, EmployeeDoB,EmployeePhone,EmployeeAddress,EmployeeEmail,JobID
	FROM Employees
	WHERE  EmployeeName LIKE N'%'+@NAME +'%'
END
GO
--====== TẠO PROCEDURE HIỂN THỊ SẢN PHẨM ======----
------====== HIỆN THỊ SẢN PHẨM ======----
CREATE PROC SHOW_PRODUCT
AS
	SELECT * FROM SHOW_ALL_PRODUCT
GO
------====== THÊM SẢN PHẨM ======----
CREATE PROC ADD_PRODUCT
@NAME NVARCHAR(50),
@CATEGORYID NVARCHAR(10),
@QUANTITY INT,
@PRICE INT,
@COLORID NVARCHAR(10),
@SIZEID NVARCHAR(10),
@BRANDID NVARCHAR(10)
AS
	BEGIN
		INSERT INTO Products VALUES (@NAME,@CATEGORYID,@QUANTITY,@PRICE,@COLORID,@SIZEID,@BRANDID)
	END
GO
------====== SỬA SẢN PHẨM======----
CREATE PROC UPDATE_PRODUCT
@PRODUCTID NVARCHAR(10),
@NAME NVARCHAR(50),
@CATEGORYID NVARCHAR(10),
@QUANTITY INT,
@PRICE INT,
@COLORID NVARCHAR(10),
@SIZEID NVARCHAR(10),
@BRANDID NVARCHAR(10)
AS
	BEGIN
		UPDATE Products
		SET ProductName = @NAME, CategoryID = @CATEGORYID, QuantityProduct = @QUANTITY, UntilPrice = @PRICE, ProductColorID = @COLORID, ProductSizeID = @SIZEID, ProductBrandID = @BRANDID
		WHERE ProductID = @PRODUCTID
	END
GO
------====== XÓA SẢN PHẨM======----
CREATE PROC DELETE_PRODUCT
@PRODUCTID NVARCHAR(10)
AS
	BEGIN
		DELETE FROM Products WHERE ProductID=@PRODUCTID
	END
GO
------====== LỌC SẢN PHẨM======----
CREATE PROC SEARCH_PRODUCT
(@nameCol VARCHAR(50), @value VARCHAR(50))
AS
IF(@nameCol LIKE 'Name')
	BEGIN
		SELECT * FROM SHOW_ALL_PRODUCT
		WHERE ProductName  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Category')
	BEGIN
		SELECT * FROM SHOW_ALL_PRODUCT
		WHERE CategoryName  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Color')
	BEGIN
		SELECT * FROM SHOW_ALL_PRODUCT
		WHERE ProductColorName  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Size')
	BEGIN
		SELECT * FROM SHOW_ALL_PRODUCT
		WHERE ProductSizeName  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Brand')
	BEGIN
		SELECT * FROM SHOW_ALL_PRODUCT
		WHERE ProductBrandName  LIKE N'%' + @value + '%'
	END
GO
------====== HIỆN THỊ DANH SÁCH MÀU CỦA SẢN PHẨM ======----
CREATE PROC GET_PRODUCTCOLOR
AS
BEGIN
	SELECT *
	FROM ProductColor
END
GO
------====== HIỆN THỊ DANH SÁCH KÍCH THƯỚC CỦA SẢN PHẨM ======----
CREATE PROC GET_PRODUCTSIZE
AS
BEGIN
	SELECT *
	FROM ProductSize
END
GO
------====== HIỆN THỊ DANH SÁCH THỂ LOẠI CỦA SẢN PHẨM ======----
CREATE PROC GET_CATEGORY
AS
BEGIN
	SELECT *
	FROM Categories
END
GO
------====== HIỆN THỊ DANH SÁCH HÃNG CỦA SẢN PHẨM ======----
CREATE PROC GET_PRODUCTBRAND
AS
BEGIN
	SELECT *
	FROM ProductBrand
END
GO
--===== END CREATE PROCEDURE =====--

--===== ADD DATA =====--
--JOBS
INSERT INTO JOBS VALUES(N'Admin', 50000000)
INSERT INTO JOBS VALUES(N'Nhân viên 1', 11000000)
INSERT INTO JOBS VALUES(N'Nhân viên 2', 12000000)
INSERT INTO JOBS VALUES(N'Nhân viên 3', 13000000)
--Employees
INSERT INTO Employees VALUES(N'Admin', N'Nam', '1999-10-10', '0123456789', 'TPHCM', 'admin123@gmail.com', 'JOB1')
INSERT INTO Employees VALUES(N'Nguyễn Văn A', N'Nam', '1999-10-1', '01111111119', 'TPHCM', 'nguyenvana123@gmail.com', 'JOB2')
INSERT INTO Employees VALUES(N'Nguyễn Văn B', N'Nam', '1999-10-2', '01111111118', 'TPHCM', 'nguyenvanb123@gmail.com', 'JOB2')
INSERT INTO Employees VALUES(N'Nguyễn Văn C', N'Nữ', '1999-10-3', '01111111117', 'TPHCM', 'nguyenvanc123@gmail.com', 'JOB2')
INSERT INTO Employees VALUES(N'Nguyễn Văn D', N'Nữ', '1999-10-4', '01111111116', 'TPHCM', 'nguyenvand123@gmail.com', 'JOB3')
INSERT INTO Employees VALUES(N'Nguyễn Văn E', N'Nam', '1999-10-5', '01111111115', 'TPHCM', 'nguyenvane123@gmail.com', 'JOB3')
INSERT INTO Employees VALUES(N'Nguyễn Văn F', N'Nam', '1999-10-6', '01111111114', 'TPHCM', 'nguyenvanf123@gmail.com', 'JOB4')
-- ProductColor
INSERT INTO ProductColor VALUES(N'Đen')
INSERT INTO ProductColor VALUES(N'Trắng')
INSERT INTO ProductColor VALUES(N'Bạc')
INSERT INTO ProductColor VALUES(N'Vàng')
-- ProductSize
insert into ProductSize values ('Size S')
insert into ProductSize values ('Size M')
insert into ProductSize values ('Size L')
insert into ProductSize values ('Size XL')
-- ProductBrand
INSERT INTO ProductBrand VALUES(N'Rolex')
INSERT INTO ProductBrand VALUES(N'Gucci')
INSERT INTO ProductBrand VALUES(N'Omega')
-- Categories 
INSERT INTO Categories VALUES(N'Đồng hồ Nam')
INSERT INTO Categories VALUES(N'Đồng hồ Nữ')
-- Products
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO1', 'PROSI1','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO1', 'PROSI2','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO1', 'PROSI3','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO1', 'PROSI4','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO2', 'PROSI1','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO2', 'PROSI2','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO2', 'PROSI3','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO2', 'PROSI4','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO3', 'PROSI1','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO3', 'PROSI2','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO3', 'PROSI3','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO3', 'PROSI4','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO4', 'PROSI1','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO4', 'PROSI2','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO4', 'PROSI3','PROBR1')
INSERT INTO Products VALUES(N'Rolex 2022', 'CATE1',50, 2000000, 'PROCO4', 'PROSI4','PROBR1')

INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO1', 'PROSI1','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO1', 'PROSI2','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO1', 'PROSI3','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO1', 'PROSI4','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO2', 'PROSI1','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO2', 'PROSI2','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO2', 'PROSI3','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO2', 'PROSI4','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO3', 'PROSI1','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO3', 'PROSI2','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO3', 'PROSI3','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO3', 'PROSI4','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO4', 'PROSI1','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO4', 'PROSI2','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO4', 'PROSI3','PROBR2')
INSERT INTO Products VALUES(N'Gucci 2022', 'CATE2',50, 1500000, 'PROCO4', 'PROSI4','PROBR2')

INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO1', 'PROSI1','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO1', 'PROSI2','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO1', 'PROSI3','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO1', 'PROSI4','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO2', 'PROSI1','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO2', 'PROSI2','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO2', 'PROSI3','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO2', 'PROSI4','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO3', 'PROSI1','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO3', 'PROSI2','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO3', 'PROSI3','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO3', 'PROSI4','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO4', 'PROSI1','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO4', 'PROSI2','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO4', 'PROSI3','PROBR3')
INSERT INTO Products VALUES(N'Omega 2022', 'CATE1',50, 300000, 'PROCO4', 'PROSI4','PROBR3')
--Customers
INSERT INTO Customers VALUES(N'Lê Văn A', N'Nam', 'TPHCM', '0999999991', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn B', N'Nữ', 'TPHCM', '0999999992', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn C', N'Nam', 'TPHCM', '0999999993', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn D', N'Nam', 'TPHCM', '0999999994', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn E', N'Nữ', 'TPHCM', '0999999995', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn F', N'Nữ', 'TPHCM', '0999999996', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn G', N'Nam', 'TPHCM', '0999999997', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn H', N'Nam', 'TPHCM', '0999999998', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn I', N'Nữ', 'TPHCM', '0999999999', 'levana123@gmail.com')
INSERT INTO Customers VALUES(N'Lê Văn J', N'Nam',  'TPHCM', '0999999919', 'levana123@gmail.com')

--Orders
--OrderDetails
GO
--===== END ADD DATA =====--

-------======PHẦN NÀY ĐỂ CHẠY THỬ NGHIỆM CÁC HÀM XEM ĐÚNG KHÔNG ======-----------------
 


-- GO
-- SELECT * FROM Orders
-- SELECT * FROM Customers
-- SELECT * FROM OrderDetails

-- SELECT * FROM Products
-- SELECT * FROM OrderDetails
-- EXEC CREATE_RECEIPT 'CUS1', 'EMP1'
-- EXEC ADD_OrderDetails 'ORD2','PRO6',42
-- EXEC ADD_OrderDetails 'ORD2','PRO7',42
-- EXEC ADD_OrderDetails 'ORD1','PRO5',42
-- SELECT * FROM OrderDetails
--EXEC THANHTOAN 'ORD1'
--SELECT * FROM Orders
--SELECT * FROM Products
--SELECT * FROM OrderDetails
--EXEC DELETE_RECEPIT 'ORD2'

--GO
--DECLARE @NAME NVARCHAR(50)='A',
--@GENDER NVARCHAR(10)='Nam',
--@DOB DATETIME='1999-11-2',
--@PHONE NVARCHAR(20)='093919311',
--@ADDRESS NVARCHAR(50)='Da Nang',
--@JOBID NVARCHAR(10)='JOB1',
--@EMAIL NVARCHAR (10)='WORK'

--EXEC ADD_EMPLOYEE @NAME, @GENDER, @DOB, @PHONE, @ADDRESS, @JOBID,@EMAIL;

--GO
--SELECT* FROM Products
--SELECT * FROM Orders
--SELECT * FROM OrderDetails

--DECLARE @ORDERID NVARCHAR(10), @PID NVARCHAR (10), @QUAN INT,@UN INT
--SET @ORDERID='ORD1'
--SET @PID ='PRO1'
--SET @QUAN=1
--EXEC ADD_OrderDetails @ORDERID,@PID,@QUAN;

--SELECT* FROM Products
--SELECT * FROM OrderDetails