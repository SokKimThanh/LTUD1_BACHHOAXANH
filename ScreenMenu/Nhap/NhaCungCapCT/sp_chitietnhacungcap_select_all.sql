-- ================================================
-- Create Procedure sp_chitietnhacungcap_select_all.sql
-- Danh mục select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		thanh
-- Create date: <10/12/2023>

-- =============================================
drop procedure if exists sp_chitietnhacungcap_select_all
go
CREATE PROCEDURE sp_chitietnhacungcap_select_all
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ct.MANCC, sp.MASP, ct.SLCUNGCCAP from CHITIETCC ct, SANPHAM sp
	where ct.MASP = sp.MASP
	group by ct.MANCC, sp.MASP, ct.SLCUNGCCAP
END
GO
exec sp_chitietnhacungcap_select_all
