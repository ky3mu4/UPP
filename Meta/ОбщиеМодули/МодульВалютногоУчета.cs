﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class МодульВалютногоУчета
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ РАБОТЫ С ВАЛЮТАМИ
		// Эта функция пересчитывает сумму из валюты ВалютаНач по курсу ПоКурсуНач
		// в валюту ВалютаКон по курсу ПоКурсуКон
		//
		// Параметры:
		//	Сумма          - сумма, которую следует пересчитать;
		//	ВалютаНач      - ссылка на элемент справочника Валют;
		//                   определяет валюты из которой надо пересчитвать;
		//	ВалютаКон      - ссылка на элемент справочника Валют;
		//                   определяет валюты в которую надо пересчитвать;
		// 	ПоКурсуНач     - курс из которого надо пересчитать;
		// 	ПоКурсуКон     - курс в который надо пересчитать;
		// 	ПоКратностьНач - кратность из которого надо пересчитать (по умолчанию = 1);
		// 	ПоКратностьКон - кратность в который надо пересчитать  (по умолчанию = 1);
		//
		// Возвращаемое значение:
		//  Сумма, пересчитанная в другую валюту
		//

		public object ПересчитатьИзВалютыВВалюту(/*Сумма, ВалютаНач, ВалютаКон, ПоКурсуНач, ПоКурсуКон, 
	               ПоКратностьНач =1, ПоКратностьКон = 1 */)
		{
			if(true/*(ВалютаНач = ВалютаКон)*/)
			{
				/*// Считаем, что пересчет не нужен.
*/
			}
			if(true/*(ПоКурсуНач = ПоКурсуКон) 
	   и (ПоКратностьНач = ПоКратностьКон)*/)
			{
				/*// пересчет суммы не требуется
*/
			}
			if(true/*ПоКурсуНач     = 0 
	 или ПоКурсуКон     = 0 
	 или ПоКратностьНач = 0 
	 или ПоКратностьКон = 0*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("При пересчете из валюты '"+ВалютаНач+"' в валюту '"+ВалютаКон+"' обнаружен нулевой курс. Пересчет не произведен!");
			}
			return null;
		}
		//ПересчитатьИзВалютыВВалюту()
		// Возвращает курс валюты на дату
		//
		// Параметры:
		//  Валюта     - Валюта (элемент справочника "Валюты")
		//  ДатаКурса  - Дата, на которую следует получить курс
		//
		// Возвращаемое значение:
		//  Структура, содержащая:
		//   Курс      - курс валюты
		//   Кратность - кратность валюты
		//

		public object ПолучитьКурсВалюты(/*Валюта, ДатаКурса*/)
		{
			//Структура = РегистрыСведений.КурсыВалют.ПолучитьПоследнее(?(ДатаКурса = Дата('00010101'),ТекущаяДата(),ДатаКурса), Новый Структура("Валюта", Валюта));
			return null;
		}
		// ПолучитьКурсВалюты()
		// Проверяет наличие установленного курс аи кратности валюты на 1 января 1980 года.
		// В случае отсутствия устанавливает курс и кратность равными единице.
		//
		// Параметры:
		//  Валюта - ссылка на элемент справочника Валют
		//

		public void ПроверитьКорректностьКурсаНа01_01_1980(/*Валюта*/)
		{
			//ДатаКурса = Дата(1980, 1, 1);
			//СтруктураКурса = ПолучитьКурсВалюты(Валюта, ДатаКурса);
			if(true/*(СтруктураКурса.Курс = 0) Или (СтруктураКурса.Кратность = 0)*/)
			{
				/*// установим курс и кратность = 1 на 01.01.1980, чтобы не было ошибок при создании документов
*/
				//РегистрКурсыВалют = РегистрыСведений.КурсыВалют.СоздатьМенеджерЗаписи();
				//РегистрКурсыВалют.Период    = ДатаКурса;
				//РегистрКурсыВалют.Валюта    = Валюта;
				//РегистрКурсыВалют.Курс      = 1;
				//РегистрКурсыВалют.Кратность = 1;
				//РегистрКурсыВалют.Записать();
				//РегистрКурсыВалют = РегистрыСведений.КурсыВалютДляРасчетовСПерсоналом.СоздатьМенеджерЗаписи();
				//РегистрКурсыВалют.Период    = ДатаКурса;
				//РегистрКурсыВалют.Валюта    = Валюта;
				//РегистрКурсыВалют.Курс      = 1;
				//РегистрКурсыВалют.Кратность = 1;
				//РегистрКурсыВалют.Записать();
			}
		}
		// ПроверитьКорректностьКурсаНа01_01_1980()
		// Функция производит пересчет суммы в валюте упр. учета в валюту регл. учета.
		//

		public object ПересчитатьВСуммуРегл(/*СуммаУпр, ВалютаРегламентированногоУчета, ВалютаУправленческогоУчета, Дата*/)
		{
			//ВалютаРегл = ВалютаРегламентированногоУчета;
			//ВалютаУпр = ВалютаУправленческогоУчета;
			//КурсВал   = ПолучитьКурсВалюты(ВалютаРегл, Дата);
			//КурсРегл  = КурсВал.Курс;
			//КратРегл  = КурсВал.Кратность;
			//КурсВал   = ПолучитьКурсВалюты(ВалютаУпр, Дата);
			//КурсУпр   = КурсВал.Курс;
			//КратУпр   = КурсВал.Кратность;
			if(true/*КурсРегл = 0*/)
			{
				//ОбщегоНазначения.Сообщение("Не задан курс валюты """ + ВалютаУправленческогоУчета + """ регламентированного учета!", СтатусСообщения.Внимание);
			}
			if(true/*КурсУпр = 0*/)
			{
				//ОбщегоНазначения.Сообщение("Не задан курс валюты """ + ВалютаУправленческогоУчета + """ управленческого учета!", СтатусСообщения.Внимание);
			}
			//СуммаРегл = ПересчитатьИзВалютыВВалюту(СуммаУпр, ВалютаУпр, ВалютаРегл, КурсУпр, КурсРегл, КратУпр, КратРегл);
			return null;
		}
		// ПересчитатьВСуммуРегл()
	}
}

