﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РасчетПриУвольненииРаботникаОрганизацийПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// ВСПОМОГАТЕЛЬНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public void ВыполнитьПрочиеДвиженияДокумента(/*ДокументОбъект, ВыборкаПоШапкеДокумента, Отказ, Заголовок, ВыборкаПоНачислениям = Неопределено*/)
		{
			if(true/*НЕ Отказ*/)
			{
				//ВыборкаПоНачислениям.Сбросить();
				while(true/*ВыборкаПоНачислениям.Следующий()*/)
				{
					//РасчетПриУвольненииРаботникаОрганизацийДополнительный.ДобавитьСтрокуВДвиженияПоРегистрамНакопления(ДокументОбъект, ВыборкаПоШапкеДокумента, ВыборкаПоНачислениям);
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
			//ВыборкаПоНачислениям = ДокументОбъект.СформироватьЗапросПоНачислениям(ВыборкаПоШапкеДокумента).Выбрать();
			while(true/*ВыборкаПоНачислениям.Следующий()*/)
			{
				//РасчетПриУвольненииРаботникаОрганизацийДополнительный.ДобавитьСтрокуВДвиженияПоРегистрамНакопления(ДокументОбъект, ВыборкаПоШапкеДокумента, ВыборкаПоНачислениям);
			}
			/*// записываем обновленные движения
*/
		}
		// Возвращает признак того, используется ли при расчете средне часовой заработок
		//
		// Параметры
		//  ДокументОбъект - ДокументОбъект.НачислениеОтпускаРаботникамОрганизаций
		//
		// Возвращаемое значение:
		//   булево
		//

		public object ИспользуетсяСреднеЧасовойЗаработок(/*ДокументОбъект*/)
		{
			return null;
		}
		// ИспользуетсяСреднеЧасовойЗаработок()
		// Возвращает перечень в.р. среднего заработка, соответствующих годовым премиям
		//
		// Параметры
		//  нет
		//
		// Возвращаемое значение:
		//   массив
		//

		public object МассивГодовыхПремий(/**/)
		{
			//ГодовыеПремии = Новый Массив(4);
			//ГодовыеПремии[0] = ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремии;
			//ГодовыеПремии[1] = ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремии;
			//ГодовыеПремии[2] = ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииНеИндексируемые;
			//ГодовыеПремии[3] = ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремииНеИндексируемые;
			return null;
		}
		// МассивГодовыхПремий()
		// Определяет количество месяцев расчетного периода в зависимости от даты начала события
		//
		// Параметры
		//  ДокументОбъект - ДокументОбъект.НачислениеОтпускаРаботникамОрганизаций
		//
		// Возвращаемое значение:
		//   число
		//

		public object КоличествоМесяцевРасчетаПоЗакону(/*ДокументОбъект*/)
		{
			return null;
		}
		// КоличествоМесяцевРасчетаПоЗакону()

		public object ПолучитьПрочиеПоляЗапросаПоСреднему(/**/)
		{
			return null;
		}

		public object ПолучитьСтруктуруРегламентированныхФорм(/*ДокументОбъект*/)
		{
			//СтруктураПечатныхФорм = Новый Структура;
			//СтруктураПечатныхФорм.Вставить("Т61", "Форма Т-61");
			return null;
		}
		// ПолучитьСтруктуруПечатныхФорм()

		public object РасчетСреднегоЗаработка(/*ДокументОбъект, ПорядокРасчетаСреднего, ПериодРасчетаСреднегоЗаработка, Начало, Окончание*/)
		{
			//ТаблицаСреднего = ?(ПорядокРасчетаСреднего = Перечисления.СпособыРасчетаОплатыТруда.ПоСреднемуЗаработку, ДокументОбъект.РасчетСреднего,ДокументОбъект.РасчетСреднегоДляОтпуска);
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
				if(true/*ПорядокРасчетаСреднего = Перечисления.СпособыРасчетаОплатыТруда.ПоСреднемуЗаработку*/)
				{
					if(true/*ЗначениеЗаполнено(ДокументОбъект.Сотрудник)*/)
					{
						//Запрос = Новый Запрос;
						/*Запрос.Текст = 
				"ВЫБРАТЬ
				|	ЕСТЬNULL(ВЫБОР
				|			КОГДА РаботникиОрганизацииСрезПоследних.ПериодЗавершения <= &ДатаАктуальности
				|					И РаботникиОрганизацииСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
				|				ТОГДА РаботникиОрганизацииСрезПоследних.ГрафикРаботыЗавершения.СуммированныйУчетРабочегоВремени
				|			ИНАЧЕ РаботникиОрганизацииСрезПоследних.ГрафикРаботы.СуммированныйУчетРабочегоВремени
				|		КОНЕЦ, ЛОЖЬ) КАК ИспользоватьСреднеЧасовойЗаработок
				|ИЗ
				|	РегистрСведений.РаботникиОрганизаций.СрезПоследних(&ДатаАктуальности, Сотрудник = &Сотрудник) КАК РаботникиОрганизацииСрезПоследних";*/
						//Запрос.УстановитьПараметр("Сотрудник", ДокументОбъект.Сотрудник);
						//Запрос.УстановитьПараметр("ДатаАктуальности", ДокументОбъект.ДатаУвольнения);
						//ВыборкаСотрудника = Запрос.Выполнить().Выбрать();
						if(true/*ВыборкаСотрудника.Следующий()*/)
						{
							if(true/*ВыборкаСотрудника.ИспользоватьСреднеЧасовойЗаработок*/)
							{
							}
						}
					}
				}
			}
			return null;
		}
		// РасчетСреднедневногоЗаработка()

		public object РегламентированнаяПечатнаяФорма(/*ДокументОбъект, ИмяМакета*/)
		{
			if(true/*ИмяМакета = "Т61"*/)
			{
			}
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
				//МассивТаблиц.Добавить(ДокументОбъект.РасчетСреднегоДляОтпуска);
			}
			return null;
		}
		// ПолучитьМассивТабличныхЧастей()
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

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
			//ЭтоПорядок2007года = ?(ЗначениеЗаполнено(ДокументОбъект.ДатаУвольнения),ДокументОбъект.ДатаУвольнения,ОбщегоНазначения.ПолучитьРабочуюДату()) < ПроведениеРасчетовДополнительный.ПолучитьДатуВступленияВСилуИзмененийПоОтпускам2008();
			/*// Список видов записей расчета среднего
*/
			//СписокВыбора = ПроведениеРасчетовПереопределяемый.ПолучитьПереченьСоставляющихСреднегоЗаработка(ЭтоПорядок2007года);
			//ЭлементыФормы.РасчетСреднего.Колонки.ВидРасчета.ЭлементУправления.СписокВыбора = СписокВыбора;
			//ЭлементыФормы.РасчетСреднего.Колонки.ВидРасчета.ЭлементУправления.ВысотаСпискаВыбора = СписокВыбора.Количество();
			//ЭлементыФормы.РасчетСреднегоДляОтпуска.Колонки.ВидРасчета.ЭлементУправления.СписокВыбора = СписокВыбора;
			//ЭлементыФормы.РасчетСреднегоДляОтпуска.Колонки.ВидРасчета.ЭлементУправления.ВысотаСпискаВыбора = СписокВыбора.Количество();
			//ЭлементыФормы.РасчетСреднегоДляОтпуска.Колонки.ОтработаноЧасов.Видимость = ЭтоПорядок2007года;
			//ЭлементыФормы.РасчетСреднегоДляОтпуска.Колонки.ОтработаноЧасов.ИзменятьНастройку = ЭтоПорядок2007года;
			//ЭлементыФормы.РасчетСреднего.Колонки.ОтработаноПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Отработано по пятидневке","Отработано за расчетный период");
			//ЭлементыФормы.РасчетСреднего.Колонки.НормаПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Норма по пятидневке","Норма за расчетный период");
			//ЭлементыФормы.РасчетСреднегоДляОтпуска.Колонки.ОтработаноПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Отработано по пятидневке","Отработано за расчетный период");
			//ЭлементыФормы.РасчетСреднегоДляОтпуска.Колонки.НормаПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Норма по пятидневке","Норма за расчетный период");
			//ЭлементыФормы.РасчетСреднего1.Колонки.ВидРасчета.ЭлементУправления.СписокВыбора = СписокВыбора;
			//ЭлементыФормы.РасчетСреднего1.Колонки.ВидРасчета.ЭлементУправления.ВысотаСпискаВыбора = СписокВыбора.Количество();
			//ЭлементыФормы.РасчетСреднегоДляОтпуска1.Колонки.ВидРасчета.ЭлементУправления.СписокВыбора = СписокВыбора;
			//ЭлементыФормы.РасчетСреднегоДляОтпуска1.Колонки.ВидРасчета.ЭлементУправления.ВысотаСпискаВыбора = СписокВыбора.Количество();
			//ЭлементыФормы.РасчетСреднегоДляОтпуска1.Колонки.ОтработаноЧасов.Видимость = ЭтоПорядок2007года;
			//ЭлементыФормы.РасчетСреднегоДляОтпуска1.Колонки.ОтработаноЧасов.ИзменятьНастройку = ЭтоПорядок2007года;
			//ЭлементыФормы.РасчетСреднего1.Колонки.ОтработаноПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Отработано по пятидневке","Отработано за расчетный период");
			//ЭлементыФормы.РасчетСреднего1.Колонки.НормаПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Норма по пятидневке","Норма за расчетный период");
			//ЭлементыФормы.РасчетСреднегоДляОтпуска1.Колонки.ОтработаноПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Отработано по пятидневке","Отработано за расчетный период");
			//ЭлементыФормы.РасчетСреднегоДляОтпуска1.Колонки.НормаПоПятидневке.ТекстШапки = ?(ЭтоПорядок2007года,"Норма по пятидневке","Норма за расчетный период");
		}

		public void ДополнитьКолонкиТабличногоПоля(/*ТабличноеПоле*/)
		{
			//РаботаСДиалогами.ВставитьКолонкуВТабличноеПоле(4, ТабличноеПоле, "ОтработаноЧасов", "Часов отработано", "ОтработаноЧасов", , , , Тип("ПолеВвода"), ПоложениеКолонки.НаСледующейСтроке, 15);
		}
		// ДополнитьКолонкиТабличнойЧасти()

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

