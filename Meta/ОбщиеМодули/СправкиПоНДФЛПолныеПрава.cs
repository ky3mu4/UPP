﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СправкиПоНДФЛПолныеПрава
	{

		public object ОписаниеДоходовОрганизации(/*Организация, ГоловнаяОрганизация, ОрганизацияЭтоЮрЛицо, НалоговыйПериод, ДатаСведений, ФизЛицо = Неопределено, Ставка = Неопределено*/)
		{
			//ОтбиратьПоФизлицу = ЗначениеЗаполнено(ФизЛицо);
			//ОтбиратьПоСтавке = ЗначениеЗаполнено(Ставка);
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Организация",Организация);
			//Запрос.УстановитьПараметр("ГоловнаяОрганизация",ГоловнаяОрганизация);
			//Запрос.УстановитьПараметр("ГодНП",НалоговыйПериод);
			//Запрос.УстановитьПараметр("ДатаПодачиСведений", ДатаСведений);
			//Запрос.УстановитьПараметр("НеОтбиратьПоФизлицу", Не ОтбиратьПоФизлицу);
			//Запрос.УстановитьПараметр("НеОтбиратьПоСтавке", Не ОтбиратьПоСтавке);
			//Запрос.УстановитьПараметр("ФизЛицо", ФизЛицо);
			//Запрос.УстановитьПараметр("Ставка", Ставка);
			//Запрос.УстановитьПараметр("ПустойКодПоОКАТО","");
			//Запрос.УстановитьПараметр("ПустойКПП","");
			/*Запрос.Текст = 
	"ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	ВЫБОР
	|		КОГДА НДФЛСведенияОДоходах.КодПоОКАТО <> &ПустойКодПоОКАТО
	|			ТОГДА НДФЛСведенияОДоходах.КодПоОКАТО
	|		КОГДА ЕСТЬNULL(НДФЛСведенияОДоходах.ПодразделениеОрганизации.КодПоОКАТО, &ПустойКодПоОКАТО) <> &ПустойКодПоОКАТО
	|			ТОГДА НДФЛСведенияОДоходах.ПодразделениеОрганизации.КодПоОКАТО
	|		ИНАЧЕ ЕСТЬNULL(НДФЛСведенияОДоходах.ОбособленноеПодразделение.КодПоОКАТО, &ПустойКодПоОКАТО)
	|	КОНеЦ КАК КодПоОКАТО,
	|	ВЫБОР
	|		КОГДА НДФЛСведенияОДоходах.КПП <> &ПустойКПП
	|			ТОГДА НДФЛСведенияОДоходах.КПП
	|		КОГДА ЕСТЬNULL(НДФЛСведенияОДоходах.ПодразделениеОрганизации.КПП, &ПустойКПП) <> &ПустойКПП
	|			ТОГДА НДФЛСведенияОДоходах.ПодразделениеОрганизации.КПП
	|		ИНАЧЕ ЕСТЬNULL(НДФЛСведенияОДоходах.ОбособленноеПодразделение.КПП, &ПустойКПП)
	|	КОНеЦ КАК КПП
	|ИЗ
	|	РегистрНакопления.НДФЛСведенияОДоходах КАК НДФЛСведенияОДоходах
	|ГДЕ
	|	НДФЛСведенияОДоходах.Организация = &ГоловнаяОрганизация
	|	И НДФЛСведенияОДоходах.ОбособленноеПодразделение = &Организация
	|	И ГОД(НДФЛСведенияОДоходах.Период) = &ГодНП
	|	И НДФЛСведенияОДоходах.ПериодРегистрации < &ДатаПодачиСведений
	|	И НДФЛСведенияОДоходах.СуммаДохода <> 0
	|	И (&НеОтбиратьПоФизлицу
	|			ИЛИ НДФЛСведенияОДоходах.ФизЛицо = &ФизЛицо)
	|	И (&НеОтбиратьПоСтавке
	|			ИЛИ НДФЛСведенияОДоходах.КодДохода.СтавкаНалогообложенияРезидента = &Ставка)";*/
			//Выборка = Запрос.Выполнить().Выбрать();
			//ТекстКодов = "";
			while(true/*Выборка.Следующий()*/)
			{
				//ТекстКодов = ТекстКодов + ?(ЗначениеЗаполнено(ТекстКодов),", ","") + ?(ОрганизацияЭтоЮрЛицо, СокрЛП(СправкиПоНДФЛ.СуммаОКАТОиКПП(Выборка.КодПоОКАТО, Выборка.КПП)), СокрЛП(Выборка.КодПоОКАТО));
			}
			return null;
		}
	}
}

