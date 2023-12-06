-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>
-- Description:	<Mô tả>
-- Create Procedure sp_cbo_phongban.sql
-- Nhân viên sp_cbo_phongban
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE IF EXISTS sp_cbo_phongban
GO
CREATE PROCEDURE sp_cbo_phongban
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	Select MAPB, TENPHG FROM PHONGBAN
END
GO
﻿-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>
-- Description:	<Mô tả>
-- Create Procedure sp_cbo_quanly.sql
-- Nhân viên sp_cbo_quanly
-- ================================================
DROP PROCEDURE IF EXISTS sp_cbo_quanly_theo_phongban
GO
CREATE PROCEDURE sp_cbo_quanly_theo_phongban
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	 SELECT 
    d.TENPHG AS 'Tên Phòng Ban',
    e.HOTENNV AS 'Họ Tên Quản Lý'     
FROM 
    PHONGBAN d 
LEFT OUTER JOIN 
    NHANVIEN e 
ON 
    d.MAPB = e.MAPB 
AND 
    (e.MANV IN (SELECT QUANLY FROM NHANVIEN))
ORDER BY 
    d.TENPHG;

END
GO
﻿-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_delete.sql
-- Nhân viên sp_nhanvien_delete
-- ================================================
DROP PROCEDURE IF EXISTS sp_nhanvien_delete
GO
CREATE PROCEDURE sp_nhanvien_delete
	-- Add the parameters for the stored procedure here
	@manv char(11) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM nhanvien WHERE manv = @manv
END
GO
﻿-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_insert.sql
-- Nhân viên sp_nhanvien_insert
-- ================================================
drop procedure if exists sp_nhanvien_insert
go
CREATE PROCEDURE sp_nhanvien_insert
	-- Add the parameters for the stored procedure here
	@manv char(11),
	@hotennv nvarchar(30),
	@diachinv nvarchar(100),
	@luong float,
	@sdtnv int,
	@ngaysinh date,
	@mapb char(4),
	@quanly char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO nhanvien VALUES (@manv, @hotennv, @diachinv, @luong, @sdtnv, @ngaysinh,@mapb,@quanly)
END
GO
﻿-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_select_all.sql
-- Nhân viên sp_nhanvien_select_all
-- ================================================
drop procedure if exists sp_nhanvien_select_all
go
CREATE PROCEDURE sp_nhanvien_select_all
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT nv.HOTENNV as 'Họ tên nhân viên', pb.TENPHG as 'Phòng ban', cn.TENCN as 'Tên Chi Nhánh'
	from nhanvien nv, PHONGBAN pb, CHINHANH cn where pb.MAPB = nv.MAPB and cn.MACN = pb.MACN
END
GO
-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_thongke.sql
-- Nhân viên sp_nhanvien_thongke
-- ================================================
drop procedure if exists sp_nhanvien_thongke
go
CREATE PROCEDURE sp_nhanvien_thongke
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pb.TENPHG as 'Phòng ban', cn.TENCN as 'Tên Chi Nhánh', COUNT(nv.HOTENNV) as 'Số nhân viên'
	FROM nhanvien nv, PHONGBAN pb, CHINHANH cn 
	WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN
	GROUP BY pb.TENPHG, cn.TENCN;

END
GO
-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_danhsach_theophongban_chinhanh.sql
-- Nhân viên sp_nhanvien_danhsach_theophongban_chinhanh
-- ================================================
drop procedure if exists sp_nhanvien_danhsach_theophongban_chinhanh
go
CREATE PROCEDURE sp_nhanvien_danhsach_theophongban_chinhanh
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pb.TENPHG as 'Phòng ban', cn.TENCN as 'Tên Chi Nhánh', 
	STUFF((SELECT ', ' + nv.HOTENNV FROM nhanvien nv WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN FOR XML PATH('')), 1, 2, '') as 'Danh sách nhân viên'
	FROM PHONGBAN pb, CHINHANH cn 
	GROUP BY pb.TENPHG, cn.TENCN, pb.MAPB, cn.MACN, pb.MACN;
END
GO﻿-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_select_one.sql
-- Nhân viên sp_nhanvien_select_one
-- ================================================
drop procedure if exists sp_nhanvien_select_one
go
CREATE PROCEDURE sp_nhanvien_select_one
	-- Add the parameters for the stored procedure here
	@manv char(11)
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from nhanvien where MANV like @manv --like chính xác mã 100%
END
GO
﻿-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_update.sql
-- Nhân viên sp_nhanvien_update
-- ================================================
drop procedure if exists sp_nhanvien_update
go
CREATE PROCEDURE sp_nhanvien_update
	-- Add the parameters for the stored procedure here
	@manv char(11),
	@hotennv nvarchar(30),
	@diachinv nvarchar(100),
	@luong float,
	@sdtnv int,
	@ngaysinh date,
	@mapb char(4),
	@quanly char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update nhanvien set hotennv = @hotennv, diachinv = @diachinv,luong=@luong,sdtnv=@sdtnv ,ngaysinh=@ngaysinh, mapb = @mapb, quanly = @quanly where manv = @manv-- chuẩn sql
END
GO
