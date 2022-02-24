--таблица заявок , данные видны самому пользователю, администраторам и модераторам 
CREATE TABLE request
(
	id nvarchar(30) PRIMARY KEY,-- уникальный 30-значный ключ типа guid(первичный ключ к таблице request_table)
	user_id UNIQUEIDENTIFIER REFERENCES users(id) null,--ид пользователя, оставившего заявку (внешний ключ к таблице user_profile)
	--если здесь будет null, то заявка анонимная
	city_district_id int REFERENCES city_districts(id),--ид района местонахождения заявки в городе(внешний ключ к таблице city_region)
	latitude_coord nvarchar(32),--широта места заявки
	longitude_coord nvarchar(32),--долгота места заявки
	request_status_id int REFERENCES request_status(id),-- ид статуса заявки (внешний ключ к таблице user_status)
	request_category_id int REFERENCES request_category(id),-- ид категории(внешний ключ к таблице user_role) 
	dateadded date,--дата добавления заявки
	datemodified date null,--дата изменения заявки
	datedeleted date null,--дата удаления заявки
	text nvarchar(max),--текст заявки
	foto_link nvarchar(max),--ссылка на фотографии заявки(пока так,потом доработаю решение с учётом возможностей ms sql для медиа)
	video_link nvarchar(max),--ссылка на видео заявки
	rate int,--рейтинг заявки(можно подвесить его расчёт на хранимую процедуру,которая запускается при создании или редактировании заявки модератором,администратором) 
	date_rate_updated date,
	request_parent_id nvarchar(30) REFERENCES request(id),-- ид родительской заявки (внешний ключ к таблице request)
);

CREATE UNIQUE CLUSTERED INDEX cl_id_request on request(id); --кластеризованный уникальный индекс по первичному ключу для таблицы request
CREATE UNIQUE NONCLUSTERED INDEX noncl_info_request on request(user_id,request_status_id,request_category_id);
GO
