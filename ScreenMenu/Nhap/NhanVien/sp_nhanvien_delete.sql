-- ================================================
-- Create Procedure sp_nhanvien_delete.sql
-- Nhân viên delete
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <10/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_nhanvien_delete
GO
CREATE PROCEDURE sp_nhanvien_delete
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

    -- Delete statements for procedure here
	DELETE FROM nhanvien WHERE ma = @ma
END
GO
