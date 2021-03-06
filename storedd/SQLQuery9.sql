USE [PetStore]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddCategory]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddCategory]
@TenLoaiSanPham NCHAR(50)
AS
BEGIN
	INSERT INTO dbo.LOAISANPHAM
	        ( TenLoaiSP)
	VALUES  ( @TenLoaiSanPham)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AddEmployee]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  StoredProcedure [dbo].[sp_AddInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddInvoice]
@NgayLap date, @MaNhanVien int, @MaKhachHang int
AS
BEGIN
	INSERT INTO HOADON
	        ( NgayLap ,MaNhanVien,MaKhachHang)
	VALUES  ( @NgayLap, @MaNhanVien,@MaKhachHang)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AddListofProInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddListofProInvoice]
@Mahoadon int, @Masanpham int, @Soluong int, @Thanhtien int
AS
BEGIN
	Insert into CHITIETHOADON  values (@Mahoadon,@Masanpham,@Soluong,@Thanhtien)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddProduct]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_AddProduct]
 @TenSanPham NCHAR(50), @SoLuongSP INT, @GiaBan INT,
 @MaLoaiSP INT, @NhaSanXuat NCHAR(50)
AS
BEGIN
	INSERT INTO dbo.SANPHAM
	        (
	          TenSanPham ,
	          SoLuongSP ,
	          GiaBan ,
	          MaLoaiSP ,
	          NhaSanXuat
	        )
	VALUES  (
	          @TenSanPham, 
	          @SoLuongSP, -- SoLuongSP - int
	          @GiaBan , -- GiaBan - int
	          @MaLoaiSP , -- MaLoaiSP - nchar(10)
	          @NhaSanXuat  -- NhaSanXuat - nchar(50)
	        )
END


GO
/****** Object:  StoredProcedure [dbo].[sp_CreateAccount]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteCategory]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteCategory]
@MaLoaiSP NVARCHAR(10)
AS
BEGIN
	Delete From LOAISANPHAM where MaLoaiSP = @MaLoaiSP;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteEmployee]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_DeleteEmployee]
 @MaNhanVien INT
AS
BEGIN
	DELETE FROM dbo.NHANVIEN WHERE MaNhanVien=@MaNhanVien
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteInvoice]
@Mahoadon int
AS
BEGIN
	Delete from HOADON 
	where MaHoaDon = @Mahoadon
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteListOfPro]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteListOfPro]
@Mahoadon int, @MaSanPham int
AS
BEGIN
	Delete from CHITIETHOADON 
	where MaHoaDon = @Mahoadon and MaSanPham = @MaSanPham
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteProduct]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DeleteProduct]
 @MaSanPham INT 
AS
BEGIN
	DELETE FROM dbo.SANPHAM WHERE MaSanPham=@MaSanPham;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_EditCategory]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditCategory]
@MaLoaiSP NCHAR(10),@TenLoaiSP NCHAR(50)
AS
BEGIN
	UPDATE dbo.LOAISANPHAM SET TenLoaiSP=@TenLoaiSP
							WHERE MaLoaiSP=@MaLoaiSP;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EditEmployee]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_EditEmployee]
 @MaNhanVien INT, @TenNhanVien NCHAR(50),@Tuoi INT, @SoDT NCHAR(50), @GioiTinh NCHAR(50), @MaLoaiNV INT	
AS
BEGIN
	UPDATE dbo.NHANVIEN SET TenNhanVien=@TenNhanVien, Tuoi=@Tuoi, SoDT=@SoDT, GioiTinh=@GioiTinh, MaLoaiNV=@MaLoaiNV
							WHERE MaNhanVien=@MaNhanVien;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EditInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EditInvoice]
@Mahoadon int, @NgayLap date, @MaNhanVien int, @MaKhachHang int
AS
BEGIN
	Update HOADON set NgayLap=@NgayLap, MaNhanVien=@MaNhanVien, MaKhachHang=@MaKhachHang
	where MaHoaDon = @Mahoadon
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EditListofProInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditListofProInvoice]
@Mahoadon int, @Masanpham int, @Soluong int, @Thanhtien int
AS
BEGIN
	Update CHITIETHOADON set SoLuong = @Soluong , ThanhTien = @Thanhtien where
	MaHoaDon = @Mahoadon and MaSanPham = @Masanpham
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EditProduct]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_EditProduct]
 @MaSanPham INT,@TenSanPham NCHAR(50), @SoLuongSP INT, @GiaBan INT,
 @MaLoaiSP INT, @NhaSanXuat NCHAR(50)
AS
BEGIN
	UPDATE dbo.SANPHAM SET TenSanPham=@TenSanPham, SoLuongSP=@SoLuongSP,GiaBan=@GiaBan, MaLoaiSP=@MaLoaiSP,
							NhaSanXuat=@NhaSanXuat
							WHERE MaSanPham=@MaSanPham;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetCategoryList]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetCategoryList]
AS
BEGIN
	SELECT MaLoaiSP,TenLoaiSP
	FROM dbo.LOAISANPHAM;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetEmployeeList]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetEmployeeList]
AS
BEGIN
	SELECT MaNhanVien, TenNhanVien, Tuoi, SoDT, GioiTinh, MaLoaiNV
	FROM dbo.NHANVIEN;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetEmployeeTypeID]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetEmployeeTypeID]
AS
BEGIN
	SELECT MaLoaiNV
	FROM dbo.LOAINHANVIEN;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetProductList]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetProductList]
AS
BEGIN
	SELECT MaSanPham,TenSanPham,SoLuongSP,GiaBan,MaLoaiSP,NhaSanXuat
	FROM dbo.SANPHAM;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetProductTypeID]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetProductTypeID]
AS
BEGIN
	SELECT MaLoaiSP,TenLoaiSP
	FROM dbo.LOAISANPHAM;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Login]
@TenDangNhap NCHAR(50),
@MatKhau NCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.TAIKHOAN WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchCategory]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SearchCategory]
@TenLoaiSP nvarchar(50)
AS
BEGIN
	
	SELECT *
	from LOAISANPHAM
	where TenLoaiSP LIKE+ '%'+@TenLoaiSP+'%'
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchEmployee]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_SearchInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SearchInvoice]
@MaHoaDon int
AS
BEGIN
	
	SELECT *
	from HOADON
	where MaHoaDon = @MaHoaDon
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_searchPro]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_searchPro]
	@MaPro int
AS
BEGIN
	select * from SANPHAM where MaSanPham = @MaPro
END

GO
/****** Object:  StoredProcedure [dbo].[sp_searchProduct]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_searchProduct]
@TenSp varchar(50)
AS
BEGIN
	SELECT *
	from SANPHAM
	where TenSanPham LIKE+ '%'+@TenSp+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectLastIdInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectLastIdInvoice]
AS
BEGIN
	SELECT Max(MaHoaDon) as LastID FROM HOADON
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectListofProInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SelectListofProInvoice]
@Mahoadon int
AS
BEGIN
	select * from CHITIETHOADON where MaHoaDon=@Mahoadon
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectProInvoice]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SelectProInvoice]
@Mahoadon int, @MaSanPham int
AS
BEGIN
	select * from CHITIETHOADON where MaHoaDon=@Mahoadon and MaSanPham=@MaSanPham
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePassword1]    Script Date: 5/30/19 3:13:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
