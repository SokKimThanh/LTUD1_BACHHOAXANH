-- ================================================
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
	SELECT cn.TENCN as 'Tên Chi Nhánh', pb.TENPHG as 'Phòng ban', nv.HOTENNV as 'Họ tên nhân viên'
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
	SELECT cn.TENCN as 'Tên Chi Nhánh', pb.TENPHG as 'Phòng ban',  COUNT(nv.HOTENNV) as 'Số nhân viên'
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
	SELECT  cn.TENCN as 'Tên Chi Nhánh', pb.TENPHG as 'Phòng ban',
	STUFF((SELECT ', ' + nv.HOTENNV FROM nhanvien nv WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN FOR XML PATH('')), 1, 2, '') as 'Danh sách nhân viên'
	FROM PHONGBAN pb, CHINHANH cn 
	GROUP BY pb.TENPHG, cn.TENCN, pb.MAPB, cn.MACN, pb.MACN;
END
GO