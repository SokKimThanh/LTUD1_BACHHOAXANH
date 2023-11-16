﻿-- ================================================
-- Create Procedure sp_taikhoan_delete.sql
-- Tài khoản delete
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <16/11/2023>
-- Description:	<Mô tả>
-- =============================================
DROP PROCEDURE IF EXISTS sp_taikhoan_delete
GO
CREATE PROCEDURE sp_taikhoan_delete
	-- Add the parameters for the stored procedure here
	@MATK CHAR(11), 
	@TENTK NVARCHAR(30), 
	@MATKHAU varchar(16),
	@CREATEDATE datetime,
	@PHONE varchar(11), 
	@CCCD varchar(16), 
	@EMAIL varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	DELETE FROM taikhoan WHERE matk @matk
END
GO
