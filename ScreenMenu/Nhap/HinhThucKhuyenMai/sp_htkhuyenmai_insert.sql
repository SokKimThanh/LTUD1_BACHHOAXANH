﻿-- ================================================
-- Create Procedure sp_hinhthuckm_insert.sql
-- Danh mục insert
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
drop procedure if exists sp_hinhthuckm_insert
go
CREATE PROCEDURE sp_hinhthuckm_insert
	-- Add the parameters for the stored procedure here
	@makm char(11) = '', 
	@hinhthuc nvarchar(50) = N'',
	@ghichu nvarchar(100) = N''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO hinhthuckm VALUES (@makm, @hinhthuc, @ghichu)
END
GO
select count(*) from hinhthuckm
exec sp_hinhthuckm_insert 'KM15','Mua 2 tặng 1',''
select count(*) from hinhthuckm
