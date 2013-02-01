﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудование1СФискальныйРегистраторЭмулятор
	{
		///////////////////////////////////////////////////////////////////////////////
		// ПРОГРАММНЫЙ ИНТЕРФЕЙС
		// Функция осуществляет подключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера   - <*>
		//           - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ПодключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ПараметрыПодключения.Вставить("СерийныйНомерККМ", "0");
			//ПараметрыПодключения.Вставить("ИДУстройства", "");
			//ПараметрыПодключения.Вставить("ФРПодключен", Ложь);
			//ПараметрыПодключения.Вставить("СтрокаЛога", "");
			/*//Обязательные выходные
*/
			//ВыходныеПараметры = Новый Массив();
			/*// Проверка настроенных параметров
*/
			//КодСимволаЧастичногоОтреза = Неопределено;
			//НомерСекции                = Неопределено;
			//Модель                     = Неопределено;
			//Параметры.Свойство("КодСимволаЧастичногоОтреза", КодСимволаЧастичногоОтреза);
			//Параметры.Свойство("НомерСекции"               , НомерСекции);
			//Параметры.Свойство("Модель"                    , Модель);
			if(true/*КодСимволаЧастичногоОтреза = Неопределено
	 Или НомерСекции                = Неопределено
	 Или Модель                     = Неопределено*/)
			{
				//Результат = Ложь;
				//ВыходныеПараметры.Добавить(999);
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
			}
			/*// Конец: Проверка настроенных параметров
*/
			if(true/*Результат*/)
			{
				if(true/*ПараметрыПодключения.ФРПодключен*/)
				{
					//ВыходныеПараметры.Добавить(999);
					//ВыходныеПараметры.Добавить(НСтр("ru='Фискальный регистратор уже подключен'"));
					//Результат = Ложь;
				}
			}
			return null;
		}
		// Функция осуществляет отключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера - <*>
		//         - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ОтключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			/*//Обязательные выходные
