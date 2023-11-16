﻿-- ================================================
-- Create Procedure sp_khuyenmai_select_all.sql
-- Danh mục select all
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
drop procedure if exists sp_khuyenmai_select_all
go
CREATE PROCEDURE sp_khuyenmai_select_all
	-- Add the parameters for the stored procedure here
	@makm char(11) = '', 
	@ngaybd date,
	@ngaykt date,
	@masp char(11) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from khuyenmai
END
GO
