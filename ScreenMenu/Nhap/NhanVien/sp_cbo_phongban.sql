-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>


DROP PROCEDURE IF EXISTS sp_cbo_phongban;
GO
CREATE PROCEDURE sp_cbo_phongban
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN 
    -- Delete statements for procedure here
	Select MAPB, TENPHG FROM PHONGBAN
END

