--таблица ролей пользователя, данные видны администраторам  
CREATE TABLE user_roles
(
	id int PRIMARY KEY IDENTITY,
	name nvarchar(64) UNIQUE--(Пользователь,Модератор,Администратор)
);

GO