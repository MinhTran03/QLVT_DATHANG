USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_addctddh]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_addctddh]
@masoddh NCHAR(8),
@mavt NCHAR(4),
@soluong INT,
@dongia FLOAT
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
	
	INSERT INTO dbo.CTDDH
	        ( MasoDDH ,
	          MAVT ,
	          SOLUONG ,
	          DONGIA 
	        )
	VALUES  ( @masoddh , -- MasoDDH - nchar(8)
	          @mavt , -- MAVT - nchar(4)
	          @soluong , -- SOLUONG - int
	          @dongia
	        )
	        
COMMIT TRANSACTION



GO
/****** Object:  StoredProcedure [dbo].[sp_addctpn]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_addctpn] @mapn NCHAR(8),
@mavt NCHAR(4),
@soluong INT,
@dongia FLOAT
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
	
	--WAITFOR DELAY '00:00:10'
	
		UPDATE dbo.Vattu SET SOLUONGTON = SOLUONGTON + @soluong WHERE MAVT = @mavt

		INSERT INTO dbo.CTPN
	        ( MAPN, MAVT, SOLUONG, DONGIA )
		VALUES  ( @mapn, -- MAPN - nchar(8)
				  @mavt, -- MAVT - nchar(4)
				  @soluong, -- SOLUONG - int
				  @dongia -- DONGIA - float
				  )
	
COMMIT TRANSACTION











GO
/****** Object:  StoredProcedure [dbo].[sp_addctpx]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE PROC [dbo].[sp_addctpx]
@mapx NCHAR(8),
@mavt NCHAR(4),
@soluong INT,
@dongia FLOAT
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
	
	--WAITFOR DELAY '00:00:10'
	IF((SELECT SOLUONGTON FROM dbo.Vattu WHERE MAVT = @mavt) >= @soluong)
	BEGIN
		UPDATE dbo.Vattu SET SOLUONGTON = SOLUONGTON - @soluong WHERE MAVT = @mavt

		INSERT INTO dbo.CTPX
	        ( MAPX, MAVT, SOLUONG, DONGIA )
		VALUES  ( @mapx, -- MAPX - nchar(8)
				  @mavt, -- MAVT - nchar(4)
				  @soluong, -- SOLUONG - int
				  @dongia -- DONGIA - float
				  )
	END
	ELSE
		RAISERROR(N'Số lượng vật tư không đủ', 18, 1)
	
COMMIT TRANSACTION










GO
/****** Object:  StoredProcedure [dbo].[sp_addddh]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_addddh]
@masoddh NCHAR(8),
@ngay DATE,
@nhacc NVARCHAR(100),
@manv INT,
@makho NCHAR(4)
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION

	INSERT INTO dbo.DatHang
	        ( MasoDDH ,
	          NGAY ,
	          NhaCC ,
	          MANV ,
	          MAKHO
	        )
	VALUES  ( @masoddh , -- MasoDDH - nchar(8)
	          @ngay , -- NGAY - date
			  @nhacc , -- NhaCC - nvarchar(100)
	          @manv , -- MANV - int
	          @makho -- MAKHO - nchar(4)
	        )
COMMIT TRANSACTION


GO
/****** Object:  StoredProcedure [dbo].[sp_addemployee]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_addemployee]
@manv INT,
@ho NVARCHAR(40),
@ten NVARCHAR(40),
@diachi NVARCHAR(100),
@ngaysinh DATETIME,
@luong FLOAT,
@ttx INT
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
	
	DECLARE @countnv INT
	DECLARE @index INT = 1
	--DECLARE @mamoi INT = 0
	DECLARE @macn NCHAR(10)

	-- lay ma cn cua chi nhanh hien tai
	SELECT @macn = MACN FROM dbo.ChiNhanh

	---- dem so luong nv
	--SELECT @countnv = COUNT(0) FROM LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien
	--SET @countnv = @countnv + 1

	---- tim kiem ma moi dua vao index
	--WHILE @index <= @countnv
	--BEGIN
	--	IF NOT EXISTS (SELECT 0 FROM LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien WHERE MANV = @index)
	--	BEGIN
	--		SET @mamoi = @index
	--		--break
	--		SET @index = @countnv + 1
	--	END
	--	SET @index = @index + 1
	--END

	-- insert nhan vien
	INSERT INTO dbo.NhanVien (MANV, HO, TEN, DIACHI, NGAYSINH, LUONG, MACN, TrangThaiXoa)
	VALUES (@manv, @ho, @ten, @diachi, @ngaysinh, @luong, @macn, @ttx)
	
	--EXEC LNK0_QLVT.QLVT_DATHANG.sys.sp_startpublication_snapshot @publication = 'QLVT_DATHANG_CN1'
	--SELECT @mamoi AS MANVMOI
	--WAITFOR DELAY '00:00:10'

COMMIT TRANSACTION
	



















GO
/****** Object:  StoredProcedure [dbo].[sp_addpn]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[sp_addpn]
@mapn NCHAR(8),
@ngay DATE,
@maddh NCHAR(8),
@manv INT,
@makho NCHAR(4)
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION

	INSERT INTO dbo.PhieuNhap
	        ( MAPN ,
	          NGAY ,
	          MasoDDH ,
	          MANV ,
	          MAKHO
	        )
	VALUES  ( @mapn , -- MAPN - nchar(8)
	          @ngay , -- NGAY - date
	          @maddh , -- MasoDDH - nchar(8)
	          @manv , -- MANV - int
	          @makho  -- MAKHO - nchar(4)
	        )
	        
COMMIT TRANSACTION



GO
/****** Object:  StoredProcedure [dbo].[sp_addpx]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_addpx]
@mapx NCHAR(8),
@ngay DATE,
@hotenkh NVARCHAR(100),
@manv INT,
@makho NCHAR(4)
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION

	INSERT INTO dbo.PhieuXuat
	        ( MAPX ,
	          NGAY ,
	          HOTENKH ,
	          MANV ,
	          MAKHO
	        )
	VALUES  ( @mapx , -- MAPX - nchar(8)
	          @ngay , -- NGAY - date
	          @hotenkh , -- HOTENKH - nvarchar(100)
	          @manv , -- MANV - int
	          @makho
	        )
	        
COMMIT TRANSACTION


GO
/****** Object:  StoredProcedure [dbo].[sp_checkinstockmaterial]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_checkinstockmaterial]
@MAPHIEU NCHAR(8),
@MAVT NCHAR(4),
@SOLUONGTHEM INT
AS
BEGIN
	IF (@SOLUONGTHEM <= (SELECT SOLUONG FROM CTddh WHERE MasoDDH = @MAPHIEU AND MAVT = @MAVT))
		SELECT SOLUONG FROM CTDDH WHERE MasoDDH = @MAPHIEU AND MAVT = @MAVT
	ELSE
		RAISERROR(50001, 18, 1, N'Số lượng vật tư không hợp lệ.')
END



GO
/****** Object:  StoredProcedure [dbo].[sp_chuyenchinhanh]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROC [dbo].[sp_chuyenchinhanh]
@manv INT,
@chinhanhmoi NCHAR(10)
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	DECLARE @ttx INT
	SELECT @ttx = TrangThaiXoa FROM dbo.NhanVien WHERE MANV = @manv
	IF(@ttx = 0)
	BEGIN
		DECLARE @countnv INT
		DECLARE @index INT = 1
		DECLARE @mamoi INT = 0

		-- dem so luong nv
		SELECT @countnv = COUNT(0) FROM LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien
		SET @countnv = @countnv + 1

		-- tim kiem ma moi dua vao index
		WHILE @index <= @countnv
		BEGIN
			IF NOT EXISTS (SELECT 0 FROM LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien WHERE MANV = @index)
			BEGIN
				SET @mamoi = @index
				--break
				SET @index = @countnv + 1
			END
			SET @index = @index + 1
		END

		-- insert nhan vien
		INSERT INTO LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien (MANV, HO, TEN, DIACHI, NGAYSINH, LUONG, MACN, TrangThaiXoa)
		SELECT MANV = @mamoi, HO, TEN, DIACHI, NGAYSINH, LUONG, MACN = @chinhanhmoi, TrangThaiXoa = 0
		FROM dbo.NhanVien
		WHERE MANV = @manv
	
		UPDATE dbo.NhanVien SET TrangThaiXoa = 1
		WHERE MANV = @manv
	END
	ELSE
		RAISERROR(50001, 18, 1, N'Nhân viên đã chuyển chi nhánh')

	--WAITFOR DELAY '00:00:10'
COMMIT TRANSACTION
----------------------------------------------------------------------------------------------------------------------------------------------------------








GO
/****** Object:  StoredProcedure [dbo].[sp_createlogin]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_createlogin]
	@LOGINNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50), --MA NHAN VIEN
	@ROLE VARCHAR(50)
AS
BEGIN
	DECLARE @RET INT

	--alters a new SQL Server login that allows a user to connect to an instance of SQL Server by using SQL Server authentication.
	EXEC @RET = sp_addlogin @LOGINNAME, @PASS, 'QLVT_DATHANG'
	IF (@RET = 1)  -- LOGIN NAME BI TRUNG
		RETURN 0
		--RAISERROR(50001, 18, 1, N'Login name')

	--Adds a database user to the current database.
	EXEC @RET= sp_grantdbaccess @LOGINNAME, @USERNAME
	IF (@RET = 1)  -- USER NAME BI TRUNG
	BEGIN
		EXEC sp_droplogin @LOGINNAME
		--RAISERROR(50001, 18, 1, N'Mã nhân viên')
		RETURN 1
	END

	--Adds a database user, database role, Windows login, or Windows group to a database role in the current database.
	--Da kiem tra USERNAME bi trung o phia tren
	EXEC sp_addrolemember @ROLE, @USERNAME

	IF (@ROLE = 'congty' OR @ROLE = 'chinhanh')
	BEGIN
		-- nhom quyen tao login cho role  tuong ung
		EXEC sp_addsrvrolemember @LOGINNAME, 'securityadmin'
		--EXEC sp_addsrvrolemember @LOGINNAME, 'dbcreator'
		--EXEC sp_addsrvrolemember @LOGINNAME, 'processadmin'
	END

	--ELSE IF (@ROLE = 'chinhanh')
	--BEGIN
	--	-- nhom quyen tao login cho role  tuong ung
	--	EXEC sp_addsrvrolemember @LOGINNAME, 'securityadmin'
	--	EXEC sp_addsrvrolemember @LOGINNAME, 'dbcreator'
	--	EXEC sp_addsrvrolemember @LOGINNAME, 'processadmin'
	--END

	--ELSE IF (@ROLE = 'user')
	--BEGIN
	--	EXEC sp_addsrvrolemember @LOGINNAME, 'processadmin'
	--END

	RETURN 0  -- THANH CONG
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deletebykey]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_deletebykey]
@table sysname,
@value sysname
AS
BEGIN

	DECLARE @col_id_name sysname
	DECLARE @sql nvarchar(max)

	SELECT @col_id_name = COLUMN_NAME
	FROM QLVT_DATHANG.INFORMATION_SCHEMA.KEY_COLUMN_USAGE
	WHERE TABLE_NAME = @table AND CONSTRAINT_NAME LIKE 'PK_%'

	SET @sql = 'DELETE FROM ' + @table + ' WHERE ' + @col_id_name + ' = ''' + @value + ''''

	EXEC sys.sp_executesql @sql

END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_deleteemployee]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_deleteemployee]
@manv INT
AS
BEGIN
	DELETE FROM dbo.NhanVien WHERE MANV = @manv
END

GO
/****** Object:  StoredProcedure [dbo].[sp_dsddhchuacophieunhap]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_dsddhchuacophieunhap] AS
BEGIN
  SELECT DH.MasoDDH AS 'Mã số DDH', DH.NGAY AS 'Ngày Đặt', DH.NhaCC AS 'Nhà Cung Cấp',
      NV.HO + '' + NV.TEN AS 'Họ và Tên', KHO.TENKHO AS 'Kho', KHO.MAKHO AS 'MAKHO'
  FROM
  (
    SELECT * FROM DBO.DatHang
  ) DH
  LEFT JOIN DBO.PhieuNhap PN ON PN.MasoDDH = DH.MasoDDH
  INNER JOIN DBO.NhanVien NV ON NV.MANV = DH.MANV
  INNER JOIN DBO.Kho KHO ON KHO.MAKHO = DH.MAKHO
  WHERE PN.MAPN IS NULL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_dsvtdathang]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_dsvtdathang]
@madh nchar(8)
AS
BEGIN
  select VT.TENVT, CT.SOLUONG, CT.DONGIA, CT.MAVT from 
  (
    select MAVT, SOLUONG, DONGIA from dbo.CTDDH
    where MasoDDH = @madh
  ) CT
  INNER JOIN dbo.Vattu VT ON CT.MAVT = VT.MAVT
END

GO
/****** Object:  StoredProcedure [dbo].[sp_execmymsgnum]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_execmymsgnum]
AS
BEGIN
	EXEC sys.sp_dropmessage @msgnum = 50001 -- int
	EXEC sys.sp_dropmessage @msgnum = 50002 -- int

	EXEC sys.sp_addmessage @msgnum = 50001, -- int
    @severity = 18, -- smallint
    @msgtext = N'%s' -- nvarchar(255)
	
	EXEC sys.sp_addmessage @msgnum = 50002, -- int
    @severity = 18, -- smallint
    @msgtext = N'%s' -- nvarchar(255)
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_getallctddh]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getallctddh]
AS
BEGIN
	SELECT MasoDDH, MAVT, SOLUONG, DONGIA FROM dbo.CTDDH
END



GO
/****** Object:  StoredProcedure [dbo].[sp_getallctpn]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_getallctpn]
AS
BEGIN
		SELECT MAPN, MAVT, SOLUONG, DONGIA FROM dbo.CTPN
END



GO
/****** Object:  StoredProcedure [dbo].[sp_getallctpx]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getallctpx]
AS
BEGIN
	SELECT MAPX, MAVT, SOLUONG, DONGIA FROM dbo.CTPX
END



GO
/****** Object:  StoredProcedure [dbo].[sp_getallddh]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getallddh]
AS
BEGIN
	SELECT MasoDDH, NGAY, NhaCC, MANV, MAKHO FROM dbo.DatHang
END



GO
/****** Object:  StoredProcedure [dbo].[sp_getallemployee]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getallemployee]
AS
BEGIN
	SELECT MANV, HO, TEN, DIACHI, NGAYSINH, LUONG, MACN, TrangThaiXoa FROM dbo.NhanVien
END

GO
/****** Object:  StoredProcedure [dbo].[sp_getallmanv]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getallmanv]
AS
BEGIN
	SELECT nv1.MANV
	FROM LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien nv1
	UNION
	SELECT nv2.MANV
	FROM dbo.NhanVien nv2
END

----------------------------------------------------------------------------------------------------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[sp_getallpn]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getallpn]
AS
BEGIN
	SELECT MAPN, NGAY, MasoDDH, MANV, MAKHO FROM dbo.PhieuNhap
END





GO
/****** Object:  StoredProcedure [dbo].[sp_getallpx]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getallpx]
AS
BEGIN
	SELECT MAPX, NGAY, HOTENKH, MANV, MAKHO FROM dbo.PhieuXuat
END



GO
/****** Object:  StoredProcedure [dbo].[sp_getdsdvt]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getdsdvt]
AS
BEGIN
	SELECT DISTINCT DVT FROM dbo.Vattu
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_getdsvattuconhang]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_getdsvattuconhang]
AS
BEGIN
	SELECT MAVT, TENVT, SOLUONGTON FROM dbo.Vattu WHERE SOLUONGTON > 0
END



GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_login]
	@LOGINNAME NVARCHAR (50)
AS
BEGIN

	DECLARE		@TENUSER NVARCHAR(50)

	SELECT		@TENUSER = NAME 
	FROM		sys.sysusers 
	WHERE		sid = SUSER_SID(@LOGINNAME)
 
	SELECT		USERNAME = @TENUSER,
				HOTEN = (SELECT HO + ' ' + TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
				TENNHOM = NAME
	FROM		sys.sysusers 
	WHERE		UID = (SELECT GROUPUID 
						FROM SYS.SYSMEMBERS 
						WHERE MEMBERUID = (SELECT UID 
											FROM sys.sysusers 
											WHERE NAME = @TENUSER))

END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_removelogin]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_removelogin] @EMPLOYEEID VARCHAR(50)
AS
BEGIN
	DECLARE @SID VARBINARY(85)
	SELECT @SID = sid FROM sys.sysusers WHERE name = @EMPLOYEEID
	IF (@SID IS NULL)
		RAISERROR(50001, 18, 1, 'Nhân viên chưa tạo tài khoản')
	ELSE
	BEGIN
		DECLARE @LGNAME VARCHAR(50)
		SELECT @LGNAME = loginname FROM sys.syslogins WHERE sid = @SID
		IF(@LGNAME IS NOT NULL)
		BEGIN
			EXEC SP_DROPUSER @EMPLOYEEID
			EXEC SP_DROPLOGIN @LGNAME
		END
		ELSE
			RAISERROR(50001, 18, 1, 'Nhân viên chưa tạo tài khoản')
	END
END

GO
/****** Object:  StoredProcedure [dbo].[sp_rep_dsctvt]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_rep_dsctvt]
@MODE CHAR,
@LOAI CHAR,
@BEGIN CHAR(10),
@END CHAR(10)
AS
BEGIN
  IF @MODE = 'C'
    IF @LOAI = 'N'
    SELECT SUBSTRING(CONVERT(VARCHAR(8), PN.NGAY, 3), 4, 5) AS [THOIGIAN], VT.TENVT, SUM(CT.SOLUONG) AS 'SOLUONG', SUM(CT.SOLUONG * CT.DONGIA) AS 'TRIGIA'
    FROM 
    (
      SELECT MAPN, NGAY
      FROM dbo.PhieuNhap
      WHERE NGAY BETWEEN CONVERT(DATETIME, @BEGIN, 102) and CONVERT(DATETIME, @END, 102)
    ) PN
    INNER JOIN dbo.CTPN CT ON CT.MAPN = PN.MAPN
    INNER JOIN dbo.Vattu VT ON VT.MAVT = CT.MAVT
    GROUP BY SUBSTRING(CONVERT(VARCHAR(8), PN.NGAY, 3), 4, 5), VT.TENVT
    ELSE
    IF @LOAI = 'X'
      SELECT SUBSTRING(CONVERT(VARCHAR(8), PX.NGAY, 3), 4, 5) AS [THOIGIAN], VT.TENVT, SUM(CT.SOLUONG) AS 'SOLUONG', SUM(CT.SOLUONG * CT.DONGIA) AS 'TRIGIA'
      FROM 
      (
      SELECT MAPX, NGAY
      FROM dbo.PhieuXuat
      WHERE NGAY BETWEEN CONVERT(DATETIME, @BEGIN, 102) and CONVERT(DATETIME, @END, 102)
      ) PX
      INNER JOIN dbo.CTPX CT ON CT.MAPX = PX.MAPX
      INNER JOIN dbo.Vattu VT ON VT.MAVT = CT.MAVT
      GROUP BY SUBSTRING(CONVERT(VARCHAR(8), PX.NGAY, 3), 4, 5), VT.TENVT
  IF @MODE = 'F'
    IF @LOAI = 'N'
    SELECT SUBSTRING(CONVERT(VARCHAR(8), PN.NGAY, 3), 4, 5) AS [THOIGIAN], VT.TENVT, SUM(CT.SOLUONG) AS 'SOLUONG', SUM(CT.SOLUONG * CT.DONGIA) AS 'TRIGIA'
    FROM 
    (
      SELECT MAPN, NGAY
      FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuNhap
      WHERE NGAY BETWEEN CONVERT(DATETIME, @BEGIN, 102) and CONVERT(DATETIME, @END, 102)
    ) PN
    INNER JOIN LNK0_QLVT.QLVT_DATHANG.dbo.CTPN CT ON CT.MAPN = PN.MAPN
    INNER JOIN dbo.Vattu VT ON VT.MAVT = CT.MAVT
    GROUP BY SUBSTRING(CONVERT(VARCHAR(8), PN.NGAY, 3), 4, 5), VT.TENVT
    ELSE
    IF @LOAI = 'X'
      SELECT SUBSTRING(CONVERT(VARCHAR(8), PX.NGAY, 3), 4, 5) AS [THOIGIAN], VT.TENVT, SUM(CT.SOLUONG) AS 'SOLUONG', SUM(CT.SOLUONG * CT.DONGIA) AS 'TRIGIA'
      FROM 
      (
      SELECT MAPX, NGAY
      FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuXuat
      WHERE NGAY BETWEEN CONVERT(DATETIME, @BEGIN, 102) and CONVERT(DATETIME, @END, 102)
      ) PX
      INNER JOIN LNK0_QLVT.QLVT_DATHANG.dbo.CTPX CT ON CT.MAPX = PX.MAPX
      INNER JOIN dbo.Vattu VT ON VT.MAVT = CT.MAVT
      GROUP BY SUBSTRING(CONVERT(VARCHAR(8), PX.NGAY, 3), 4, 5), VT.TENVT
END





GO
/****** Object:  StoredProcedure [dbo].[sp_rep_DSDDHChuaCoPhieuNhap]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_rep_DSDDHChuaCoPhieuNhap]
AS
BEGIN
	SELECT rs1.MasoDDH AS 'Mã số DDH', rs1.Ngay AS 'Ngày đặt', rs1.NhaCC AS 'Nhà cung cấp', rs1.NVDATHANG AS 'NV đặt hàng', vt.TENVT AS 'Tên vật tư', ctddh.SOLUONG AS 'Số lượng', ctddh.DONGIA AS 'Đơn giá'
	FROM
	(
		SELECT dh.MasoDDH, dh.Ngay, dh.NhaCC, nv.HO + ' ' + nv.TEN AS 'NVDATHANG'--, ctddh.MAVT, ctddh.SOLUONG, ctddh.DONGIA
		FROM 
		(
			SELECT MasoDDH, NGAY, NhaCC, MANV
			FROM dbo.DatHang
			-- lọc ra mã số  ddh chưa có trong phiếu nhập
			WHERE MasoDDH NOT IN (SELECT MasoDDH FROM dbo.PhieuNhap)
		) dh
		LEFT JOIN dbo.NhanVien nv ON nv.MANV = dh.MANV
	) rs1
	LEFT JOIN dbo.CTDDH ctddh ON ctddh.MasoDDH = rs1.MasoDDH
	INNER JOIN dbo.Vattu vt ON vt.MAVT = ctddh.MAVT
END


GO
/****** Object:  StoredProcedure [dbo].[sp_rep_dsnv]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_rep_dsnv]
AS
BEGIN
	SELECT MANV AS 'Mã NV', HO + ' ' + TEN AS 'Họ tên', DIACHI AS 'Địa chỉ', NGAYSINH AS 'Ngày sinh', LUONG AS 'Lương'
	FROM dbo.NhanVien
	ORDER BY TEN, HO
END


GO
/****** Object:  StoredProcedure [dbo].[sp_rep_dsvt]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_rep_dsvt] AS
SELECT MAVT as'Mã VT', TENVT as 'Tên VT', DVT as 'Đơn vị tính', SOLUONGTON as 'Số lượng tồn' FROM dbo.Vattu ORDER BY TENVT ASC
----------------------------------------------------------------------------------------------------------------------------------------------------------





GO
/****** Object:  StoredProcedure [dbo].[sp_rep_hdnv]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_rep_hdnv]
@MANV INT,
@LOAI CHAR,
@BEGIN CHAR(10),
@END CHAR(10)
AS
BEGIN
  IF @LOAI = 'N'
    SELECT SUBSTRING(CONVERT(VARCHAR(8), PN.NGAY, 3), 4, 5) AS 'Ngày',
		PN.MAPN AS 'Mã Phiếu', PN.HOTENKH AS 'Họ và Tên', VT.TENVT AS 'Tên Vật Tư', 
		KHO.TENKHO AS 'Tên Kho',CT.SOLUONG AS 'Số Lượng',
		DONGIA AS 'Đơn Giá', CT.SOLUONG * CT.DONGIA AS 'Trị Giá'
    FROM 
    (
		SELECT MAPN, NGAY, MAKHO, HOTENKH = '' 
		FROM PhieuNhap
		WHERE MANV = @MANV AND NGAY BETWEEN CONVERT(DATETIME, @BEGIN, 102) and CONVERT(DATETIME, @END, 102)
    ) PN
    INNER JOIN dbo.CTPN CT ON CT.MAPN = PN.MAPN
    INNER JOIN dbo.Vattu VT ON VT.MAVT = CT.MAVT
	INNER JOIN DBO.KHO KHO ON KHO.MAKHO = PN.MAKHO
  ELSE
    IF @LOAI = 'X'
      SELECT SUBSTRING(CONVERT(VARCHAR(8), PX.NGAY, 3), 4, 5) AS 'Ngày',
		PX.MAPX AS 'Mã Phiếu', PX.HOTENKH AS 'Họ và Tên', VT.TENVT AS 'Tên Vật Tư', 
		KHO.TENKHO AS 'Tên Kho',CT.SOLUONG AS 'Số Lượng',
		DONGIA AS 'Đơn Giá', CT.SOLUONG * CT.DONGIA AS 'Trị Giá'
    FROM 
    (
		SELECT MAPX, NGAY, MAKHO, HOTENKH
		FROM PhieuXuat
		WHERE MANV = @MANV AND NGAY BETWEEN CONVERT(DATETIME, @BEGIN, 102) and CONVERT(DATETIME, @END, 102)
    ) PX
    INNER JOIN dbo.CTPX CT ON CT.MAPX = PX.MAPX
    INNER JOIN dbo.Vattu VT ON VT.MAVT = CT.MAVT
	INNER JOIN DBO.KHO KHO ON KHO.MAKHO = PX.MAKHO
END


GO
/****** Object:  StoredProcedure [dbo].[sp_timddh]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timddh] @maddh NCHAR(8)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.DatHang WHERE MasoDDH = @maddh)
		SELECT MasoDDH, NGAY, NhaCC, MANV FROM dbo.DatHang WHERE MasoDDH = @maddh
	ELSE
		IF EXISTS (SELECT 1 FROM LNK0_QLVT.QLVT_DATHANG.dbo.DatHang WHERE MasoDDH = @maddh)
			SELECT MasoDDH, NGAY, NhaCC, MANV FROM LNK0_QLVT.QLVT_DATHANG.dbo.DatHang WHERE MasoDDH = @maddh
		ELSE
			RAISERROR(50001, 18, 1, N'Đơn đặt hàng bạn tìm không tồn tại.')
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_timkho]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timkho] @makho NCHAR(4)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.Kho WHERE MAKHO = @makho)
		SELECT MAKHO, TENKHO, DIACHI, MACN FROM dbo.Kho WHERE MAKHO = @makho
	ELSE
		IF EXISTS (SELECT 1 FROM LNK0_QLVT.QLVT_DATHANG.dbo.Kho WHERE MAKHO = @makho)
			SELECT MAKHO, TENKHO, DIACHI, MACN FROM LNK0_QLVT.QLVT_DATHANG.dbo.Kho WHERE MAKHO = @makho
		ELSE
			RAISERROR(50001, 18, 1, N'Mã kho bạn tìm không tồn tại.')
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_timnhanvien]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_timnhanvien]
@manv INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE MANV = @manv)
		SELECT MANV, HO, TEN, DIACHI, NGAYSINH, LUONG, MACN, TrangThaiXoa FROM dbo.NhanVien WHERE MANV = @manv
	ELSE
		IF EXISTS (SELECT 1 FROM LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien WHERE MANV = @manv)
			SELECT MANV, HO, TEN, DIACHI, NGAYSINH, LUONG, MACN, TrangThaiXoa FROM LNK0_QLVT.QLVT_DATHANG.dbo.NhanVien WHERE MANV = @manv
		ELSE
			RAISERROR(50001, 18, 1, N'Nhân viên bạn tìm không tồn tại')
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_timphieunhap]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_timphieunhap]
@mapn NCHAR(8)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.PhieuNhap WHERE MAPN = @mapn)
		SELECT MAPN, NGAY, MasoDDH, MANV FROM dbo.PhieuNhap WHERE MAPN = @mapn
	ELSE
		IF EXISTS (SELECT 1 FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuNhap WHERE MAPN = @mapn)
			SELECT MAPN, NGAY, MasoDDH, MANV
			FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuNhap
			WHERE MAPN = @mapn
		ELSE
			RAISERROR(50001, 18, 1, N'Phiếu nhập bạn tìm không tồn tại')
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_timphieuxuat]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_timphieuxuat]
@mapx NCHAR(8)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.PhieuXuat WHERE MAPX = @mapx)
		SELECT MAPX, NGAY, HOTENKH, MANV FROM dbo.PhieuXuat WHERE MAPX = @mapx
	ELSE
		IF EXISTS (SELECT 1 FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuXuat WHERE MAPX = @mapx)
			SELECT MAPX, NGAY, HOTENKH, MANV
			FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuXuat
			WHERE MAPX = @mapx
		ELSE
			RAISERROR(50001, 18, 1, N'Phiếu xuất bạn tìm không tồn tại')
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_timtaikhoannhanvien]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_timtaikhoannhanvien]
@manv sysname
AS
BEGIN
	IF EXISTS(SELECT 0 FROM sys.sysusers WHERE name = @manv)
		RAISERROR(50002, 18, 1, N'Nhân viên đã tạo tài khoản.')
	
END

----------------------------------------------------------------------------------------------------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[sp_timvattu]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_timvattu]
@mavt NCHAR(4)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.Vattu WHERE MAVT = @mavt)
		SELECT MAVT, TENVT, DVT, SOLUONGTON FROM dbo.Vattu WHERE MAVT = @mavt
	ELSE
		RAISERROR(50001, 18, 1, N'Mã vật tư bạn tìm không tồn tại.')
END

----------------------------------------------------------------------------------------------------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[sp_tonhopnhapxuat]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[sp_tonhopnhapxuat] @from DATE,
@to DATE,
@mode CHAR(7) -- [full] and [current]
AS
BEGIN
	--SELECT 0 AS 'NGÀY', 0.0 AS 'NHẬP', 0.0 AS 'TỶ LỆ NHẬP', 0.0 AS 'XUẤT', 0.0 AS 'TỶ LỆ XUẤT'
	create TABLE #tonghopxuat (NGAY DATE, TONGTIEN FLOAT)
	create TABLE #tonghopnhap (NGAY DATE, TONGTIEN FLOAT)
	IF(@mode = 'current')
	BEGIN
		INSERT INTO #tonghopxuat (NGAY, TONGTIEN)
			SELECT pxfilter.NGAY, SUM(ctpx.SOLUONG * ctpx.DONGIA) AS 'TONGTIEN'
			FROM (SELECT MAPX, NGAY FROM dbo.PhieuXuat WHERE NGAY BETWEEN @from AND @to) pxfilter
			INNER JOIN dbo.CTPX ctpx ON ctpx.MAPX = pxfilter.MAPX
			GROUP BY pxfilter.NGAY
		INSERT INTO #tonghopnhap (NGAY, TONGTIEN)
			SELECT pnfilter.NGAY, SUM(ctpn.SOLUONG * ctpn.DONGIA) AS 'TONGTIEN'
			FROM (SELECT MAPN, NGAY FROM dbo.PhieuNhap WHERE NGAY BETWEEN @from AND @to) pnfilter
			INNER JOIN dbo.CTPN ctpn ON ctpn.MAPN = pnfilter.MAPN
			GROUP BY pnfilter.NGAY
	END
	ELSE
	BEGIN
		INSERT INTO #tonghopxuat (NGAY, TONGTIEN)
			SELECT pxfilter.NGAY, SUM(ctpx.SOLUONG * ctpx.DONGIA) AS 'TONGTIEN'
			FROM (SELECT MAPX, NGAY FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuXuat WHERE NGAY BETWEEN @from AND @to) pxfilter
			INNER JOIN LNK0_QLVT.QLVT_DATHANG.dbo.CTPX ctpx ON ctpx.MAPX = pxfilter.MAPX
			GROUP BY pxfilter.NGAY
		INSERT INTO #tonghopnhap (NGAY, TONGTIEN)
			SELECT pnfilter.NGAY, SUM(ctpn.SOLUONG * ctpn.DONGIA) AS 'TONGTIEN'
			FROM (SELECT MAPN, NGAY FROM LNK0_QLVT.QLVT_DATHANG.dbo.PhieuNhap WHERE NGAY BETWEEN @from AND @to) pnfilter
			INNER JOIN LNK0_QLVT.QLVT_DATHANG.dbo.CTPN ctpn ON ctpn.MAPN = pnfilter.MAPN
			GROUP BY pnfilter.NGAY
	END
		
	SELECT result.NGAY AS 'NGÀY',
			result.TONGTIENNHAP AS 'NHẬP',
			result.TONGTIENNHAP/(result.TONGTIENNHAP + result.TONGTIENXUAT) AS 'TỶ LỆ NHẬP',
			result.TONGTIENXUAT AS 'XUẤT',
			(result.TONGTIENXUAT/(result.TONGTIENNHAP + result.TONGTIENXUAT)) AS 'TỶ LỆ XUẤT'
	FROM
	(
		-- FULL OUTER JOIN 2 BẢNG, CỘT NÀO NULL LÀ NGÀY ĐÓ KHÔNG CÓ NHẬP HOẶC KHÔNG CÓ XUẤT => THAY CỘT ĐÓ = 0
		SELECT ISNULL(tonghopnhap.NGAY, tonghopxuat.NGAY) AS 'NGAY',
				ISNULL(tonghopnhap.TONGTIEN, 0) AS 'TONGTIENNHAP',
				ISNULL(tonghopxuat.TONGTIEN, 0) AS 'TONGTIENXUAT'
		FROM #tonghopnhap tonghopnhap
		FULL OUTER JOIN
		(
			SELECT *
			FROM #tonghopxuat
		) tonghopxuat
		ON (tonghopxuat.NGAY = tonghopnhap.NGAY)
	) result
	ORDER BY result.NGAY

	DROP TABLE #tonghopnhap
	DROP TABLE #tonghopxuat
END









GO
/****** Object:  StoredProcedure [dbo].[sp_updateemployee]    Script Date: 1/3/2020 11:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_updateemployee]
@manv INT,
@ho NVARCHAR(40),
@ten NVARCHAR(40),
@diachi NVARCHAR(100),
@ngaysinh DATETIME,
@luong FLOAT,
@macn NCHAR(10),
@ttx INT
AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
	SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

	-- update nhan vien
	UPDATE dbo.NhanVien
	SET HO=@ho,
		TEN=@ten,
		DIACHI=@diachi,
		NGAYSINH=@ngaysinh,
		LUONG=@luong,
		MACN=@macn,
		TrangThaiXoa=@ttx
	WHERE MANV = @manv
	
	--EXEC LNK0_QLVT.QLVT_DATHANG.sys.sp_startpublication_snapshot @publication = 'QLVT_DATHANG_CN1'
	--SELECT @mamoi AS MANVMOI
	--WAITFOR DELAY '00:00:7'

COMMIT TRANSACTION
	
















GO
