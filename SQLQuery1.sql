/*
�zerinde i�lem/deneme yap�ld��� zaman veri kayb� veya tabloda de�i�iklik olabilir,
o y�zden her tablo i�in drop table komutuyla b�t�n tablolar� silme i�lemi yap�yoruz BA�LANGI�TA!
*/
drop table musteriler
drop table urunler
drop table sehirler
drop table markalar
drop table teller
drop table renkler
drop table kategoriler
drop table govdeler
drop table satislar
drop table adminler

//												Create Tables


create table sehirler (
sehirid tinyint primary key not null,
sehiradi varchar(20) not null
)

create table markalar (
markaid int primary key identity(1,1) not null,
markaadi varchar(30) not null
)

create table kategoriler(
kategoriid int primary key identity(1,1) not null,
kategoriadi varchar(20) not null
)

create table renkler (
renkid int primary key  not null,
renkadi varchar(20) not null
)

create table govdeler (
govdeid int primary key  not null,
govdet�r� varchar(25) not null
)

create table teller (
telid int primary key identity(1,1) not null,
telsayisi varchar(2) not null
)

create table urunler (
urunid int primary key identity(1,1) not null,
kategoriid int not null foreign key references kategoriler(kategoriid) on update cascade on delete cascade ,
markaid int not null foreign key references markalar(markaid) on update cascade on delete cascade,
govdeid int not null foreign key references govdeler(govdeid) on update cascade on delete cascade,
telid int not null foreign key references teller(telid) on update cascade on delete cascade,
renkid int not null foreign key references renkler(renkid) on update cascade on delete cascade,
barkodno varchar(12) null,
urunadi varchar(50) not null,
fiyat money not null,
stokadeti tinyint not null,
aciklama varchar(300) null,
unique (barkodno)
)

create table musteriler (
musteriid int not null primary key identity(1,1),
sehirid tinyint not null foreign key references sehirler(sehirid) on update cascade on delete cascade,
adi varchar(25) not null,
soyadi varchar(30) not null,
gsmno varchar(20) not null,
vergino varchar(10) null,
eposta varchar(75) not null,
adres varchar(100) not null
CONSTRAINT UK_vergino_eposta unique(gsmno,vergino,eposta)
)

create table satislar (
satisid int not null identity(1,1) primary key ,
urunid int not null foreign key references urunler(urunid) on update cascade on delete cascade,
musteriid int not null foreign key references musteriler(musteriid) on update cascade on delete cascade,
bfiyat money not null,
adet int not null,
tarih date not null,

)

create table adminler(
admin_id int identity(1,1) primary key,
k_adi nvarchar(25) unique,
sifre nvarchar(50),
admin_adsoyad nvarchar(60)
)

/*
	Add data
*/
											/* SEH�RLER */
insert into sehirler(sehiradi,sehirid) values ('Adana',1);
insert into sehirler(sehiradi,sehirid) values ('Kayseri',38);
insert into sehirler(sehiradi,sehirid) values ('�stanbul',34);
insert into sehirler(sehiradi,sehirid) values ('Nev�ehir',50);
insert into sehirler(sehiradi,sehirid) values ('�zmir',35);
insert into sehirler(sehiradi,sehirid) values ('Adana',06);
insert into sehirler(sehiradi,sehirid) values ('Yozgat',66);
insert into sehirler(sehiradi,sehirid) values ('Ni�de',51);
											/* MARKALAR */											
insert into markalar(markaadi) values ('Yamaha');
insert into markalar(markaadi) values ('�banez');
insert into markalar(markaadi) values ('Ovation');
insert into markalar(markaadi) values ('Cort');
insert into markalar(markaadi) values ('WashBurn');
insert into markalar(markaadi) values ('Gibson');
insert into markalar(markaadi) values ('Taylor');
insert into markalar(markaadi) values ('Martin');
insert into markalar(markaadi) values ('Fender');
insert into markalar(markaadi) values ('Takamine');

											/* KATEGOR�LER */
