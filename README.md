  Выложил модуль Администратора.
  
  Моя дипломная работа "Разработка АРМ сотрудника IT-отдела" включала в себя разработку ПО типа Helpdesk.
  
Программа включает в себя 2 модуля(модуль Админисратора,который я вложил,и модуль Пользователя) и БД.

Модуль Админ был создан с целью посика/хранения/использования информации об организации,включал очень большой функционал.
Например,опишу функционал кнопки "Редактор отделов". 
  -  Кнопка  «Добавить отдел» добавляет в таблицу Dept запись о новом отделе, присваивая ему значение True в полу True, 
              то есть это нам говорит, что отдел действующий.
  -  Кнопка «Изменить данные о отделе» предоставляет администратору изменить название и описание отдела.
  -  Кнопка «Удалить отдел» удаляет отдел из базы данных и присваивает полю True значение False, тем самым указываю,
              что отдел стал недействующим и позволит показать в истории работы сотрудника имя этого отдела. 
              Удалить отдел с сотрудниками невозможно.
Касательно сотрудников, логика везде присутсвует.Ничего сложного нет.
Разве что при удаление информации о сотруднике, его контакты переносятся в отдел "Уволены".
Так же можно посмотерть информацию о том, с какого по какое время сотрудник работал в каком-то отделе.

Код рабочий,но из-за того,что нет у меня базы SQL,программа не будет работать.

Добавление информации было либо,в случае просто запроса,напрямую через VS,либо,в противном случае,передавались параметры
в SQL и изменялись/добавлялись при помощи команд SQL. 
Код хранимоц процедуры по доабвлению сотрудника:
USE [new_yur]
GO
/****** Object:  StoredProcedure [dbo].[ADD_PERSON]    Script Date: 06/25/2015 06:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ADD_PERSON]
	@surname varchar(50),
	@name varchar(50),
	@secname varchar(50),
	@date_birth date,
	@telephone varchar(50),
	@mail varchar(50),
	@post varchar(50),
	@id_dept int
AS
DECLARE @id_p int
INSERT INTO [new_yur].[dbo].[person]
     VALUES (@surname,@name,@secname,@date_birth,@telephone,@mail,123)
DECLARE id_cursor CURSOR FOR
			SELECT [id_person]
			FROM [new_yur].[dbo].[person]
			where name=@name and surname=@surname and secondaryname=@secname 
			order by id_person desc;
open id_cursor  
fetch next from id_cursor into @id_p;
close id_cursor
deallocate id_cursor

INSERT INTO [new_yur].[dbo].[person_dept]
     VALUES(@id_dept,@id_p,getdate(),1,@post,1)

