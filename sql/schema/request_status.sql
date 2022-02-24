--таблица статусов заявки, данные которые видны администраторам  
CREATE TABLE request_status
(
	id int PRIMARY KEY IDENTITY,
	name nvarchar(30) UNIQUE--(Обрабатывается,Рассматривается,Исполняется,Проверяется,Выполняется,В архиве)
);

GO