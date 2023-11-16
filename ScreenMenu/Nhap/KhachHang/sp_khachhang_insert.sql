-- ================================================
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung cấp insert
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_nhacungcap_insert
go
CREATE PROCEDURE sp_khachhang_insert
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
	INSERT INTO KHACHHANG VALUES (@maKH, @tenKH, @sdtKH,@diemTL)
END
GO
