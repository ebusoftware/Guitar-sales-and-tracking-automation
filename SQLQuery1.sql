/*
üzerinde iþlem/deneme yapýldýðý zaman veri kaybý veya tabloda deðiþiklik olabilir,
o yüzden her tablo için drop table komutuyla bütün tablolarý silme iþlemi yapýyoruz BAÞLANGIÇTA!
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
govdetürü varchar(25) not null
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
											/* SEHÝRLER */
insert into sehirler(sehiradi,sehirid) values ('Adana',1);
insert into sehirler(sehiradi,sehirid) values ('Kayseri',38);
insert into sehirler(sehiradi,sehirid) values ('Ýstanbul',34);
insert into sehirler(sehiradi,sehirid) values ('Nevþehir',50);
insert into sehirler(sehiradi,sehirid) values ('Ýzmir',35);
insert into sehirler(sehiradi,sehirid) values ('Adana',06);
insert into sehirler(sehiradi,sehirid) values ('Yozgat',66);
insert into sehirler(sehiradi,sehirid) values ('Niðde',51);
											/* MARKALAR */											
insert into markalar(markaadi) values ('Yamaha');
insert into markalar(markaadi) values ('Ýbanez');
insert into markalar(markaadi) values ('Ovation');
insert into markalar(markaadi) values ('Cort');
insert into markalar(markaadi) values ('WashBurn');
insert into markalar(markaadi) values ('Gibson');
insert into markalar(markaadi) values ('Taylor');
insert into markalar(markaadi) values ('Martin');
insert into markalar(markaadi) values ('Fender');
insert into markalar(markaadi) values ('Takamine');

											/* KATEGORÝLER */
insert into kategoriler(kategoriadi) values ('Akustik Gitar');
insert into kategoriler(kategoriadi) values ('Klasik Gitar');
insert into kategoriler(kategoriadi) values ('Bass Gitar');
											/* RENKLER */
insert into renkler(renkadi,renkid) values ('sarý',1);
insert into renkler(renkadi,renkid) values ('Mavi',2);
insert into renkler(renkadi,renkid) values ('Yeþil',3);
insert into renkler(renkadi,renkid) values ('Hardal sarýsý',4);
insert into renkler(renkadi,renkid) values ('Turuncu',5);
insert into renkler(renkadi,renkid) values ('Mavimsi',6);
insert into renkler(renkadi,renkid) values ('Kýrmýzý',7);
insert into renkler(renkadi,renkid) values ('Pembe',8);
insert into renkler(renkadi,renkid) values ('Siyah',9);

											/* GOVDELER */
insert into govdeler(govdetürü,govdeid ) values ('Çam Aðacý',1);
insert into govdeler(govdetürü,govdeid) values ('Söðüt Aðacý',2);
insert into govdeler(govdetürü,govdeid) values ('Ahþap',3);
											/* TELLER */

insert into teller(telsayisi) values (6);
insert into teller(telsayisi) values (5);
insert into teller(telsayisi) values (4);
insert into teller(telsayisi) values (8);
											/* URUNLER */
insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (1,1,1,1,1,'189203042221','öðrenci gitarý',
250,22,'yeni baþlayanlar için ideal bir gitar');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (1,1,2,2,2,'182205040001','orta seviye kaliteli gitar',
420,5,'çalmayý biliyorum fakat sesi güzel çýkmýyor diyorsanýz tam size göre bir ürün...');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (2,4,3,3,1,'435203042221','Profesyonel klasik gitar',
1000,4,'Profesyonel kayýtlar için kullanýþlý.');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (3,2,3,2,3,'189203042232','Sahne bass gitarý',
2200,19,'Sahnelerde ýþýldayan ve mükemmel ses için en iyi gitar');

insert into urunler(kategoriid,markaid,renkid,govdeid,telid,barkodno,urunadi,
fiyat,stokadeti,aciklama) values (3,8,4,1,1,'189230042221','Ultra bass',
250,22,'Bass severler için tasarlanmýþ gitar.');
											/* MUSTERÝLER */
insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(1,'Ebubekir','Aydoðmuþ','05076543892','138927654','ebubekiram@gmail.com','esentepe mah. sedat sok.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(38,'Ali','Ankaralý','05443543892','145027654','aliank@gmail.com','hürriyet mah. elif apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(34,'Aslý','Öztürk','05036563892','138264654','asliöztrk@gmail.com','sahabiye mah. pýnar sok. kuþ apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(34,'Sedef','Týknaz','053489053892','376527654','sdftknz@hotmail.com','baðcýlar mah. seyran sok. gül apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(51,'Erhan','Soysal','05076399875','338927654','erhan_soysal@gmail.com','kunduz mah. çiçekçi sok. zafer apt.')

insert into musteriler(sehirid,adi,soyadi,gsmno,vergino,eposta,adres)
values(50,'Buse','tatsýz','05074632457','155927654','bu_se_tatsýz@gmail.com','Sancak mah. Yýldýrým sok. cennet apt.')

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

											/* ADMÝNLER */
insert into adminler(k_adi,sifre,admin_adsoyad) values ('ebuwav','admin123','Ebubekir Aydoðmuþ')


