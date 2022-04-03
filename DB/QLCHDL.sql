DROP DATABASE IF EXISTS QLCHDL;

CREATE DATABASE IF NOT EXISTS QLCHDL character set "utf8";
USE QLCHDL;
# -----------------------------------------------------------------------------
#       TABLE : TAIKHOAN
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TAIKHOAN
 (
   USERNAME CHAR(32) NOT NULL  ,
   MALTK int NOT NULL  ,
   PASSWORD CHAR(200) NULL  
   , PRIMARY KEY (USERNAME) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : LO
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LO
 (
   MALO CHAR(8) NOT NULL  ,
   NGAY_NHAP DATE NULL  ,
   HAN_SU_DUNG DATE NULL  
   , PRIMARY KEY (MALO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : SANPHAM
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SANPHAM
 (
   MASP CHAR(8) NOT NULL  ,
   MALO CHAR(8) NOT NULL  ,
   TENSP VARCHAR(64) NULL  ,
   DON_VI_TINH CHAR(32) NULL  ,
   SO_LUONG_TON_KHO INTEGER NULL  
   , PRIMARY KEY (MASP) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : KHACHHANG
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS KHACHHANG
 (
   MA_KHACH_HANG CHAR(8) NOT NULL  ,
   MALKH CHAR(8) NOT NULL  ,
   HO_TEN_KH VARCHAR(64) NULL  ,
   SDT CHAR(16) NULL  
   , PRIMARY KEY (MA_KHACH_HANG) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : HOADON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS HOADON
 (
   MAHD CHAR(8) NOT NULL  ,
   NGAY_LAP DATE NULL  
   , PRIMARY KEY (MAHD) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : NHANVIEN
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS NHANVIEN
 (
   MANV CHAR(8) NOT NULL  ,
   USERNAME CHAR(32) NOT NULL  ,
   HO_TEN_NV VARCHAR(64) NULL  ,
   GIOI_TINH CHAR(1) NULL  ,
   NGAY_SINH DATE NULL  ,
   DIA_CHI VARCHAR(128) NULL  ,
   SDT CHAR(16) NULL  
   , PRIMARY KEY (MANV) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : LOAIKHACHHANG
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LOAIKHACHHANG
 (
   MALKH CHAR(8) NOT NULL  ,
   TENLKH VARCHAR(128) NULL  
   , PRIMARY KEY (MALKH) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : LOAITAIKHOAN
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LOAITAIKHOAN
 (
   MALTK CHAR(8) NOT NULL  ,
   TENLTK VARCHAR(64) NULL  
   , PRIMARY KEY (MALTK) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : HD_KH
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS HD_KH
 (
   MA_KHACH_HANG CHAR(8) NOT NULL  ,
   MAHD CHAR(8) NOT NULL  
   , PRIMARY KEY (MA_KHACH_HANG,MAHD) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : NV_SP
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS NV_SP
 (
   MANV CHAR(8) NOT NULL  ,
   MASP CHAR(8) NOT NULL  
   , PRIMARY KEY (MANV,MASP) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CHITIETHOADON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CHITIETHOADON
 (
   MASP CHAR(8) NOT NULL  ,
   MAHD CHAR(8) NOT NULL  ,
   SO_LUONG INTEGER NULL  
   , PRIMARY KEY (MASP,MAHD) 
 ) 
 comment = "";


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE TAIKHOAN 
  ADD FOREIGN KEY FK_TAIKHOAN_LOAITAIKHOAN (MALTK)
      REFERENCES LOAITAIKHOAN (MALTK) ;


ALTER TABLE SANPHAM 
  ADD FOREIGN KEY FK_SANPHAM_LO (MALO)
      REFERENCES LO (MALO) ;


ALTER TABLE KHACHHANG 
  ADD FOREIGN KEY FK_KHACHHANG_LOAIKHACHHANG (MALKH)
      REFERENCES LOAIKHACHHANG (MALKH) ;


ALTER TABLE NHANVIEN 
  ADD FOREIGN KEY FK_NHANVIEN_TAIKHOAN (USERNAME)
      REFERENCES TAIKHOAN (USERNAME) ;


ALTER TABLE HD_KH 
  ADD FOREIGN KEY FK_HD_KH_KHACHHANG (MA_KHACH_HANG)
      REFERENCES KHACHHANG (MA_KHACH_HANG) ;


ALTER TABLE HD_KH 
  ADD FOREIGN KEY FK_HD_KH_HOADON (MAHD)
      REFERENCES HOADON (MAHD) ;


ALTER TABLE NV_SP 
  ADD FOREIGN KEY FK_NV_SP_NHANVIEN (MANV)
      REFERENCES NHANVIEN (MANV) ;


ALTER TABLE NV_SP 
  ADD FOREIGN KEY FK_NV_SP_SANPHAM (MASP)
      REFERENCES SANPHAM (MASP) ;


ALTER TABLE CHITIETHOADON 
  ADD FOREIGN KEY FK_CHITIETHOADON_SANPHAM (MASP)
      REFERENCES SANPHAM (MASP) ;


ALTER TABLE CHITIETHOADON 
  ADD FOREIGN KEY FK_CHITIETHOADON_HOADON (MAHD)
      REFERENCES HOADON (MAHD) ;

