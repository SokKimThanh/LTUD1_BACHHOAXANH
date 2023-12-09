
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 9:39 CH>

 
CREATE PROCEDURE sp_nhanvien_select_one
	-- Add the parameters for the stored procedure here
	@manv char(11)
	 
AS
BEGIN 
    -- Insert statements for procedure here
	SELECT * from nhanvien where MANV like @manv --like chính xác mã 100%
END;
go

