--Представление "Полный профиль пользователя"
--Частично сделал подтягивание в один вид текстом ФИО, Адрес, номер телефона пользователя, роль, статус, район, город??
--добавил город, но не уверен

IF OBJECT_ID('dbo.full_user_profile', 'V') IS NOT NULL
    DROP VIEW dbo.full_user_profile
GO

CREATE VIEW full_user_profile AS
	SELECT 
		user.user_phone as phone
	,	user_profiles.FIO as FIO
	,	user_profiles.address as address
	,	user_statuses.name as status
	,	user_roles.name as role
	,	city_districts.name as district
	,	cities.name as city
	FROM users_profiles
	INNER JOIN user ON users_profiles.id = user.id
	INNER JOIN user_roles ON users_profiles.role_id=user_roles.id
	INNER JOIN user_statuses ON users_profiles.status_id=user_statuses.id
	INNER JOIN city_districts ON users_profiles.district_id=city_districts.id
	INNER JOIN (SELECT name FROM cities WHERE id IN (SELECT city_id FROM city_districts)) ON users_profiles.district_id=city_districts.id
GO

SELECT * FROM full_user_profile
