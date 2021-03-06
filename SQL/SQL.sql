USE [BookShop]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[USERNAME] [nchar](10) NOT NULL,
	[PASSWORD] [nchar](10) NULL,
	[MaPQ] [int] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHD] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[TongThuNhap] [float] NULL,
	[LuongNV] [float] NULL,
	[LoiNhuan] [float] NULL,
	[ChuKi] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nchar](10) NOT NULL,
	[ngayLap] [date] NULL,
	[gia] [float] NULL,
	[MaKH] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
 CONSTRAINT [PK_HOADON_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[username] [nchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MaPQ] [int] NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[MaPQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[MaTheLoai] [nchar](10) NULL,
	[NXB] [nvarchar](50) NULL,
	[TacGia] [nchar](10) NULL,
	[gia] [float] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTacGia] [nchar](10) NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 6/1/2022 11:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTheLoai] [nchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASSWORD], [MaPQ]) VALUES (N'admin     ', N'admin     ', 1)
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASSWORD], [MaPQ]) VALUES (N'dien      ', N'123       ', 2)
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASSWORD], [MaPQ]) VALUES (N'dien1     ', N'123       ', 1)
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASSWORD], [MaPQ]) VALUES (N'giabao    ', N'giabao    ', 3)
GO
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD001     ', N'B0001     ', 2, 100000, 200000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD002     ', N'B0001     ', 3, 100000, 300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD221     ', N'B0001     ', 2, 100000, 200000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD221     ', N'B0288     ', 2, 70000, 200000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD371     ', N'B0288     ', 3, 70000, 210000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD448     ', N'B0001     ', 2, 100000, 200000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD511     ', N'B0001     ', 5, 100000, 500000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD511     ', N'B0288     ', 2, 70000, 140000)
GO
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD001     ', CAST(N'2022-06-01' AS Date), 500000, N'KH001     ', N'NV1       ')
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD002     ', CAST(N'2022-06-01' AS Date), 540000, N'KH001     ', N'NV1       ')
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD003     ', CAST(N'2022-06-01' AS Date), 20000, N'KH001     ', N'NV1       ')
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD221     ', CAST(N'2022-06-01' AS Date), 400000, N'KH002     ', N'NV1       ')
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD236     ', CAST(N'2022-06-01' AS Date), 110000, N'KH002     ', N'NV1       ')
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD371     ', CAST(N'2022-06-01' AS Date), 30000, N'KH002     ', N'NV2       ')
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD448     ', CAST(N'2022-06-01' AS Date), 580000, N'KH002     ', N'NV1       ')
INSERT [dbo].[HOADON] ([MaHD], [ngayLap], [gia], [MaKH], [MaNV]) VALUES (N'HD511     ', CAST(N'2022-06-01' AS Date), 200000, N'KH002     ', N'nv3       ')
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [EMAIL], [Address]) VALUES (N'KH001     ', N'Lê Bữu Điền', N'0814977747', N'lebuudien.cntt@gmail.com', N'45 Dương Bá Trạc')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [EMAIL], [Address]) VALUES (N'KH002     ', N'demo', N'1234567   ', N'demo@gmail.com', N'hufi')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [Email], [address], [username]) VALUES (N'NV1       ', N'Nhân Viên a', N'123       ', N'nv@gmail.com', N'hufi', N'admin     ')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [Email], [address], [username]) VALUES (N'NV2       ', N'Lê Bữu Điền', N'0814977747', N'lebuudien.cntt@Gmail.com', N'TP.HCM', N'dien      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [Email], [address], [username]) VALUES (N'nv3       ', N'Điền', N'0814977747', N'lebuudien.cntt@gmail.com', N'Bến Tre', N'dien1     ')
GO
INSERT [dbo].[PHANQUYEN] ([MaPQ], [ChucVu]) VALUES (1, N'admin')
INSERT [dbo].[PHANQUYEN] ([MaPQ], [ChucVu]) VALUES (2, N'staff')
INSERT [dbo].[PHANQUYEN] ([MaPQ], [ChucVu]) VALUES (3, N'customer')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0001     ', N'Lập trình c', N'TL4       ', N'unknow', N'TG1       ', 100000)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0002     ', N'Zen and the Art of Motorcycle Maintenance', N'TL5       ', N'Penguin', N'TG2       ', 541000)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0003     ', N'Watership Down - Đồi Thỏ', N'TL5       ', N'Nhã Nam', N'TG3       ', 130500)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0190     ', N'Cơ Sở Dữ Liệu', N'TL4       ', N'Bộ giáo dục', N'TG1       ', NULL)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0288     ', N'Tuổi trẻ đáng giá bao nhiêu', N'TL5       ', N'Nhã nam', N'TG1       ', 70000)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0349     ', N'Doraemon ', N'TL5       ', N'Kim đồng', N'TG1       ', 26000)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0573     ', N'Luật hôn nhân', N'TL1       ', N'unknow', N'TG1       ', 120000)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [NXB], [TacGia], [gia]) VALUES (N'B0667     ', N'3 chú heo con', N'TL6       ', N'don''t know', N'TG1       ', 20000)
GO
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG1       ', N'Vô danh')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG2       ', N'Robert M. Pirsig')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG3       ', N'Richard Adams')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG4       ', N' Randy Pausch & Jeffrey Zaslow')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG5       ', N'Bill Bryson')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG6       ', N'Viktor Frank')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG7       ', N'Joe Haldeman')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG8       ', N'Carl Sagan')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG9       ', N'Herman Melville')
GO
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL1       ', N'Chính trị - Pháp Luật')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL2       ', N'Khoa học công nghệ – Kinh tế')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL3       ', N'Văn học nghệ thuật')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL4       ', N'Giáo trình')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL5       ', N'Truyện, tiểu thuyết')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL6       ', N'Sách thiếu nhi')
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_PHANQUYEN] FOREIGN KEY([MaPQ])
REFERENCES [dbo].[PHANQUYEN] ([MaPQ])
GO
ALTER TABLE [dbo].[ACCOUNT] CHECK CONSTRAINT [FK_ACCOUNT_PHANQUYEN]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_Sach]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KhachHang]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_ACCOUNT] FOREIGN KEY([username])
REFERENCES [dbo].[ACCOUNT] ([USERNAME])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_ACCOUNT]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TACGIA] FOREIGN KEY([TacGia])
REFERENCES [dbo].[TACGIA] ([MaTacGia])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TACGIA]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_THELOAI] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAI] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_THELOAI]
GO
