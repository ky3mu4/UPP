﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЗаполнениеДокументовПереопределяемый
	{
		// Процедура предназначена для заполнения общих реквизитов документов,
		// вызывается в обработчиках событий "ПриОткрытии" в модулех форм всех документов.
		//
		// Параметры:
		//  ДокументОбъект                 - объект редактируемого документа,
		//  ТекПользователь                - ссылка на справочник, определяет текущего пользователя
		//  ВалютаРегламентированногоУчета - валюта регламентированного учета
		//

		public void ЗаполнитьШапкуДокумента(/*ДокументОбъект, ТекПользователь, ВалютаРегламентированногоУчета = Неопределено*/)
		{
			//МетаданныеДокумента = ДокументОбъект.Метаданные();
			if(true/*МетаданныеДокумента.Реквизиты.Найти("Ответственный") <> Неопределено*/)
			{
				//ДокументОбъект.Ответственный = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекПользователь, "ОсновнойОтветственный");
			}
			/*// Флаги принадлежности к учету заполняем, только если оба не заполнены
*/
			if(true/*МетаданныеДокумента.Реквизиты.Найти("ОтражатьВУправленческомУчете") <> Неопределено
		И МетаданныеДокумента.Реквизиты.Найти("ОтражатьВБухгалтерскомУчете") <> Неопределено*/)
			{
				if(true/*Не (ДокументОбъект.ОтражатьВУправленческомУчете 
			или ДокументОбъект.ОтражатьВБухгалтерскомУчете)*/)
				{
					//ДокументОбъект.ОтражатьВУправленческомУчете = Ложь;
					//ДокументОбъект.ОтражатьВБухгалтерскомУчете  = Истина;
					if(true/*МетаданныеДокумента.Реквизиты.Найти("ОтражатьВНалоговомУчете") <> Неопределено*/)
					{
						//ДокументОбъект.ОтражатьВНалоговомУчете = Истина;
					}
				}
			}
			if(true/*МетаданныеДокумента.Реквизиты.Найти("Подразделение") <> Неопределено 
		И (НЕ ЗначениеЗаполнено(ДокументОбъект.Подразделение))*/)
			{
				//ДокументОбъект.Подразделение = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекПользователь, "ОсновноеПодразделение");
			}
			//ПроверятьСоответствиеПодразделенияОрганизации = Ложь;
			if(true/*МетаданныеДокумента.Реквизиты.Найти("Организация") <> Неопределено*/)
			{
				//ЭтоУпрДокумент =  МетаданныеДокумента.Реквизиты.Найти("ОтражатьВУправленческомУчете") <> Неопределено И ДокументОбъект.ОтражатьВУправленческомУчете;
				if(true/*Не ЭтоУпрДокумент*/)
				{
					//ПроверятьСоответствиеПодразделенияОрганизации = Истина;
					if(true/*(НЕ ЗначениеЗаполнено(ДокументОбъект.Организация))*/)
					{
						//ДокументОбъект.Организация = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекПользователь, "ОсновнаяОрганизация");
					}
				}
			}
			if(true/*МетаданныеДокумента.Реквизиты.Найти("ВидОперации") <> Неопределено
		И (НЕ ЗначениеЗаполнено(ДокументОбъект.ВидОперации))*/)
			{
				//ДокументОбъект.ВидОперации = Перечисления[ДокументОбъект.ВидОперации.Метаданные().Имя][0];
			}
			if(true/*МетаданныеДокумента.Реквизиты.Найти("СчетОрганизации") <> Неопределено
		И (НЕ ЗначениеЗаполнено(ДокументОбъект.СчетОрганизации))
		И (ЗначениеЗаполнено(ДокументОбъект.Организация.ЮрФизЛицо))*/)
			{
				//СчетПоУмолчанию = ДокументОбъект.Организация.ОсновнойБанковскийСчет;
				//ДокументОбъект.СчетОрганизации = СчетПоУмолчанию;
				if(true/*МетаданныеДокумента.Реквизиты.Найти("ВалютаДокумента") <> Неопределено
			И (НЕ ЗначениеЗаполнено(ДокументОбъект.ВалютаДокумента))*/)
				{
					//ДокументОбъект.ВалютаДокумента =  СчетПоУмолчанию.ВалютаДенежныхСредств;
				}
			}
			if(true/*МетаданныеДокумента.Реквизиты.Найти("ПодразделениеОрганизации") <> Неопределено
	   И (НЕ ЗначениеЗаполнено(ДокументОбъект.ПодразделениеОрганизации))*/)
			{
				//ПодразделениеПоУмолчанию = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекПользователь, "ОсновноеПодразделениеОрганизации");
				if(true/*ПроверятьСоответствиеПодразделенияОрганизации*/)
				{
					if(true/*ПодразделениеПоУмолчанию.Владелец = ДокументОбъект.Организация*/)
					{
						//ДокументОбъект.ПодразделениеОрганизации = ПодразделениеПоУмолчанию;
					}
				}
			}
			if(true/*МетаданныеДокумента.Реквизиты.Найти("ВалютаДокумента") <> Неопределено
	   И (НЕ ЗначениеЗаполнено(ДокументОбъект.ВалютаДокумента))*/)
			{
				//ДокументОбъект.ВалютаДокумента = ВалютаРегламентированногоУчета;
			}
			if(true/*МетаданныеДокумента.Реквизиты.Найти("КурсДокумента") <> Неопределено
	   И (НЕ ЗначениеЗаполнено(ДокументОбъект.КурсДокумента))*/)
			{
				//СтруктураКурсаДокумента      = МодульВалютногоУчета.ПолучитьКурсВалюты(ДокументОбъект.ВалютаДокумента, ДокументОбъект.Дата);
				//ДокументОбъект.КурсДокумента = СтруктураКурсаДокумента.Курс;
				if(true/*МетаданныеДокумента.Реквизиты.Найти("КратностьДокумента") <> Неопределено*/)
				{
					//ДокументОбъект.КратностьДокумента = СтруктураКурсаДокумента.Кратность;
				}
			}
			if(true/*МетаданныеДокумента.Реквизиты.Найти("ПериодРегистрации") <> Неопределено
	   И (НЕ ЗначениеЗаполнено(ДокументОбъект.ПериодРегистрации))*/)
			{
				//ДокументОбъект.ПериодРегистрации = НачалоМесяца(ОбщегоНазначения.ПолучитьРабочуюДату());
			}
		}
		// ЗаполнитьШапкуДокумента()

		public void ДобавитьТаблицыВЗапросПолученияДействийСНачислениями(/*ТекстЗапроса*/)
		{
			/*//	В этой конфигурации дополнительных таблиц не предусмотрено
*/
		}

		public void ДобавитьОбъединенияВЗапросПолученияДействийСНачислениями(/*ТекстЗапроса, ЧастьЗапроса*/)
		{
			if(true/*ЧастьЗапроса = 1*/)
			{
				//ПолеПодразделение 	= "СтароеПодразделениеОрганизации";
				//ПолеДолжность		= "СтараяДолжность";
			}
			//ЗаполнениеНачислениямиДополнительный.ДобавитьОбъединенияВЗапросПолученияДействийСНачислениями(ТекстЗапроса, ПолеПодразделение, ПолеДолжность);
		}

		public object ВалютаПоказателяИмяПоляЗапроса(/**/)
		{
			//ИмяПоляЗапроса = ЗаполнениеНачислениямиДополнительный.ВалютаПоказателяИмяПоляЗапроса();
			return null;
		}

		public void ДополнитьЗапросПолученияДействийСНачислениями(/*Запрос, ТекстЗапроса*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДополнитьЗапросПоНачислениямОтбором(/*ТекстЗапроса, ДокументСсылка*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДополнитьЗапросПоЗаписямПлановыхНачислений(/*ТекстЗапроса*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ДополнитьЗапросПоЗаписямПлановыхНачислений()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПОЛУЧЕНИЯ СВЕДЕНИЙ О ВИДАХ РАСЧЕТА

		public void ДополнитьСведенияПВРПоТипуВР(/*СведенияПВРПоТипуВР*/)
		{
			//СведенияПВРПоТипуВР.Вставить(Тип("ПланВидовРасчетаСсылка.УправленческиеНачисления"),	ЗаполнениеДокументовЗК.СтруктураСведенийПВР("УправленческиеНачисления", Истина, Ложь, Ложь));
			//СведенияПВРПоТипуВР.Вставить(Тип("ПланВидовРасчетаСсылка.УправленческиеУдержания"),		ЗаполнениеДокументовЗК.СтруктураСведенийПВР("УправленческиеУдержания", Ложь, Ложь, Ложь));
		}

		public object СкрыватьПредопределенныйПоказатель(/*Показатель, Режим*/)
		{
			return null;
		}
		// Проверяет способ расчета на предмет поддержке в этой конфигурации, если поддерживается
		// возвращает Истина
		//
		// Параметры
		//  СпособРасчета  		  - Перечисление.СпособыРасчетаОплатыТруда
		//
		// Возвращаемое значение:
		//   Булево   - Истина - Поддерживается, Ложь - не поддерживается
		//

		public object ЕстьЧемДополнитьСведенияОСпособеРасчета(/*СпособРасчета*/)
		{
			return null;
		}
		// Дополняет структуру сведений о показателях для предопределенного способа расчета
		//
		// Параметры
		//  СпособРасчета  		  - Перечисление.СпособыРасчетаОплатыТруда
		//  СведенияОВидеРасчета  - Структура, содержащия сведения о виде расчета
		//

		public void ДополнитьСведенияОСпособеРасчета(/*СпособРасчета, СведенияОВидеРасчета*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДополнитьСведенияОВидеРасчета(/*СведенияОВидеРасчета, ВидРасчета = Неопределено*/)
		{
			if(true/*СведенияОВидеРасчета.СпособРасчета = Перечисления.СпособыРасчетаОплатыТруда.ДоначислениеПоУправленческомуУчету*/)
			{
				//СведенияОВидеРасчета.Вставить("Показатель1Наименование", "Сумма");
				//СведенияОВидеРасчета.Вставить("Показатель1Видимость", Истина);
				//СведенияОВидеРасчета.Вставить("Показатель1НаименованиеВидимость", Истина);
				//СведенияОВидеРасчета.Вставить("Валюта1Видимость", Ложь);
				//СведенияОВидеРасчета.Вставить("КоличествоПоказателей",0);
				//СведенияОВидеРасчета.Вставить("Показатель1Точность", 2);
			}
			if(true/*ВидРасчета = ПланыВидовРасчета.УправленческиеУдержания.УдержаноПоБухгалтерии*/)
			{
				//СведенияОВидеРасчета.Вставить("Показатель1Наименование", "Удержано по бухгалтерии");
				//СведенияОВидеРасчета.Вставить("Показатель1Видимость", Истина);
				//СведенияОВидеРасчета.Вставить("Показатель1НаименованиеВидимость", Ложь);
				//СведенияОВидеРасчета.Вставить("Валюта1Видимость", Ложь);
				//СведенияОВидеРасчета.Вставить("Показатель1Точность", 2);
			}
		}

		public void ДобавитьОбъединенияВЗапросВидыРасчета(/*ТекстЗапроса*/)
		{
			/*ТекстЗапроса = ТекстЗапроса + "
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	УправленческиеНачисления.Ссылка,
	|	УправленческиеНачисления.СпособРасчета,
	|	ЛОЖЬ,
	|	УправленческиеНачисления.ЗачетОтработанногоВремени
	|ИЗ
	|	ПланВидовРасчета.УправленческиеНачисления КАК УправленческиеНачисления
	|ГДЕ
	|	УправленческиеНачисления.Ссылка В(&Ссылка)
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	УправленческиеУдержания.Ссылка,
	|	УправленческиеУдержания.СпособРасчета,
	|	ЛОЖЬ,
	|	ЛОЖЬ
	|ИЗ
	|	ПланВидовРасчета.УправленческиеУдержания КАК УправленческиеУдержания
	|ГДЕ
	|	УправленческиеУдержания.Ссылка В(&Ссылка)";*/
		}

		public void ДобавитьОбъединенияВЗапросПоказатели(/*ТекстЗапроса*/)
		{
			/*ТекстЗапроса = ТекстЗапроса + "
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	УправленческиеНачисленияПоказатели.Ссылка,
	|	УправленческиеНачисленияПоказатели.Показатель,
	|	УправленческиеНачисленияПоказатели.НомерСтроки,
	|	УправленческиеНачисленияПоказатели.ЗапрашиватьПриКадровыхПеремещениях
	|ИЗ
	|	ПланВидовРасчета.УправленческиеНачисления.Показатели КАК УправленческиеНачисленияПоказатели
	|ГДЕ
	|	УправленческиеНачисленияПоказатели.Ссылка В(&Ссылка)
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	УправленческиеУдержанияПоказатели.Ссылка,
	|	УправленческиеУдержанияПоказатели.Показатель,
	|	УправленческиеУдержанияПоказатели.НомерСтроки,
	|	УправленческиеУдержанияПоказатели.ЗапрашиватьПриКадровыхПеремещениях
	|ИЗ
	|	ПланВидовРасчета.УправленческиеУдержания.Показатели КАК УправленческиеУдержанияПоказатели
	|ГДЕ
	|	УправленческиеУдержанияПоказатели.Ссылка В(&Ссылка)";*/
		}

		public object ПолеЗапросаВводВалютныхЗначений(/**/)
		{
			return null;
		}

		public object ПолеЗапросаТочностьПредставленияПоказателя(/**/)
		{
			return null;
		}
	}
}

