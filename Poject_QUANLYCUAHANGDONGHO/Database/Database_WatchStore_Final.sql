 --USE master
 --GO

 --DROP DATABASE WatchStore
 --GO

CREATE DATABASE WatchStore
GO

USE WatchStore
GO

--===== START CREATE TABLE =====--
CREATE TABLE Systems(
	username NVARCHAR(50) PRIMARY KEY,
	passwd NVARCHAR(50) NOT NULL UNIQUE,
	EmployeeID NVARCHAR(10) NOT NULL,
	active BIT,
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

	CONSTRAINT PK_EMPLOYEE PRIMARY KEY CLUSTERED (EmployeeID)
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
GO
--===== START CREATE CONSTRAINT =====--
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
--CHECK CONSTRAINT
ALTER TABLE Employees ADD CONSTRAINT CK_Employees_Email CHECK (EmployeeEmail like '%_@%_._%')
ALTER TABLE Customers ADD CONSTRAINT CK_Customers_Email CHECK (CustomerEmail like '%_@%_._%')
GO
--===== END CREATE CONSTRAINT =====--

--===== START CREATE VIEW =====--
-- HIỂN THỊ TẤT CẢ SẢN PHẨM
CREATE VIEW V_Show_AllProducts
AS
	SELECT	ProductID as [Mã sản phẩm], ProductName as [Tên sản phẩm], CategoryName as [Loại sản phẩm], 
			QuantityProduct as [Số lượng], UntilPrice as [Đơn giá], ProductColorName as [Màu sắc], 
			ProductSizeName as [Kích thước], ProductBrandName as [Hãng]
	FROM dbo.Products
	JOIN Categories ON Products.CategoryID = Categories.CategoryID
	JOIN ProductColor ON Products.ProductColorID = ProductColor.ProductColorID
	JOIN ProductSize ON Products.ProductSizeID = ProductSize.ProductSizeID
	JOIN ProductBrand ON Products.ProductBrandID = ProductBrand.ProductBrandID;
GO
-- HIỂN THỊ TẤT CẢ NHÂN VIÊN
CREATE VIEW V_Show_AllEmployees
AS
	SELECT	EmployeeID as [Mã nhân viên], EmployeeName as [Tên nhân viên], EmployeeGender as [Giới tính], 
			EmployeeDoB as [Ngày sinh], EmployeePhone as [Số điện thoại], JobName as [Tên công việc], 
			JobSalary as [Lương tháng], EmployeeAddress as [Địa chỉ], EmployeeEmail as [Email]
 	FROM Employees JOIN JOBS ON Employees.JobID = JOBS.JobID
GO
-- HIỂN THỊ TẤT CẢ KHÁCH HÀNG
CREATE VIEW V_Show_AllCustomers
AS
	SELECT	CustomerID as [Mã khách hàng] ,CustomerName as [Tên khách hàng],  CustomerGender as [Giới tính], 
			CustomerAddress as [Địa chỉ], CustomerPhone as [Số điện thoại], CustomerEmail as [Email]
	FROM Customers
GO
-- HIỂN THỊ TẤT CẢ TÀI KHOẢN
CREATE VIEW V_Show_AllAccounts
AS 
	SELECT	EmployeeName as [Tên nhân viên], username as [Tên đăng nhập], passwd as [Mật khẩu], active as [Tình trạng],
			JobName as [Tên công việc],	EmployeePhone as [Số điện thoại], EmployeeEmail as [Email]
	FROM	Systems JOIN Employees ON Systems.EmployeeID = Employees.EmployeeID
					JOIN JOBS ON Employees.JobID = JOBS.JobID
GO
--===== END CREATE VIEW =====--

--===== START CREATE FUNCTION =====--
-- CHECK TÀI KHOẢN
CREATE FUNCTION FN_Check_AccountID (@username NVARCHAR(50), @passwd NVARCHAR(50))
RETURNS NVARCHAR(10)
AS BEGIN
	DECLARE @id NVARCHAR(10)
	SELECT @id = EmployeeID FROM Systems
	WHERE CAST(username as binary) = CAST(@username as binary) 
		AND CAST(passwd as binary) = CAST(@passwd as binary)
	RETURN @id;
END
GO
-- Lấy ID công việc theo ID nhân viên
CREATE FUNCTION FN_Get_JobID (@id NVARCHAR(50))
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @jobid NVARCHAR(50)
	SET @jobid = (SELECT  JobID From Employees Where EmployeeID = @id)
	RETURN @jobid
END
GO
-- Lấy Tên công việc theo ID
CREATE FUNCTION FN_Get_JobName (@id NVARCHAR(50))
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @jobname NVARCHAR(50)
	SET @jobname = (SELECT  JobName From JOBS Where JobID = (select dbo.FN_Get_JobID(@id)))
	RETURN @jobname
END
GO
--===== END CREATE FUNCTION =====--

--===== START CREATE PROCEDURE ====--
-----========== [JOBS] ==========----- 
-- HIỆN THỊ DANH SÁCH CÔNG VIỆC CỦA CỬA HÀNG
CREATE PROC SP_Show_JOBS
AS
	SELECT JobID as [Mã công việc], JobName as [Tên công việc], JobSalary as [Lương tháng]
	FROM JOBS
GO
-- Lấy công việc của 1 nhân viên
CREATE PROC SP_Get_Job
@empid NVARCHAR(10)
AS
	Select * From JOBS Where JobID = (select dbo.FN_Get_JobID(@empid))
GO
-- HIỆN THỊ DANH SÁCH CÔNG VIỆC
CREATE PROC SP_Show_JOB
AS
	SELECT JobID as [Mã công việc], JobName as [Tên công việc], JobSalary as [Lương tháng] 
	FROM JOBS
GO
-----========== [ACCOUNT] ==========----- 
-- CẬP NHẬT TÀI KHOẢN
CREATE PROC SP_Update_Account
@username NVARCHAR(50), @passwd NVARCHAR(50),
@empID NVARCHAR(10), @active BIT
as
	UPDATE Systems SET username = @username, passwd = @passwd, active = @active
	WHERE EmployeeID = @empID
GO
-- LẤY TÀI KHOẢN THEO ID
CREATE PROC SP_Get_Account 
@username NVARCHAR(50), @passwd NVARCHAR(50)
AS
BEGIN
	DECLARE @id NVARCHAR(10) 
	SET @id = (Select dbo.FN_Check_AccountID(@username, @passwd))
	SELECT * FROM Systems WHERE EmployeeID = @id
END
GO
-- SHOW DANH SÁCH TÀI KHOẢN
CREATE PROC SP_Show_Account
As
	SELECT * FROM V_Show_AllAccounts
GO
-----========== [ORDERS & ORDER DETAILS] ==========----- 
-- TẠO HÓA ĐƠN
CREATE PROC SP_Create_Receipt
@idcus nvarchar(50),
@EMPID NVARCHAR(10)
AS
	INSERT INTO Orders VALUES (@EMPID,@idcus,GETDATE(),0)
GO
-- LẤY MÃ HÓA ĐƠN MỚI TẠO
CREATE PROC SP_Select_NewOrder
AS
	SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC
GO
-- XÓA HÓA ĐƠN
CREATE PROC SP_Delete_Receipt
@ORDERID NVARCHAR(10)
AS
	DELETE FROM Orders WHERE OrderID=@ORDERID
GO
-- ADD VÀO HÓA ĐƠN
CREATE PROC SP_Add_OrderDetails
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
-- HIỂN THỊ CHI TIẾT HÓA ĐƠN THEO SẢN PHẨM
CREATE PROC SP_Show_OrderDetails
@ORDERID NVARCHAR(10)
AS
	SELECT * FROM OrderDetails WHERE OrderID=@ORDERID
GO
-- THANH TOÁN TẠM THỜI
CREATE PROC SP_Pay_Wait 
@id NVARCHAR(10)
as 
BEGIN
	SELECT SUM(OrderDetails.UntilPrice*OrderDetails.OrderQuantity)
	FROM OrderDetails
	WHERE OrderDetails.OrderID= @id
END
GO
-- THANH TOÁN HÓA ĐƠN
CREATE PROC SP_Pay 
@ORDERID NVARCHAR(10)
as 
BEGIN
	
    BEGIN TRANSACTION;
	DECLARE @TIEN INT

    SAVE TRANSACTION MySavePoint;
	BEGIN TRY
		
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
-- SHOW TOÀN BỘ HÓA ĐƠNI
CREATE PROC SP_Show_Order
AS
BEGIN
SELECT * FROM Orders 
END
GO
-----========== [EMPLOYEES] ==========----- 
-- THÊM NHÂN VIÊN 
CREATE PROC SP_Add_Employee 
@NAME NVARCHAR(50), @GENDER NVARCHAR(10), @DOB DATETIME,
@PHONE NVARCHAR(20), @ADDRESS NVARCHAR(50),@EMAIL NVARCHAR(50),@JOBID NVARCHAR(10)
AS
	INSERT INTO Employees VALUES (@NAME,@GENDER,@DOB,@PHONE,@ADDRESS,@EMAIL,@JOBID)
GO
-- UPDATE NHÂN VIÊN
CREATE PROC SP_Update_Employee
@EMPID NVARCHAR(10), @NAME NVARCHAR(50), @GENDER NVARCHAR(10),
@DOB DATETIME, @PHONE NVARCHAR(20), @ADDRESS NVARCHAR(50), 
@EMAIL NVARCHAR(50), @JOBID NVARCHAR(10)
AS
	UPDATE Employees
	SET EmployeeName = @NAME, EmployeeGender = @GENDER, EmployeeDoB = @DOB,
		EmployeePhone = @PHONE, EmployeeAddress = @ADDRESS,
		EmployeeEmail = @EMAIL, JobID = @JOBID
	WHERE EmployeeID = @EMPID
GO
-- DELETE NHÂN VIÊN
CREATE PROC SP_Delete_Employee
@ID NVARCHAR(10)
AS
	DELETE FROM Employees WHERE EmployeeID = @ID;
GO
-- GET NHÂN VIÊN THEO ID
CREATE PROC SP_Get_Employee
@id NVARCHAR(10)
AS
	SELECT * FROM Employees WHERE  EmployeeID = @id
GO
-- SHOW NHÂN VIÊN
CREATE PROC SP_Show_Employee
AS
	SELECT * FROM V_Show_AllEmployees
GO
-- TÌM KIẾM NHÂN VIÊN BẰNG SĐT
CREATE PROC SP_Search_Employee (@phone NVARCHAR(50))
AS
	SELECT * FROM V_Show_AllEmployees 
	WHERE [Số điện thoại] LIKE N'%'+@phone +'%'
GO
-- GET THÔNG TIN CÁ NHÂN CỦA NHÂN VIÊN
CREATE PROC SP_Get_PersonalInfo
@id NVARCHAR(10)
AS
	SELECT * FROM V_Show_AllEmployees WHERE [Mã nhân viên]=@id
GO
-----========== [CUSTOMERS] ==========----- 
-- THÊM KHÁCH HÀNG
CREATE PROC SP_Add_Customer 
@NAME NVARCHAR(50), @GENDER NVARCHAR(10), 
@ADDRESS NVARCHAR(50), @PHONE NVARCHAR(20), @EMAIL NVARCHAR(50)
AS
	INSERT INTO Customers VALUES (@NAME,@GENDER,@ADDRESS,@PHONE,@EMAIL)
GO
-- UPDATE KHÁCH HÀNG
CREATE PROC SP_Update_Customer
@CUSID NVARCHAR(10), @NAME NVARCHAR(50), @GENDER NVARCHAR(10),
@ADDRESS NVARCHAR(50), @PHONE NVARCHAR(20), @EMAIL NVARCHAR(50)
AS
	UPDATE Customers 
	SET CustomerName = @NAME, CustomerGender = @GENDER, CustomerAddress = @ADDRESS,
		CustomerPhone = @PHONE, CustomerEmail = @EMAIL 
	WHERE CustomerID = @CUSID
GO
-- DELETE KHÁCH HÀNG
CREATE PROC SP_Delete_Customer 
@ID NVARCHAR(10)
AS
	DELETE FROM Customers WHERE CustomerID = @ID
GO
-- GET KHÁCH HÀNG THEO ID
CREATE PROC SP_Get_Customer
@id NVARCHAR(10)
AS
	SELECT * FROM Customers WHERE  CustomerID = @id
GO
-- SHOW KHÁCH HÀNG
CREATE PROC SP_Show_Customer
as
	SELECT * FROM V_Show_AllCustomers
GO
-- TÌM KIẾM KHÁCH HÀNG BẰNG SĐT
CREATE PROC SP_Search_Customer (@phone NVARCHAR(50))
AS
	SELECT * FROM V_Show_AllCustomers
	WHERE [Số điện thoại] LIKE N'%'+@phone +'%'
GO
-----========== [PRODUCTS] ==========----- 
-- THÊM SẢN PHẨM
CREATE PROC SP_Add_Product
@NAME NVARCHAR(50),
@CATEGORYID NVARCHAR(10),
@QUANTITY INT,
@PRICE INT,
@COLORID NVARCHAR(10),
@SIZEID NVARCHAR(10),
@BRANDID NVARCHAR(10)
AS
IF (@PRICE >= 0 AND @QUANTITY >= 0)
		INSERT INTO Products VALUES (@NAME,@CATEGORYID,@QUANTITY,@PRICE,@COLORID,@SIZEID,@BRANDID)
GO
-- SỬA SẢN PHẨM
CREATE PROC SP_Update_Product
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
	IF (@PRICE >= 0 AND @QUANTITY >= 0)
		UPDATE Products
		SET ProductName = @NAME, CategoryID = @CATEGORYID, QuantityProduct = @QUANTITY, UntilPrice = @PRICE, ProductColorID = @COLORID, ProductSizeID = @SIZEID, ProductBrandID = @BRANDID
		WHERE ProductID = @PRODUCTID
	END
GO
-- XÓA SẢN PHẨM
CREATE PROC SP_Delete_Product
@PRODUCTID NVARCHAR(10)
AS
	DELETE FROM Products WHERE ProductID=@PRODUCTID
GO
-- GET SẢN PHẨM THEO ID
CREATE PROC SP_Get_Product
@id NVARCHAR(10)
AS
	SELECT * FROM Products WHERE ProductID = @id
GO
-- HIỂN THỊ SẢN PHẨM
CREATE PROC SP_Show_Product
AS
	SELECT * FROM V_Show_AllProducts
GO
-- LỌC SẢN PHẨM
CREATE PROC SP_Search_Product
(@nameCol VARCHAR(50), @value NVARCHAR(50))
AS
IF(@nameCol LIKE 'Name')
	BEGIN
		SELECT * FROM V_Show_AllProducts
		WHERE [Tên sản phẩm]  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Category')
	BEGIN
		SELECT * FROM V_Show_AllProducts
		WHERE [Loại sản phẩm]  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Color')
	BEGIN
		SELECT * FROM V_Show_AllProducts
		WHERE [Màu sắc]  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Size')
	BEGIN
		SELECT * FROM V_Show_AllProducts
		WHERE [Kích thước]  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Brand')
	BEGIN
		SELECT * FROM V_Show_AllProducts
		WHERE [Hãng]  LIKE N'%' + @value + '%'
	END
GO
-----========== [PRODUCTCOLORS - PRODUCTSIZES - PRODUCTBRANDS - CATEGORIES] ==========----- 
-- HIỆN THỊ DANH SÁCH MÀU CỦA SẢN PHẨM 
CREATE PROC SP_Show_ProductColor
AS
	SELECT ProductColorID as [Mã màu], ProductColorName [Tên màu] 
	FROM ProductColor
GO
-- HIỆN THỊ DANH SÁCH KÍCH THƯỚC CỦA SẢN PHẨM
CREATE PROC SP_Show_ProductSize
AS
	SELECT ProductSizeID as [Mã kích cỡ], ProductSizeName [Tên kích cỡ] 
	FROM ProductSize
GO
-- HIỆN THỊ DANH SÁCH HÃNG CỦA SẢN PHẨM 
CREATE PROC SP_Show_ProductBrand
AS
	SELECT ProductBrandID as [Mã hãng], ProductBrandName as [Tên hãng]
	FROM ProductBrand
GO
-- HIỆN THỊ DANH SÁCH THỂ LOẠI CỦA SẢN PHẨM 
CREATE PROC SP_Show_Category
AS
	SELECT CategoryID as [Mã loại], CategoryName as [Tên loại]
	FROM Categories
GO
--===== END CREATE PROCEDURE =====--

--===== START CREATE TRIGGER ====--
--====== TẠO TRIGGER TẠO TÀI KHOẢN ĐĂNG NHẬP THEO QUYỀN NGƯỜI DÙNG =====--
CREATE TRIGGER TRG_CreateUserLogin ON Systems FOR INSERT AS
BEGIN
	DECLARE @username NVARCHAR(50), @passwd NVARCHAR(50), @id NVARCHAR(50), @db_name NVARCHAR(MAX), @active BIT
	SET @db_name = DB_NAME()
	SELECT @username = username, @passwd = passwd, @id = EmployeeID, @active = active FROM inserted
	DECLARE @job NVARCHAR(50) 
	SET @job = (SELECT dbo.FN_Get_JobName(@id))

	EXEC('CREATE LOGIN ['+@username+'] WITH PASSWORD = '''+@passwd+''', CHECK_POLICY = OFF, DEFAULT_DATABASE=['+@db_name+']')
	EXEC('CREATE USER ['+@username+'] FOR LOGIN ['+@username+']') 

	IF @job Like 'Admin%'
	Begin
		EXEC sp_addrolemember 'db_owner', @username
		EXEC sp_addrolemember 'db_accessadmin', @username
		EXEC sp_addrolemember 'db_securityadmin', @username
		EXEC sp_addrolemember 'AdminStore', @username
		EXEC('USE master; GRANT ALTER ANY LOGIN TO ['+ @username+'] WITH GRANT OPTION')
	End
	ELSE IF @job like 'Nhân viên%'
	Begin
		EXEC sp_addrolemember 'EmployeeStore', @username
	End

	IF @active = 0
		EXEC('ALTER LOGIN ['+@username+'] DISABLE')
	ELSE
		EXEC('ALTER LOGIN ['+@username+'] ENABLE')
END
GO
--====== TẠO TRIGGER CẬP NHẬT TÀI KHOẢN ĐĂNG NHẬP THEO QUYỀN NGƯỜI DÙNG =====--
CREATE TRIGGER TRG_UpdateUserLogin ON Systems FOR UPDATE AS
BEGIN
	DECLARE @old_active BIT, @new_active BIT,
			@old_username NVARCHAR(50), @new_username NVARCHAR(50),
			@old_passwd NVARCHAR(50), @new_passwd NVARCHAR(50),
			@id NVARCHAR(10), @db_name NVARCHAR(MAX)
	SET @db_name = DB_NAME()

	SELECT @old_username = username, @old_passwd = passwd, @id = EmployeeID, @old_active = active
	FROM deleted
	SELECT @new_username = username, @new_passwd = passwd, @id = EmployeeID, @new_active  = active
	FROM inserted
	
	DECLARE @job NVARCHAR(50) 
	set @job = (SELECT dbo.FN_Get_JobName(@id))
	IF (@new_username = @old_username AND @new_passwd = @old_passwd AND @new_active = @old_active)
		RETURN
	ELSE IF (@new_username <> @old_username) 
	Begin
		EXEC('DROP USER ['+@old_username+']')
		EXEC('DROP LOGIN ['+@old_username+']')
		EXEC('CREATE LOGIN ['+@new_username+'] WITH PASSWORD = '''+@new_passwd+''', CHECK_POLICY = OFF, DEFAULT_DATABASE=['+@db_name+']')
		EXEC('CREATE USER ['+@new_username+'] FOR LOGIN ['+@new_username+']') 
	
		IF @job Like 'Admin%'
		begin
			EXEC sp_addrolemember 'db_owner', @new_username
			EXEC sp_addrolemember 'db_accessadmin', @new_username
			EXEC sp_addrolemember 'db_securityadmin', @new_username
		EXEC sp_addrolemember 'AdminStore', @new_username
			EXEC('USE master; GRANT ALTER ANY LOGIN TO ['+ @new_username+'] WITH GRANT OPTION')
		end
		ELSE IF @job like 'Nhân viên%'
		begin
			EXEC sp_addrolemember 'EmployeeStore', @new_username
			EXEC('USE master; GRANT ALTER ANY LOGIN TO ['+ @new_username+'] WITH GRANT OPTION')
		end
	End
	ELSE IF (@new_passwd <> @old_passwd)
	Begin
		EXEC('ALTER LOGIN ['+@new_username+'] WITH PASSWORD = '''+@new_passwd+''' OLD_PASSWORD = ''' + @old_passwd + '''')
	End
	ELSE 
	Begin
		IF @new_active = 0
			EXEC('ALTER LOGIN ['+@new_username+'] DISABLE')
		ELSE
			EXEC('ALTER LOGIN ['+@new_username+'] ENABLE')
	end
END
GO
--====== TẠO TRIGGER XÓA TÀI KHOẢN ĐĂNG NHẬP =====--
CREATE TRIGGER TRG_DeleteUserLogin ON Systems FOR DELETE AS
BEGIN
	DECLARE @username NVARCHAR(50)

	SET @username = (SELECT username From deleted)

	EXEC('DROP USER ['+ @username +']')
	EXEC('DROP LOGIN ['+ @username +']')
END
GO
--====== TẠO TRIGGER THÊM TÀI KHOẢN KHI THÊM NHÂN VIÊN =====--
CREATE TRIGGER TRG_AddAcount ON Employees AFTER INSERT AS
BEGIN
	INSERT INTO Systems VALUES ((SELECT Employees.EmployeeName FROM inserted,Employees WHERE inserted.EmployeeID=Employees.EmployeeID),
	(SELECT Employees.EmployeePhone FROM Employees,inserted WHERE inserted.EmployeeID=Employees.EmployeeID),

	(SELECT Employees.EmployeeID FROM Employees,inserted WHERE inserted.EmployeeID=Employees.EmployeeID),1)
END
GO
--====== TẠO TRIGGER CẬP NHẬT SỐ LƯỢNG SẢN PHẨM CỦA BẢNG PRODUCTS VÀ ORDERDETAILS KHI THÊM SẢN PHẨM VÀO BẢNG ORDERDETAILS=====--
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
--====== TẠO TRIGGER CẬP NHẬT SỐ LƯỢNG SẢN PHẨM TRONG BẢNG PRODUCTS KHI XÓA SẢN PHẨM TRONG BẢNG ORDERDETAILS=====--
CREATE TRIGGER TRG_UpProduct_delete ON OrderDetails AFTER DELETE AS
BEGIN

		UPDATE Products SET QuantityProduct=Products.QuantityProduct+(SELECT OrderQuantity FROM deleted WHERE ProductID= Products.ProductID )
		FROM deleted
		WHERE Products.ProductID=deleted.ProductID
		
END
GO
--===== END CREATE TRIGGER ====--


--===== END ADD DATA =====--

--===== Security and Authorization =====--
-- Authorization EMPLOYEE
CREATE ROLE EmployeeStore
--View Employee
GRANT SELECT ON [dbo].[V_Show_AllCustomers] TO EmployeeStore
GRANT SELECT ON [dbo].[V_Show_AllProducts] TO EmployeeStore
--Proc Employee
GRANT EXECUTE ON [dbo].[SP_Add_Customer] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Get_Account] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Get_Customer] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Get_Job] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Get_Job] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Get_PersonalInfo] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Get_Product] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Search_Customer] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Search_Product] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Show_Customer] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Show_Product] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Update_Account] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Update_Customer] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Add_OrderDetails] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Pay] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Show_OrderDetails] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Show_Order] TO EmployeeStore
GRANT EXECUTE ON [dbo].[SP_Pay_Wait] TO EmployeeStore


-- Authorization ADMIN
CREATE ROLE AdminStore
--View Admin
GRANT SELECT ON [dbo].[V_Show_AllAccounts] TO AdminStore
GRANT SELECT ON [dbo].[V_Show_AllCustomers] TO AdminStore
GRANT SELECT ON [dbo].[V_Show_AllEmployees] TO AdminStore
GRANT SELECT ON [dbo].[V_Show_AllProducts] TO AdminStore

--Proc Admin
GRANT EXECUTE ON [dbo].[SP_Add_Customer] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Add_Employee] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Add_OrderDetails] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Add_Product] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Create_Receipt] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Delete_Customer] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Delete_Employee]TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Delete_Product] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Delete_Receipt] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Get_Account] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Get_Customer] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Get_Employee] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Get_PersonalInfo] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Get_Product] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Pay] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Pay_Wait] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Search_Customer] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Search_Employee] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Search_Product] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Select_NewOrder] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_Account] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_Category] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_Customer] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_Employee] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_JOBS] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_Order] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_OrderDetails] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_Product] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_ProductBrand] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_ProductColor] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Show_ProductSize] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Update_Account] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Update_Customer] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Update_Employee] TO AdminStore
GRANT EXECUTE ON [dbo].[SP_Update_Product] TO AdminStore
GO

--===== START ADD DATA =====--
--JOBS
INSERT INTO JOBS VALUES(N'Admin', 0)
INSERT INTO JOBS VALUES(N'Nhân viên', 20000000)
--Employees
INSERT INTO Employees VALUES(N'admin', N'Nam', '1999-10-10', '1', 'TPHCM', 'admin123@gmail.com', 'JOB1')
INSERT INTO Employees VALUES(N'employee', N'Nam', '1999-10-1', '123', 'TPHCM', 'nguyenvana123@gmail.com', 'JOB2')
-- ProductColor
INSERT INTO ProductColor VALUES(N'Đen')
INSERT INTO ProductColor VALUES(N'Trắng')
INSERT INTO ProductColor VALUES(N'Bạc')
INSERT INTO ProductColor VALUES(N'Vàng')
-- ProductSize
INSERT into ProductSize values ('Size S')
INSERT into ProductSize values ('Size M')
INSERT into ProductSize values ('Size L')
INSERT into ProductSize values ('Size XL')
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
INSERT INTO Customers VALUES(N'Lê Văn A', N'Nam', 'TPHCM', '123', 'levana123@gmail.com')
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