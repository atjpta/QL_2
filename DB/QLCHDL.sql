DROP DATABASE IF EXISTS QLCHDL;

CREATE DATABASE IF NOT EXISTS QLCHDL;
USE QLCHDL;
# -----------------------------------------------------------------------------
#       TABLE : TAIKHOAN
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TAIKHOAN
 (
   USERNAME CHAR(32) NOT NULL  ,
   MALTK CHAR(8) NOT NULL  ,
   PASSWORD VARCHAR(256) NULL  
   , PRIMARY KEY (USERNAME) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TAIKHOAN
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TAIKHOAN_LOAITAIKHOAN
     ON TAIKHOAN (MALTK ASC);

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
   ID_SP INTEGER(11) NOT NULL auto_increment ,
   ID_NV INTEGER(11) NOT NULL  ,
   MALO CHAR(8) NOT NULL  ,
   don_gia int(11) null ,
   TENSP VARCHAR(64) NULL  ,
   DON_VI_TINH CHAR(32) NULL  ,
   SO_LUONG_TON_KHO INTEGER(2) NULL  ,
   IMG LONGBLOB NULL  
   , PRIMARY KEY (ID_SP) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE SANPHAM
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_SANPHAM_NHANVIEN
     ON SANPHAM (ID_NV ASC);

CREATE  INDEX I_FK_SANPHAM_LO
     ON SANPHAM (MALO ASC);

# -----------------------------------------------------------------------------
#       TABLE : KHACHHANG
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS KHACHHANG
 (
   ID_KHACH_HANG INTEGER(11) NOT NULL auto_increment ,
   MALKH CHAR(8) NOT NULL  ,
   HO_TEN_KH VARCHAR(64) NULL  ,
   SDT CHAR(16) NULL  
   , PRIMARY KEY (ID_KHACH_HANG) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE KHACHHANG
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_KHACHHANG_LOAIKHACHHANG
     ON KHACHHANG (MALKH ASC);

# -----------------------------------------------------------------------------
#       TABLE : HOADON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS HOADON
 (
   ID_HD INTEGER(11) NOT NULL auto_increment ,
   ID_KHACH_HANG INTEGER(11) NOT NULL  ,
   ID_NV INTEGER(11) NOT NULL  ,
   NGAY_LAP DATE NULL  
   , PRIMARY KEY (ID_HD) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE HOADON
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_HOADON_KHACHHANG
     ON HOADON (ID_KHACH_HANG ASC);

CREATE  INDEX I_FK_HOADON_NHANVIEN
     ON HOADON (ID_NV ASC);

# -----------------------------------------------------------------------------
#       TABLE : NHANVIEN
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS NHANVIEN
 (
   ID_NV INTEGER(11) NOT NULL auto_increment ,
   USERNAME CHAR(32) NOT NULL  ,
   HO_TEN_NV VARCHAR(64) NULL  ,
   GIOI_TINH CHAR(1) NULL  ,
   NGAY_SINH DATE NULL  ,
   DIA_CHI VARCHAR(128) NULL  ,
   SDT CHAR(16) NULL  
   , PRIMARY KEY (ID_NV) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE NHANVIEN
# -----------------------------------------------------------------------------


CREATE UNIQUE INDEX I_FK_NHANVIEN_TAIKHOAN
     ON NHANVIEN (USERNAME ASC);

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
#       TABLE : CHITIETHOADON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CHITIETHOADON
 (
   ID_SP INTEGER(11) NOT NULL  ,
   ID_HD INTEGER(11) NOT NULL  ,
   SO_LUONG INTEGER(2) NULL  
   , PRIMARY KEY (ID_SP,ID_HD) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CHITIETHOADON
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CHITIETHOADON_SANPHAM
     ON CHITIETHOADON (ID_SP ASC);

CREATE  INDEX I_FK_CHITIETHOADON_HOADON
     ON CHITIETHOADON (ID_HD ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE TAIKHOAN 
  ADD FOREIGN KEY FK_TAIKHOAN_LOAITAIKHOAN (MALTK)
      REFERENCES LOAITAIKHOAN (MALTK) ;


ALTER TABLE SANPHAM 
  ADD FOREIGN KEY FK_SANPHAM_NHANVIEN (ID_NV)
      REFERENCES NHANVIEN (ID_NV) ;


ALTER TABLE SANPHAM 
  ADD FOREIGN KEY FK_SANPHAM_LO (MALO)
      REFERENCES LO (MALO) ;


ALTER TABLE KHACHHANG 
  ADD FOREIGN KEY FK_KHACHHANG_LOAIKHACHHANG (MALKH)
      REFERENCES LOAIKHACHHANG (MALKH) ;


ALTER TABLE HOADON 
  ADD FOREIGN KEY FK_HOADON_KHACHHANG (ID_KHACH_HANG)
      REFERENCES KHACHHANG (ID_KHACH_HANG) ;


ALTER TABLE HOADON 
  ADD FOREIGN KEY FK_HOADON_NHANVIEN (ID_NV)
      REFERENCES NHANVIEN (ID_NV) ;


ALTER TABLE NHANVIEN 
  ADD FOREIGN KEY FK_NHANVIEN_TAIKHOAN (USERNAME)
      REFERENCES TAIKHOAN (USERNAME) 
		ON DELETE CASCADE
		ON UPDATE CASCADE;

ALTER TABLE CHITIETHOADON 
  ADD FOREIGN KEY FK_CHITIETHOADON_SANPHAM (ID_SP)
      REFERENCES SANPHAM (ID_SP)
      ON DELETE NO ACTION ;


ALTER TABLE CHITIETHOADON 
  ADD FOREIGN KEY FK_CHITIETHOADON_HOADON (ID_HD)
      REFERENCES HOADON (ID_HD)
      ON DELETE NO ACTION ;

