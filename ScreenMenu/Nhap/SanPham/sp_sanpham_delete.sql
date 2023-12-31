﻿-- ================================================
-- Create Procedure sp_sanpham_delete.sql
-- Sản phẩm delete
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
DROP PROCEDURE IF EXISTS sp_sanpham_delete
GO
CREATE PROCEDURE sp_sanpham_delete
	-- Add the parameters for the stored procedure here
	@MASP CHAR(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM sanpham WHERE MASP = @MASP
END
GO
