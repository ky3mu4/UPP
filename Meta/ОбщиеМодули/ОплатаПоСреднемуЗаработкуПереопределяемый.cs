﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ОплатаПоСреднемуЗаработкуПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// ВСПОМОГАТЕЛЬНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public void ВыполнитьПрочиеДвиженияДокумента(/*ДокументОбъект, ВыборкаПоШапкеДокумента, Отказ, Заголовок, ВыборкаПоНачислениям = Неопределено*/)
		{
			if(true/*НЕ Отказ*/)
			{
				//Движения = ДокументОбъект.Движения;
				//ВыборкаПоНачислениям.Сбросить();
				while(true/*ВыборкаПоНачислениям.Следующий()*/)
				{
					if(true/*ЗначениеЗаполнено(ВыборкаПоНачислениям.КодДоходаНДФЛ)*/)
					{
						//Движение = Движения.НДФЛСведенияОДоходах.Добавить();
						//ЗаполнитьЗначенияСвойств(Движение,ВыборкаПоШапкеДокумента);
						/*// Организация, ФизЛицо,  ПериодРегистрации, ОбособленноеПодразделение
*/
						//ЗаполнитьЗначенияСвойств(Движение,ВыборкаПоНачислениям);
						/*//ПодразделениеОрганизации, ВидРасчета
*/
						/*// Свойства
*/
						//Движение.Период					= ВыборкаПоНачислениям.МесяцНалоговогоПериода;
						/*// Измерения
*/
						//Движение.КодДохода				= ВыборкаПоНачислениям.КодДоходаНДФЛ;
						/*// Ресурсы
*/
						//Движение.СуммаДохода			= ВыборкаПоНачислениям.Результат;
						/*// Реквизиты
*/
						//Движение.ИсчисленоИзЗарплаты	= Истина;
					}
					if(true/*Не ВыборкаПоНачислениям.ЯвляетсяДоходомВНатуральнойФорме*/)
					{
						//Движение = Движения.ВзаиморасчетыСРаботникамиОрганизаций.Добавить();
						/*// Свойства
*/
						//Движение.Период					= КонецМесяца(ВыборкаПоШапкеДокумента.ПериодРегистрации);
						//Движение.ВидДвижения			= ВидДвиженияНакопления.Приход;
						/*// Измерения
*/
						//Движение.Организация			= ВыборкаПоШапкеДокумента.ОбособленноеПодразделение;
						//Движение.ФизЛицо				= ВыборкаПоШапкеДокумента.ФизЛицо;
						//Движение.ПериодВзаиморасчетов	= ВыборкаПоШапкеДокумента.ПериодРегистрации;
						/*// Ресурсы
*/
						//Движение.СуммаВзаиморасчетов	= ВыборкаПоНачислениям.Результат;
					}
				}
				//;;
			}
		}

		public void ВыполнитьДополнительныеПроверкиСтрокиНачислений(/*ДокументОбъект,ВыборкаПоСтрокамДокумента,Отказ, Заголовок, СтрокаНачалаСообщенияОбОшибке*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void ПереписатьПрочиеДвиженияПриПерерасчете(/*ДокументОбъект, ВыборкаПоШапкеДокумента*/)
		{
			//ДокументОбъект.Движения.НДФЛСведенияОДоходах.Очистить();
			//ДокументОбъект.Движения.ВзаиморасчетыСРаботникамиОрганизаций.Очистить();
			//ДокументОбъект.Движения.ФактическиеОтпускаОрганизаций.Очистить();
			//ДокументОбъект.Движения.ВнутрисменноеВремяРаботниковОрганизаций.Очистить();
			//ВыборкаПоНачислениям = ДокументОбъект.СформироватьЗапросПоНачислениям(ВыборкаПоШапкеДокумента).Выбрать();
			while(true/*ВыборкаПоНачислениям.Следующий()*/)
			{
				//ОплатаПоСреднемуЗаработкуДополнительный.ДобавитьСтрокуВДвиженияПоРегистрамНакопления(ДокументОбъект, ВыборкаПоШапкеДокумента, ВыборкаПоНачислениям);
				if(true/*ВыборкаПоНачислениям.ЯвляетсяПочасовымОтклонением*/)
				{
					//ДокументОбъект.ДобавитьСтрокуРабочегоВремени(ВыборкаПоШапкеДокумента, ВыборкаПоНачислениям, ДокументОбъект.Движения.ВнутрисменноеВремяРаботниковОрганизаций);
				}
			}
			/*// записываем обновленные движения
*/
		}

		public object ПолучитьДополнительноеПолеЗапросаПоНачислениям(/**/)
		{
			return null;
		}

		public object ПолучитьСтруктуруРегламентированныхФорм(/*ДокументОбъект*/)
		{
			//СтруктураПечатныхФорм = Новый Структура;
			return null;
		}
		// ПолучитьСтруктуруПечатныхФорм()

		public object РасчетСреднегоЗаработка(/*ДокументОбъект, ИспользоватьСреднеЧасовойЗаработок, ПериодРасчетаСреднегоЗаработка, Начало, Окончание*/)
		{
			//ТаблицаСреднего = ДокументОбъект.РасчетСреднего;
			if(true/*ТаблицаСреднего.Количество() = 0*/)
			{
			}
			//Запрос = Новый Запрос;
			//Запрос.МенеджерВременныхТаблиц = Новый МенеджерВременныхТаблиц;
			//ОсновнойЗаработок = Новый Массив(2);
			//ОсновнойЗаработок[0] = ПланыВидовРасчета.СреднийЗаработок.ПоЗаработку;
			//ОсновнойЗаработок[1] = ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуИндексируемые;
			//ПоФиксПремиям = Новый Массив(1);
			//ПоФиксПремиям[0] = ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиям;
			//ПоПремиям = Новый Массив(3);
			//ПоПремиям[0] = ПланыВидовРасчета.СреднийЗаработок.ПоПремиям;
			//ПоПремиям[1] = ПланыВидовРасчета.СреднийЗаработок.ПоПремиямИндексируемые;
			//ПоПремиям[2] = ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииИндексируемые;
			//ПоФиксПремиямНеИндексируемые = Новый Массив(3);
			//ПоФиксПремиямНеИндексируемые[0] = ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремии;
			//ПоФиксПремиямНеИндексируемые[1] = ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремииНеИндексируемые;
			//ПоФиксПремиямНеИндексируемые[2] = ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиямНеИндексируемые;
			//Запрос.УстановитьПараметр("ОсновнойЗаработок",				ОсновнойЗаработок);
			/*// Основной заработок индексируемый
*/
			//Запрос.УстановитьПараметр("ОсновнойЗаработокНеиндексируемый", ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуНеИндексируемые);
			//Запрос.УстановитьПараметр("ПоПремиям",						ПоПремиям);
			/*// Премии полностью учитываемые, индексируемые
*/
			//Запрос.УстановитьПараметр("ПоФиксПремиям",					ПоФиксПремиям);
			/*// Премии учитываемые частично, индексируемые
*/
			//Запрос.УстановитьПараметр("ПоФиксПремиямНеИндексируемые",	ПоФиксПремиямНеИндексируемые);
			/*// Премии учитываемые частично, не индексируемые
*/
			//Запрос.УстановитьПараметр("ТаблицаСреднего",				ТаблицаСреднего);
			//Запрос.УстановитьПараметр("ПериодРасчетаСреднегоЗаработка",	ПериодРасчетаСреднегоЗаработка);
			//Запрос.УстановитьПараметр("Начало",							Начало);
			//Запрос.УстановитьПараметр("Окончание",						КонецДня(Окончание));
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	РасчетСреднегоЗаработка.ВидРасчета,
	|	РасчетСреднегоЗаработка.Результат,
	|	РасчетСреднегоЗаработка.ОтработаноДней,
	|	РасчетСреднегоЗаработка.ОтработаноЧасов,
	|	РасчетСреднегоЗаработка.НормаПоПятидневке,
	|	РасчетСреднегоЗаработка.ОтработаноПоПятидневке,
	|	РасчетСреднегоЗаработка.ЧислоМесяцев,
	|	РасчетСреднегоЗаработка.КоэффициентИндексации,
	|	РасчетСреднегоЗаработка.БазовыйПериодНачало,
	|	РасчетСреднегоЗаработка.БазовыйПериодКонец
	|ПОМЕСТИТЬ ВТРасчетСреднегоЗаработка
	|ИЗ
	|	&ТаблицаСреднего КАК РасчетСреднегоЗаработка";*/
			//Запрос.Выполнить();
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	СУММА(ВЫБОР
	|			КОГДА РасчетСреднегоЗаработка.ВидРасчета В (&ОсновнойЗаработок)
	|				ТОГДА РасчетСреднегоЗаработка.Результат * ВЫБОР
	|						КОГДА РасчетСреднегоЗаработка.КоэффициентИндексации < 1
	|							ТОГДА 1
	|						ИНАЧЕ РасчетСреднегоЗаработка.КоэффициентИндексации
	|					КОНЕЦ
	|			КОГДА РасчетСреднегоЗаработка.ВидРасчета В (&ОсновнойЗаработокНеиндексируемый)
	|				ТОГДА РасчетСреднегоЗаработка.Результат
	|			КОГДА РасчетСреднегоЗаработка.ЧислоМесяцев = 0
	|				ТОГДА 0
	|			ИНАЧЕ ВЫБОР
	|					КОГДА РасчетСреднегоЗаработка.ВидРасчета В (&ПоПремиям)
	|						ТОГДА РасчетСреднегоЗаработка.Результат * ВЫБОР
	|								КОГДА РасчетСреднегоЗаработка.КоэффициентИндексации < 1
	|									ТОГДА 1
	|								ИНАЧЕ РасчетСреднегоЗаработка.КоэффициентИндексации
	|							КОНЕЦ
	|					КОГДА РасчетСреднегоЗаработка.ВидРасчета В (&ПоФиксПремиям)
	|						ТОГДА РасчетСреднегоЗаработка.Результат * ВЫБОР
	|								КОГДА РасчетСреднегоЗаработка.КоэффициентИндексации < 1
	|									ТОГДА 1
	|								ИНАЧЕ РасчетСреднегоЗаработка.КоэффициентИндексации
	|							КОНЕЦ * ВЫБОР
	|								КОГДА РасчетСреднегоЗаработка.НормаПоПятидневке = 0
	|									ТОГДА 0
	|								ИНАЧЕ РасчетСреднегоЗаработка.ОтработаноПоПятидневке / РасчетСреднегоЗаработка.НормаПоПятидневке
	|							КОНЕЦ
	|					КОГДА РасчетСреднегоЗаработка.ВидРасчета В (&ПоФиксПремиямНеИндексируемые)
	|						ТОГДА РасчетСреднегоЗаработка.Результат * ВЫБОР
	|								КОГДА РасчетСреднегоЗаработка.НормаПоПятидневке = 0
	|									ТОГДА 0
	|								ИНАЧЕ РасчетСреднегоЗаработка.ОтработаноПоПятидневке / РасчетСреднегоЗаработка.НормаПоПятидневке
	|							КОНЕЦ
	|					ИНАЧЕ РасчетСреднегоЗаработка.Результат
	|				КОНЕЦ * ВЫБОР
	|					КОГДА РасчетСреднегоЗаработка.ЧислоМесяцев > &ПериодРасчетаСреднегоЗаработка
	|						ТОГДА &ПериодРасчетаСреднегоЗаработка / РасчетСреднегоЗаработка.ЧислоМесяцев
	|					ИНАЧЕ 1
	|				КОНЕЦ
	|		КОНЕЦ) КАК СреднийЗаработок,
	|	СУММА(ВЫБОР
	|			КОГДА РасчетСреднегоЗаработка.ВидРасчета В (&ОсновнойЗаработок)
	|					ИЛИ РасчетСреднегоЗаработка.ВидРасчета В (&ОсновнойЗаработокНеиндексируемый)
	|				ТОГДА РасчетСреднегоЗаработка.ОтработаноДней
	|			ИНАЧЕ 0
	|		КОНЕЦ) КАК ОтработаноДней,
	|	СУММА(ВЫБОР
	|			КОГДА РасчетСреднегоЗаработка.ВидРасчета В (&ОсновнойЗаработок)
	|					ИЛИ РасчетСреднегоЗаработка.ВидРасчета В (&ОсновнойЗаработокНеиндексируемый)
	|				ТОГДА РасчетСреднегоЗаработка.ОтработаноЧасов
	|			ИНАЧЕ 0
	|		КОНЕЦ) КАК ОтработаноЧасов
	|ИЗ
	|	ВТРасчетСреднегоЗаработка КАК РасчетСреднегоЗаработка
	|ГДЕ
	|	РасчетСреднегоЗаработка.БазовыйПериодНачало МЕЖДУ &Начало И &Окончание";*/
			//Выборка = Запрос.Выполнить().Выбрать();
			if(true/*Выборка.Следующий()*/)
			{
				if(true/*ИспользоватьСреднеЧасовойЗаработок*/)
				{
				}
			}
			return null;
		}
		// РасчетСреднедневногоЗаработка()

		public object РегламентированнаяПечатнаяФорма(/*ДокументОбъект, ИмяМакета*/)
		{
			return null;
		}
		// РегламентированнаяПечатнаяФорма

		public object ОписаниеРегламентированнойПечатнойФормы(/*ДокументОбъект, ИмяМакета*/)
		{
			return null;
		}
		// ОписаниеРегламентированнойПечатнойФормы
		// Функция возвращает массив табличных частей документа, которые необходимо очистить
		// перед расчетом
		//

		public object ПолучитьМассивТабличныхЧастей(/*ДокументОбъект, ЧтоРассчитываем*/)
		{
			//МассивТаблиц = Новый Массив;
			if(true/*ЧтоРассчитываем = "ПолныйРасчет" или ЧтоРассчитываем = "РасчетСреднего"*/)
			{
				//МассивТаблиц.Добавить(ДокументОбъект.Начисления);
				//МассивТаблиц.Добавить(ДокументОбъект.РасчетСреднего);
			}
			return null;
		}
		// ПолучитьМассивТабличныхЧастей()
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public void ВыполнитьДействияПередОткрытиемФормы(/*ФормаДокумента*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void ВыполнитьДополнительныеДействияПриОткрытииФормы(/*ДокументОбъект, ФормаДокумента*/)
		{
			//ЭлементыФормы = ФормаДокумента.ЭлементыФормы;
			//ЭлементыФормы.ЗаголовокДополнительнойИнформационнойНадписи.Видимость = Ложь;
			//ЭлементыФормы.ДополнительнаяИнформационнаяНадпись.Видимость = Ложь;
		}

		public void ВыполнитьДополнительныеДействияПриИзмененииПериодаРегистрации(/*ДокументОбъект, ФормаДокумента*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void ВыполнитьДействияПриНачалеРедактированияНачисления(/*ФормаДокумента, Элемент, НоваяСтрока*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void ВыполнитьДействияПослеРедактированияНачисления(/*ФормаДокумента, ТекущаяСтрока*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void ВыполнитьДействияПередУдалениемНачисления(/*Элемент, ДокументОбъект, Отказ*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void ВыполнитьДополнительныеДействияПриУдаленииНачислений(/*ДокументОбъект, ФормаДокумента*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void НастроитьСпискиВыбораЭлементовУправления(/*ДокументОбъект, ФормаДокумента*/)
		{
			//ЭлементыФормы = ФормаДокумента.ЭлементыФормы;
			//ЭтоПорядок2007года = ?(ЗначениеЗаполнено(ДокументОбъект.ДатаНачалаСобытия),ДокументОбъект.ДатаНачалаСобытия,ОбщегоНазначения.ПолучитьРабочуюДату()) < ПроведениеРасчетовДополнительный.ПолучитьДатуВступленияВСилуИзмененийПоОтпускам2008();
			/*// Список видов записей расчета среднего
*/
			//СписокВыбора = ПроведениеРасчетовПереопределяемый.ПолучитьПереченьСоставляющихСреднегоЗаработка(ЭтоПорядок2007года);
			//ЭлементыФормы.РасчетСреднего.Колонки.ВидРасчета.ЭлементУправления.СписокВыбора = СписокВыбора;
			//ЭлементыФормы.РасчетСреднего.Колонки.ВидРасчета.ЭлементУправления.ВысотаСпискаВыбора = СписокВыбора.Количество();
			//ЭлементыФормы.РасчетСреднего.Колонки.ОтработаноПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Отработано по пятидневке","Отработано за расчетный период");
			//ЭлементыФормы.РасчетСреднего.Колонки.НормаПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Норма по пятидневке","Норма за расчетный период");
		}

		public void ОбновитьДополнительнуюИнформационнуюНадпись(/*ДокументОбъект, ФормаДокумента*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}

		public void ПоказатьДополнительнуюФорму(/*ДокументОбъект, ФормаДокумента*/)
		{
			/*// В этой конфигурации дополнительные действия не выполняются
*/
		}
	}
}

