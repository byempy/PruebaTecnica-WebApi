create database Hotels 
use Hotels

Create table Hotel(
Id int identity(1,1) primary key 
,Nombre nvarchar(50)
,Categoria int default(1)
,Descripcion nvarchar(100)
,foto nvarchar(150)
,destacado bit default(0)
)

Create table HotelDetail(
Id int identity(1,1) primary key
,Ciudad nvarchar(50)
,Imagen nvarchar(150)
,Descripcion nvarchar(500)
,Caracteristicas nvarchar(200)
,IdHotel int foreign key references Hotel(Id)
)


insert into Hotel(Nombre, Categoria, Descripcion, foto, destacado) values(
'NH'
,4
,'NH Hotel Group es una multinacional hotelera española fundada en 1978'
,'nh.png'
,0)

insert into HotelDetail(Ciudad, Imagen, Descripcion, Caracteristicas, IdHotel)
values(
'Granada'
,'nhgranada.jpg'
,'El hotel NH Collection Granada Victoria se encuentra al pie de las montañas de Sierra Nevada. Tiene una ubicación privilegiada en Granada, una ciudad definida por la influencia de dos importantes religiones. A 3 minutos a pie de la Catedral y de la Capilla Real, y a un agradable paseo de 20 minutos de la Alhambra.'
,'bar, parking'
,1
)

insert into Hotel(Nombre, Categoria, Descripcion, foto, destacado) values(
'Accor'
,5
,'AccorHotels es un grupo francés'
,'Accor.jpg'
,1)

Insert into HotelDetail(Ciudad, Imagen, Descripcion, Caracteristicas, IdHotel)
values(
'París'
,'accorparis.jpg'
,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae ante nulla. Praesent augue elit, tempus sit amet ex ac, elementum lobortis ante. Sed a vulputate enim. Sed id aliquet.'
,'bar, parking, limpieza'
,2
)
