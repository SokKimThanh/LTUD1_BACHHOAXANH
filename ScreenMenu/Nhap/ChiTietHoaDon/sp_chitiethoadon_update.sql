﻿-- ================================================
-- Create Procedure sp_hinhthuckm_update.sql
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
drop procedure if exists sp_hinhthuckm_update
go
CREATE PROCEDURE sp_hinhthuckm_update
	-- Add the parameters for the stored procedure here
	@mahd char(11) = '', 
	@masp char(11) = '',
	@sl int
	as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Update sp set sp.SLTONKHO = sp.SLTONKHO + ct.SLMUA 
	 from SANPHAM sp,CHITIETHD ct
	 where sp.MASP = @masp and ct.MASP = sp.MASP
    -- Insert statements for procedure here
	update CHITIETHD set SLMUA = @sl where MAHD = @mahd and  MASP = @masp -- chuẩn sql

	Update SANPHAM set SLTONKHO = SLTONKHO - @sl where MASP = @masp;
END
GO
