USE [QuanLyMuonSach]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDNM]    Script Date: 02/07/2022 10:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[NguoiMuon]    Script Date: 02/03/2022 12:09:24 ******/
CREATE FUNCTION [dbo].[AUTO_IDNM]()
RETURNS VARCHAR(5)
AS
BEGIN
		DECLARE @ID VARCHAR(5)
		IF (SELECT COUNT(idNguoiMuon) FROM NguoiMuon) = 0
			SET @ID = '0'
		ELSE 
			SELECT @ID = MAX(RIGHT(idNguoiMuon,3)) FROM NguoiMuon
			SELECT @ID = CASE
				WHEN @ID >= 0 AND @ID < 9 THEN 'NM00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9 THEN 'NM0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			END
		RETURN @ID
END
GO
/****** Object:  Table [dbo].[NguoiMuon]    Script Date: 02/07/2022 10:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiMuon](
	[idNguoiMuon] [char](5) NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[soSachMuon] [decimal](8, 2) NULL,
	[soSachConGiu] [decimal](8, 2) NULL,
	[soSachQuaHan] [decimal](8, 2) NULL,
	[soTienNo] [decimal](8, 2) NULL,
	[trangThai] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguoiMuon] PRIMARY KEY CLUSTERED 
(
	[idNguoiMuon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NguoiMuon] ([idNguoiMuon], [hoTen], [ngaySinh], [soSachMuon], [soSachConGiu], [soSachQuaHan], [soTienNo], [trangThai], [diaChi], [Sdt]) VALUES (N'NM001', N'Nguyễn Thị Ngọc', CAST(0xEA290B00 AS Date), CAST(2.00 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(50000.00 AS Decimal(8, 2)), N'Còn', N'34 Nguyễn Văn Công, Gò Vấp, Hồ Chí Minh', N'0913465516')
INSERT [dbo].[NguoiMuon] ([idNguoiMuon], [hoTen], [ngaySinh], [soSachMuon], [soSachConGiu], [soSachQuaHan], [soTienNo], [trangThai], [diaChi], [Sdt]) VALUES (N'NM002', N'Lý Tiến Việt', CAST(0x8F240B00 AS Date), CAST(5.00 AS Decimal(8, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(87000.00 AS Decimal(8, 2)), N'Còn', N'34/233 Lý Chính Thắng, Quận 3, Hồ Chí Minh', N'0934816541')
INSERT [dbo].[NguoiMuon] ([idNguoiMuon], [hoTen], [ngaySinh], [soSachMuon], [soSachConGiu], [soSachQuaHan], [soTienNo], [trangThai], [diaChi], [Sdt]) VALUES (N'NM003', N'Nguyễn Thị Yến', CAST(0x75250B00 AS Date), CAST(3.00 AS Decimal(8, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(0.00 AS Decimal(8, 2)), CAST(22000.00 AS Decimal(8, 2)), N'Còn', N'45 Nguyễn Hữu Thọ, Quận 7, Hồ Chí Minh', N'071621320')
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDPM]    Script Date: 02/07/2022 10:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 02/03/2022 12:09:24 ******/
CREATE FUNCTION [dbo].[AUTO_IDPM]()
RETURNS VARCHAR(6)
AS
BEGIN
		DECLARE @ID VARCHAR(6);
		IF (SELECT COUNT(soPhieu) FROM PhieuMuon) = 0
			SET @ID = '0';
		ELSE 
			SELECT @ID = MAX(RIGHT(soPhieu,4)) FROM PhieuMuon
			SELECT @ID = CASE
				WHEN @ID >= 0 AND @ID < 9 THEN 'PM000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9 THEN 'PM00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			END;
		RETURN @ID
