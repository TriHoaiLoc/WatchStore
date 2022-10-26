USE master
GO

DROP DATABASE WatchStore
GO

CREATE DATABASE WatchStore
GO

USE WatchStore
GO

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


insert into Customers values ('Nguyen Van A','Nam','Tp.HCM','01919331','a@gmail.com')
insert into Categories values ('Dong ho')
insert into JOBS values ('Thu ngan',5000000)
insert into Employees values ('Employee 1','Nu','1920-1-1','01131311','HN','JOB1','WORK')
insert into Systems values ('EMP1','01131311','EMP1')
insert into ProductSize values ('Size L')
insert into ProductSize values ('Size M')
insert into ProductSize values ('Size S')
insert into ProductColor values ('Red')
insert into ProductColor values ('Blue')
insert into ProductColor values ('Gold')
insert into ProductColor values ('Platinum')
insert into ProductDetails values ('PROCO1','PROSI1')
insert into ProductDetails values ('PROCO2','PROSI1')
insert into ProductDetails values ('PROCO3','PROSI1')
insert into ProductDetails values ('PROCO1','PROSI2')
insert into ProductDetails values ('PROCO2','PROSI2')
insert into ProductDetails values ('PROCO3','PROSI2')
insert into ProductDetails values ('PROCO1','PROSI3')
insert into ProductBrand values ('Rolex')
insert into Products values ('Rolex youth', 'PRODE1','CATE1',500,2000000,'PROBR1')
insert into Orders values ('CUS1','2022-9-1',590000,'EMP1')
insert into Orders values ('CUS1','2022-9-1',0,'EMP1')
--insert into OrderDetails values ('ORD1','PRO1',12,1)


--====== TẠO TRIGGER CHO THÊM XÓA TÀI KHOẢN KHI XÓA NHÂN VIÊN=====----
go
CREATE TRIGGER TRG_AddAcount ON Employees AFTER INSERT AS
BEGIN
INSERT INTO Systems VALUES ((SELECT Employees.EmployeeID FROM inserted,Employees WHERE inserted.EmployeeID=Employees.EmployeeID),
(SELECT Employees.EmployeePhone FROM Employees,inserted WHERE inserted.EmployeeID=Employees.EmployeeID),

(SELECT Employees.EmployeeID FROM Employees,inserted WHERE inserted.EmployeeID=Employees.EmployeeID))
END
--====== TẠO TRIGGER CẬP NHẬT SỐ LƯỢNG SẢN PHẨM=====----
GO
CREATE TRIGGER TRG_UpProduct_add ON OrderDetails AFTER INSERT AS
BEGIN
		UPDATE Products SET QuantityProduct=Products.QuantityProduct-(SELECT OrderQuantity FROM inserted WHERE ProductID= Products.ProductID )
		FROM inserted
		WHERE Products.ProductID=inserted.ProductID
		UPDATE OrderDetails SET OrderDetails.UntilPrice=Products.UntilPrice
		FROM Products
		WHERE OrderDetails.ProductID=Products.ProductID
END
GO
CREATE TRIGGER TRG_UpProduct_delete ON OrderDetails AFTER DELETE AS

BEGIN

		UPDATE Products SET QuantityProduct=Products.QuantityProduct+(SELECT OrderQuantity FROM deleted WHERE ProductID= Products.ProductID )
		FROM deleted
		WHERE Products.ProductID=deleted.ProductID
		
END
GO
--====== TẠO PROCEDURE TẠO HÓA ĐƠN======----
CREATE PROC CREATE_RECEIPT
@idcus nvarchar(50),
@EMPID NVARCHAR(10)

AS
BEGIN 

		INSERT INTO Orders VALUES (@idcus,GETDATE(),0,@EMPID)
END

--====== TẠO PROCEDURE ADD VÀO HÓA ĐƠN======----
insert into Orders(OrderID,ProductID,OrderQuantity) values ('ORD1','PRO1',21)
GO
CREATE PROC ADD_OrderDetails 
@ORDER_ID nvarchar(10),
@PRODUCT_ID NVARCHAR(10),
@QUANTITY INT
AS
BEGIN 

		INSERT INTO OrderDetails(OrderID,ProductID,OrderQuantity) VALUES (@ORDER_ID,@PRODUCT_ID,@QUANTITY)
END


----====== TÌM KIẾM KHÁCH HÀNG THEO SỐ ĐIỆN THOẠI======----
GO 
CREATE PROC FIND_CUS 
@PHONE nvarchar(20)
AS
BEGIN
	SELECT CustomerID,CustomerName,CustomerPhone
	FROM Customers
	WHERE @PHONE=CustomerPhone
END
------====== THÊM NHÂN VIÊN======----
GO
CREATE PROC ADD_EMPLOYEE 
@NAME NVARCHAR(50),
@GENDER NVARCHAR(10),
@DOB DATETIME,
@PHONE NVARCHAR(20),
@ADDRESS NVARCHAR(50),
@JOBID NVARCHAR(10),
@STUSWORK NVARCHAR(10)
AS
BEGIN
INSERT INTO Employees VALUES (@NAME,@GENDER,@DOB,@PHONE,@ADDRESS,@JOBID,@STUSWORK)
END


GO
DECLARE @NAME NVARCHAR(50)='A',
@GENDER NVARCHAR(10)='Nam',
@DOB DATETIME='1999-11-2',
@PHONE NVARCHAR(20)='093919311',
@ADDRESS NVARCHAR(50)='Da Nang',
@JOBID NVARCHAR(10)='JOB1',
@STUSWORK NVARCHAR (10)='WORK'

EXEC ADD_EMPLOYEE @NAME, @GENDER, @DOB, @PHONE, @ADDRESS, @JOBID,@STUSWORK;

GO
select * from Systems

--DECLARE @cus NVARCHAR(50)='CUS1',
-- @DATE DATE=GETDATE(),
-- @EMPLOYEE NVARCHAR(10)='EMP1'
--EXEC ADD_RECEIPT @cus,@EMPLOYEE

GO
DECLARE @ORDER_ID nvarchar(10),
@PRODUCT_ID NVARCHAR(10),
@QUANTITY INT
EXEC ADD_OrderDetails 
GO
insert into OrderDetails(OrderID,ProductID,OrderQuantity) values ('ORD1','PRO1',21)
select * from Customers
select * from OrderDetails
select * from Products



--delete from OrderDetails where OrderDetailID ='ORDDE2'
--select * from Products
----insert into Employees values ('Employee 2','NAM','1922-11-10','066848432','Hcm','JOB1')
----select * from Employees
----select * from Systems

----DELETE FROM Employees WHERE EmployeeID='EMP2'
----select * from Systems
----select * from Employees
--go
----select * from Customers
----select * from ProductDetails
----select * from ProductColor
----select * from ProductSize
--select * from Products
----select * from OrderDetails 
----select * from Orders 