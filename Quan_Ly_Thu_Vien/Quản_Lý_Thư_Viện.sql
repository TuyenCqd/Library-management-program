create database Quan_Ly_Thu_Vien
use Quan_Ly_Thu_Vien
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
select * from tb_NhaXuatBan
select * from tb_TheLoai
select * from tb_NhanVien
select * from tb_TacGia
select * from tb_Sach
select * from tb_DocGia
select * from tb_PhieuMuon
select * from tb_ChiTietPhieuMuon
select * from tb_TaiKhoan
select MatKhau from tb_TaiKhoan where Email = 'admin123@gmail.com'
insert into tb_TaiKhoan values ('NV01','NV01','123','NV01@gmail.com','admin')
alter table tb_Sach add NamXB int
select tb_Sach.MaS, tb_Sach.TenS, tb_NhaXuatBan.TenNXB,tb_Sach.NamXB,tb_TheLoai.TenTL from tb_Sach, tb_NhaXuatBan, tb_TheLoai, tb_ChiTietPhieuMuon where (tb_Sach.idNXB=tb_NhaXuatBan.idNXB and tb_Sach.MaTL=tb_Sach.MaTL and tb_Sach.MaS=tb_ChiTietPhieuMuon.MaS)
select tb_Sach.MaS, tb_Sach.TenS, tb_NhaXuatBan.TenNXB,tb_Sach.NamXB,tb_TheLoai.TenTL from tb_Sach, tb_NhaXuatBan, tb_TheLoai, tb_ChiTietPhieuMuon where (tb_Sach.idNXB=tb_NhaXuatBan.idNXB and tb_Sach.MaTL=tb_Sach.MaTL and tb_Sach.MaS=tb_ChiTietPhieuMuon.MaS and tb_ChiTietPhieuMuon.NgayHenTra<GETDATE())
select  tb_Sach.MaS, tb_Sach.TenS, tb_NhaXuatBan.TenNXB,tb_Sach.NamXB,tb_TheLoai.TenTL from tb_Sach, tb_NhaXuatBan, tb_TheLoai where (tb_Sach.idNXB=tb_NhaXuatBan.idNXB and tb_Sach.MaTL=tb_Sach.MaTL)

alter table tb_PhieuMuon add constraint f1 foreign key (MaDG) references tb_DocGia(MaDG)
alter table tb_ChiTietPhieuMuon add constraint f2 foreign key (MaS) references tb_Sach(MaS)
--alter table tb_ChiTietPhieuMuon add constraint f7 foreign key (MaP) references tb_PhieuMuon(MaP)
alter table tb_Sach add constraint f3 foreign key (idNXB) references tb_NhaXuatBan(idNXB)
alter table tb_Sach add constraint f4 foreign key (MaTL) references tb_TheLoai(MaTL)
alter table tb_Sach add constraint f5 foreign key (MaTG) references tb_TacGia(MaTG)
alter table tb_PhieuMuon add constraint f6 foreign key (MaNV) references tb_NhanVien(MaNV)
alter table tb_PhieuMuon add constraint f8 foreign key (MaP) references tb_ChiTietPhieuMuon(MaP)


delete from tb_ChiTietPhieuMuon
delete from tb_PhieuMuon
delete from tb_TaiKhoan
delete from tb_NhanVien
delete from tb_Sach
delete from tb_ChiTietPhieuMuon

select distinct tb_DocGia.MaDG,tb_DocGia.TenDG, tb_DocGia.NgaySinh,tb_DocGia.GioiTinh, tb_DocGia.Lop 
from tb_DocGia, tb_PhieuMuon,tb_ChiTietPhieuMuon 
where (tb_DocGia.MaDG=tb_PhieuMuon.MaDG and tb_PhieuMuon.MaP=tb_ChiTietPhieuMuon.MaP and tb_ChiTietPhieuMuon.NgayHenTra<GETDATE())

select tb_Sach.MaS, tb_Sach.TenS, tb_NhaXuatBan.TenNXB,tb_Sach.NamXB,tb_TheLoai.TenTL 
from tb_Sach, tb_NhaXuatBan, tb_TheLoai, tb_ChiTietPhieuMuon 
where (tb_Sach.idNXB=tb_NhaXuatBan.idNXB and tb_Sach.MaTL=tb_Sach.MaTL and tb_Sach.MaS=tb_ChiTietPhieuMuon.MaS and tb_ChiTietPhieuMuon.NgayHenTra<GETDATE())

select  MaS, TenS, TenNXB, NamXB, TenTG,TenTL 
from tb_Sach, tb_NhaXuatBan, tb_TheLoai ,tb_TacGia
where tb_Sach.idNXB=tb_NhaXuatBan.idNXB  and tb_Sach.MaTG=tb_TacGia.MaTG and tb_Sach.MaTL=tb_TheLoai.MaTL

create view info
as
select MaS, TenS, TenNXB, NamXB, TenTG, TenTL 
from tb_Sach, tb_NhaXuatBan, tb_TheLoai, tb_TacGia
where tb_Sach.idNXB = tb_NhaXuatBan.idNXB and tb_Sach.MaTL = tb_TheLoai.MaTL and tb_Sach.MaTG = tb_TacGia.MaTG

select * from info
--
select * from tb_NhanVien
select * from tb_DocGia
select * from tb_PhieuMuon
select * from tb_Sach
select * from tb_ChiTietPhieuMuon

create view CTPhieu as
select tb_PhieuMuon.MaP,tb_DocGia.TenDG,tb_NhanVien.TenNV,tb_ChiTietPhieuMuon.MaS,tb_Sach.TenS,tb_ChiTietPhieuMuon.NgayMuon,tb_ChiTietPhieuMuon.NgayHenTra
from tb_ChiTietPhieuMuon,tb_Sach,tb_PhieuMuon,tb_NhanVien,tb_DocGia
where tb_ChiTietPhieuMuon.MaS=tb_Sach.MaS and tb_PhieuMuon.MaDG=tb_DocGia.MaDG and tb_PhieuMuon.MaNV=tb_NhanVien.MaNV and tb_ChiTietPhieuMuon.MaP=tb_PhieuMuon.MaP
drop view CTPhieu
select * from CTPhieu
select distinct(MaP) from CTPhieu


