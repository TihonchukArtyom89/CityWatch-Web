--таблица городов ДНР, охватываемых информационной системой "Народное Око", данные видны администраторам и модераторам 
CREATE TABLE cities
(
	id int PRIMARY KEY IDENTITY,
	name NVARCHAR(50)
);

GO

-- NOTE: indexes, data, etc, could be here.