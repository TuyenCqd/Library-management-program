CREATE TABLE [dbo].[tb_NhanVien] (
    [MaNV]     NCHAR (10)    NOT NULL,
    [TenNV]    NVARCHAR (50) NULL,
    [NgaySinh] DATE          NULL,
    [GioiTinh] NVARCHAR (50) NULL,
    [DiaChi]   NVARCHAR (50) NULL,
    [Sdt]      NCHAR (10)    NULL,
    CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED ([MaNV] ASC)
);
CREATE TABLE [dbo].[tb_TaiKhoan] (
    [TenDangNhap] NCHAR (10)    NOT NULL,
    [MaNV]        NCHAR (10)    NOT NULL,
    [MatKhau]     VARCHAR (50)  NOT NULL,
    [Email]       VARCHAR (50)  NOT NULL,
    [Quyen]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tb_TaiKhoan] PRIMARY KEY CLUSTERED ([TenDangNhap] ASC, [MaNV] ASC),
    CONSTRAINT [FK_tb_TaiKhoan_tb_NhanVien] FOREIGN KEY ([MaNV]) REFERENCES [dbo].[tb_NhanVien] ([MaNV])
);
CREATE TABLE [dbo].[tb_DocGia] (
    [MaDG]     NCHAR (10)    NOT NULL,
    [TenDG]    NVARCHAR (50) NULL,
    [NgaySinh] DATE          NULL,
    [GioiTinh] NVARCHAR (30) NULL,
    [Lop]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_tb_DocGia] PRIMARY KEY CLUSTERED ([MaDG] ASC)
);
CREATE TABLE [dbo].[tb_NhaXuatBan] (
    [idNXB]  NCHAR (10)    NOT NULL,
    [TenNXB] NVARCHAR (50) NULL,
    [DiaChi] NVARCHAR (50) NULL,
    [Sdt]    NCHAR (10)    NULL,
    CONSTRAINT [PK_tb_NhaXuatBan] PRIMARY KEY CLUSTERED ([idNXB] ASC)
);
CREATE TABLE [dbo].[tb_TacGia] (
    [MaTG]  NCHAR (10)    NOT NULL,
    [TenTG] NVARCHAR (50) NULL,
    CONSTRAINT [PK_tb_TacGia] PRIMARY KEY CLUSTERED ([MaTG] ASC)
);
CREATE TABLE [dbo].[tb_TheLoai] (
    [MaTL]  NCHAR (10)    NOT NULL,
    [TenTL] NVARCHAR (50) NULL,
    CONSTRAINT [PK_tb_TheLoai] PRIMARY KEY CLUSTERED ([MaTL] ASC)
);
CREATE TABLE [dbo].[tb_Sach] (
    [MaS]   NCHAR (10)    NOT NULL,
    [TenS]  NVARCHAR (50) NULL,
    [NamXB] INT           NULL,
    [idNXB] NCHAR (10)    NULL,
    [MaTL]  NCHAR (10)    NULL,
    [MaTG]  NCHAR (10)    NULL,
    CONSTRAINT [PK_tb_Sach] PRIMARY KEY CLUSTERED ([MaS] ASC),
    CONSTRAINT [f3] FOREIGN KEY ([idNXB]) REFERENCES [dbo].[tb_NhaXuatBan] ([idNXB]),
    CONSTRAINT [f4] FOREIGN KEY ([MaTL]) REFERENCES [dbo].[tb_TheLoai] ([MaTL]),
    CONSTRAINT [f5] FOREIGN KEY ([MaTG]) REFERENCES [dbo].[tb_TacGia] ([MaTG])
);
CREATE TABLE [dbo].[tb_PhieuMuon] (
    [MaP]  NCHAR (10) NOT NULL,
    [MaDG] NCHAR (10) NULL,
    [MaNV] NCHAR (10) NULL,
    CONSTRAINT [PK_tb_PhieuMuon] PRIMARY KEY CLUSTERED ([MaP] ASC),
    CONSTRAINT [f1] FOREIGN KEY ([MaDG]) REFERENCES [dbo].[tb_DocGia] ([MaDG]),
    CONSTRAINT [f6] FOREIGN KEY ([MaNV]) REFERENCES [dbo].[tb_NhanVien] ([MaNV])
);
CREATE TABLE [dbo].[tb_ChiTietPhieuMuon] (
    [MaP]           NCHAR (10)     NOT NULL,
    [MaS]           NCHAR (10)     NOT NULL,
    [NgayMuon]      DATE           NULL,
    [NgayHenTra]    NCHAR (10)     NULL,
    [TinhTrangSach] NVARCHAR (100) NULL,
    CONSTRAINT [PK_tb_ChiTietPhieuMuon] PRIMARY KEY CLUSTERED ([MaP] ASC, [MaS] ASC),
    CONSTRAINT [f2] FOREIGN KEY ([MaS]) REFERENCES [dbo].[tb_Sach] ([MaS]),
    CONSTRAINT [FK_tb_ChiTietPhieuMuon_tb_PhieuMuon] FOREIGN KEY ([MaP]) REFERENCES [dbo].[tb_PhieuMuon] ([MaP])
);
create view CTPhieu as
select tb_PhieuMuon.MaP,tb_DocGia.TenDG,tb_NhanVien.TenNV,tb_ChiTietPhieuMuon.MaS,tb_Sach.TenS,tb_ChiTietPhieuMuon.NgayMuon,tb_ChiTietPhieuMuon.NgayHenTra
from tb_ChiTietPhieuMuon,tb_Sach,tb_PhieuMuon,tb_NhanVien,tb_DocGia
where tb_ChiTietPhieuMuon.MaS=tb_Sach.MaS and tb_PhieuMuon.MaDG=tb_DocGia.MaDG and tb_PhieuMuon.MaNV=tb_NhanVien.MaNV and tb_ChiTietPhieuMuon.MaP=tb_PhieuMuon.MaP

select * from CTPhieu

create view info
as
select MaS, TenS, TenNXB, NamXB, TenTG, TenTL 
from tb_Sach, tb_NhaXuatBan, tb_TheLoai, tb_TacGia
where tb_Sach.idNXB = tb_NhaXuatBan.idNXB and tb_Sach.MaTL = tb_TheLoai.MaTL and tb_Sach.MaTG = tb_TacGia.MaTG