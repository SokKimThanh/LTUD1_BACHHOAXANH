-- ================================================
-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023>
-- Description:	<Mô tả>
-- Create Procedure sp_cbo_quanly.sql
-- Nhân viên sp_cbo_quanly
-- ================================================
DROP PROCEDURE IF EXISTS sp_cbo_quanly_theo_phongban
GO
CREATE PROCEDURE sp_cbo_quanly_theo_phongban
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	 SELECT 
    d.TENPHG AS 'Tên Phòng Ban',
    e.HOTENNV AS 'Họ Tên Quản Lý'     
FROM 
    PHONGBAN d 
LEFT OUTER JOIN 
    NHANVIEN e 
ON 
    d.MAPB = e.MAPB 
AND 
    (e.MANV IN (SELECT QUANLY FROM NHANVIEN))
ORDER BY 
    d.TENPHG;

END
GO
