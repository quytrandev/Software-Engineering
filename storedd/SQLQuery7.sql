CREATE PROC [dbo].[sp_AddEmployee]
  @TenNhanVien NCHAR(50),@Tuoi INT, @SoDT NCHAR(50), @GioiTinh NCHAR(50), @MaLoaiNV INT	
AS
BEGIN
	INSERT INTO dbo.NHANVIEN
	(
	    TenNhanVien,
	    Tuoi,
	    SoDT,
	    GioiTinh,
	    MaLoaiNV
	)
	VALUES
	(   @TenNhanVien, -- TenNhanVien - nchar(50)
	    @Tuoi,   -- Tuoi - int
	    @SoDT, -- SoDT - nchar(50)
	    @GioiTinh, -- GioiTinh - nchar(50)
	    @MaLoaiNV    -- MaLoaiNV - int
	    )
END
GO



CREATE PROC [dbo].[sp_CreateAccount]
@TenDangNhap	NCHAR(50),
@MatKhau NCHAR(50),
@MaLoaiNV INT
AS
BEGIN
INSERT INTO dbo.TAIKHOAN
(
    TenDangNhap,
    MatKhau,
    MaLoaiNV
)
VALUES
(   @TenDangNhap, -- TenDangNhap - nchar(50)
    @MatKhau, -- MatKhau - nchar(50)
    @MaLoaiNV    -- MaLoaiNV - int
    )
END
GO


CREATE PROC [dbo].[sp_DeleteEmployee]
 @MaNhanVien INT
AS
BEGIN
	DELETE FROM dbo.NHANVIEN WHERE MaNhanVien=@MaNhanVien
END
GO


CREATE PROC [dbo].[sp_EditEmployee]
 @MaNhanVien INT, @TenNhanVien NCHAR(50),@Tuoi INT, @SoDT NCHAR(50), @GioiTinh NCHAR(50), @MaLoaiNV INT	
AS
BEGIN
	UPDATE dbo.NHANVIEN SET TenNhanVien=@TenNhanVien, Tuoi=@Tuoi, SoDT=@SoDT, GioiTinh=@GioiTinh, MaLoaiNV=@MaLoaiNV
							WHERE MaNhanVien=@MaNhanVien;
END
GO


CREATE PROC [dbo].[sp_GetEmployeeList]
AS
BEGIN
	SELECT MaNhanVien, TenNhanVien, Tuoi, SoDT, GioiTinh, MaLoaiNV
	FROM dbo.NHANVIEN;
END
GO

CREATE PROC [dbo].[sp_GetEmployeeTypeID]
AS
BEGIN
	SELECT MaLoaiNV, TenLoaiNV
	FROM dbo.LOAINHANVIEN;
END
GO

CREATE PROCEDURE [dbo].[sp_Login]
@TenDangNhap NCHAR(50),
@MatKhau NCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.TAIKHOAN WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau
END
GO


CREATE PROCEDURE [dbo].[sp_SearchEmployee]
@TenNhanVien VARCHAR(50)
AS
BEGIN
	SELECT MaNhanVien, TenNhanVien,Tuoi,SoDT,GioiTinh,LOAINHANVIEN.MaLoaiNV
	FROM dbo.NHANVIEN, dbo.LOAINHANVIEN
	WHERE dbo.NHANVIEN.MaLoaiNV=dbo.LOAINHANVIEN.MaLoaiNV 
	AND TenNhanVien LIKE + '%' + @TenNhanVien + '%'
END
GO

CREATE PROCEDURE [dbo].[sp_UpdatePassword1]
@TenDangNhap NCHAR(50),
@MatKhau NCHAR(50),
@MatKhauMoi NCHAR(50)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM dbo.TAIKHOAN WHERE TenDangNhap=@TenDangNhap AND MatKhau = @MatKhau
	IF (@isRightPass=1)
	BEGIN
		UPDATE dbo.TAIKHOAN SET MatKhau=@MatKhauMoi WHERE TenDangNhap=@TenDangNhap
	END	
END
GO