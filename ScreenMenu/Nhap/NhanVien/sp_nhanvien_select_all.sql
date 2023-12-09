-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>
 
CREATE PROCEDURE sp_nhanvien_select_all
AS
BEGIN
    SELECT 
       
        NV.MANV AS NhanVienID,
        PB.MAPB AS PhongBanID,
        NV.HOTENNV AS 'Họ và tên',
        PB.TENPHG AS 'Tên phòng ban'
        
    FROM 
        NHANVIEN NV,
		PHONGBAN PB
    where NV.MAPB = PB.MAPB
	order by nv.created_date desc;
END;
go


-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>

 
CREATE PROCEDURE sp_nhanvien_thongke
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN 
    -- Insert statements for procedure here
	SELECT cn.TENCN as 'Tên Chi Nhánh', pb.TENPHG as 'Phòng ban',  COUNT(nv.HOTENNV) as 'Số nhân viên'
	FROM nhanvien nv, PHONGBAN pb, CHINHANH cn 
	WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN
	GROUP BY pb.TENPHG, cn.TENCN;

END;
go

-- Author:		Sok Kim Thanh
-- Create date: <06/12/2023 10:57 CH>

 
CREATE PROCEDURE sp_nhanvien_danhsach_theophongban_chinhanh
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN 
    -- Insert statements for procedure here
	SELECT  cn.TENCN as 'Tên Chi Nhánh', pb.TENPHG as 'Phòng ban',
	STUFF((SELECT ', ' + nv.HOTENNV FROM nhanvien nv WHERE pb.MAPB = nv.MAPB AND cn.MACN = pb.MACN FOR XML PATH('')), 1, 2, '') as 'Danh sách nhân viên'
	FROM PHONGBAN pb, CHINHANH cn 
	GROUP BY pb.TENPHG, cn.TENCN, pb.MAPB, cn.MACN, pb.MACN;
END;
go

