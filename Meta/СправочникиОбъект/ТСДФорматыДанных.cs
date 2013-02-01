﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ТСДФорматыДанных:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		public Guid Ссылка;
		public long Версия;
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления;
		public bool Предопределенный;
		public Guid Владелец;
		public bool ЭтоГруппа;
		public Guid Родитель;
		public string/*9*/ Код;
		public string/*25*/ Наименование;
		public void Записать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference275(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference275
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference275
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		///////////////////////////////////////////////////////////////////////////////
		//// ПЕРЕМЕННЫЕ МОДУЛЯ

		public object ПолучитьСоответствиеПолейТСД(/*Штрихкод, Номенклатура, ЕдиницаИзмерения,
                                     ХарактеристикаНоменклатуры, СерияНоменклатуры,
                                     Качество, Цена, Количество*/)
		{
			/*Результат                = Новый Соответствие();*/
			/*Поле                     = Неопределено;*/
			/*НаименованиеНоменклатуры = СокрЛП(Номенклатура);*/
			/*Артикул                  = "";*/
			/*Характеристика           = СокрЛП(ХарактеристикаНоменклатуры);*/
			/*Серия                    = СокрЛП(СерияНоменклатуры);*/
			/*ЕдИзм                    = СокрЛП(ЕдиницаИзмерения);*/
			/*КодНоменклатуры          = "";*/
			/*ЦенаСтр                  = Формат(Цена, "ЧЦ=15; ЧДЦ=2; ЧН=0; ЧГ=0");*/
			/*КолвоСтр                 = Формат(Количество, "ЧЦ=15; ЧДЦ=2; ЧН=0; ЧГ=0");*/
			/*КачествоСтр              = СокрЛП(Качество);*/
			return null;
		}
		// ПолучитьСоответствиеПолейТСД()
		// Процедура возвращает параметры номенклатуры из соответствия полей ТСД.
		//
		// Параметры:
		//  СоответствиеПолей - <Соответствие>
		//                    - Соответствие, содержащее значения полей таблицы ТСД.
		//                      Значению поля X ТСД соответствует ключ "ПолеX".
		//
		//  Штрихкод          - <Строка>
		//                    - Выходной параметр; штрихкод товара.
		//
		//  Количество        - <Число>
		//                    - Выходной параметр; количество товара.
		//

		public void ПолучитьСодержимоеСоответствияПолейТСД(/*СоответствиеПолей, Штрихкод,
                                               Количество*/)
		{
			/*ПолеШтрихкод   = СвязываемыеПоля.Найти(Перечисления.ТСДПоляДанных.ШтрихКод,
	                                         "ПараметрНоменклатуры");*/
			/*ПолеКоличество = СвязываемыеПоля.Найти(Перечисления.ТСДПоляДанных.КоличествоНаСкладе,
	                                         "ПараметрНоменклатуры");*/
			/*СтрокаШтрихкод   = ?(ПолеШтрихкод = Неопределено,
	                     "",
	                     "Поле" + Формат(ПолеШтрихкод.ПолеТСД, "ЧГ=0"));*/
			/*СтрокаКоличество = ?(ПолеКоличество = Неопределено,
	                     "",
	                     "Поле" + Формат(ПолеКоличество.ПолеТСД, "ЧГ=0"));*/
			/*ВремШтрихкод     = СоответствиеПолей[СтрокаШтрихкод];*/
			/*ВремКоличество   = СоответствиеПолей[СтрокаКоличество];*/
			/*Штрихкод         = ?(ВремШтрихкод = Неопределено, "", ВремШтрихкод);*/
			/*Попытка
		Количество = Число(ВремКоличество);*/
			/*Исключение
		Количество = 0;*/
			/*КонецПопытки;*/
		}
		// ПолучитьСодержимоеСоответствияПолейТСД()
		///////////////////////////////////////////////////////////////////////////////
		//// ОБРАБОТЧИКИ СОБЫТИЙ
		// Процедура - обработчик события "ПередЗаписью"
		//
		// Параметры
		//  Отказ - <Булево>
		//        - признак отказа от записи элемента. Если в теле
		//          процедуры-обработчика установить данному параметру
		//          значение Истина, запись элемента выполнена не будет
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*Не ОбменДанными.Загрузка*/)
			{
				/*Ошибки                          = "";*/
				/*ЕстьШтрихКод                    = Ложь;*/
				/*ЗаполненыПараметрыНоменклатуры  = Истина;*/
				/*ЗаполненыПоляТСД                = Истина;*/
				/*УникальныеПараметрыНоменклатуры = Истина;*/
				/*УникальныеПоляТСД               = Истина;*/
				/*ПараметрыНоменклатуры           = Новый Соответствие();*/
				/*ПоляТСД                         = Новый Соответствие();*/
				if(true/*НЕ ЗначениеЗаполнено(Наименование)*/)
				{
					/*Ошибки = " - Не задано имя формата.";*/
				}
				if(true/*Не ЕстьШтрихКод*/)
				{
					if(true/*Не ПустаяСтрока(Ошибки)*/)
					{
						/*Ошибки = Ошибки + "
				|";*/
					}
					/*Ошибки = Ошибки + " - Параметр номенклатуры ""Штрих-Код"" должен выгружаться в обязательном порядке.";*/
				}
				if(true/*Не ЗаполненыПараметрыНоменклатуры*/)
				{
					if(true/*Не ПустаяСтрока(Ошибки)*/)
					{
						/*Ошибки = Ошибки + "
				|";*/
					}
					/*Ошибки = Ошибки + " - Обнаружены незаполненные параметры номенклатуры.";*/
				}
				if(true/*Не ЗаполненыПоляТСД*/)
				{
					if(true/*Не ПустаяСтрока(Ошибки)*/)
					{
						/*Ошибки = Ошибки + "
				|";*/
					}
					/*Ошибки = Ошибки + " - Обнаружены незаполненные поля терминала.";*/
				}
				if(true/*Не УникальныеПараметрыНоменклатуры*/)
				{
					if(true/*Не ПустаяСтрока(Ошибки)*/)
					{
						/*Ошибки = Ошибки + "
				|";*/
					}
					/*Ошибки = Ошибки + " - Обнаружен параметр номенклатуры, выгружаемый в два поля одновременно.";*/
				}
				if(true/*Не УникальныеПоляТСД*/)
				{
					if(true/*Не ПустаяСтрока(Ошибки)*/)
					{
						/*Ошибки = Ошибки + "
				|";*/
					}
					/*Ошибки = Ошибки + " - Обнаружено поле терминала, в которое выгружаются несколько параметров одновременно.";*/
				}
				if(true/*Не ПустаяСтрока(Ошибки)*/)
				{
					/*ОбщегоНазначения.СообщитьОбОшибке("При попытке записи были обнаружены следующие ошибки:
			                 |" + Ошибки);*/
					/*Отказ = Истина;*/
				}
			}
		}
		// ПередЗаписью()
		///////////////////////////////////////////////////////////////////////////////
		//// ОПЕРАТОРЫ ОСНОВНОЙ ПРОГРАММЫ
	}
}
