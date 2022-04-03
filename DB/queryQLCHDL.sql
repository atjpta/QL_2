use QLCHDL;

insert into loaitaikhoan values ("1", "root");
insert into loaitaikhoan values ("3", "Nhân viên");
insert into loaitaikhoan values ("2", "quản lý");

insert into taikhoan values("root","1" , "d404559f602eab6fd602ac7680dacbfaadd13630335e951f097af3900e9de176b6db28512f2e000b9d04fba5133e8b1c6e8df59db3a8ab9d60be4b97cc9e81db");
# là 1234

select * from taikhoan;

select * 
from taikhoan
where username = "root";