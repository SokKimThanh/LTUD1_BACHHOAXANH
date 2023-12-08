﻿-- ================================================
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
drop procedure if exists sp_chitiethoadon_TongTien
go
CREATE PROCEDURE sp_chitiethoadon_TongTien
	-- Add the parameters for the stored procedure here
	@makm char(11) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	Declare  @TT int = 0;
	select @TT += ct.SLMUA * sp.DONGIA
	from CHITIETHD ct,HOADON hd,SANPHAM sp
	where ct.MAHD = hd.MAHD and sp.MASP = ct.MASP

	Update HOADON
	set TONGTHANHTIEN = @TT
	where MAHD = @makm;
END
GO
exec sp_chitiethoadon_TongTien 'HD01'
select * 
from HOADON
where MAHD='HD01'
