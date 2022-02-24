--таблица профиля пользователя, данные видны самому пользователю, администраторам и модераторам 
CREATE TABLE user_profiles
(
	-- TODO: 1to1
	id UNIQUEIDENTIFIER PRIMARY KEY REFERENCES users(id),-- уникальный 16-значный ключ типа guid(первичный ключ к таблице user_profile)
	-- user_id UNIQUEIDENTIFIER REFERENCES users(id),--ид пользователя(внешний ключ к таблице user_table)
	-- END TODO
	FIO nvarchar(256),
	dateofbirth date,--дата рождения
	dateadded date,--дата добавления пользователя
	datemodified date null,--дата изменения пользователя
	datedeleted date null,--дата удаления пользователя
	address nvarchar(512),--текст адреса пользователя
	-- NOTE: reduntant reference, since district_id points to city.
	-- city_id int REFERENCES city_table(id_city),--ид города(внешний ключ к таблице city)
	district_id int REFERENCES city_districts(id),--ид района в городе(внешний ключ к таблице city_region)
	status_id int REFERENCES user_statuses(id),-- ид статуса профиля пользователя(внешний ключ к таблице user_status)
	role_id int REFERENCES user_roles(id),-- ид роли пользователя(внешний ключ к таблице user_role)  
	gender_id int REFERENCES user_geders(id),-- ид полов пользователя(внешний ключ к таблице user_role)
	rating int--рейтинг пользователя(можно подвесить его расчёт на хранимую процедуру,которая запускается раз в час) 
);

--Индексируем две таблицы (заявки,профиль пользователей), по два индекса (кластеризованный)  по ид и (некластеризованный)информационным полям на каждую таблицу 
--Кластеризованные индексы по первичному ключу 
CREATE UNIQUE CLUSTERED INDEX cl_id_user_profiles on user_profiles(id)--кластеризованный уникальный индекс по первичному ключу для таблицы user_profiles
--Некластеризованные индексы по информационым полям 
CREATE UNIQUE NONCLUSTERED INDEX noncl_info_user_profiles on user_profiles(FIO,address,district_id,role_id)

GO