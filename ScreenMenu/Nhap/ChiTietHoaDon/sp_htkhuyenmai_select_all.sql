-- ================================================
-- Create Procedure sp_chitiethoadon_select_all.sql
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
drop procedure if exists sp_chitiethoadon_select_all
go
CREATE PROCEDURE sp_chitiethoadon_select_all
	-- Add the parameters for the stored procedure here
	 @MAHD CHAR(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT sp.TENSP,ct.SLMUA, ct.SLMUA * sp.DONGIA as "Thành tiền"
	from CHITIETHD ct,HOADON hd,SANPHAM sp 
	where ct.MAHD = hd.MAHD and ct.MASP=sp.MASP and ct.MAHD = @MAHD

END
GO
exec sp_chitiethoadon_select_all 'HD01'