END
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 02/07/2022 10:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tenDangNhap] [nchar](50) NOT NULL,
	[matKhau] [nchar](20) NULL,
	[quyen] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[tenDangNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([tenDangNhap], [matKhau], [quyen]) VALUES (N'hoaTran111                                        ', N'123                 ', 0)
INSERT [dbo].[TaiKhoan] ([tenDangNhap], [matKhau], [quyen]) VALUES (N'nhiNguyen99                                       ', N'123                 ', 0)
INSERT [dbo].[TaiKhoan] ([tenDangNhap], [matKhau], [quyen]) VALUES (N'TienToan345                                       ', N'456                 ', 0)
INSERT [dbo].[TaiKhoan] ([tenDangNhap], [matKhau], [quyen]) VALUES (N'Tham1402                                          ', N'1402                ', 1)
/****** Object:  Table [dbo].[Sach]    Script Date: 02/07/2022 10:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[idSach] [int] IDENTITY(1,1) NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[tacGia] [nvarchar](50) NULL,
	[soLuong] [decimal](8, 2) NULL,
	[ngayNhapKho] [datetime] NULL,
	[tinhTrang] [nvarchar](50) NULL,
	[NXB] [nvarchar](50) NULL,
	[loaiSach] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[idSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sach] ON
INSERT [dbo].[Sach] ([idSach], [tensach], [tacGia], [soLuong], [ngayNhapKho], [tinhTrang], [NXB], [loaiSach]) VALUES (1, N'Cơ sở lập trình', N'Nguyễn Thôn Dã', CAST(5.00 AS Decimal(8, 2)), CAST(0x0000AE0900000000 AS DateTime), N'Còn', N'ĐHQGHCM', N'Lập trình')
INSERT [dbo].[Sach] ([idSach], [tensach], [tacGia], [soLuong], [ngayNhapKho], [tinhTrang], [NXB], [loaiSach]) VALUES (2, N'Lập trình hướng đối tượng', N'Nguyễn Thôn Dã', CAST(10.00 AS Decimal(8, 2)), CAST(0x0000ADF100000000 AS DateTime), N'Còn', N'ĐHQGHCM', N'Lập trình')
INSERT [dbo].[Sach] ([idSach], [tensach], [tacGia], [soLuong], [ngayNhapKho], [tinhTrang], [NXB], [loaiSach]) VALUES (3, N'Pháp luật đại cương', N'Jack C.Richards', CAST(7.00 AS Decimal(8, 2)), CAST(0x0000ADE900000000 AS DateTime), N'Còn', N'NXB Chính trị quốc gia sự thật', N'Chính trị, xã hội')
INSERT [dbo].[Sach] ([idSach], [tensach], [tacGia], [soLuong], [ngayNhapKho], [tinhTrang], [NXB], [loaiSach]) VALUES (4, N'Giao tiếp tiếng anh căn bản', N'Vũ Quang', CAST(5.00 AS Decimal(8, 2)), CAST(0x0000AE0600000000 AS DateTime), N'Còn', N'NXB Giáo dục', N'Tiếng anh')
INSERT [dbo].[Sach] ([idSach], [tensach], [tacGia], [soLuong], [ngayNhapKho], [tinhTrang], [NXB], [loaiSach]) VALUES (6, N'Cuộc đời của Pi', N'Paulo Coelho', CAST(8.00 AS Decimal(8, 2)), CAST(0x0000ADC800000000 AS DateTime), N'Còn', N'Kim Đồng', N'Kỹ năng mềm')
SET IDENTITY_INSERT [dbo].[Sach] OFF
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02/07/2022 10:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNV] [nchar](50) NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[ngaySinh] [datetime] NULL,
	[noiSinh] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[ngayBatDauLam] [datetime] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[idNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([idNV], [hoTen], [ngaySinh], [noiSinh], [Sdt], [diaChi], [ngayBatDauLam]) VALUES (N'hoaTran111                                        ', N'Trần Thị Hoa', CAST(0x00008E9100000000 AS DateTime), N'Nha Trang', N'0942042299', N'84, Mai Hắc Đế, Hai Bà Trưng, Hà nội', CAST(0x0000AB3500000000 AS DateTime))
INSERT [dbo].[NhanVien] ([idNV], [hoTen], [ngaySinh], [noiSinh], [Sdt], [diaChi], [ngayBatDauLam]) VALUES (N'nhiNguyen99                                       ', N'Nguyễn Thúy Nhi', CAST(0x00008C7B00000000 AS DateTime), N'Phú Thọ', N'0961838383', N'102, Văn Bán, Cẩm Khê, Cẩm Khê, Phú Thọ', CAST(0x0000AD3100000000 AS DateTime))
INSERT [dbo].[NhanVien] ([idNV], [hoTen], [ngaySinh], [noiSinh], [Sdt], [diaChi], [ngayBatDauLam]) VALUES (N'TienToan345                                       ', N'Mai Tiến Toàn', CAST(0x000088DD00000000 AS DateTime), N'Tp.Hồ Chí Minh', N'0329979797', N'F4 Lữ Gia, Phường 15, Quận 11, Tp. Hồ Chí Minh', CAST(0x0000AB7500000000 AS DateTime))
INSERT [dbo].[NhanVien] ([idNV], [hoTen], [ngaySinh], [noiSinh], [Sdt], [diaChi], [ngayBatDauLam]) VALUES (N'Tham1402                                          ', N'Nguyễn Lê Hồng Thắm', CAST(0x0000904600000000 AS DateTime), N'Long An', N'0377014122', N'101/3 Chợ Ông Bái, An Lục Long, Châu Thành, Long A', CAST(0x0000AE3300000000 AS DateTime))
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 02/07/2022 10:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[soPhieu] [char](6) NOT NULL,
	[idNguoiMuon] [char](5) NULL,
	[idNV] [nchar](50) NULL,
	[ngayMuon] [datetime] NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[soPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PhieuMuon] ([soPhieu], [idNguoiMuon], [idNV], [ngayMuon]) VALUES (N'PM0001', N'NM001', N'hoaTran111                                        ', CAST(0x0000AE2400000000 AS DateTime))
INSERT [dbo].[PhieuMuon] ([soPhieu], [idNguoiMuon], [idNV], [ngayMuon]) VALUES (N'PM0002', N'NM003', N'nhiNguyen99                                       ', CAST(0x0000ADF200000000 AS DateTime))
INSERT [dbo].[PhieuMuon] ([soPhieu], [idNguoiMuon], [idNV], [ngayMuon]) VALUES (N'PM0003', N'NM001', N'hoaTran111                                        ', CAST(0x0000AE0C00000000 AS DateTime))
INSERT [dbo].[PhieuMuon] ([soPhieu], [idNguoiMuon], [idNV], [ngayMuon]) VALUES (N'PM0004', N'NM002', N'TienToan345                                       ', CAST(0x0000ADFF00000000 AS DateTime))
INSERT [dbo].[PhieuMuon] ([soPhieu], [idNguoiMuon], [idNV], [ngayMuon]) VALUES (N'PM0005', N'NM002', N'hoaTran111                                        ', CAST(0x0000AE3300000000 AS DateTime))
INSERT [dbo].[PhieuMuon] ([soPhieu], [idNguoiMuon], [idNV], [ngayMuon]) VALUES (N'PM0006', N'NM003', N'hoaTran111                                        ', CAST(0x0000AE3500000000 AS DateTime))
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 02/07/2022 10:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[idSach] [int] NOT NULL,
	[soPhieu] [char](6) NOT NULL,
	[ngayTra] [datetime] NULL,
 CONSTRAINT [PK_ChiTietPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[idSach] ASC,
	[soPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietPhieuMuon] ([idSach], [soPhieu], [ngayTra]) VALUES (1, N'PM0001', CAST(0x0000AE1E00000000 AS DateTime))
INSERT [dbo].[ChiTietPhieuMuon] ([idSach], [soPhieu], [ngayTra]) VALUES (1, N'PM0005', CAST(0x0000AE2600000000 AS DateTime))
INSERT [dbo].[ChiTietPhieuMuon] ([idSach], [soPhieu], [ngayTra]) VALUES (2, N'PM0002', CAST(0x0000AE1E00000000 AS DateTime))
INSERT [dbo].[ChiTietPhieuMuon] ([idSach], [soPhieu], [ngayTra]) VALUES (3, N'PM0002', CAST(0x0000AE0600000000 AS DateTime))
INSERT [dbo].[ChiTietPhieuMuon] ([idSach], [soPhieu], [ngayTra]) VALUES (4, N'PM0003', CAST(0x0000AE1100000000 AS DateTime))
INSERT [dbo].[ChiTietPhieuMuon] ([idSach], [soPhieu], [ngayTra]) VALUES (6, N'PM0004', CAST(0x0000AE0E00000000 AS DateTime))
INSERT [dbo].[ChiTietPhieuMuon] ([idSach], [soPhieu], [ngayTra]) VALUES (6, N'PM0005', CAST(0x0000AE2600000000 AS DateTime))
/****** Object:  Default [IDNM]    Script Date: 02/07/2022 10:54:38 ******/
ALTER TABLE [dbo].[NguoiMuon] ADD  CONSTRAINT [IDNM]  DEFAULT ([DBO].[AUTO_IDNM]()) FOR [idNguoiMuon]
GO
/****** Object:  Default [IDPM]    Script Date: 02/07/2022 10:54:38 ******/
ALTER TABLE [dbo].[PhieuMuon] ADD  CONSTRAINT [IDPM]  DEFAULT ([DBO].[AUTO_IDPM]()) FOR [soPhieu]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuMuon_PhieuMuon]    Script Date: 02/07/2022 10:54:38 ******/
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon] FOREIGN KEY([soPhieu])
REFERENCES [dbo].[PhieuMuon] ([soPhieu])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuMuon_Sach]    Script Date: 02/07/2022 10:54:38 ******/
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_Sach] FOREIGN KEY([idSach])
REFERENCES [dbo].[Sach] ([idSach])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_Sach]
GO
/****** Object:  ForeignKey [FK_NhanVien_TaiKhoan]    Script Date: 02/07/2022 10:54:38 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([idNV])
REFERENCES [dbo].[TaiKhoan] ([tenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_PhieuMuon_NguoiMuon]    Script Date: 02/07/2022 10:54:38 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_NguoiMuon] FOREIGN KEY([idNguoiMuon])
REFERENCES [dbo].[NguoiMuon] ([idNguoiMuon])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_NguoiMuon]
GO
/****** Object:  ForeignKey [FK_PhieuMuon_NhanVien]    Script Date: 02/07/2022 10:54:38 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_NhanVien] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_NhanVien]
GO
