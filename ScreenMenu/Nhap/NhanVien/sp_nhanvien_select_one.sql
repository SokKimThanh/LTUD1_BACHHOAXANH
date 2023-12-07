
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>
-- Description:	<Mô tả>
-- Create Procedure sp_nhanvien_select_one.sql
-- Nhân viên sp_nhanvien_select_one
-- ================================================
go
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
