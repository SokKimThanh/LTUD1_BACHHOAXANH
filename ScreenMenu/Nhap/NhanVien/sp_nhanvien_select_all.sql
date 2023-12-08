go
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
	SELECT nv.MANV, nv.HOTENNV as 'Họ tên nhân viên'
	from nhanvien nv, PHONGBAN pb, CHINHANH cn where pb.MAPB = nv.MAPB and cn.MACN = pb.MACN
END

-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_thongke.sql
-- Nhân viên sp_nhanvien_thongke
-- ================================================
-- Create Procedure sp_nhanvien_select_all.sql
-- Nhân viên select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <10/11/2023>
-- Description:	<Nhân viên select all>
-- =============================================
drop procedure if exists sp_nhanvien_select_all
go
CREATE PROCEDURE sp_nhanvien_select_all
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
	SELECT * from nhanvien
END
GO
