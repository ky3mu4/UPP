﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЭлектроннаяЦифроваяПодпись
	{
		////////////////////////////////////////////////////////////////////////////////
		//  ОСНОВНЫЕ МЕТОДЫ
		// Проверяет подпись. В случае ошибки бросает исключение
		//
		// Параметры
		//  МенеджерКриптографии  - МенеджерКриптографии - менеджер криптографии
		//  ДвоичныеДанныеФайла  -    двоичные данные файла
		//  ДвоичныеДанныеПодписи  -  двоичные данные подписи

		public void ПроверитьПодпись(/*МенеджерКриптографии, ДвоичныеДанныеФайла, ДвоичныеДанныеПодписи*/)
		{
			//Сертификат = Неопределено;
			//МенеджерКриптографии.ПроверитьПодпись(ДвоичныеДанныеФайла, ДвоичныеДанныеПодписи, Сертификат);
			//МассивРежимовПроверки = Новый Массив;
			//МассивРежимовПроверки.Добавить(РежимПроверкиСертификатаКриптографии.ИгнорироватьВремяДействия);
			//МассивРежимовПроверки.Добавить(РежимПроверкиСертификатаКриптографии.РазрешитьТестовыеСертификаты);
			//МенеджерКриптографии.ПроверитьСертификат(Сертификат, МассивРежимовПроверки);
		}
		// Заносит информацию о подписи объекта
		//
		// Параметры
		//	ПодписываемыйОбъектСсылка  - любая ссылка / объект - в табличную часть которого будет занесена информация о ЭЦП
		//								в случае если ссылка - будет получен объект, блокировка, запись в ИБ
		//								в случае объекта - за блокировку и запись - ответственнен вызывающий код
		//	НоваяПодписьДвоичныеДанные  - ДвоичныеДанные - двоичные данные подписи
		//	Отпечаток  - Строка - Base64 закодированная строка с отпечатком сертификата подписавшего
		//	ДатаПодписи  - Дата - дата подписи
		//	Комментарий  - Строка - комментарий подписи
		//	ИмяФайлаПодписи  - Строка - имя файла подписи (не пусто только в случае если подпись добавлена из файла)
		//	КомуВыданСертификат  - Строка - представление поля КомуВыдан сертификата
		//	УникальныйИдентификатор - УникальныйИдентификатор - уникальный идентификатор формы
		//

		public void ЗанестиИнформациюОПодписи(/*
			ПодписываемыйОбъектСсылка,
			НоваяПодписьДвоичныеДанные,
			Отпечаток,
			ДатаПодписи,
			Комментарий,
			ИмяФайлаПодписи,
			КомуВыданСертификат,
			ДвоичныеДанныеСертификата,
			УникальныйИдентификатор = Неопределено*/)
		{
			if(true/*ОбщегоНазначения.ЭтоСсылка(ТипЗнч(ПодписываемыйОбъектСсылка))*/)
			{
				//ПодписываемыйОбъект = ПодписываемыйОбъектСсылка.ПолучитьОбъект();
				//ПодписываемыйОбъект.Заблокировать();
			}
			//НоваяЗапись = ПодписываемыйОбъект.ЭлектронныеЦифровыеПодписи.Добавить();
			//НоваяЗапись.КомуВыданСертификат	= КомуВыданСертификат;
			//НоваяЗапись.ДатаПодписи			= ДатаПодписи;
			//НоваяЗапись.ИмяФайлаПодписи		= ИмяФайлаПодписи;
			//НоваяЗапись.Комментарий			= Комментарий;
			//НоваяЗапись.Отпечаток			= Отпечаток;
			//НоваяЗапись.Подпись				= Новый ХранилищеЗначения(НоваяПодписьДвоичныеДанные);
			//НоваяЗапись.УстановившийПодпись = ПользователиСервер.ТекущийПользователь();
			//НоваяЗапись.Сертификат 			= Новый ХранилищеЗначения(ДвоичныеДанныеСертификата);
			//ПодписываемыйОбъект.ПодписанЭЦП = Истина;
			//ПодписываемыйОбъект.ДополнительныеСвойства.Вставить("ЗаписьПодписанногоОбъекта", Истина);
			/*// чтобы прошла запись ранее подписанного объекта
*/
			if(true/*ОбщегоНазначения.ЭтоСсылка(ТипЗнч(ПодписываемыйОбъектСсылка))*/)
			{
				//УстановитьПривилегированныйРежим(Истина);
				//ПодписываемыйОбъект.Записать();
				//ПодписываемыйОбъект.Разблокировать();
			}
		}
		////////////////////////////////////////////////////////////////////////////////
		//  ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ
		// Возвращает структуру, содержащую различные персональные настройки по работе с ЭЦП
		// Возвращаемое значение:
		//   Структура  - структура с настройками

		public object ПолучитьПерсональныеНастройкиРаботыСЭЦПСервер(/**/)
		{
			//Настройки = Новый Структура;
			//УстановитьПривилегированныйРежим(Истина);
			//ПровайдерЭЦП = Константы.ПровайдерЭЦП.Получить();
			//Настройки.Вставить("ПровайдерЭЦП", ПровайдерЭЦП);
			//ТипПровайдераЭЦП = Константы.ТипПровайдераЭЦП.Получить();
			//Настройки.Вставить("ТипПровайдераЭЦП", ТипПровайдераЭЦП);
			//ВыполнятьПроверкуЭЦПНаСервере = Константы.ВыполнятьПроверкуЭЦПНаСервере.Получить();
			//Настройки.Вставить("ВыполнятьПроверкуЭЦПНаСервере", ВыполнятьПроверкуЭЦПНаСервере);
			//АлгоритмПодписи = Константы.АлгоритмПодписи.Получить();
			//Настройки.Вставить("АлгоритмПодписи", АлгоритмПодписи);
			//АлгоритмХеширования = Константы.АлгоритмХеширования.Получить();
			//Настройки.Вставить("АлгоритмХеширования", АлгоритмХеширования);
			//АлгоритмШифрования = Константы.АлгоритмШифрования.Получить();
			//Настройки.Вставить("АлгоритмШифрования", АлгоритмШифрования);
			//ПутьМодуляКриптографии = ОбщегоНазначения.ХранилищеОбщихНастроекЗагрузить("ЭЦП", "ПутьМодуляКриптографии");
			if(true/*ПутьМодуляКриптографии = Неопределено*/)
			{
				//ПутьМодуляКриптографии = "";
			}
			//Настройки.Вставить("ПутьМодуляКриптографии", ПутьМодуляКриптографии);
			//ДействияПриСохраненииСЭЦП = ОбщегоНазначения.ХранилищеОбщихНастроекЗагрузить("ЭЦП", "ДействияПриСохраненииСЭЦП");
			if(true/*ДействияПриСохраненииСЭЦП = Неопределено*/)
			{
				//ДействияПриСохраненииСЭЦП = Перечисления.ДействияПриСохраненииСЭЦП.Спрашивать;
			}
			//СтрокаДействияПриСохраненииСЭЦП = "";
			if(true/*ДействияПриСохраненииСЭЦП = Перечисления.ДействияПриСохраненииСЭЦП.Спрашивать*/)
			{
				//СтрокаДействияПриСохраненииСЭЦП = "Спрашивать";
			}
			//Настройки.Вставить("ДействияПриСохраненииСЭЦП", СтрокаДействияПриСохраненииСЭЦП);
			//РасширениеДляФайловПодписи = ОбщегоНазначения.ХранилищеОбщихНастроекЗагрузить("ЭЦП", "РасширениеДляФайловПодписи");
			if(true/*РасширениеДляФайловПодписи = Неопределено ИЛИ ПустаяСтрока(РасширениеДляФайловПодписи)*/)
			{
				//РасширениеДляФайловПодписи = "p7s";
			}
			//Настройки.Вставить("РасширениеДляФайловПодписи", РасширениеДляФайловПодписи);
			//РасширениеДляЗашифрованныхФайлов = ОбщегоНазначения.ХранилищеОбщихНастроекЗагрузить("ЭЦП", "РасширениеДляЗашифрованныхФайлов");
			if(true/*РасширениеДляЗашифрованныхФайлов = Неопределено ИЛИ ПустаяСтрока(РасширениеДляЗашифрованныхФайлов)*/)
			{
				//РасширениеДляЗашифрованныхФайлов = "p7m";
			}
			//Настройки.Вставить("РасширениеДляЗашифрованныхФайлов", РасширениеДляЗашифрованныхФайлов);
			return null;
		}
		// Преобразует назначения сертификатов в дружественный вид
		// Параметры
		//  Назначение  - Строка - назначение сертификата вида "TLS Web Client Authentication (1.3.6.1.5.5.7.3.2)"
		//  НовоеНазначение  - Строка - удобное для понимания назначение сертификата вида "Проверка подлинности клиента"
		//  ДобавлятьКодНазначения  - Булево - надо ли добавлять к назначению код назначения
		//    (например 1.3.6.1.5.5.7.3.2, чтобы получилось "Проверка подлинности клиента (1.3.6.1.5.5.7.3.2)")

		public void ЗаполнитьНазначениеСертификата(/*Назначение, НовоеНазначение, ДобавлятьКодНазначения = Ложь*/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			//НовоеНазначение = "";
		}
		// Получает все подписи файла
		//
		// Параметры
		//  СсылкаНаОбъект  - СправочникСсылка - ссылка объект, в табличной части которого содержатся подписи
		//  УникальныйИдентификатор - УникальныйИдентификатор - уникальный идентификатор формы
		//
		// Возвращаемое значение:
		//  МассивВозврата - Массив  - массив структур с возвращаемыми значениями
		//

		public object ПолучитьВсеПодписи(/*СсылкаНаОбъект, УникальныйИдентификатор*/)
		{
			//МассивВозврата = Новый Массив;
			/*//ВерсияСсылка = ОбщегоНазначения.ПолучитьЗначениеРеквизита(ФайлСсылка, "ТекущаяВерсия");
*/
			//ПолноеИмяОбъектаСЭЦП = СсылкаНаОбъект.Метаданные().ПолноеИмя();
			/*ТекстЗапроса = "ВЫБРАТЬ РАЗРЕШЕННЫЕ
					|	ЭлектронныеЦифровыеПодписи.КомуВыданСертификат КАК КомуВыданСертификат,
					|	ЭлектронныеЦифровыеПодписи.Подпись             КАК Подпись,
					|	ЭлектронныеЦифровыеПодписи.ИмяФайлаПодписи     КАК ИмяФайлаПодписи
					|ИЗ
					|	[ПолноеИмяОбъектаСЭЦП].ЭлектронныеЦифровыеПодписи КАК ЭлектронныеЦифровыеПодписи
					|ГДЕ
					|	ЭлектронныеЦифровыеПодписи.Ссылка = &СсылкаНаОбъект";*/
			//ТекстЗапроса = СтрЗаменить(ТекстЗапроса, "[ПолноеИмяОбъектаСЭЦП]", ПолноеИмяОбъектаСЭЦП);
			//Запрос = Новый Запрос;
			//Запрос.Текст = ТекстЗапроса;
			//Запрос.Параметры.Вставить("СсылкаНаОбъект", СсылкаНаОбъект);
			//ВыборкаЗапроса = Запрос.Выполнить().Выбрать();
			while(true/*ВыборкаЗапроса.Следующий()*/)
			{
				//ДвоичныеДанные = ВыборкаЗапроса.Подпись.Получить();
				//АдресПодписи = ПоместитьВоВременноеХранилище(ДвоичныеДанные, УникальныйИдентификатор);
				/*СтруктураВозврата = Новый Структура("АдресПодписи, КомуВыданСертификат, ИмяФайлаПодписи",
											АдресПодписи,
											ВыборкаЗапроса.КомуВыданСертификат,
											ВыборкаЗапроса.ИмяФайлаПодписи);*/
				//МассивВозврата.Добавить(СтруктураВозврата);
			}
			return null;
		}
	}
}

