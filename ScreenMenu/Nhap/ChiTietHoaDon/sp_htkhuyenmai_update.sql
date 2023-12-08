-- ================================================
-- Create Procedure sp_chitiethoadon_update.sql
-- Danh mục update
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_chitiethoadon_update
go
CREATE PROCEDURE sp_chitiethoadon_update
	-- Add the parameters for the stored procedure here
	@mahd char(11) = '', 
	@masp char(11) = '', 
	@SLmua int
	as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update CHITIETHD set SLMUA = @SLmua where MAHD = @mahd and MASP = @masp -- chuẩn sql
END
GO