insert into kategoriler(kategoriadi) values ('Akustik Gitar');
insert into kategoriler(kategoriadi) values ('Klasik Gitar');
insert into kategoriler(kategoriadi) values ('Bass Gitar');
											/* RENKLER */
insert into renkler(renkadi,renkid) values ('sar�',1);
insert into renkler(renkadi,renkid) values ('Mavi',2);
insert into renkler(renkadi,renkid) values ('Ye�il',3);
insert into renkler(renkadi,renkid) values ('Hardal sar�s�',4);
insert into renkler(renkadi,renkid) values ('Turuncu',5);
insert into renkler(renkadi,renkid) values ('Mavimsi',6);
insert into renkler(renkadi,renkid) values ('K�rm�z�',7);
insert into renkler(renkadi,renkid) values ('Pembe',8);
insert into renkler(renkadi,renkid) values ('Siyah',9);

											/* GOVDELER */
insert into govdeler(govdet�r�,govdeid ) values ('�am A�ac�',1);
insert into govdeler(govdet�r�,govdeid) values ('S���t A�ac�',2);
insert into govdeler(govdet�r�,govdeid) values ('Ah�ap',3);
											/* TELLER */

insert into teller(telsayisi) values (6);
insert into teller(telsayisi) values (5);
insert into teller(telsayisi) values (4);
insert into teller(telsayisi) values (8);
											/* URUNLER */
insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (1,1,1,1,1,'189203042221','��renci gitar�',
250,22,'yeni ba�layanlar i�in ideal bir gitar');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (1,1,2,2,2,'182205040001','orta seviye kaliteli gitar',
420,5,'�almay� biliyorum fakat sesi g�zel ��km�yor diyorsan�z tam size g�re bir �r�n...');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (2,4,3,3,1,'435203042221','Profesyonel klasik gitar',
1000,4,'Profesyonel kay�tlar i�in kullan��l�.');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (3,2,3,2,3,'189203042232','Sahne bass gitar�',
2200,19,'Sahnelerde ���ldayan ve m�kemmel ses i�in en iyi gitar');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (3,8,4,1,1,'189230042221','Ultra bass',
250,22,'Bass severler i�in tasarlanm�� gitar.');
											/* MUSTER�LER */
insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(1,'Ebubekir','Aydo�mu�','05076543892','138927654','ebubekiram@gmail.com','esentepe mah. sedat sok.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(38,'Ali','Ankaral�','05443543892','145027654','aliank@gmail.com','h�rriyet mah. elif apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(34,'Asl�','�zt�rk','05036563892','138264654','asli�ztrk@gmail.com','sahabiye mah. p�nar sok. ku� apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(34,'Sedef','T�knaz','053489053892','376527654','sdftknz@hotmail.com','ba�c�lar mah. seyran sok. g�l apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(51,'Erhan','Soysal','05076399875','338927654','erhan_soysal@gmail.com','kunduz mah. �i�ek�i sok. zafer apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(50,'Buse','tats�z','05074632457','155927654','bu_se_tats�z@gmail.com','Sancak mah. Y�ld�r�m sok. cennet apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(35,'Feyyaz','terzi','05076333892','138929833','fyyzterzi@hotmail.com','sahiler mah. tezcan sok. hidayet apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(1,'Tatar','Ramazan','05076345692','132693124','tatarbey@gmail.com','orhangazi mah. valiler sok. fecri apt.')
											/* SATISLAR */
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (1,1,250,1,'1.1.2021')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (2,1,420,2,'9.10.2021')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (3,2,1000,1,'5.1.2020')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (2,1,420,2,'9.10.2021')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (4,4,2200,1,'4.4.2021')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (3,5,1000,4,'3.5.2021')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (5,1,250,2,'10.7.2019')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (2,8,420,1,'9.10.2020')
insert into satislar(urunid,musteriid,bfiyat,adet,tarih) values (3,7,1000,2,'5.5.2021')

											/* ADM�NLER */
insert into adminler(k_adi,sifre,admin_adsoyad) values ('ebuwav','admin123','Ebubekir Aydo�mu�')


