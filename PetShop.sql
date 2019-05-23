USE [master]
GO
/****** Object:  Database [PetShop]    Script Date: 23/5/2019 9:27:43 AM ******/
CREATE DATABASE [PetShop]
 CONTAINMENT = NONE

GO
ALTER DATABASE [PetShop] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PetShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PetShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PetShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PetShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PetShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PetShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [PetShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PetShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PetShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PetShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PetShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PetShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PetShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PetShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PetShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PetShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PetShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PetShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PetShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PetShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PetShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PetShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PetShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PetShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PetShop] SET  MULTI_USER 
GO
ALTER DATABASE [PetShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PetShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PetShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PetShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PetShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PetShop] SET QUERY_STORE = OFF
GO
USE [PetShop]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 23/5/2019 9:27:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHoaDon] [nchar](10) NOT NULL,
	[MaSanPham] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 23/5/2019 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [nchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaKhachHang] [nchar](10) NULL,
	[MaNhanVien] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 23/5/2019 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [nchar](10) NOT NULL,
	[TenKhachHang] [nchar](50) NULL,
	[SoDienThoai] [nchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 23/5/2019 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINHANVIEN](
	[MaLoaiNV] [nchar](10) NOT NULL,
	[TenLoaiNV] [nchar](50) NULL,
 CONSTRAINT [PK_LOAINHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 23/5/2019 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MaLoaiSP] [nchar](10) NOT NULL,
	[TenLoaiSP] [nchar](50) NULL,
 CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 23/5/2019 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [nchar](10) NOT NULL,
	[TenNhanVien] [nchar](50) NULL,
	[Tuoi] [int] NULL,
	[SoDT] [nchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[MaLoaiNV] [nchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 23/5/2019 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSanPham] [nchar](10) NOT NULL,
	[TenSanPham] [nchar](50) NULL,
	[SoLuongSP] [int] NULL,
	[GiaBan] [int] NULL,
	[MaLoaiSP] [nchar](10) NULL,
	[NhaSanXuat] [nchar](50) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 23/5/2019 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [nchar](50) NOT NULL,
	[MatKhau] [nchar](50) NULL,
	[MaLoaiNV] [nchar](10) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'HD01      ', N'SP01      ', 2, 600000)
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'HD01      ', N'SP02      ', 5, 1750000)
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'HD02      ', N'SP02      ', 5, 1750000)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [MaKhachHang], [MaNhanVien]) VALUES (N'HD01      ', CAST(N'2019-05-12' AS Date), N'KH01      ', N'NV02      ')
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [MaKhachHang], [MaNhanVien]) VALUES (N'HD02      ', CAST(N'2019-05-14' AS Date), N'KH02      ', N'NV02      ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH01      ', N'Nguyen Van A                                      ', N'0988456258                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH02      ', N'Doan Thi B                                        ', N'0905287456                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH03      ', N'Le Van C                                          ', N'0122458712                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH04      ', N'Tran Van D                                        ', N'0988159753                                        ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH05      ', N'Dao Thi E                                         ', N'0905854289                                        ')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV01     ', N'QuanLyKho                                         ')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV02     ', N'NVThuNgan                                         ')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV03     ', N'NVBanHang                                         ')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV04     ', N'QuanLyCuaHang                                     ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP01     ', N'ThucAnCho                                         ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP02     ', N'ThucAnMeo                                         ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP03     ', N'PhuKienCho                                        ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP04     ', N'PhuKienMeo                                        ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP05     ', N'DoDungCho                                         ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP06     ', N'DoDungMeo                                         ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP07     ', N'ThuocCho                                          ')
INSERT [dbo].[LOAISANPHAM] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'LSP08     ', N'ThuocMeo                                          ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (N'NV01      ', N'Ngo Van Tu                                        ', 18, N'0793699821                                        ', N'Nam       ', N'LNV01     ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (N'NV02      ', N'Tran Tan Quy                                      ', 22, N'0905741258                                        ', N'Nam       ', N'LNV02     ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (N'NV03      ', N'Nguyen Thi Dieu Huyen                             ', 22, N'0973584128                                        ', N'Nu        ', N'LNV03     ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [Tuoi], [SoDT], [GioiTinh], [MaLoaiNV]) VALUES (N'NV04      ', N'Tran Hoai Mi                                      ', 22, N'0905478125                                        ', N'Nu        ', N'LNV04     ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP01      ', N'Hat MaxPower Poodle Puppy                         ', 100, 300000, N'LSP01     ', N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP02      ', N'Hat MaxPower Poodle Adult                         ', 100, 350000, N'LSP01     ', N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP03      ', N'Pate Care Chicken Liver                           ', 100, 250000, N'LSP01     ', N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP04      ', N'Pate CatSeaFish Pure Tuna Meat                    ', 100, 300000, N'LSP02     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP05      ', N'Pate CatSeaFish Tuna With Mackerel                ', 100, 200000, N'LSP02     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP06      ', N'ANF Salmon & Potato                               ', 100, 150000, N'LSP02     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP07      ', N'Xich Reflective Collar Leash Set Waistband        ', 100, 205000, N'LSP03     ', N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP08      ', N'Ro mom  Polyethylene                              ', 100, 450000, N'LSP03     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP09      ', N'Day dat Knitting Lead                             ', 100, 550000, N'LSP03     ', N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP10      ', N'Bang ten                                          ', 100, 690000, N'LSP04     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP11      ', N'Luc lac                                           ', 100, 360000, N'LSP04     ', N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP12      ', N'No                                                ', 100, 120000, N'LSP04     ', N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP13      ', N'Khay ve sinh                                      ', 100, 240000, N'LSP05     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP14      ', N'Nha                                               ', 100, 250000, N'LSP05     ', N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP17      ', N'Chuong                                            ', 100, 125000, N'LSP06     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP18      ', N'Tui xach                                          ', 100, 245000, N'LSP06     ', N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP19      ', N'Tay giun Heartgard Plus                           ', 100, 290000, N'LSP07     ', N'Trung Quoc                                        ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP20      ', N'Tri ve NexGard Spectra                            ', 100, 450000, N'LSP07     ', N'Hoa Ky                                            ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP22      ', N'Tay giun Bayer Cat                                ', 100, 460000, N'LSP08     ', N'Viet Nam                                          ')
INSERT [dbo].[SANPHAM] ([MaSanPham], [TenSanPham], [SoLuongSP], [GiaBan], [MaLoaiSP], [NhaSanXuat]) VALUES (N'SP23      ', N'Tri ve Frontline Plus                             ', 100, 365000, N'LSP08     ', N'Viet Nam                                          ')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'huyenntd                                          ', N'12345                                             ', N'LNV03     ')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'mith                                              ', N'123456                                            ', N'LNV04     ')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'quytt                                             ', N'1234                                              ', N'LNV02     ')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'tunv                                              ', N'123                                               ', N'LNV01     ')
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON1] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON1]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SANPHAM] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SANPHAM1] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SANPHAM1]
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
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNhanVien])
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
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_LOAINHANVIEN1] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_LOAINHANVIEN1]
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
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_LOAINHANVIEN1] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_LOAINHANVIEN1]
GO
USE [master]
GO
ALTER DATABASE [PetShop] SET  READ_WRITE 
GO
