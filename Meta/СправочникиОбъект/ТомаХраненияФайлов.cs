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
	///Каталоги на диске для хранения файлов
	///</summary>
	public partial class ТомаХраненияФайлов:СправочникОбъект
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
		public string/*150*/ Наименование;
		///<summary>
		///Описание тома
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///Максимальный размер файлов на томе, в Мб
		///</summary>
		public decimal/*(10)*/ МаксимальныйРазмер;//Максимальный размер
		///<summary>
		///Полный путь в Linux
		///</summary>
		public string/*(0)*/ ПолныйПутьLinux;//Полный путь linux
		///<summary>
		///Полный путь в UNC формате
		///</summary>
		public string/*(0)*/ ПолныйПутьWindows;//Полный путь windows
		///<summary>
		///Определяет порядок заполнения томов - начинаем с наименьшего
		///</summary>
		public decimal/*(3)*/ ПорядокЗаполнения;//Порядок заполнения
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
						Insert Into _Reference271(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3985
						,_Fld3986
						,_Fld3987
						,_Fld3988
						,_Fld3989)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@Комментарий
						,@МаксимальныйРазмер
						,@ПолныйПутьLinux
						,@ПолныйПутьWindows
						,@ПорядокЗаполнения)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference271
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3985	= @Комментарий
						,_Fld3986	= @МаксимальныйРазмер
						,_Fld3987	= @ПолныйПутьLinux
						,_Fld3988	= @ПолныйПутьWindows
						,_Fld3989	= @ПорядокЗаполнения
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("МаксимальныйРазмер", МаксимальныйРазмер);
					Команда.Parameters.AddWithValue("ПолныйПутьLinux", ПолныйПутьLinux);
					Команда.Parameters.AddWithValue("ПолныйПутьWindows", ПолныйПутьWindows);
					Команда.Parameters.AddWithValue("ПорядокЗаполнения", ПорядокЗаполнения);
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
					Команда.CommandText = @"Delete _Reference271
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public void ОбработкаПроверкиЗаполнения(/*Отказ, ПроверяемыеРеквизиты*/)
		{
			if(true/*Не НомерПорядкаУникален(ПорядокЗаполнения, Ссылка)*/)
			{
				/*Отказ = Истина;*/
				/*ТекстОшибки = НСтр("ru = 'Порядок заполнения не уникален - в системе уже есть том с таким порядком'");*/
				/*ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстОшибки, , "ПорядокЗаполнения", "Объект");*/
			}
			if(true/*ПустаяСтрока(ПолныйПутьWindows) И ПустаяСтрока(ПолныйПутьLinux)*/)
			{
				/*ТекстОшибки = НСтр("ru = 'Не заполнен полный путь'");*/
				/*ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстОшибки, , "ПолныйПутьWindows", "Объект");*/
				/*ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстОшибки, , "ПолныйПутьLinux", "Объект");*/
			}
			if(true/*Не ПустаяСтрока(ПолныйПутьWindows) И (Лев(ПолныйПутьWindows, 2) <> "\\" ИЛИ Найти(ПолныйПутьWindows, ":") <> 0)*/)
			{
				/*Отказ = Истина;*/
				/*ТекстОшибки = НСтр("ru = 'Путь к тому должен быть в формате UNC (\\servername\resource) '");*/
				/*ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстОшибки, , "ПолныйПутьWindows", "Объект");*/
			}
			/*ИмяПоляСПолнымПутем = "";*/
			/*Попытка
		ПолныйПутьТома = "";*/
			/*ТипПлатформыСервера = ОбщегоНазначенияПовтИсп.ТипПлатформыСервера();*/
			if(true/*ТипПлатформыСервера = ТипПлатформы.Windows_x86 ИЛИ ТипПлатформыСервера = ТипПлатформы.Windows_x86_64*/)
			{
				/*ПолныйПутьТома = ПолныйПутьWindows;*/
				/*ИмяПоляСПолнымПутем = "ПолныйПутьWindows";*/
			}
			/*ИмяКаталогаТестовое = ПолныйПутьТома + "ПроверкаДоступа\";*/
			/*СоздатьКаталог(ИмяКаталогаТестовое);*/
			/*УдалитьФайлы(ИмяКаталогаТестовое);*/
			/*Исключение
		Отказ = Истина;*/
			/*ТекстОшибки = НСтр("ru = 'Путь к тому некорректен. Возможно учетная запись, от лица которой работает сервер 1С:Предприятия, не имеет прав доступа к каталогу тома: '");*/
			/*Информация = ИнформацияОбОшибке();*/
			if(true/*Информация.Причина <> Неопределено*/)
			{
				/*ТекстОшибки = ТекстОшибки + Информация.Причина.Описание;*/
				if(true/*Информация.Причина.Причина <> Неопределено*/)
				{
					/*ТекстОшибки = ТекстОшибки + ": " + Информация.Причина.Причина.Описание;*/
				}
			}
			/*ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстОшибки, , ИмяПоляСПолнымПутем, "Объект");*/
			/*КонецПопытки;*/
			if(true/*МаксимальныйРазмер <> 0*/)
			{
				/*ТекущийРазмерВБайтах = 0;*/
				if(true/*Не Ссылка.Пустая()*/)
				{
					/*ТекущийРазмерВБайтах = ФайловыеФункции.ПодсчитатьРазмерФайловНаТоме(Ссылка);*/
				}
				/*ТекущийРазмер = ТекущийРазмерВБайтах / (1024 * 1024);*/
				if(true/*МаксимальныйРазмер < ТекущийРазмер*/)
				{
					/*Отказ = Истина;*/
					/*ТекстОшибки = НСтр("ru = 'Максимальный размер тома меньше, чем текущий размер'");*/
					/*ОбщегоНазначенияКлиентСервер.СообщитьПользователю(ТекстОшибки, , "МаксимальныйРазмер", "Объект");*/
				}
			}
		}
		// Возвращает Ложь, если есть том с таким порядком

		public object НомерПорядкаУникален(/*ПорядокЗаполнения, СсылкаНаТом*/)
		{
			/*Запрос = Новый Запрос;*/
			/*Запрос.Текст = "ВЫБРАТЬ
				   |	КОЛИЧЕСТВО(Тома.ПорядокЗаполнения) КАК Количество
				   |ИЗ
				   |	Справочник.ТомаХраненияФайлов КАК Тома
				   |ГДЕ
				   |	Тома.ПорядокЗаполнения = &ПорядокЗаполнения
				   |И   Тома.Ссылка <> &СсылкаНаТом";*/
			/*Запрос.Параметры.Вставить("ПорядокЗаполнения", ПорядокЗаполнения);*/
			/*Запрос.Параметры.Вставить("СсылкаНаТом", СсылкаНаТом);*/
			/*Выборка = Запрос.Выполнить().Выбрать();*/
			if(true/*Выборка.Следующий()*/)
			{
				if(true/*Выборка.Количество = 0*/)
				{
				}
			}
			return null;
		}
	}
}
