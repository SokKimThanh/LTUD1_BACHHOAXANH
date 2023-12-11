-- =============================================
-- Author:		Vo Tu
-- Create date: <13/11/2023>
-- Description:	<Mô tả>
-- =============================================
drop procedure if exists sp_hoadon_update
go
CREATE PROCEDURE sp_hoadon_update
	-- Add the parameters for the stored procedure here
	@maHD char(11) = '', 
	@ngayHD date,
	@tongTien decimal,
	@maNV char(11),
	@maKH char(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update HOADON set NGAYHOADON = @ngayHD, TONGTHANHTIEN = @tongTien, MANV = @maNV, MAKH =@maKH where MAHD = @maHD -- chuẩn sql
END
GO
set dateformat dmy
select * from HOADON where MAHD = 'HD02'
exec sp_hoadon_update'HD02','15/01/2022', 0,'NV03', 'KH01'
select * from HOADON where MAHD = 'HD02'