-- ================================================
-- Create Procedure sp_nhacungcap_select_all.sql
-- Nhà cung cấp select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Nhà cung cấp select all>
-- =============================================
drop procedure if exists sp_khachhang_select_all
go
CREATE PROCEDURE sp_khachhang_select_all
	-- Add the parameters for the stored procedure here
		@maKH char(11) = '', 
	@tenKH nvarchar(30) = N'',
	@sdtKH int = 0,
	@diemTL int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from KHACHHANG
END
GO
exec sp_khachhang_select_all
