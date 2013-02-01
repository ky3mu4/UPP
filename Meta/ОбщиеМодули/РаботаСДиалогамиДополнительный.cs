﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РаботаСДиалогамиДополнительный
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ МЕХАНИЗМА ОСТАТКОВ ОТПУСКОВ

		public object ГрафикОтпусков_ЦветПлана(/**/)
		{
			return null;
		}

		public object ГрафикОтпусков_ЦветПланаНеУтвержденного(/**/)
		{
			return null;
		}

		public object ГрафикОтпусков_ЦветФакта(/**/)
		{
			return null;
		}

		public object ГрафикОтпусков_ЦветМероприятий(/**/)
		{
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПОДГОТОВКИ ИНФОРМАЦИИ В ФОРМЕ
		// Процедура возвращает паспортные данные физлица в виде строки
		//
		// Параметры:
		//  Валюта                         - Валюта, курс которой необходимо отобразить
		//  Курс                           - курс, которой необходимо отобразить
		//  Кратность                      - кратность, которую необходимо отобразить
		//  ВалютаРегламентированногоУчета - валюта регламентированного учета
		//  СформироватьСкобки             - признак необходимости скобок
		//
		// Возвращаемое значение:
		//  Строка с данными о курсе и кратности валюты
		//

		public object ПолучитьИнформациюКурсаВалютыСтрокой(/*Валюта, Курс, Кратность, ВалютаРегламентированногоУчета, СформироватьСкобки = Ложь*/)
		{
			if(true/*Не ЗначениеЗаполнено(Валюта)*/)
			{
			}
			return null;
		}
		// ПолучитьИнформациюКурсаВалютыСтрокой()
		// Формирует представление переданного способа отражения с "предметной" точки зрения
		//
		// Параметры
		//  СпособОтраженияВБухучете - СправочникСсылка.СпособыОтраженияЗарплатыВРеглУчете - описываемый
		//                 способ отражения
		//  НетБазовыхРасчетов - булево - указывает на наличие/отсутствие у в.р. расчетной базы
		//
		// Возвращаемое значение:
		//   строка - сформированное представление
		//

		public object ПолучитьПредставлениеСпособаОтраженияНачисленияВУчетах(/*СпособОтраженияВБухучете, НетБазовыхРасчетов*/)
		{
			if(true/*СпособОтраженияВБухучете.Пустая()*/)
			{
				//РасшифровкаТекст = "Способ отражения определяется по данным о работнике и его плановых начислениях";
			}
			return null;
		}
		// ПолучитьПредставлениеСпособаОтраженияНачисленияВУчетах()

		public object РасшифровкаЕжегодныйОтпускДляРезервов(/*ЕжегодныйОтпускДляРезервов*/)
		{
			//РасшифровкаТекст = "";
			if(true/*ЕжегодныйОтпускДляРезервов*/)
			{
				//РасшифровкаТекст = "Если в организации формируются оценочные обязательства и указано оценочное обязательство по ежегодным отпускам, это начисление будет отражаться в учете по дебету счета 96";
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ОФОРМЛЕНИЯ ФОРМЫ

		public void УстановитьВидимостьПереключателяВидаУчета(/*Форма*/)
		{
			//ИспользоватьУправленческийУчетЗарплаты = глЗначениеПеременной("глИспользоватьУправленческийУчетЗарплаты");
			//Форма.ЭлементыФормы.ВидУчета.Видимость = ИспользоватьУправленческийУчетЗарплаты;
		}

		public void УстановитьВидимостьКолонкиУпрУчета(/*Список*/)
		{
			//ИспользоватьУправленческийУчетЗарплаты = глЗначениеПеременной("глИспользоватьУправленческийУчетЗарплаты");
			//Список.Колонки.ОтражатьВУправленческомУчете.Видимость	= ИспользоватьУправленческийУчетЗарплаты;
			//Список.Колонки.ОтражатьВБухгалтерскомУчете.Видимость	= ИспользоватьУправленческийУчетЗарплаты;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ФОРМИРОВАНИЯ И ОБРАБОТКИ МЕНЮ
		// Процедура установки типа и доступности субконто в зависимости от  выбранного счета
		//
		//     Параметры:
		//          Счет - выбранный счет
		//          Форма - форма(или табличное поле) на которой расположены счет и субконто
		//          Префикс - префекс наименования субконто. к префиксу добавляется номер субконто на счете
		//                    для подписи с наименованием субконто предполагается имя
		//                    вида "Надпись" + Префикс + НомерСубконто
		//                    в случае если форма - это таб.поле, то надписи не устанавливаются
		//

		public void ПриВыбореСчета(/*Счет, Субконто1, НадписьСубконто1, Субконто2, НадписьСубконто2, Субконто3, НадписьСубконто3, ПолеСчет = НЕОПРЕДЕЛЕНО, ТолькоПросмотр = ЛОЖЬ*/)
		{
			//ЭлементыСубконто = Новый Структура("Субконто1,НадписьСубконто1,Субконто2,НадписьСубконто2,Субконто3,НадписьСубконто3", Субконто1, НадписьСубконто1, Субконто2, НадписьСубконто2, Субконто3, НадписьСубконто3);
			//ЧислоАктивныхСубконто = Счет.ВидыСубконто.Количество();
			if(true/*ПолеСчет <> НЕОПРЕДЕЛЕНО*/)
			{
				//ПолеСчет.ТолькоПросмотр = ТолькоПросмотр;
			}
		}
		// ПриВыбореСчета()
		// Процедура инициирует диалог выбора времени.
		//
		// Параметры
		//  Форма - Форма, в которой производится выбор
		//  ДатаВремен - дата для выбора времени
		//  ТекЭлемент - элемент формы
		//  ПолныйГод - булево, показывать год 4-мя цифрами или 2-мя
		//
		// Возвращаемое значение:
		//  НЕТ
		//

		public void ВыбратьВремяДня(/*Форма, ДатаВремен, ТекЭлемент, Пользователь, ПоГрафику = Истина, ПолныйГод = Истина, ВыбиратьТолькоВремя = Ложь, ДатаНачала = Неопределено*/)
		{
			//ДлинаЧаса = 3600;
			if(true/*ПоГрафику*/)
			{
				//СтруктураРабочегоВремени = УправлениеКонтактами.ОпределитьНачалоИОкончаниеРабочегоДняПользователя(Пользователь, ДатаВремен);
				//НачалоРабочегоДняКонстанта    = СтруктураРабочегоВремени.ДатаНачала;
				//ОкончаниеРабочегоДняКонстанта = СтруктураРабочегоВремени.ДатаОкончания;
			}
			//СписокВремен = Новый СписокЗначений;
			//НачалоРабочегоДня = НачалоЧаса(НачалоДня(ДатаВремен) + Час(НачалоРабочегоДняКонстанта) * ДлинаЧаса + Минута(НачалоРабочегоДняКонстанта)*60);
			//ОкончаниеРабочегоДня = КонецЧаса(НачалоДня(ДатаВремен) + Час(ОкончаниеРабочегоДняКонстанта) * ДлинаЧаса + Минута(ОкончаниеРабочегоДняКонстанта)*60) - ДлинаЧаса;
			/*// Если в процедуру дата начала не передана, список начнется с даты начала рабочего дня
*/
			/*// В противном случае, необходимо взять из даты начала время, а саму дату взять из ДатаВремен
*/
			//ВремяНачала = ?(ДатаНачала = Неопределено, НачалоРабочегоДня, НачалоДня(ДатаВремен) + (ДатаНачала - НачалоДня(ДатаНачала)));
			//ВремяСписка = ВремяНачала;
			while(true/*НачалоЧаса(ВремяСписка) <= НачалоЧаса(ОкончаниеРабочегоДня)*/)
			{
				if(true/*НЕ ЗначениеЗаполнено(ВремяСписка) И ВыбиратьТолькоВремя*/)
				{
					//ПредставлениеВремени = "00:00";
				}
				if(true/*ЗначениеЗаполнено(ДатаНачала)*/)
				{
					//РазностьДат = (ВремяСписка - ВремяНачала) / ДлинаЧаса;
					if(true/*РазностьДат = 0*/)
					{
						//ПредставлениеВремени = ПредставлениеВремени + " (0 мин.)";
					}
				}
				//СписокВремен.Добавить(ВремяСписка, ПредставлениеВремени);
				//ВремяСписка = ВремяСписка + ДлинаЧаса / 2;
				/*// по полчаса
*/
			}
			/*;

	НачальноеЗначение = СписокВремен.НайтиПоЗначению(ДатаВремен);*/
			if(true/*НачальноеЗначение = Неопределено*/)
			{
				//ВыбранноеВремя = Форма.ВыбратьИзСписка(СписокВремен, ТекЭлемент);
			}
			if(true/*ВыбранноеВремя <> Неопределено*/)
			{
				//ДатаВремен = ВыбранноеВремя.Значение;
			}
		}
		// ВыбратьВремя()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ОБРАБОТКИ КОМАНД ГЛАВНОГО МЕНЮ И РАБОЧЕГО СТОЛА

		public void ПереключитьПолныйИнтерфейс(/**/)
		{
			//ИспользоватьУправленческийУчетЗарплаты = глЗначениеПеременной("глИспользоватьУправленческийУчетЗарплаты");
			if(true/*ИспользоватьУправленческийУчетЗарплаты*/)
			{
				//ГлавныйИнтерфейс.ПереключитьИнтерфейс("Полный");
			}
		}

		public void ПоказатьВариантыАлгоритмовРасчета(/**/)
		{
			//ПроцедурыУправленияПерсоналом.ОткрытьФормуНастройкаПараметровУчета("АлгоритмыРасчетов");
		}
		// Открытие кассовых и банковских документов с отбором по операциям функциональности ЗУП

		public object УстановитьФормуДокументаСОтбором(/*ЭлементИмя*/)
		{
			//ИмяОбъектаМетаданных = РабочийСтол.ОтсечьЦифры(ЭлементИмя);
			//Форма = Документы[ИмяОбъектаМетаданных].ПолучитьФормуСписка();
			//Форма.Отбор.ВидОперации.Использование = Истина;
			//Форма.Отбор.ВидОперации.ВидСравнения = ВидСравнения.ВСписке;
			//СписокЗначенийОтбора = Новый СписокЗначений;
			if(true/*ИмяОбъектаМетаданных = "РасходныйКассовыйОрдер"*/)
			{
				//СписокЗначенийОтбора.Добавить(Перечисления.ВидыОперацийРКО.ВыплатаЗаработнойПлатыПоВедомостям);
				//СписокЗначенийОтбора.Добавить(Перечисления.ВидыОперацийРКО.ВыплатаЗаработнойПлатыРаботнику);
				//СписокЗначенийОтбора.Добавить(Перечисления.ВидыОперацийРКО.ВыплатаДепонентов);
			}
			//Форма.Отбор.ВидОперации.Значение = СписокЗначенийОтбора;
			return null;
		}
		// Регл учет

		public void РКОРеглОткрытьСписокДокументов(/**/)
		{
			//ОткрытьКассовыйДокументРеглУчете("РасходныйКассовыйОрдер");
		}
		// РКОРеглОткрытьСписокДокументов()

		public void ПКОРеглОткрытьСписокДокументов(/**/)
		{
			//ОткрытьКассовыйДокументРеглУчете("ПриходныйКассовыйОрдер");
		}
		// ПКОРеглОткрытьСписокДокументов()

		public void ПлатежноеПоручениеИсходящееОткрытьСписокДокументов(/**/)
		{
			//ОткрытьДокументПоБанку("ПлатежноеПоручениеИсходящее");
		}
		// ПлатежноеПоручениеИсходящееОткрытьСписокДокументов()

		public void ПлатежныйОрдерСписаниеДенежныхСредствОткрытьСписокДокументов(/**/)
		{
			//ОткрытьДокументПоБанку("ПлатежныйОрдерСписаниеДенежныхСредств");
		}
		// ПлатежныйОрдерСписаниеДенежныхСредствОткрытьСписокДокументов()

		public void ОткрытьКассовыйДокументРеглУчете(/*ЭлементИмя*/)
		{
			/*Экспорт
	
	Форма = УстановитьФормуДокументаСОтбором(ЭлементИмя);*/
			//Форма.Отбор.ОтражатьВБухгалтерскомУчете.Установить(Истина);
			//Форма.Открыть();
		}
		// ОткрытьКассовыйДокументРеглУчете()
		// Упр учет

		public void РКОУпрОткрытьСписокДокументов(/**/)
		{
			//ОткрытьКассовыйДокументУпрУчете("РасходныйКассовыйОрдер");
		}
		// РКОУпрОткрытьСписокДокументов()

		public void ПКОУпрОткрытьСписокДокументов(/**/)
		{
			//ОткрытьКассовыйДокументУпрУчете("ПриходныйКассовыйОрдер");
		}
		// ПКОУпрОткрытьСписокДокументов()

		public void ОткрытьКассовыйДокументУпрУчете(/*ЭлементИмя*/)
		{
			//Форма = УстановитьФормуДокументаСОтбором(ЭлементИмя);
			//Форма.Отбор.ОтражатьВУправленческомУчете.Установить(Истина);
			//Форма.Открыть();
		}
		// ОткрытьКассовыйДокументУпрУчете()

		public void ОткрытьДокументПоБанку(/*ЭлементИмя*/)
		{
			/*Экспорт
	
	Форма = УстановитьФормуДокументаСОтбором(ЭлементИмя);*/
			//Форма.Открыть();
		}
		// ОткрытьДокументПоБанку()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ УПРАВЛЕНИЯ СПИСКАМИ ЖУРНАЛОВ ДОКУМЕНТОВ

		public void УстановитьРежимРаботыЖурналаУправленческихДокументов(/*Форма, ЖурналДокументов*/)
		{
			//ВосстановленноеЗначение = ВосстановитьЗначение(Метаданные.НайтиПоТипу(Тип(ЖурналДокументов)).Имя + "ПоказыватьПоОрганизациям");
			//ПоказыватьПоОрганизациям = ?(ВосстановленноеЗначение = Неопределено, Истина, ВосстановленноеЗначение);
			//Форма.ПоказыватьПоОрганизациям = ПоказыватьПоОрганизациям;
			/*// колонка Организация есть во всех журналах
*/
			//Форма.ВидимостьРегламентированныхКолонок.Вставить("Организация");
			//УстановитьОтборПоУправленческимДокументам(Форма, ЖурналДокументов);
		}

		public void СохранитьРежимРаботыЖурналаУправленческихДокументов(/*Форма, ЖурналДокументов*/)
		{
			//СохранитьЗначение(Метаданные.НайтиПоТипу(Тип(ЖурналДокументов)).Имя + "ПоказыватьПоОрганизациям", Форма.ПоказыватьПоОрганизациям);
		}

		public void УстановитьОтборПоУправленческимДокументам(/*Форма, ЖурналДокументовСписок*/)
		{
			//ПоказыватьПоОрганизациям  = Форма.ПоказыватьПоОрганизациям;
			if(true/*НЕ ПоказыватьПоОрганизациям*/)
			{
				/*// определяем список ответственных из управленческих документов
*/
				//Запрос = Новый Запрос;
				/*Запрос.Текст = 
		"ВЫБРАТЬ РАЗРЕШЕННЫЕ РАЗЛИЧНЫЕ
		|	ДокументыЖурнала.УпрОтветственный
		|ИЗ
		|	ЖурналДокументов." + Метаданные.НайтиПоТипу(Тип(ЖурналДокументовСписок)).Имя + " КАК ДокументыЖурнала";*/
				//Выборка = Запрос.Выполнить().Выбрать();
				//ПолныйСписокУпрОтветственных = Новый СписокЗначений;
				while(true/*Выборка.Следующий()*/)
				{
					//ПолныйСписокУпрОтветственных.Добавить(Выборка.УпрОтветственный);
				}
				/*// устанавливаем отбор по списку ответственных
*/
				//ЖурналДокументовСписок.Отбор.УпрОтветственный.ВидСравнения 	= ВидСравнения.ВСписке;
				//ЖурналДокументовСписок.Отбор.УпрОтветственный.Значение 		= ПолныйСписокУпрОтветственных;
				//ЖурналДокументовСписок.Отбор.УпрОтветственный.Использование = Истина;
			}
			/*// определяем видимость регламентированных колонок
*/
			/*// устанавливаем пометку на кнопке
*/
			//Форма.ЭлементыФормы.ДействияФормы.Кнопки.ПоказыватьПоОрганизациям.Пометка = ПоказыватьПоОрганизациям;
		}
		// Процедура "расширяет" значение отбора значением из вновь записанного документа
		//

		public void ПересмотретьОтборУправленческихДокументов(/*ЖурналДокументов, Ответственный, ДокументСсылка*/)
		{
			if(true/*Метаданные.НайтиПоТипу(Тип(ЖурналДокументов)).РегистрируемыеДокументы.Содержит(ДокументСсылка.Метаданные())*/)
			{
				//СписокУпрОтветственных = ЖурналДокументов.Отбор.УпрОтветственный.Значение;
				if(true/*СписокУпрОтветственных.НайтиПоЗначению(Ответственный) = Неопределено*/)
				{
					//ЖурналДокументов.Отбор.УпрОтветственный.Использование = Ложь;
					//СписокУпрОтветственных.Добавить(Ответственный);
					//ЖурналДокументов.Отбор.УпрОтветственный.Значение = СписокУпрОтветственных;
					//ЖурналДокументов.Отбор.УпрОтветственный.Использование = Истина;
				}
			}
		}

		public void УстановитьОтборСпискаДокументаСуществующегоВДвухУчетах(/*Форма*/)
		{
			//ПараметрТекущаяСтрока = Форма.ПараметрТекущаяСтрока;
			if(true/*ПараметрТекущаяСтрока <> Неопределено И ОбщегоНазначения.ПолучитьЗначениеРеквизита(ПараметрТекущаяСтрока, "ОтражатьВУправленческомУчете")*/)
			{
				/*// список открывается "по просьбе" управленческого документа, отбор по организации не нужен
*/
				//ЭлементыФормы = Форма.ЭлементыФормы;
				//ЭлементыФормы.ДокументСписок.Колонки.Организация.Видимость = Ложь;
				//ЭлементыФормы.ПанельОтборПоОрганизации.Свертка = РежимСверткиЭлементаУправления.Верх;
				//Форма.ДокументСписок.Отбор.ОтражатьВУправленческомУчете.Установить(Истина);
			}
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедура устанавливает видимость реквизитов в зависимости от типа учета
		//
		//		Параметры:
		//
		//

		public void ВидимостьРеквизитовПоТипуУчета(/*ДокументОбъект, ФормаДокумента, Знач РеквизитыУпрУчета, Знач РеквизитыБухУчета, Знач РеквизитыНалУчета = ""*/)
		{
			//СтрРеквУпр = СтрЗаменить(РеквизитыУпрУчета, " ", "");
			//СтрРеквУпр = СтрЗаменить(СтрРеквУпр, Символы.ПС,  "");
			//СтрРеквУпр = СтрЗаменить(СтрРеквУпр, Символы.Таб, "");
			while(true/*Не ПустаяСтрока(СтрРеквУпр)*/)
			{
				//Поз = Найти(СтрРеквУпр, ",");
				if(true/*Поз = 0*/)
				{
					//ИмяРекв    = СтрРеквУпр;
					//СтрРеквУпр = "";
				}
				if(true/*ПустаяСтрока(ИмяРекв)*/)
				{
					//Продолжить;
				}
				//Поз = Найти(ИмяРекв, ".");
				if(true/*Поз = 0*/)
				{
					//ФормаДокумента.ЭлементыФормы[ИмяРекв].Видимость = ДокументОбъект.ОтражатьВУправленческомУчете;
				}
			}
			/*;
	
	СтрРеквБух = СтрЗаменить(РеквизитыБухУчета, " ", "");*/
			//СтрРеквБух = СтрЗаменить(СтрРеквБух, Символы.ПС,  "");
			//СтрРеквБух = СтрЗаменить(СтрРеквБух, Символы.Таб, "");
			while(true/*Не ПустаяСтрока(СтрРеквБух)*/)
			{
				//Поз = Найти(СтрРеквБух, ",");
				if(true/*Поз = 0*/)
				{
					//ИмяРекв    = СтрРеквБух;
					//СтрРеквБух = "";
				}
				if(true/*ПустаяСтрока(ИмяРекв)*/)
				{
					//Продолжить;
				}
				//Поз = Найти(ИмяРекв, ".");
				if(true/*Поз = 0*/)
				{
					//ФормаДокумента.ЭлементыФормы[ИмяРекв].Видимость = ДокументОбъект.ОтражатьВБухгалтерскомУчете;
				}
			}
			/*;
	
	СтрРеквНал = СтрЗаменить(РеквизитыНалУчета, " ", "");*/
			//СтрРеквНал = СтрЗаменить(СтрРеквНал, Символы.ПС,  "");
			//СтрРеквНал = СтрЗаменить(СтрРеквНал, Символы.Таб, "");
			while(true/*Не ПустаяСтрока(СтрРеквНал)*/)
			{
				//Поз = Найти(СтрРеквНал, ",");
				if(true/*Поз = 0*/)
				{
					//ИмяРекв    = СтрРеквНал;
					//СтрРеквНал = "";
				}
				if(true/*ПустаяСтрока(ИмяРекв)*/)
				{
					//Продолжить;
				}
				//Поз = Найти(ИмяРекв, ".");
				if(true/*Поз = 0*/)
				{
					//ФормаДокумента.ЭлементыФормы[ИмяРекв].Видимость = ДокументОбъект.ОтражатьВНалоговомУчете;
				}
			}
			//;;
		}
		// ВидимостьРеквизитовПоТипуУчета()
		// Формирует представление переданного способа отражения с "предметной" точки зрения
		//
		// Параметры
		//  СпособОтраженияВУпручете -	СправочникСсылка.СпособыОтраженияЗарплатыВУпрУчете - описываемый
		//								способ отражения
		//
		// Возвращаемое значение:
		//   строка - сформированное представление
		//

		public object ПолучитьПредставлениеСпособаОтраженияНачисленияВУпрУчете(/*СпособОтраженияВУпручете*/)
		{
			if(true/*СпособОтраженияВУпручете.Пустая()*/)
			{
				//РасшифровкаТекст = "Способ отражения определяется по данным о работнике и его плановых начислениях";
			}
			return null;
		}
		// ПолучитьПредставлениеСпособаОтраженияНачисленияВУчетах()
		// Функция определеяте, по статье затрат, относится способ отражения к ЕНВД или нет
		//
		// Параметры
		//  <СпособОтраженияВБухучете>  – <СправочникСсылка.СпособыОтраженияЗарплатыВРеглУчете> – способ отражения который проверяем
		// Возвращаемое значение:
		//   Истина   – когда статья затрат относится к ЕНВД
		//   Ложь     - когда статья затрат не относится у ЕНВД
		//   Неопределено - когда способ отражения не содержит субконто - Статьи затрат
		//   NULL     - когда у способа отражения пустой счет Дт или Кт
		//

		public object СтатьяЗатратСпособаОтраженияОтноситсяКЕНВД(/*СпособОтраженияВБухучете*/)
		{
			//Запрос = Новый Запрос;
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	ВЫБОР
	|		КОГДА СчетаУчетаПоДеятельностиЕНВД.Счет ЕСТЬ NULL 
	|			ТОГДА ЛОЖЬ
	|		ИНАЧЕ ИСТИНА
	|	КОНЕЦ КАК ЭтоЕНВД
	|ИЗ
	|	Справочник.СпособыОтраженияЗарплатыВРеглУчете КАК СпособыОтраженияЗарплатыВРеглУчете
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СчетаУчетаПоДеятельностиЕНВД КАК СчетаУчетаПоДеятельностиЕНВД
	|		ПО СпособыОтраженияЗарплатыВРеглУчете.СчетДт = СчетаУчетаПоДеятельностиЕНВД.Счет
	|ГДЕ
	|	СпособыОтраженияЗарплатыВРеглУчете.Ссылка = &Ссылка";*/
			//Запрос.УстановитьПараметр("Ссылка",СпособОтраженияВБухучете);
			//Запрос.Текст = ТекстЗапроса;
			//ВыборкаИзЗапроса = Запрос.Выполнить().Выбрать();
			//ВыборкаИзЗапроса.Следующий();
			return null;
		}
		// ПроверитьСтатьюЗатаратСпособаОтражения()
		////////////////////////////////////////////////////////////////////////////////
		// управление доступностью ввода на основании в документе Планирование отпуска

		public void УстановитьДоступностьВводаНаОснованииДокументаПланированиеОтпуска(/*ЭлементыФормы*/)
		{
			//ДоступностьКоманд = Новый Соответствие;
			//ДоступностьКоманд.Вставить("ГрафикОтпусковОрганизацийВводНаОсновании", ПравоДоступа("Использование", Метаданные.Обработки.ВводРегламентированныхКадровыхДокументовНаОсновании));
			//ДоступностьКоманд.Вставить("ОтсутствиеНаРабочемМесте", ПравоДоступа("ИнтерактивноеДобавление", Метаданные.Документы.ОтсутствияНаРабочемМесте));
			//КоллекцииКнопок = Новый Массив;
			//КоллекцииКнопок.Добавить(ЭлементыФормы.ДействияФормы.Кнопки.ПодменюВводНаОсновании.Кнопки);
			//КоллекцииКнопок.Добавить(ЭлементыФормы.ДействияФормы.Кнопки.ПодменюДействия.Кнопки.ПодменюВводНаОсновании.Кнопки);
		}
	}
}

