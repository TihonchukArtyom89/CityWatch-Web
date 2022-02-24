--таблица районов городов ДНР, охватываемых информационной системой "Народное Око", данные видны администраторам и модераторам 
CREATE TABLE city_districts
(
	id int PRIMARY KEY IDENTITY,
	city_id int REFERENCES cities(id),
	name NVARCHAR(64)
);

GO