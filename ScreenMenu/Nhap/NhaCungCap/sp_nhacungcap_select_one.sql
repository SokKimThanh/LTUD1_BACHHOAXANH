﻿-- ================================================
-- Create Procedure sp_nhacungcap_select_one.sql
-- Nhà cung cấp select one
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
drop procedure if exists sp_nhacungcap_select_one
go
CREATE PROCEDURE sp_nhacungcap_select_one
	-- Add the parameters for the stored procedure here
	@ma nvarchar(11) = '', 
	@ten nvarchar(256) = N'',
	@ghichu nvarchar(256) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from nhacungcap where ma like @ma --like chính xác mã 100%
END
GO
