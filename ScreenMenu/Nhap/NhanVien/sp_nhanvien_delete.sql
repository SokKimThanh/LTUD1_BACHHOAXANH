-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>

DROP PROCEDURE IF EXISTS sp_nhanvien_delete
GO
CREATE PROCEDURE sp_nhanvien_delete
	-- Add the parameters for the stored procedure here
	@manv char(11) 
AS
BEGIN 
    -- Delete statements for procedure here
	DELETE FROM nhanvien WHERE manv = @manv
END
