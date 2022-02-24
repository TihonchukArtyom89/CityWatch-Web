--таблица категорий заявки, данные которые видны администраторам  
CREATE TABLE request_category
(
	id int PRIMARY KEY IDENTITY,
	name nvarchar(30) UNIQUE--(В Т.З есть)
);

GO