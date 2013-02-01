﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УправлениеПользователямиСервер
	{
		// Функция записывает изменения данных пользователя ИБ
		// Параметры:
		// ИмяИдентификаторПользователя - УникальныйИдентификатор/строка - имя пользователя ИБ
		//								либо уникальный идентификатор пользователя ИБ
		// ПользовательСтруктура - структура - структура, содержащая новые значения
		//									характеристик пользователя ИБ
		//

		public object ЗаписатьПользователяИБ(/*	знач ИмяИдентификаторПользователя,
								знач ПользовательСтруктура,
								СообщениеОбОшибке,
								знач СписокРолей = Неопределено*/)
		{
			if(true/*ТипЗнч(ИмяИдентификаторПользователя) = Тип("УникальныйИдентификатор")*/)
			{
				//ПользовательИБ = ПользователиИнформационнойБазы.НайтиПоУникальномуИдентификатору(ИмяИдентификаторПользователя);
			}
			if(true/*ПользовательИБ = Неопределено*/)
			{
				//ПользовательИБ = ПользователиИнформационнойБазы.СоздатьПользователя();
			}
			//ПользовательИБ.Имя						= ПользовательСтруктура["Имя"];
			//ПользовательИБ.ПолноеИмя				= ПользовательСтруктура["ПолноеИмя"];
			//ПользовательИБ.АутентификацияОС			= ПользовательСтруктура["АутентификацияОС"];
			//ПользовательИБ.ПользовательОС			= ПользовательСтруктура["ПользовательОС"];
			//ПользовательИБ.АутентификацияСтандартная= ПользовательСтруктура["АутентификацияСтандартная"];
			//ПользовательИБ.ПоказыватьВСпискеВыбора	= ПользовательСтруктура["ПоказыватьВСпискеВыбора"];
			//ПользовательИБ.ЗапрещеноИзменятьПароль	= ПользовательСтруктура["ЗапрещеноИзменятьПароль"];
			//ПользовательИБ.РежимЗапуска				= ПользовательСтруктура["РежимЗапуска"];
			if(true/*ПользовательСтруктура.Свойство("Пароль")*/)
			{
				//ПользовательИБ.Пароль = ПользовательСтруктура.Пароль;
			}
			//ПользовательИБ.ОсновнойИнтерфейс = Метаданные.Интерфейсы.Найти(ПользовательСтруктура["ОсновнойИнтерфейс"]);
			//ПользовательИБ.Язык = Метаданные.Языки.Найти(ПользовательСтруктура["Язык"]);
			if(true/*СписокРолей <> Неопределено*/)
			{
				//ПользовательИБ.Роли.Очистить();
			}
			/*Попытка
		ПользовательИБ.Записать();*/
			/*Исключение
		ИнформацияОбОшибке = ИнформацияОбОшибке();*/
			//СообщениеОбОшибке = ИнформацияОбОшибке.Причина.Описание;
			//КонецПопытки;
			return null;
		}
		// Процедура для удаления пользователя информационной базы
		//

		public object УдалитьПользователяИБ(/*знач ИдентификаторПользователя*/)
		{
			/*Попытка
		ПользовательИБ = ПользователиИнформационнойБазы.НайтиПоУникальномуИдентификатору(ИдентификаторПользователя);*/
			//ПользовательИБ.Удалить();
			/*Исключение
		Сообщение = 
			НСтр("ru = 'Ошибка удаления пользователя информационной базы: '") +
			ОбщегоНазначенияКлиентСервер.ПолучитьПредставлениеОписанияОшибки(ИнформацияОбОшибке());*/
			//КонецПопытки;
			return null;
		}
		// Функция проверяющая право администрирования объекта метаданного у текущего
		// пользователя. Если объект метаданных не указан, но проверяется право
		// на администрирование конфигурации.
		// Параметры
		// ОбъектМетаданных - метаданные - метаданные
		// Возвращаемое значение
		// Истина        - пользователь имеет право на администрирование
		// Ложь          - пользователь не имеет права на администрирование
		//

		public object ПроверитьПравоАдминистрирования(/*знач ОбъектМетаданных = Неопределено*/)
		{
			if(true/*ОбъектМетаданных = Неопределено*/)
			{
				//ОбъектМетаданных = Метаданные;
			}
			return null;
		}
		// Получает имя  и полное имя пользователя ИБ по идентефикатору пользователя
		//

		public object ПолучитьИмяПолноеИмя(/*УникальныйИдентификатор*/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			//Пользователь = ПользователиИнформационнойБазы.НайтиПоУникальномуИдентификатору(УникальныйИдентификатор);
			if(true/*Пользователь = Неопределено*/)
			{
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Функциональность для управления оформлением списков пользователей

		public void ПроверитьСинхронизациюПользователейИУстановитьОформлениеСписка(/*УсловноеОформление*/)
		{
			//ПользователиОтмеченные = Новый Массив;
			//Запрос = Новый Запрос;
			/*Запрос.Текст = "ВЫБРАТЬ
					|	Ссылка, Код, Наименование, ИдентификаторПользователяИБ
					|ИЗ
					|	Справочник.Пользователи КАК Пользователи
					|ГДЕ
					|	НЕ ЭтоГруппа";*/
			//Выборка = Запрос.Выполнить().Выбрать();
			while(true/*Выборка.Следующий()*/)
			{
				if(true/*СокрЛП(Выборка.Код) = "<Не указан>"*/)
				{
					//Продолжить;
				}
			}
			if(true/*ПользователиОтмеченные.Количество() > 0*/)
			{
				//УстановитьУсловноеОформлениеДляЭлементовТребующихВнимания(ПользователиОтмеченные, УсловноеОформление);
			}
		}

		public void УстановитьУсловноеОформлениеДляВыбранногоЭлемента(/*знач Ссылка, УсловноеОформление*/)
		{
			/*ЭлементУсловногоОформления = 
			ПолучитьЭлементУсловногоОформления(УсловноеОформление,
												"ЭлементыСправочникаВыбранные",
												Метаданные.ЭлементыСтиля.ПользовательВыбранный.Значение);*/
			//ДобавитьЭлементОтбораКУсловномуОформлению(ЭлементУсловногоОформления, Ссылка);
		}

		public void УстановитьУсловноеОформлениеДляЭлементовТребующихВнимания(/*знач ПользователиОтмеченные, УсловноеОформление*/)
		{
			/*ЭлементУсловногоОформления = 
			ПолучитьЭлементУсловногоОформления(УсловноеОформление,
												"ЭлементыСправочникаТребующиеВнимания",
												Метаданные.ЭлементыСтиля.ПользовательБезУчетнойЗаписи.Значение);*/
			//ДобавитьЭлементОтбораКУсловномуОформлению(ЭлементУсловногоОформления, ПользователиОтмеченные);
		}

		public object ДобавитьЭлементОтбораКУсловномуОформлению(/*ЭлементУсловногоОформления, МассивСсылка*/)
		{
			if(true/*ЭлементУсловногоОформления.Отбор.Элементы.Количество() = 0*/)
			{
				//ЭлементОтбораДанных = ЭлементУсловногоОформления.Отбор.Элементы.Добавить(Тип("ЭлементОтбораКомпоновкиДанных"));
			}
			//ЭлементОтбораДанных.ЛевоеЗначение = Новый ПолеКомпоновкиДанных("Ссылка");
			//ЭлементОтбораДанных.ВидСравнения = ВидСравненияКомпоновкиДанных.ВСписке;
			if(true/*ЭлементОтбораДанных.ПравоеЗначение = Неопределено*/)
			{
				//ЭлементОтбораДанных.ПравоеЗначение = Новый СписокЗначений;
			}
			if(true/*ТипЗнч(МассивСсылка) = Тип("Массив")*/)
			{
				//ЭлементОтбораДанных.ПравоеЗначение.ЗагрузитьЗначения(МассивСсылка);
			}
			//ЭлементОтбораДанных.Использование = Истина;
			return null;
		}

		public object ПолучитьЭлементУсловногоОформления(/*УсловноеОформление,
											ИдентификаторПользовательскойНастройки,
											ЭлементСтиляЗначение*/)
		{
			//ЭлементУсловногоОформления = УсловноеОформление.Элементы.Добавить();
			//ПолеОформления = ЭлементУсловногоОформления.Поля.Элементы.Добавить();
			//ПолеОформления.Использование = Истина;
			//ПолеОформления.Поле = Новый ПолеКомпоновкиДанных("Код");
			//ПолеОформления = ЭлементУсловногоОформления.Поля.Элементы.Добавить();
			//ПолеОформления.Использование = Истина;
			//ПолеОформления.Поле = Новый ПолеКомпоновкиДанных("Наименование");
			//ЭлементУсловногоОформления.Оформление.УстановитьЗначениеПараметра("ЦветТекста", ЭлементСтиляЗначение);
			//ЭлементУсловногоОформления.ИдентификаторПользовательскойНастройки = ИдентификаторПользовательскойНастройки;
			return null;
		}

		public object ПользователюРазрешенЗапускКонфигурации(/**/)
		{
			if(true/*НЕ РольДоступна("Пользователь")
		И (НЕ РольДоступна("ПолныеПрава"))*/)
			{
			}
			return null;
		}
	}
}

