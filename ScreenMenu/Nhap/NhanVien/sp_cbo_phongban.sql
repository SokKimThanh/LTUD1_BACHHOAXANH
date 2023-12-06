-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>
-- Description:	<Mô tả>
-- Create Procedure sp_cbo_phongban.sql
-- Nhân viên sp_cbo_phongban
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE IF EXISTS sp_cbo_phongban
GO
CREATE PROCEDURE sp_cbo_phongban
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	Select MAPB, TENPHG FROM PHONGBAN
END
GO
