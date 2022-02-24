--таблица полов пользователя, данные видны администраторам  
CREATE TABLE user_genders
(
	id int PRIMARY KEY IDENTITY,
	name nvarchar(64) UNIQUE--(Мужчина,Женщина,Не указан)
);

GO