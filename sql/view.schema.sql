--Представление"Полный профиль пользователя"
--Частично сделал подтягивание в один вид текстом ФИО, Адрес, номер телефона пользователя, роль, статус, район
--осталось добавить текстом  город 
create view full_user_profile as
select user.user_phone as phone,
user_profiles.FIO as FIO,
user_profiles.address as address,
user_statuses.name as status,
user_roles.name as role,
city_districts.name as district
from 
users_profiles inner join user on users_profiles.id=user.id
inner join user_roles on users_profiles.status_id=user_roles.id
inner join user_statuses on users_profiles.role_id=user_statuses.id
inner join city_districts on users_profiles.district_id=city_districts.id
