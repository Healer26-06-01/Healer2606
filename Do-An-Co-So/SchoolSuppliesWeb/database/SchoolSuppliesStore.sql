USE [master]
GO
CREATE DATABASE [SchoolSuppliesStore]
GO
USE [SchoolSuppliesStore]
GO
GO
CREATE TABLE [dbo].[Account](
	[account_id] [int] IDENTITY(1,1) NOT NULL,
	[account_name] [nvarchar](255) NOT NULL,
	[account_email] [nvarchar](255) NOT NULL,
	[account_pass] [nvarchar](255) NOT NULL,
	[account_phone] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[bill_id] [int] IDENTITY(1,1) NOT NULL,
	[account_id] [int] NOT NULL,
	[total] [money] NOT NULL,
	[payment] [nvarchar](255) NOT NULL,
	[address] [nvarchar](255) NOT NULL,
	[date] [date] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[phone] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[bill_detail_id] [int] IDENTITY(1,1) NOT NULL,
	[schoolsupplies_id] [nvarchar](255) NOT NULL,
	[account_id] [int] NOT NULL,
	[schoolsupplies_name] [nvarchar](255) NOT NULL,
	[schoolsupplies_image] [nvarchar](255) NOT NULL,
	[price] [money] NOT NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bill_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchoolSupplies](
	[schoolsupplies_id] [nvarchar](255) NOT NULL,
	[category_id] [int] NOT NULL,
	[schoolsupplies_name] [nvarchar](255) NOT NULL,
	[schoolsupplies_image] [nvarchar](255) NOT NULL,
	[schoolsupplies_price] [money] NOT NULL,
	[schoolsupplies_description] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[schoolsupplies_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[contact_id] [int] IDENTITY(1,1) NOT NULL,
	[contact_name] [nvarchar](255) NOT NULL,
	[contact_email] [nvarchar](255) NOT NULL,
	[contact_title] [nvarchar](255) NOT NULL,
	[contact_message] [nvarchar](1000) NOT NULL,
	[contact_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[contact_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAdmin](
	[account_id] [int] IDENTITY(1,1) NOT NULL,
	[account_name] [nvarchar](255) NOT NULL,
	[account_pass] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([account_id], [account_name], [account_email], [account_pass], [account_phone]) VALUES (1, N'user', N'user@gmail.com', N'user', N'09274318544')
SET IDENTITY_INSERT [dbo].[Account] OFF
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS01', 1, N'Sổ tay Dotgrid - French Toast', N'images/schoolsupplies/SotayDotgrid-FrenchToast.png', 74900.0000, N'Sổ Baked & Fun Dotted Notebook')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS02', 1, N'Sổ tay Dotgrid - Blue Cheese', N'images/schoolsupplies/SotayDotgrid-BlueCheese.png', 74900.0000, N'Sổ Baked & Fun Dotted Notebook')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS03', 1, N'Sổ Grid Minimalism - The Black Book 130GSM', N'images/schoolsupplies/SoGridMinimalism-TheBlackBook130GSM.png', 79000.0000, N'The Black Book là dòng sổ tay với định lượng 130GSM đầu tiên được Crabit cho ra mắt. Định lượng 130GSM sẽ vừa thoả mãn những bạn có nhu cầu ghi chép hàng ngày, vừa muốn sáng tạo với nhiều loại màu khác nhau. Điểm khác biệt cho dòng sổ 130GSM chính là mẫu sổ giấy đen, đặc biệt dành cho những bạn yêu thích sự khác biệt, một điều mới mẻ và khác biệt.')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS04', 1, N'Sổ còng A5 6 lỗ - Speed Well', N'images/schoolsupplies/SocongA56lo-SpeedWell.png', 129000.0000, N'Sổ còng màu sắc trẻ trung, thiết kế tối giản, dạng bìa cứng, sử dụng loại còng 6 lỗ dành cho giấy khổ A5 dễ dàng tiện dụng cho ghi chép, lên kế hoạch.')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS05', 1, N'Sổ tay dotted - Coffeeine Collection', N'images/schoolsupplies/Sotaydotted-CoffeeineCollection.png', 202500.0000, N'Bộ sưu tập Coffeeine là dòng sản phẩm mới nhất của Crabit Notebuck. Sản phẩm được lấy cảm hứng và thiết kế từ các vị cà phê cơ bản nhất: Espresso, Americano, Latte. Đây sẽ là một sản phẩm không thể thiếu của một tín đồ Coffeeholic.Sổ phù hợp cho nhu cầu ghi chép, lên kế hoạch, bắt đầu sử dụng bullet journal. Việc viết sổ trở nên vô cùng thú vị và hiệu quả, hãy duy trì thói quen này mỗi ngày với Sổ tay Crabit nhé!')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS06', 2, N'Vở dot 120 trang - Trap', N'images/schoolsupplies/Vodot120trang-Trap.png', 15900.0000, N'Vở học sinh với chất lượng giấy mịn, siêu xịn, không thấm mực sang trang sau. Bạn có thể thoải mái ghi chép bằng bút máy, bút bi các loại. ')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS07', 2, N'Vở dot - Xanh lá sóng vàng', N'images/schoolsupplies/Vodot-Xanhlasongvang.png', 15900.0000, N'Bên cạnh vở học sinh kẻ ngang truyền thống, Crabit cho ra mắt loại vở học sinh với loại ruột khác nhau. Trong đó Dotted Notebuck là loại vở phù hợp với nhiều nhu cầu khác nhau trong học tập hàng ngày. Việc ghi chép trở nên dễ dàng, thoáng mắt, sử dụng vở chấm cho các bài tập về hình hoạ, sơ đồ và đồ thị trở nên dễ dàng.')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS08', 2, N'Vở ô vuông 120 trang - Xương cá', N'images/schoolsupplies/Voovuong120trang-Xuongca.png', 15900.0000, N'Vở học sinh với chất lượng giấy mịn, siêu xịn, không thấm mực sang trang sau. Bạn có thể thoải mái ghi chép bằng bút máy, bút bi các loại. ')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS09', 2, N'Vở ô vuông - Xanh 120 trang', N'images/schoolsupplies/Voovuong-Xanh120trang.png', 15900.0000, N'Vở kẻ ô vuông họa tiết pattern cá tính, bắt mắt phù hợp với nhu cầu học tập, ghi chép bài chuyên dụng , hiệu quả. Vở truyền thông dần trở nên nhàm chán, sự xuất hiện của vở ô vuông khiến việc ghi chép, học và làm bài tập trở nên thú vị, làm tăng hiệu quả học tập đặc biệt trong các môn học về ngoại ngữ, văn học, khoa học,... ')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS10', 2, N'Vở kẻ ngang 120 trang - Thịt', N'images/schoolsupplies/Vokengang120trang-Thit.png', 14900.0000, N'Vở học sinh với chất lượng giấy mịn, siêu xịn, không thấm mực sang trang sau. Bạn có thể thoải mái ghi chép bằng bút máy, bút bi các loại. ')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS11', 3, N'Bút xóa kéo - Donut', N'images/schoolsupplies/Butxoakeo-Donut.png', 35000.0000, N'Bút xoá kéo hình Donut, nhỏ gọn, tiện lợi và xinh xắn')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS12', 3, N'Bút sáp màu dầu Pentel - 36 màu', N'images/schoolsupplies/ButsapmaudauPentel-36mau.png', 89000.0000, N'Bút sáp màu Pentel là dòng sản phẩm thuộc thương hiệu Pentel nổi tiếng được giới hội họa ưu dùng')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS13', 3, N'Bút bi Pastel mực đen', N'images/schoolsupplies/ButbiPastelmucden.png', 15000.0000, N'Bút bi Pastel mực đen thiết kế nhỏ gọn tiện lợi với các màu sắc thời trang')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS14', 3, N'Bút highlight Stabilo Boss Mini pastel', N'images/schoolsupplies/ButhighlightStabiloBossMinipastel.png', 34000.0000, N'Stabilo Boss mini Pastel là sản phẩm bút Highlighter bán chạy nhất trên thị trường hiện nay')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS15', 3, N'Bút Tombow Dual Brush - Tone Tím Hồng', N'images/schoolsupplies/ButTombowDualBrush-ToneTimHong.png', 52000.0000, N'Tombow Dual Brush pen là dòng bút chuyên Caligraphy nổi tiếng của Tombow Nhật Bản')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS16', 4, N'Sticker Free Inspiration lập kế hoạch', N'images/schoolsupplies/StickerFreeInspirationlapkehoach.png', 40000.0000, N'Bộ planner và sticker Note dành cho lập kế hoạch, giúp bạn sắp xếp công việc hàng ngày một cách hợp lý và năng suất nhất.')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS17', 4, N'Lovely Life Sticker', N'images/schoolsupplies/LovelyLifeSticker.png', 35000.0000, N'Miếng dán sticker trang trí sổ với những chủ đề đơn giản bạn có thể sử dụng trang trí sổ, làm bullet journal, trang trí thiệp...')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS18', 4, N'Sticker bảng chữ cái', N'images/schoolsupplies/Stickerbangchucai.png', 20000.0000, N'Bạn có thể sử dụng bảng chữ cái và số để trang trí cho cuốn sổ của mình. Sticker được bế viền ngoài theo từng chữ cái, chỉ cần bóc ra là có thể dán được.')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS19', 4, N'Hello sticker', N'images/schoolsupplies/Hellosticker.png', 35000.0000, N'Những miếng sticker đáng yêu dành cho bạn để trang trí sổ, làm bullet journal, trang trí thiệp,...')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS20', 4, N'Bear sticker', N'images/schoolsupplies/Bearsticker.png', 10000.0000, N'BEAR STICKER - STICKER TRANG TRÍ SIÊU ĐÁNG YÊU')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS21', 5, N'Box làm đất sét tự khô - Be Happier Clay Craft Box - Box cho 2+ người (1000g)', N'images/schoolsupplies/Boxlamdatsettukho-BeHappierClayCraftBox-Boxcho2+nguoi(1000g).png', 279000.0000, N'Đúng như tên gọi của set này, đây là một chiếc hộp chứa đựng không chỉ niềm vui khi bạn tự tay nhào nặn ra những thành quả mà còn là chiếc hộp chứa đựng đầy đủ các dụng cụ cần thiết để bạn thỏa sức sáng tạo với đất sét tự khô. Đặc biệt hơn nữa, bạn có thể lưu giữ những khoảng khắc đáng nhớ với bạn bè cùa mình với box đất sét này. ')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS22', 5, N'Box làm đất sét tự khô - Be Happier Clay Craft Box - Box dành cho 1 người (500g)', N'images/schoolsupplies/Boxlamdatsettukho-BeHappierClayCraftBox-Boxdanhcho1nguoi(500g).png', 210000.0000, N'Đúng như tên gọi của set này, đây là một chiếc hộp chứa đựng không chỉ niềm vui khi bạn tự tay nhào nặn ra những thành quả mà còn là chiếc hộp chứa đựng đầy đủ các dụng cụ cần thiết để bạn thỏa sức sáng tạo với đất sét tự khô. ')
INSERT [dbo].[SchoolSupplies] ([schoolsupplies_id], [category_id], [schoolsupplies_name], [schoolsupplies_image], [schoolsupplies_price], [schoolsupplies_description]) VALUES (N'SS23', 5, N'500g Đất sét tự khô - Crabit Air Dry Clay', N'images/schoolsupplies/Datsettukho-CrabitAirDryClay.png', 79000.0000, N'Không giống như đất sét truyền thống cần nung trong lò ở nhiệt độ cao, đất sét khô trong không khí không cần đun nóng hay cần thêm một công đoạn nào để ra thành phẩm. Đất ẩm, dẻo, dễ dàng tạo hình và sau khi khô sẽ cứng, đóng rắn ở nhiệt độ phòng bình thường và có thể được sơn, trang trí bằng màu nước, màu acrylic hay những con dấu để tạo hoạ tiết.')
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([category_id], [category_name]) VALUES (1, N'Sổ tay')
INSERT [dbo].[Category] ([category_id], [category_name]) VALUES (2, N'Vở viết')
INSERT [dbo].[Category] ([category_id], [category_name]) VALUES (3, N'Bút')
INSERT [dbo].[Category] ([category_id], [category_name]) VALUES (4, N'Sticker')
INSERT [dbo].[Category] ([category_id], [category_name]) VALUES (5, N'Đất sét tự khô')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[UserAdmin] ON 

INSERT [dbo].[UserAdmin] ([account_id], [account_name], [account_pass]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[UserAdmin] OFF
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([account_id])
REFERENCES [dbo].[Account] ([account_id])
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD FOREIGN KEY([account_id])
REFERENCES [dbo].[Account] ([account_id])
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD FOREIGN KEY([schoolsupplies_id])
REFERENCES [dbo].[SchoolSupplies] ([schoolsupplies_id])
GO
ALTER TABLE [dbo].[SchoolSupplies]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([category_id])
GO
USE [master]
GO
ALTER DATABASE [SchoolSuppliesStore] SET  READ_WRITE 
GO
