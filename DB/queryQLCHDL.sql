use QLCHDL;

insert into loaitaikhoan values ("3", "root");
insert into loaitaikhoan values ("1", "Nhân viên");
insert into loaitaikhoan values ("2", "Quản lý");

insert into taikhoan(username, maltk, password) values("root","3" , SHA2 ("1", 512));
insert into taikhoan(username, maltk, password) values("nhanvien1","1" , SHA2 ("1", 512) );
insert into taikhoan(username, maltk, password) values("nhanvien2","1" ,SHA2 ("1", 512));
insert into taikhoan(username, maltk, password) values("nhanvien3","1" ,SHA2 ("1", 512));
insert into taikhoan(username, maltk, password) values("nhanvien4","1" , SHA2 ("1", 512));

insert into lo (malo, ngay_nhap, han_su_dung) values ("lo1", "2022-04-05", "2023-04-05");
insert into lo (malo, ngay_nhap, han_su_dung) values ("lo2", "2022-04-05", "2024-04-05");
insert into lo (malo, ngay_nhap, han_su_dung) values ("lo3", "2022/04/05", "2025/04/05");


insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien1", "cao duc an", "M","2000-03-03", "dia chi ne", "0342622915");
insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien2", "pham nhut hao ", "M","2000-03-03", "dia chi ne", "0342622915");
insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien3", "cong ton thang", "M","2000-03-03", "dia chi ne", "0342622915");
insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
value ("nhanvien4", "ai z ta", "M","2000-03-03", "dia chi ne", "0342622915");

drop procedure update_nv;
# procedure update nhân viên
DELIMITER $
create procedure update_nv (
	in ID_nv_up int(11),
	in USERNAME_up CHAR(32) ,
	in HO_TEN_NV_up VARCHAR(64)  ,
	in GIOI_TINH_up CHAR(1),
	in NGAY_SINH_up DATE,
	in DIA_CHI_up VARCHAR(128),
	in SDT_up CHAR(16),
	in chuc_vu_up char(32))
begin
update taikhoan
set username = USERNAME_up,
	taikhoan.maltk = chuc_vu_up
where username = (select username from nhanvien where Id_nv = id_nv_up);
update nhanvien
set nhanvien.HO_TEN_NV = HO_TEN_NV_up,
    nhanvien.GIOI_TINH = GIOI_TINH_up,
    nhanvien.NGAY_SINH = NGAY_SINH_up,
    nhanvien.DIA_CHI = DIA_CHI_up,
    nhanvien.SDT = SDT_up
where nhanvien.ID_nv = id_nv_up;

end $

call update_nv("2", "uuu","sss","F","2099-02-02","eghh","111111111","1");
call Get_All_nv();
drop procedure add_nv;
# procedure add nhân viên
DELIMITER $
create procedure add_nv (
	in USERNAME_add CHAR(32) ,
	in HO_TEN_NV_add VARCHAR(64)  ,
	in GIOI_TINH_add CHAR(1),
	in NGAY_SINH_add DATE,
	in DIA_CHI_add VARCHAR(128),
	in SDT_add CHAR(16),
	in chuc_vu_add int)
begin
insert into taikhoan(username, maltk, password) values(USERNAME_add, chuc_vu_add , SHA2 ("1", 512));
insert into nhanvien (username, ho_ten_nv, gioi_tinh, ngay_sinh, dia_chi, sdt) 
	value (USERNAME_add, HO_TEN_NV_add, GIOI_TINH_add, NGAY_SINH_add, DIA_CHI_add, SDT_add);
end $

call add_nv("aaa","erthg","F","2099-02-02","eghh","111111111","2");

drop procedure Get_All_nv;
DELIMITER $
create procedure Get_All_nv()
begin 
select a.ID_nv, a.ho_ten_nv, a.username, a.gioi_tinh, a.ngay_sinh, a.dia_chi, a.sdt,c.tenltk as chuc_vu 
from	nhanvien a join taikhoan b on a.username = b.username 
		join loaitaikhoan c on b.maltk = c.maltk;
end $

call Get_All_nv();

drop procedure Get_nv;
DELIMITER $
create procedure Get_nv(username char(32))
begin 
select a.ID_nv, a.ho_ten_nv, a.username, a.gioi_tinh, a.ngay_sinh, a.dia_chi, a.sdt,c.tenltk as chuc_vu 
from	nhanvien a join taikhoan b on a.username = b.username 
		join loaitaikhoan c on b.maltk = c.maltk
where 	a.username = username;
end $

call Get_nv("uuu");

select * from nhanvien;
select username from nhanvien where nhanvien.username = "gwwww";
select username from nhanvien where nhanvien.username = 'uuu';
select * from taikhoan;

DELIMITER $
create function test()
returns int 
begin
	return 4654;
end $

select test();

DELIMITER $
create function test2 ()
returns int 
begin 
	declare a int ;
	set a = 53;
end $



