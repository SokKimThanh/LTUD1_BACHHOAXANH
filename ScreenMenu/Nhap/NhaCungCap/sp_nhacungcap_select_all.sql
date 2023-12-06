-- ================================================
-- Create Procedure sp_nhacungcap_select_all.sql
-- Nhà cung cấp select all
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sok Kim Thanh
-- Create date: <07/11/2023>
-- Description:	<Nhà cung cấp select all>
-- =============================================
drop procedure if exists sp_nhacungcap_select_all
go
CREATE PROCEDURE sp_nhacungcap_select_all
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from nhacungcap
END
GO
