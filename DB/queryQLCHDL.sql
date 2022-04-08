use QLCHDL;

insert into loaitaikhoan values ("1", "root");
insert into loaitaikhoan values ("3", "Nhân viên");
insert into loaitaikhoan values ("2", "quản lý");

insert into taikhoan(username, maltk, password) values("root","1" , "d404559f602eab6fd602ac7680dacbfaadd13630335e951f097af3900e9de176b6db28512f2e000b9d04fba5133e8b1c6e8df59db3a8ab9d60be4b97cc9e81db");
# là 1234

insert into taikhoan(username, maltk, password) values("nhanvien1","3" , "d404559f602eab6fd602ac7680dacbfaadd13630335e951f097af3900e9de176b6db28512f2e000b9d04fba5133e8b1c6e8df59db3a8ab9d60be4b97cc9e81db");
insert into taikhoan(username, maltk, password) values("nhanvien2","3" , "d404559f602eab6fd602ac7680dacbfaadd13630335e951f097af3900e9de176b6db28512f2e000b9d04fba5133e8b1c6e8df59db3a8ab9d60be4b97cc9e81db");
insert into taikhoan(username, maltk, password) values("nhanvien3","3" , "d404559f602eab6fd602ac7680dacbfaadd13630335e951f097af3900e9de176b6db28512f2e000b9d04fba5133e8b1c6e8df59db3a8ab9d60be4b97cc9e81db");
insert into taikhoan(username, maltk, password) values("nhanvien4","3" , "d404559f602eab6fd602ac7680dacbfaadd13630335e951f097af3900e9de176b6db28512f2e000b9d04fba5133e8b1c6e8df59db3a8ab9d60be4b97cc9e81db");
# là 1234

select * from loaitaikhoan;
select * from taikhoan;

select * 
from taikhoan
where username = "root";

insert into lo (malo, ngay_nhap, han_su_dung) values ("lo1", "2022-04-05", "2023-04-05");
insert into lo (malo, ngay_nhap, han_su_dung) values ("lo2", "2022-04-05", "2024-04-05");
insert into lo (malo, ngay_nhap, han_su_dung) values ("lo3", "2022/04/05", "2025/04/05");

delete 
from lo 
where malo = 'aaa';

UPDATE Lo
SET ngay_nhap = '2024-04-05',
	han_su_dung = '2026-04-05'
WHERE malo = "zzz";

select * 
from lo;

select * 
from lo
where malo = "lo1";

select * 
from sanpham;

delete from sanpham where 'id_sp' = 31;

INSERT INTO `sanpham` (`ID_NV`, `MALO`, `TENSP`, `DON_VI_TINH`, `SO_LUONG_TON_KHO`) VALUES ('2', 'lo1', 'San Pham 1001', 'Chiec', '69');


insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
values ("root", "chu toa", "M","2022-03-03", "dia chi ne", "0342622915");

insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien1", "chu toa22", "M","2022-03-03", "dia chi ne", "0342622915");


insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien2", "chu toa22", "M","2022-03-03", "dia chi ne", "0342622915");


insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien3", "chu toa22", "M","2022-03-03", "dia chi ne", "0342622915");


insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien4", "chu toa22", "M","2022-03-03", "dia chi ne", "0342622915");
select * from nhanvien;

