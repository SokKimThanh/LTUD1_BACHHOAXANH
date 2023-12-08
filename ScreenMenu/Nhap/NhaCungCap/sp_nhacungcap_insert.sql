-- ================================================
-- Create Procedure sp_nhacungcap_insert.sql
-- Nhà cung cấp insert
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
drop procedure if exists sp_nhacungcap_insert
go
CREATE PROCEDURE sp_nhacungcap_insert
	-- Add the parameters for the stored procedure here
	@MANCC CHAR(11),
	@TENNCC NVARCHAR(30) ,
	@DIACHINCC NVARCHAR(100),
	@SDTNCC INT   
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO nhacungcap VALUES (@@MANCC, @TENNCC, @DIACHINCC,@SDTNCC)
END
GO
