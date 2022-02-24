--таблица статусов пользователя, данные видны администраторам  
CREATE TABLE user_statuses
(
	id int PRIMARY KEY IDENTITY,
	name nvarchar(64) UNIQUE--(Активен,Забанен,ещё какие хз)
);

GO