﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ОсновныеСредства:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid Родитель {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public bool ЭтоГруппа {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public bool Автотранспорт {get;set;}//Признак автотранспорта
		///<summary>
		///Адрес местонахождения объекта недвижимости
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public string/*(0)*/ АдресМестонахождения {get;set;}//Адрес местонахождения
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.Перечисления/*Ссылка*/.АмортизационныеГруппы АмортизационнаяГруппа {get;set;}//Амортизационная группа
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public V82.Перечисления/*Ссылка*/.ГруппыОС ГруппаОС {get;set;}//Группа ОС
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public DateTime ДатаВыпуска {get;set;}//Дата выпуска (постройки)
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ ЗаводскойНомер {get;set;}//Заводской номер
		///<summary>
		///(Общ) Организация-изготовитель
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public string/*(0)*/ Изготовитель {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.ОбщероссийскийКлассификаторОсновныхФондов КодПоОКОФ {get;set;}//Код по ОКОФ
		///<summary>
		///Код региона объекта недвижимости
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public string/*(2)*/ КодРегиона {get;set;}//Код региона
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public string/*(0)*/ НаименованиеПолное {get;set;}//Полное наименование
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public string/*(0)*/ НомерПаспорта {get;set;}//Номер паспорта (регистрационный)
		[DataMember]
		[ProtoMember(22)]
		public bool Помещение {get;set;}//Является помещением или составной частью здания (сооружения)
		[DataMember]
		[ProtoMember(23)]
		public string/*(100)*/ КадастровыйНомер {get;set;}//Кадастровый номер
		[DataMember]
		[ProtoMember(24)]
		public string/*(21)*/ УсловныйНомер {get;set;}//Условный номер
		[DataMember]
		[ProtoMember(25)]
		public V82.Перечисления/*Ссылка*/.НазначенияПомещения НазначениеПомещения {get;set;}//Назначение помещения
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для справочников.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference180(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3092
						,_Fld3093
						,_Fld3094RRef
						,_Fld3095RRef
						,_Fld3096
						,_Fld3097
						,_Fld3098
						,_Fld3099RRef
						,_Fld3100
						,_Fld3101
						,_Fld3102
						,_Fld3103
						,_Fld3104
						,_Fld3105
						,_Fld3106
						,_Fld3107RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@Автотранспорт
						,@АдресМестонахождения
						,@АмортизационнаяГруппа
						,@ГруппаОС
						,@ДатаВыпуска
						,@ЗаводскойНомер
						,@Изготовитель
						,@КодПоОКОФ
						,@КодРегиона
						,@Комментарий
						,@НаименованиеПолное
						,@НомерПаспорта
						,@Помещение
						,@КадастровыйНомер
						,@УсловныйНомер
						,@НазначениеПомещения)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference180
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3092	= @Автотранспорт
						,_Fld3093	= @АдресМестонахождения
						,_Fld3094RRef	= @АмортизационнаяГруппа
						,_Fld3095RRef	= @ГруппаОС
						,_Fld3096	= @ДатаВыпуска
						,_Fld3097	= @ЗаводскойНомер
						,_Fld3098	= @Изготовитель
						,_Fld3099RRef	= @КодПоОКОФ
						,_Fld3100	= @КодРегиона
						,_Fld3101	= @Комментарий
						,_Fld3102	= @НаименованиеПолное
						,_Fld3103	= @НомерПаспорта
						,_Fld3104	= @Помещение
						,_Fld3105	= @КадастровыйНомер
						,_Fld3106	= @УсловныйНомер
						,_Fld3107RRef	= @НазначениеПомещения
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Автотранспорт", Автотранспорт);
					Команда.Parameters.AddWithValue("АдресМестонахождения", АдресМестонахождения);
					Команда.Parameters.AddWithValue("АмортизационнаяГруппа", АмортизационнаяГруппа.Ключ());
					Команда.Parameters.AddWithValue("ГруппаОС", ГруппаОС.Ключ());
					Команда.Parameters.AddWithValue("ДатаВыпуска", ДатаВыпуска);
					Команда.Parameters.AddWithValue("ЗаводскойНомер", ЗаводскойНомер);
					Команда.Parameters.AddWithValue("Изготовитель", Изготовитель);
					Команда.Parameters.AddWithValue("КодПоОКОФ", КодПоОКОФ.Ссылка);
					Команда.Parameters.AddWithValue("КодРегиона", КодРегиона);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("НаименованиеПолное", НаименованиеПолное);
					Команда.Parameters.AddWithValue("НомерПаспорта", НомерПаспорта);
					Команда.Parameters.AddWithValue("Помещение", Помещение);
					Команда.Parameters.AddWithValue("КадастровыйНомер", КадастровыйНомер);
					Команда.Parameters.AddWithValue("УсловныйНомер", УсловныйНомер);
					Команда.Parameters.AddWithValue("НазначениеПомещения", НазначениеПомещения.Ключ());
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
					Команда.CommandText = @"Delete _Reference180
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public object ПечатьОС6_2003(/*ДатаСведений,ПечатьПоДаннымУпрУчета = Истина*/)
		{
			//Макет = ПолучитьМакет("ОС6_2003");
			//Шапка = Макет.ПолучитьОбласть("Шапка");
			//ШапкаРазделов1и2  = Макет.ПолучитьОбласть("ШапкаРазделов1и2");
			//ШапкаРаздела3     = Макет.ПолучитьОбласть("ШапкаРаздела3");
			//СтрокиРаздела3    = Макет.ПолучитьОбласть("СтрокиРаздела3");
			//ШапкаРаздела4     = Макет.ПолучитьОбласть("ШапкаРаздела4");
			//СтрокаРаздела4    = Макет.ПолучитьОбласть("СтрокаРаздела4");
			//ПодвалСтраницы1   = Макет.ПолучитьОбласть("ПодвалСтраницы1");
			//ШапкаРазделов5и6  = Макет.ПолучитьОбласть("ШапкаРазделов5и6");
			//СтрокаРазделов5и6 = Макет.ПолучитьОбласть("СтрокаРазделов5и6");
			//ШапкаРаздела7_1   = Макет.ПолучитьОбласть("ШапкаРаздела7_1");
			//ШапкаРаздела7_2   = Макет.ПолучитьОбласть("ШапкаРаздела7_2");
			//ПодвалСтраницы2   = Макет.ПолучитьОбласть("ПодвалСтраницы2");
			//ТабДок = Новый ТабличныйДокумент();
			//НазваниеРегистраСтоимость = "СтоимостьОС";
			//НазваниеРегистраСобытия   = "СобытияОС";
			//НазваниеСуммыЗатрат		  = "СуммаЗатрат";
			//Организация = Неопределено;
			if(true/*ПечатьПоДаннымУпрУчета*/)
			{
				//кВидуУчета   = "управленческому";
				//cВидаУчета   = "управленческого";
				//ВалютаПечати = глЗначениеПеременной("ВалютаУправленческогоУчета").Наименование;
				//ВидУчета 	 = "Упр";
			}
			//СведенияОбОС = УправлениеВнеоборотнымиАктивами.ПолучитьСведенияОбОС(Ссылка,ДатаСведений,Организация,ВидУчета);
			if(true/*СведенияОбОС <> Неопределено*/)
			{
				if(true/*Не ПечатьПоДаннымУпрУчета и НЕ ЗначениеЗаполнено(СведенияОбОС.ОсновноеСредство)*/)
				{
					/*Сообщить("На момент печати основное средство не принималось к учету в указанной организации."+Символы.ПС+
			"Нельзя сформировать инвентарную карточку объекта!",СтатусСообщения.Внимание);*/
				}
				//Шапка.Параметры.Заполнить(СведенияОбОС);
				//Шапка.Параметры.ДатаДок        = Лев(Строка(ДатаСведений),10);
				//Шапка.Параметры.НомерДок       = Шапка.Параметры.ИнвентарныйНомер;
				/*Шапка.Параметры.НаименованиеОС = ? (НЕ ЗначениеЗаполнено(СведенияОбОС.НаименованиеПолное),
										    СведенияОбОС.Наименование,СведенияОбОС.НаименованиеПолное);*/
			}
			if(true/*НЕ (Организация = Неопределено)*/)
			{
				//Шапка.Параметры.КодПоОКПО = Организация.КодПоОКПО;
			}
			/*// получим даты  и документы изменения состояний ос
*/
			//СтруктПараметров = УправлениеВнеоборотнымиАктивами.ПолучитьАтрибутыСостоянияОС(Ссылка, Перечисления.СостоянияОС.ПринятоКУчету,ПечатьПоДаннымУпрУчета,Организация);
			//ДокументПринятия = СтруктПараметров["ИмяДок"];
			//ДатаПринятия     = СтруктПараметров["Дата"];
			//СтруктПараметров   = УправлениеВнеоборотнымиАктивами.ПолучитьАтрибутыСостоянияОС(Ссылка, Перечисления.СостоянияОС.ВведеноВЭксплуатацию,ПечатьПоДаннымУпрУчета,Организация);
			//ДатаВвода          = СтруктПараметров["Дата"];
			//ДокументВвода      = СтруктПараметров["ИмяДок"];
			//ДокументВводаНомер = СтруктПараметров["НомерДок"];
			//СтруктПараметров    = УправлениеВнеоборотнымиАктивами.ПолучитьАтрибутыСостоянияОС(Ссылка, Перечисления.СостоянияОС.СнятоСУчета,ПечатьПоДаннымУпрУчета,Организация);
			//ДатаСписания        = СтруктПараметров["Дата"];
			//ДокументСписания    = СтруктПараметров["ИмяДок"];
			//РегистраторСписания = СтруктПараметров["Регистратор"];
			/*//	получим дату и документ последней модернизации
*/
			if(true/*ПечатьПоДаннымУпрУчета*/)
			{
				//ВыборкаЗаписей = РегистрыСведений.СобытияОС.Выбрать(,КонецДня(РабочаяДата),Новый Структура("ОсновноеСредство",Ссылка));
			}
			while(true/*ВыборкаЗаписей.Следующий()*/)
			{
				if(true/*ВыборкаЗаписей.Событие.ВидСобытияОС = Перечисления.ВидыСобытийОС.Модернизация*/)
				{
					//ДатаПоследнейМодернизации     = Лев(Строка(ВыборкаЗаписей.Период),10);
					//ДокументПоследнейМодернизации = ВыборкаЗаписей.НазваниеДокумента;
				}
			}
			/*;
	
	Шапка.Параметры.ДатаВвода    = ДатаПринятия;*/
			//Шапка.Параметры.ДатаСписания = ДатаСписания;
			//Шапка.Параметры.кВидуУчета 	 = кВидуУчета;
			//Шапка.Параметры.cВидаУчета 	 = cВидаУчета;
			//ТабДок.Вывести(Шапка);
			//ШапкаРазделов1и2.Параметры.кВидуУчета = кВидуУчета;
			/*// Балансовая стоимость ОС на момент поступления
*/
			//ШапкаРазделов1и2.Параметры.ПервоначальнаяСтоимость    = СведенияОбОС.ПервоначальнаяСтоимость;
			//ШапкаРазделов1и2.Параметры.СрокПолезногоИспользования = СведенияОбОС.СрокПолезногоИспользования;
			//ШапкаРазделов1и2.Параметры.Валюта = ВалютаПечати;
			//ТабДок.Вывести(ШапкаРазделов1и2);
			//ШапкаРаздела3.Параметры.Валюта = ВалютаПечати;
			//ТабДок.Вывести(ШапкаРаздела3);
			//ТабДок.Вывести(СтрокиРаздела3);
			/*// Сведения о приемке, внутренних перемещениях и выбытии	
*/
			//ШапкаРаздела4.Параметры.Валюта = ВалютаПечати;
			//ТабДок.Вывести(ШапкаРаздела4);
			//СписокСобытийОС = Новый Массив();
			//СписокСобытийОС.Добавить(Перечисления.ВидыСобытийОС.ПринятиеКУчету);
			//СписокСобытийОС.Добавить(Перечисления.ВидыСобытийОС.ВнутреннееПеремещение);
			//СписокСобытийОС.Добавить(Перечисления.ВидыСобытийОС.Списание);
			//СписокСобытийОС.Добавить(Перечисления.ВидыСобытийОС.Передача);
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("СписокСобытийОС",  СписокСобытийОС);
			//Запрос.УстановитьПараметр("ОсновноеСредство", Ссылка);
			//Запрос.УстановитьПараметр("Организация",      Организация);
			//Запрос.УстановитьПараметр("Период",           ДатаСведений);
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	ПРЕДСТАВЛЕНИЕ(ВложенныйЗапрос.Событие) КАК СобытиеПредставление,
	|	ВложенныйЗапрос.Событие КАК Событие,
	|	ВложенныйЗапрос.ВидСобытияОС КАК ВидСобытияОС,
	|	ВложенныйЗапрос.СобытиеОСРегистратор КАК Регистратор,
	|	ВложенныйЗапрос.НазваниеДокумента КАК НазваниеДокумента,
	|	ВложенныйЗапрос.НомерДокумента КАК НомерДокумента,
	|	ВложенныйЗапрос.СобытиеОСПериод КАК Период,
	|	ПРЕДСТАВЛЕНИЕ(МестонахождениеОС.МОЛ) КАК МОЛПредставление,
	|	ПРЕДСТАВЛЕНИЕ(МестонахождениеОС.Местонахождение) КАК МестонахождениеПредставление
	|ИЗ
	|	(ВЫБРАТЬ
	|		СобытияОС.ОсновноеСредство КАК ОсновноеСредство,
	|		СобытияОС.Период КАК СобытиеОСПериод,
	|		СобытияОС.Регистратор КАК СобытиеОСРегистратор,
	|		СобытияОС.Событие КАК Событие,
	|		СобытияОС.Событие.ВидСобытияОС КАК ВидСобытияОС, 
	|		СобытияОС.НазваниеДокумента КАК НазваниеДокумента,
	|		СобытияОС.НомерДокумента КАК НомерДокумента,
	|		МАКСИМУМ(МестонахождениеОС.Период) КАК МестонахождениеОСПериод
	|	ИЗ
	|		РегистрСведений.СобытияОС" + ?(ПечатьПоДаннымУпрУчета, "", "Организаций") + " КАК СобытияОС
	|			ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.МестонахождениеОС" + ?(ПечатьПоДаннымУпрУчета, "", "БухгалтерскийУчет") + " КАК МестонахождениеОС
	|			ПО СобытияОС.ОсновноеСредство = МестонахождениеОС.ОсновноеСредство
	|				И СобытияОС.Период >= МестонахождениеОС.Период
	|	ГДЕ
	|		СобытияОС.ОсновноеСредство = &ОсновноеСредство
	|		И СобытияОС.Период <= &Период
	|		И СобытияОС.Событие.ВидСобытияОС В(&СписокСобытийОС)
	|		" + ?(ПечатьПоДаннымУпрУчета, "", "И СобытияОС.Организация = &Организация") + "
	|	
	|	СГРУППИРОВАТЬ ПО
	|		СобытияОС.ОсновноеСредство,
	|		СобытияОС.Период,
	|		СобытияОС.Регистратор,
	|		СобытияОС.Событие,
	|		СобытияОС.Событие.ВидСобытияОС,
	|		СобытияОС.НазваниеДокумента,
	|		СобытияОС.НомерДокумента) КАК ВложенныйЗапрос
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.МестонахождениеОС" + ?(ПечатьПоДаннымУпрУчета, "", "БухгалтерскийУчет") + " КАК МестонахождениеОС
	|		ПО ВложенныйЗапрос.ОсновноеСредство = МестонахождениеОС.ОсновноеСредство
	|			И ВложенныйЗапрос.МестонахождениеОСПериод = МестонахождениеОС.Период
	|
	|УПОРЯДОЧИТЬ ПО
	|	Период";*/
			//ВыборкаЗаписей = Запрос.Выполнить().Выбрать();
			while(true/*ВыборкаЗаписей.Следующий()*/)
			{
				/*СтрокаРаздела4.Параметры.ДатаНомерДокумента = ВыборкаЗаписей.НазваниеДокумента 
		                                            + " № " + ВыборкаЗаписей.НомерДокумента
		                                            + " от " + Формат(ВыборкаЗаписей.Период, "ДФ=dd.MM.yyyy");*/
				//СтрокаРаздела4.Параметры.ВидОперации        = ВыборкаЗаписей.СобытиеПредставление;
				//СтрокаРаздела4.Параметры.ФИОМОЛДвижения     = ВыборкаЗаписей.МОЛПредставление;
				//СтрокаРаздела4.Параметры.Подразделение      = ВыборкаЗаписей.МестонахождениеПредставление;
				/*// Остаточная стоимость ОС на момент события
*/
				//Запрос = Новый Запрос;
				//Запрос.УстановитьПараметр("ОсновноеСредство", Ссылка);
				if(true/*ВыборкаЗаписей.ВидСобытияОС = Перечисления.ВидыСобытийОС.Списание 
		 ИЛИ ВыборкаЗаписей.ВидСобытияОС = Перечисления.ВидыСобытийОС.Передача*/)
				{
					//Запрос.УстановитьПараметр("МоментСобытия", Новый МоментВремени(ВыборкаЗаписей.Период, ВыборкаЗаписей.Регистратор));
					/*Запрос.Текст =  "
			|	ВЫБРАТЬ
			|	ЕСТЬNULL(СтоимостьОС.СтоимостьРасход, 0) - ЕСТЬNULL(СтоимостьОС.АмортизацияРасход, 0) КАК ОстаточнаяСтоимость
			|ИЗ
			|	РегистрНакопления." + НазваниеРегистраСтоимость + ".Обороты(&МоментСобытия, &МоментСобытия, , ОсновноеСредство = &ОсновноеСредство) КАК СтоимостьОС
			|";*/
					//РезультатЗапроса = Запрос.Выполнить();
					if(true/*НЕ РезультатЗапроса.Пустой()*/)
					{
						//СтрокаРаздела4.Параметры.ОстаточнаяСтоимость = РезультатЗапроса.Выгрузить()[0].ОстаточнаяСтоимость;
					}
				}
				//ТабДок.Вывести(СтрокаРаздела4);
			}
			/*;	
	
	ТабДок.Вывести(ПодвалСтраницы1);*/
			/*// модернизация ос и ремонт
*/
			//ТаблицаМодернизаций = Новый ТаблицаЗначений;
			//ТаблицаМодернизаций.Колонки.Добавить("ВидОперации");
			//ТаблицаМодернизаций.Колонки.Добавить("Название");
			//ТаблицаМодернизаций.Колонки.Добавить("Дата");
			//ТаблицаМодернизаций.Колонки.Добавить("Номер");
			//ТаблицаМодернизаций.Колонки.Добавить("Сумма");
			//ТаблицаРемонтов = Новый ТаблицаЗначений;
			//ТаблицаРемонтов.Колонки.Добавить("ВидОперации");
			//ТаблицаРемонтов.Колонки.Добавить("Название");
			//ТаблицаРемонтов.Колонки.Добавить("Дата");
			//ТаблицаРемонтов.Колонки.Добавить("Номер");
			//ТаблицаРемонтов.Колонки.Добавить("Сумма");
			//ШапкаРазделов5и6.Параметры.Валюта = ВалютаПечати;
			//ТабДок.Вывести(ШапкаРазделов5и6);
			//СписокМодернизаций = Новый Массив;
			//СписокМодернизаций.Добавить(Перечисления.ВидыСобытийОС.Модернизация);
			//СписокМодернизаций.Добавить(Перечисления.ВидыСобытийОС.Достройка);
			//СписокМодернизаций.Добавить(Перечисления.ВидыСобытийОС.Реконструкция);
			//СписокМодернизаций.Добавить(Перечисления.ВидыСобытийОС.Дооборудование);
			//СписокМодернизаций.Добавить(Перечисления.ВидыСобытийОС.ЧастичнаяЛиквидация);
			//СписокРемонтов = Новый Массив;
			//СписокРемонтов.Добавить(Перечисления.ВидыСобытийОС.СреднийРемонт);
			//СписокРемонтов.Добавить(Перечисления.ВидыСобытийОС.ТекущийРемонт);
			//СписокРемонтов.Добавить(Перечисления.ВидыСобытийОС.КапитальныйРемонт);
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("ОсновноеСредство",    Ссылка);
			//Запрос.УстановитьПараметр("УсловиеМодернизаций", СписокМодернизаций);
			//Запрос.УстановитьПараметр("УсловиеРемонтов",	 СписокРемонтов);
			//Запрос.УстановитьПараметр("ВидОперацииОС",       Перечисления.ВидыСобытийОС.ПринятиеКУчету);
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	СУММА(ВЫБОР КОГДА ОперацииОС.Событие.ВидСобытияОС В (&УсловиеМодернизаций) 
	|		  ТОГДА ОперацииОС."+НазваниеСуммыЗатрат+" ИНАЧЕ 0 КОНЕЦ) КАК СуммаЗатратМодернизаций,
	|	СУММА(ВЫБОР КОГДА ОперацииОС.Событие.ВидСобытияОС В (&УсловиеРемонтов) 
	|		  ТОГДА ОперацииОС."+НазваниеСуммыЗатрат+" ИНАЧЕ 0 КОНЕЦ) КАК СуммаЗатратРемонтов,
	|	ОперацииОС.Регистратор КАК Регистратор,
	|	ОперацииОС.Период КАК Период,
	|	ОперацииОС.Событие КАК Операция,
	|	ОперацииОС.НомерДокумента КАК НомерДокумента,
	|	ОперацииОС.НазваниеДокумента КАК НазваниеДокумента
	|ИЗ
	|	РегистрСведений."+НазваниеРегистраСобытия+" КАК ОперацииОС
	|
	|ГДЕ
	|	ОперацииОС.Событие.ВидСобытияОС <> &ВидОперацииОС И
	|	ОперацииОС.ОсновноеСредство = &ОсновноеСредство
	|
	|СГРУППИРОВАТЬ ПО
	|	ОперацииОС.Период,
	|	ОперацииОС.Регистратор,
	|	ОперацииОС.Событие,
	|	ОперацииОС.НомерДокумента,
	|	ОперацииОС.НазваниеДокумента
	|
	|УПОРЯДОЧИТЬ ПО
	|	Период,
	|	Регистратор";*/
			//Результат = Запрос.Выполнить();
			//СпособВыборки = ОбходРезультатаЗапроса.ПоГруппировкам;
			//ВыборкаРегистраторов = Результат.Выбрать(СпособВыборки);
			/*// все ремонты, модернизации и т.д. произведенные документом модернизация размещаем в 5 разделе
*/
			/*// до тех пор, пока не доказано обратное 
*/
			/*// все действия проведенные документом модернизация
*/
			/*// могут влиять на первоначальную стоимость и таким образом должны отражаться в 5 разделе
*/
			while(true/*ВыборкаРегистраторов.Следующий()*/)
			{
				//СуммаМодернизаций = ?(ВыборкаРегистраторов.СуммаЗатратМодернизаций = NULL, 0, ВыборкаРегистраторов.СуммаЗатратМодернизаций);
				//СуммаРемонтов = ?(ВыборкаРегистраторов.СуммаЗатратРемонтов = NULL, 0, ВыборкаРегистраторов.СуммаЗатратРемонтов);
				if(true/*СуммаМодернизаций+СуммаРемонтов<> 0*/)
				{
					//СтрокаТаблицыМодернизаций = ТаблицаМодернизаций.Добавить();
					//СтрокаТаблицыМодернизаций.ВидОперации = ВыборкаРегистраторов.Операция;
					//СтрокаТаблицыМодернизаций.Название    = ВыборкаРегистраторов.НазваниеДокумента;
					//СтрокаТаблицыМодернизаций.Номер       = ВыборкаРегистраторов.НомерДокумента;
					//СтрокаТаблицыМодернизаций.Дата        = ВыборкаРегистраторов.Период;
					//СтрокаТаблицыМодернизаций.Сумма       = СуммаМодернизаций + СуммаРемонтов;
				}
				/*//Если СуммаРемонтов <> 0 Тогда		
*/
				/*//	СтрокаТаблицыРемонтов = ТаблицаРемонтов.Добавить();
*/
				/*//	СтрокаТаблицыРемонтов.ВидОперации = ВыборкаРегистраторов.Операция;
*/
				/*//	СтрокаТаблицыРемонтов.Название    = ВыборкаРегистраторов.НазваниеДокумента;
*/
				/*//	СтрокаТаблицыРемонтов.Номер       = ВыборкаРегистраторов.НомерДокумента;
*/
				/*//	СтрокаТаблицыРемонтов.Дата        = ВыборкаРегистраторов.Период;
*/
				/*//	СтрокаТаблицыРемонтов.Сумма       = СуммаРемонтов;
*/
				/*//КонецЕсли;
*/
			}
			/*;
	
	КоличествоСтрок = Макс(ТаблицаМодернизаций.Количество(),ТаблицаРемонтов.Количество());*/
			//ТабДок.Вывести(ШапкаРаздела7_1);
			//ТабДок.Вывести(ШапкаРаздела7_2);
			//ТабДок.Вывести(ПодвалСтраницы2);
			//ТабДок.ИмяПараметровПечати = "ПараметрыПечати_ОС6_2003";
			//ТабДок.АвтоМасштаб = Истина;
			//ТабДок.ОриентацияСтраницы = ОриентацияСтраницы.Портрет;
			//ТабДок.ПолеСверху = 0;
			//ТабДок.ПолеСнизу = 0;
			return null;
		}
		// ПечатьОС6_2003()
		////////////////////////////////////////////////////////////////////////////////
		// ЭКСПОРТНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Процедура осуществляет печать справочника. Можно направить печать на
		// экран или принтер, а также распечатать необходимое количество копий.
		//
		//  Название макета печати передается в качестве параметра,
		// по переданному названию находим имя макета в соответствии.
		// Параметры:
		//  НазваниеМакета - строка, название макета.
		// Возвращаемое значение:
		//  Нет.
		//

		public void Печать(/*ИмяМакета, КоличествоЭкземпляров = 1, НаПринтер = Ложь, ФормаЭлемента = Неопределено*/)
		{
			//ДатаСведений = ?(мДатаСведений = Неопределено, КонецДня(ОбщегоНазначения.ПолучитьРабочуюДату()), мДатаСведений);
			/*// Получить экземпляр документа на печать
*/
			if(true/*ИмяМакета = "ОС6_2003упр"*/)
			{
				//ТабДокумент = ПечатьОС6_2003(ДатаСведений);
			}
			//УниверсальныеМеханизмы.НапечататьДокумент(ТабДокумент, КоличествоЭкземпляров, НаПринтер, "Инвентарная карточка ОС (Форма ОС-6)", Ссылка);
		}
		// Печать()
		// Возвращает доступные варианты печати документа
		//
		// Возвращаемое значение:
		//  Структура, каждая строка которой соответствует одному из вариантов печати
		//

		public object ПолучитьСтруктуруПечатныхФорм(/**/)
		{
			return null;
		}
		// ПолучитьТаблицуПечатныхФорм()
	}
}