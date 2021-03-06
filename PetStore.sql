USE [PetStore]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHoaDon] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNhanVien] [int] NULL,
	[MaKhachHang] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nchar](50) NULL,
	[SoDienThoai] [nchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINHANVIEN](
	[MaLoaiNV] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiNV] [nchar](50) NULL,
 CONSTRAINT [PK_LOAINHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MaLoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSP] [nchar](50) NULL,
 CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nchar](50) NULL,
	[Tuoi] [int] NULL,
	[SoDT] [nchar](50) NULL,
	[GioiTinh] [nchar](50) NULL,
	[MaLoaiNV] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nchar](50) NULL,
	[SoLuongSP] [int] NULL,
	[GiaBan] [int] NULL,
	[MaLoaiSP] [int] NULL,
	[NhaSanXuat] [nchar](50) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 5/29/2019 11:36:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [nchar](50) NOT NULL,
	[MatKhau] [nchar](50) NULL,
	[MaLoaiNV] [int] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1, 1, 2, 480000)
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1, 2, 2, 480000)
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2, 3, 2, 500000)
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (1, CAST(N'2019-05-12' AS Date), 2, 1)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (2, CAST(N'2019-05-14' AS Date), 2, 2)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (1, N'Nguyen Van A                                      ', N'0988456258                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (2, N'Doan Thi B                                        ', N'0905287456                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (3, N'Le Van C                                          ', N'0122458712                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (4, N'Tran Van D                                        ', N'0988159753                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (5, N'Dao Thi E                                         ', N'0905854289                                        ')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] ON 

INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (1, N'QuanLyKho                                         ')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (2, N'NVThuNgan                                         ')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (3, N'NVBanHang                                         ')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (4, N'QuanLyCuaHang                                     ')
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[LOAISANPHAM] ON 

INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (1, N'ThucAnChoCho                                      ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (2, N'ThucAnChoMeo                                      ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (3, N'PhuKienChoCho                                     ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (4, N'PhuKienChoMeo                                     ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (5, N'DoDungChoCho                                      ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (6, N'DoDungChoMeo                                      ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (7, N'ThuocChoCho                                       ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (8, N'ThuocChoMeo                                       ')
SET IDENTITY_INSERT [dbo].[LOAISANPHAM] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (1, N'Ngo Van Tu                                        ', 19, N'0793699821                                        ', N'Nam                                               ', 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (2, N'Tran Tan Quy                                      ', 18, N'0905741258                                        ', N'Nam                                               ', 2)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (3, N'Nguyen Thi Dieu Huyen                             ', 20, N'0973584128                                        ', N'Nu                                                ', 3)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (4, N'Tran Hoai Mi                                      ', 21, N'0905478125                                        ', N'Nu                                                ', 4)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (1, N'Hat MaxPower Poodle Puppy                         ', 100, 240000, 1, N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (2, N'Hat MaxPower Poodle Adult                         ', 100, 240000, 1, N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (3, N'Pate Care Chicken Liver                           ', 100, 250000, 1, N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (4, N'Pate CatSeaFish Pure Tuna Meat                    ', 100, 300000, 2, N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (5, N'Pate CatSeaFish Tuna With Mackerel                ', 100, 400000, 2, N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (6, N'ANF Salmon & Potato                               ', 120000, 100, 1, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (7, N'Xich Reflective Collar Leash Set Waistband        ', 100, 365000, 3, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (8, N'Ro mom  Polyethylene                              ', 100, 450000, 3, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (9, N'Day dat Knitting Lead                             ', 100, 450000, 3, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (10, N'Bang ten                                          ', 100, 600000, 4, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (11, N'Luc lac                                           ', 100, 140000, 4, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (12, N'No                                                ', 100, 365000, 4, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (13, N'Khay ve sinh                                      ', 100, 140000, 5, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (14, N'Nha                                               ', 100, 350000, 5, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (15, N'Chuong                                            ', 100, 450000, 6, N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (16, N'Tui xach                                          ', 100, 360000, 6, N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (17, N'Tay giun Heartgard Plus                           ', 100, 245000, 7, N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (18, N'Tri ve NexGard Spectra                            ', 100, 450000, 7, N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (19, N'Tay giun Bayer Cat                                ', 100, 365000, 8, N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (20, N'Tri ve Frontline Plus                             ', 100, 120000, 8, N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (21, N'Something new                                     ', 12, 1999, 1, N'Spain                                             ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (23, N'Test                                              ', 123, 12, 8, N'Laos                                              ')
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'huyenntd                                          ', N'123                                               ', 3)
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'mith                                              ', N'123                                               ', 4)
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'quytt                                             ', N'123                                               ', 2)
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'tngo                                              ', N'123                                               ', 1)
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([SoLuong])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SANPHAM] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SANPHAM]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG1] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG1]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN1] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN1]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_LOAINHANVIEN] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_LOAINHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHAVIEN_LOAINHANVIEN1] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHAVIEN_LOAINHANVIEN1]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISANPHAM] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LOAISANPHAM] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISANPHAM]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISANPHAM1] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LOAISANPHAM] ([MaLoaiSP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISANPHAM1]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_LOAINHANVIEN] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_LOAINHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddProduct]    Script Date: 5/29/2019 11:36:49 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteProduct]    Script Date: 5/29/2019 11:36:49 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_EditProduct]    Script Date: 5/29/2019 11:36:49 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetEmployeeList]    Script Date: 5/29/2019 11:36:49 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetEmployeeTypeID]    Script Date: 5/29/2019 11:36:49 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetProductList]    Script Date: 5/29/2019 11:36:49 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetProductTypeID]    Script Date: 5/29/2019 11:36:49 AM ******/
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
