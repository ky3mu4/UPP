﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЗарплатаКВыплатеПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры и функции для работы модуля документа

		public void ЗаполнитьШапкуДокумента(/*Документ*/)
		{
		}

		public void ПроверитьЗаполнениеШапкиДополнительно(/*ШапкаДокумента, Отказ, Заголовок = ""*/)
		{
		}
		// ПроверитьЗаполнениеШапки()

		public void РассчитатьЗарплату(/*Документ, ТаблицаЗарплат*/)
		{
		}

		public void ЗаполнитьСтрокуЗарплаты(/*СтрокаЗарплаты, ДанныеЗаполнения = Неопределено*/)
		{
			if(true/*ДанныеЗаполнения = Неопределено*/)
			{
				//СтрокаЗарплаты.Сумма	 	= 0;
			}
		}

		public void ПровестиПоХарактеруВыплаты(/*Документ, Отказ*/)
		{
		}
		// Процедура осуществляет регистрацию взаиморасчетов документа при упрощенном учете взаиморасчетов
		//
		// Параметр:
		//   Документ - документ "Зарплата к выплате организаций"
		//   Отказ    - признак отказа от проведения
		//

		public void ПровестиВзаиморасчеты(/*Документ, Отказ*/)
		{
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public void ФормаДокументаПередОткрытиемДополнительно(/*Форма, ОбработчикиПолейВвода, ОбработчикНажатия*/)
		{
		}

		public void ФормаДокументаДополнительныеДействияПриИзменении(/*Форма, Элемент*/)
		{
		}

		public void ФормаДокументаДополнительныеДействияНажатие(/*Форма, Элемент*/)
		{
		}

		public void ФормаДокументаДополнительныеДействияПриИзмененииЗарплаты(/*Форма, Элемент*/)
		{
		}

		public void УстановитьНадписьНастройкаРасчета(/*Форма*/)
		{
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы списка

		public void ФормаСпискаПриСозданииФормыДополнительно(/*Форма*/)
		{
		}

		public void ФормаСпискаПередОткрытиемДополнительно(/*Форма*/)
		{
		}
	}
}

