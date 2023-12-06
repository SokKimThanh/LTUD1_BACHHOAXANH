-- ================================================
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