*/
			//ВыходныеПараметры = Неопределено;
			//ПараметрыПодключения.ФРПодключен = Ложь;
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			//Результат = Истина;
			//ВыходныеПараметры = Новый Массив();
			/*// Открыть смену
*/
			if(true/*Команда = "OpenDay"*/)
			{
				//Результат = ОткрытьСмену(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
				/*// Печать чека
*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция осуществляет открытие смены

		public object ОткрытьСмену(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//СтрокаЛога = "";
			//СтрокаЛога = "----- " + НСтр("ru='Смена открыта'") + " -----";
			/*// Заполнение выходных параметров
*/
			//ВыходныеПараметры.Добавить(0);
			//ВыходныеПараметры.Добавить(0);
			//ВыходныеПараметры.Добавить(0);
			//ВыходныеПараметры.Добавить(ТекущаяДата());
			//СообщитьПользователю(СтрокаЛога);
			return null;
		}
		// Осуществляет печать фискального чека

		public object ПечатьЧека(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВходныеПараметры, ВыходныеПараметры*/)
		{
			//ПараметрыПодключения.СтрокаЛога = "";
			/*Результат = МенеджерОборудованияКлиентСерверПереопределяемый.ПечатьЧека(ПодключаемоеОборудование1СФискальныйРегистраторЭмулятор,
		ОбъектДрайвера, Параметры, ПараметрыПодключения, ВходныеПараметры, ВыходныеПараметры);*/
			//СообщитьПользователю(ПараметрыПодключения.СтрокаЛога);
			return null;
		}
		// Функция осуществляет печать слип-чека

		public object ПечатьТекста(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                       СтрокаТекста, ВыходныеПараметры*/)
		{
			//Результат  = Истина;
			/*// Открываем чек
*/
			//Результат = ОткрытьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, Ложь, Ложь, ВыходныеПараметры);
			/*// Печатаем строки чека
*/
			if(true/*Результат*/)
			{
			}
			/*// Закрываем чек
*/
			if(true/*Результат*/)
			{
				//ТаблицаОплат = Новый Массив();
				//Результат = ЗакрытьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ТаблицаОплат, ВыходныеПараметры);
			}
			//СообщитьПользователю(ПараметрыПодключения.СтрокаЛога);
			return null;
		}
		// Функция осуществляет открытие нового чека.
		//

		public object ОткрытьЧек(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ЧекВозврата, ФискальныйЧек, ВыходныеПараметры*/)
		{
			//Результат  = Истина;
			//СтрокаЛога = "";
			//мНомерСмены = 1;
			//мНомерЧека  = 1;
			//СтрокаЛога = СтрокаЛога + "===== " + ?(ЧекВозврата, НСтр("ru='Открытие чека возврата'"), НСтр("ru='Открытие чека продажи'")) + " =====" + Символы.ПС;
			//СтрокаЛога = СтрокаЛога + "=====" + ?(ФискальныйЧек, "== " + НСтр("ru='Фискальный режим'"), " " + НСтр("ru='Нефискальный режим'")) + "=====" + Символы.ПС;
			/*СтрокаЛога = СтрокаЛога + НСтр("ru='№ чека'")   + ": " + Формат(мНомерЧека,  "ЧЦ=4; ЧН=0; ЧВН=")
	           + "    "
	           + НСтр("ru='№ смены'") + ": " + Формат(мНомерСмены, "ЧЦ=4; ЧН=0; ЧВН=") + Символы.ПС;*/
			//НомерСмены = мНомерСмены;
			//НомерЧека  = мНомерЧека;
			/*// Заполнение выходных параметров
*/
			//ВыходныеПараметры.Добавить(НомерСмены);
			//ВыходныеПараметры.Добавить(НомерЧека);
			//ВыходныеПараметры.Добавить(0);
			//ВыходныеПараметры.Добавить(ТекущаяДата());
			//ПараметрыПодключения.Вставить("ФискальныйЧек", ФискальныйЧек);
			//ПараметрыПодключения.Вставить("ЧекОткрыт"    , Истина);
			//ПараметрыПодключения.Вставить("ИтогЧека"     , 0);
			//ПараметрыПодключения.СтрокаЛога = ПараметрыПодключения.СтрокаЛога + СтрокаЛога;
			return null;
		}
		// Функция осуществляет печать фискальной строки.
		//

		public object НапечататьФискальнуюСтроку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                   Наименование, Количество, Цена, ПроцентСкидки, Сумма,
                                   НомерСекции, СтавкаНДС, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//СтрокаЛога = "";
			if(true/*Не ПараметрыПодключения.ЧекОткрыт*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить(НСтр("ru='Чек не был открыт'"));
				//Результат = Ложь;
			}
			//ПараметрыПодключения.СтрокаЛога = ПараметрыПодключения.СтрокаЛога + СтрокаЛога;
			return null;
		}
		// Функция осуществляет печать нефискальной строки.
		//

		public object НапечататьНефискальнуюСтроку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, СтрокаТекста, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ПараметрыПодключения.СтрокаЛога = ПараметрыПодключения.СтрокаЛога + СтрокаТекста + Символы.ПС;
			return null;
		}
		// Функция осуществляет закрытие ранее открытого чека.
		//

		public object ЗакрытьЧек(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ТаблицаОплат, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//СтрокаЛога = "";
			//СуммаНаличнойОплаты     = 0;
			//СуммаБезналичнойОплаты1 = 0;
			//СуммаБезналичнойОплаты2 = 0;
			if(true/*Не ПараметрыПодключения.ЧекОткрыт*/)
			{
				//ВыходныеПараметры.Очистить();
				//ВыходныеПараметры.Добавить(999);
				//ВыходныеПараметры.Добавить(НСтр("ru='Чек не был открыт'"));
				//Результат = Ложь;
			}
			//ПараметрыПодключения.СтрокаЛога = ПараметрыПодключения.СтрокаЛога + СтрокаЛога;
			return null;
		}
		// Функция осуществляет внесение или выемку суммы на ФР.
		//

		public object Инкассация(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ТипИнкассации, Сумма, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//СообщитьПользователю(?(ТипИнкассации = 1, НСтр("ru='Внесение на сумму'"), НСтр("ru='Выемка на сумму'")) + " " + Сумма);
			/*// Заполнение выходных параметров
*/
			//ВыходныеПараметры.Добавить(1);
			//ВыходныеПараметры.Добавить(1);
			//ВыходныеПараметры.Добавить(0);
			//ВыходныеПараметры.Добавить(ТекущаяДата());
			return null;
		}
		// Функция осуществляет снятие отчёта без гашения.
		//

		public object НапечататьОтчетБезГашения(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//СообщитьПользователю(НСтр("ru='Печать отчета без гашения'"));
			/*// Заполнение выходных параметров
*/
			//ВыходныеПараметры.Добавить(1);
			//ВыходныеПараметры.Добавить(1);
			//ВыходныеПараметры.Добавить(0);
			//ВыходныеПараметры.Добавить(ТекущаяДата());
			return null;
		}
		// Функция осуществляет снятие отчёта с гашением.
		//

		public object НапечататьОтчетСГашением(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			/*СообщитьПользователю(НСтр("ru='Печать отчета с гашением'") + Символы.ПС
	                      + "----- " + НСтр("ru='Смена закрыта'") + " -----");*/
			/*// Заполнение выходных параметров
*/
			//ВыходныеПараметры.Добавить(1);
			//ВыходныеПараметры.Добавить(1);
			//ВыходныеПараметры.Добавить(0);
			//ВыходныеПараметры.Добавить(ТекущаяДата());
			return null;
		}
		// Функция осуществляет открытие денежного ящика
		//

		public object ОткрытьДенежныйЯщик(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//СообщитьПользователю(НСтр("ru='Денежный ящик открыт'"));
			return null;
		}
		// Формирует и выводит сообщение
		//

		public void СообщитьПользователю(/*ТекстСообщения*/)
		{
			//ПоказатьОповещениеПользователя(НСтр("ru = '1С: Фискальный регистратор (эмулятор)'"), , ТекстСообщения);
		}
	}
}

