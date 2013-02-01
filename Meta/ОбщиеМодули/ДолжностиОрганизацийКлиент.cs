﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ДолжностиОрганизацийКлиент
	{
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы элемента
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ МЕХАНИЗМА СВОЙСТВ И КАТЕГОРИЙ
		// Процедура перезаполняет таблицу свойств и значений.
		//
		// Параметры:
		//  Нет.
		//

		public void ПрочитатьЗаполнитьСвойстваИЗначения(/*ИмяДанных = "", ЭтаФорма*/)
		{
			/*// Эта проверка добавлена, чтобы не выполнялось перезаполнение таблицы 
*/
			/*// при вызове данной процедуры из ПриИзмененииДанных, осуществляемом до 
*/
			/*// вызова из ПередОткрытием
*/
			//ОбработкаОбъектЗначенияСвойств = ЭтаФорма.ОбработкаОбъектЗначенияСвойств;
			if(true/*ОбработкаОбъектЗначенияСвойств.НазначениеСвойств = ПланыВидовХарактеристик.НазначенияСвойствКатегорийОбъектов.Справочник_ДолжностиОрганизаций*/)
			{
				//ОбработкаОбъектЗначенияСвойств.ОбъектОтбораЗначений   = ЭтаФорма.Ссылка;
				//ОбработкаОбъектЗначенияСвойств.ОбъектОтбораНазначений = ЭтаФорма.Ссылка;
				//ОбработкаОбъектЗначенияСвойств.ПрочитатьЗаполнитьСвойстваИЗначения();
			}
		}
		// Процедура перезаполняет таблицу Категорий.
		//
		// Параметры:
		//  Нет.
		//

		public void ПрочитатьЗаполнитьКатегории(/*ИмяДанных = "", ЭтаФорма*/)
		{
			/*// Эта проверка добавлена, чтобы не выполнялось перезаполнение таблицы 
*/
			/*// при вызове данной процедуры из ПриИзмененииДанных, осуществляемом до 
*/
			/*// вызова из ПередОткрытием.
*/
			//ОбработкаОбъектКатегорииОбъекта = ЭтаФорма.ОбработкаОбъектКатегорииОбъекта;
			if(true/*ОбработкаОбъектКатегорииОбъекта.НазначениеКатегорий = ПланыВидовХарактеристик.НазначенияСвойствКатегорийОбъектов.Справочник_ДолжностиОрганизаций*/)
			{
				//ОбработкаОбъектКатегорииОбъекта.ОбъектОтбораКатегорий = ЭтаФорма.Ссылка;
				//ОбработкаОбъектКатегорииОбъекта.ПрочитатьЗаполнитьКатегорииОбъекта();
			}
		}
		// Обработчик события ПередНачаломДобавления элемента СвойстваИЗначения.
		//

		public void ФормаЭлементаСвойстваИЗначенияПередНачаломДобавления(/*Элемент, Отказ, Копирование, ЭтаФорма*/)
		{
			//Отказ = Истина;
			//ЭтаФорма.ОбработкаОбъектЗначенияСвойств.ОткрытьФормуНовогоСвойства(ЭтаФорма);
		}
		// Обработчик события ПриНачалеРедактирования элемента СвойстваИЗначения.
		//

		public void ФормаЭлементаСвойстваИЗначенияПриНачалеРедактирования(/*Элемент, НоваяСтрока, ЭтаФорма*/)
		{
			//ЭтаФорма.ОбработкаОбъектЗначенияСвойств.ПривестиТипЗначенияСвойства(Элемент.ТекущиеДанные, Элемент.Колонки.Значение.ЭлементУправления);
		}
		// Обработчик события ПередУдалением элемента СвойстваИЗначения.
		//

		public void ФормаЭлементаСвойстваИЗначенияПередУдалением(/*Элемент, Отказ, ЭтаФорма*/)
		{
			//Отказ = Истина;
		}
		// Обработчик события ПриВыводеСтроки элемента СвойстваИЗначения.
		//

		public void ФормаЭлементаСвойстваИЗначенияПриВыводеСтроки(/*Элемент, ОформлениеСтроки, ДанныеСтроки, ЭтаФорма*/)
		{
			//ЭтаФорма.ОбработкаОбъектЗначенияСвойств.ПриВыводеСтрокиСвойствИЗначений(Элемент, ОформлениеСтроки, ДанныеСтроки);
		}
		// Обработчик события ПриИзменении элемента СвойстваИЗначения.Значение.
		//

		public void ФормаЭлементаСвойстваИЗначенияЗначениеПриИзменении(/*Элемент, ЭтаФорма*/)
		{
			//ЭтаФорма.Модифицированность = Истина;
		}
		// Обработчик события Очистка элемента СвойстваИЗначения.Значение.
		//

		public void ФормаЭлементаСвойстваИЗначенияЗначениеОчистка(/*Элемент, СтандартнаяОбработка, ЭтаФорма*/)
		{
			//СтандартнаяОбработка = Ложь;
			//ЭтаФорма.ЭлементыФормы.СвойстваИЗначения.ТекущиеДанные.Значение = Неопределено;
			//ЭтаФорма.ОбработкаОбъектЗначенияСвойств.ПривестиТипЗначенияСвойства(ЭтаФорма.ЭлементыФормы.СвойстваИЗначения.ТекущиеДанные, Элемент);
			//ЭтаФорма.Модифицированность = Истина;
		}
		// Обработчик события ПередНачаломДобавления элемента Категории.
		//

		public void ФормаЭлементаКатегорииПередНачаломДобавления(/*Элемент, Отказ, Копирование, ЭтаФорма*/)
		{
			//Отказ = Истина;
			//ЭтаФорма.ОбработкаОбъектКатегорииОбъекта.ОткрытьФормуНовойКатегории(ЭтаФорма);
		}
		// Обработчик события ПередУдалением элемента Категории.
		//

		public void ФормаЭлементаКатегорииПередУдалением(/*Элемент, Отказ, ЭтаФорма*/)
		{
			//Отказ = Истина;
		}
		// Обработчик события ПриНачалеРедактирования элемента Категории.
		//

		public void ФормаЭлементаКатегорииПриИзмененииФлажка(/*Элемент, НоваяСтрока, ЭтаФорма*/)
		{
			//ЭтаФорма.Модифицированность = Истина;
		}
		// Обработчик события ПриВыводеСтроки элемента Категории.
		//

		public void ФормаЭлементаКатегорииПриВыводеСтроки(/*Элемент, ОформлениеСтроки, ДанныеСтроки, ЭтаФорма*/)
		{
			if(true/*Элемент.Колонки.Принадлежность.Видимость*/)
			{
				//ОформлениеСтроки.Ячейки.Принадлежность.ОтображатьФлажок    = Истина;
			}
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ - ОБРАБОТЧИКИ СОБЫТИЙ ФОРМЫ

		public void ФормаЭлементаПередОткрытием(/*Отказ, СтандартнаяОбработка, ЭтаФорма*/)
		{
			//ЭтаФорма.ОбработкаОбъектЗначенияСвойств.НазначениеСвойств = ПланыВидовХарактеристик.НазначенияСвойствКатегорийОбъектов.Справочник_ДолжностиОрганизаций;
			//ПрочитатьЗаполнитьСвойстваИЗначения(,ЭтаФорма);
			//ЭтаФорма.ОбработкаОбъектКатегорииОбъекта.НазначениеКатегорий = ПланыВидовХарактеристик.НазначенияСвойствКатегорийОбъектов.Справочник_ДолжностиОрганизаций;
			//ПрочитатьЗаполнитьКатегории(,ЭтаФорма);
		}

		public void ФормаЭлементаПриОткрытии(/*ЭтаФорма*/)
		{
			//ЭлементыФормы = ЭтаФорма.ЭлементыФормы;
			//МеханизмНумерацииОбъектов.УстановитьДоступностьПоляВводаНомера(ЭтаФорма.Метаданные(), ЭтаФорма, ЭлементыФормы.ДействияФормы.Кнопки.Подменю, ЭлементыФормы.Код);
			//ЕстьЛетчики = ПроцедурыУправленияПерсоналом.ЗначениеУчетнойПолитикиПоПерсоналуВсехОрганизаций(глЗначениеПеременной("глУчетнаяПолитикаПоПерсоналуОрганизации"), "ИспользуетсяТрудЧленовЛетныхЭкипажей");
			//ЕстьШахтеры = ПроцедурыУправленияПерсоналом.ЗначениеУчетнойПолитикиПоПерсоналуВсехОрганизаций(глЗначениеПеременной("глУчетнаяПолитикаПоПерсоналуОрганизации"), "ИспользуетсяТрудШахтеров");
			//ЕстьФармацевты = ПроцедурыУправленияПерсоналом.ЗначениеУчетнойПолитикиПоПерсоналуВсехОрганизаций(глЗначениеПеременной("глУчетнаяПолитикаПоПерсоналуОрганизации"), "ИспользуетсяТрудФармацевтов");
			//ЭлементыФормы.ПанельДолжностиЛетногоЭкипажа.Свертка = ?(ЕстьЛетчики, РежимСверткиЭлементаУправления.Нет, РежимСверткиЭлементаУправления.Верх);
			//ЭлементыФормы.ПанельШахтерскойДолжности.Свертка = ?(ЕстьШахтеры, РежимСверткиЭлементаУправления.Нет, РежимСверткиЭлементаУправления.Верх);
			//ЭлементыФормы.ПанельФармацевтов.Свертка = ?(ЕстьФармацевты, РежимСверткиЭлементаУправления.Нет, РежимСверткиЭлементаУправления.Верх);
			//ЭлементыФормы.ПанельСтраховыеВзносы.Свертка = ?(ЕстьЛетчики Или ЕстьШахтеры Или ЕстьФармацевты, РежимСверткиЭлементаУправления.Нет, РежимСверткиЭлементаУправления.Верх);
		}
		// Процедура - обработчик события "ОбработкаЗаписиНовогоОбъекта" формы
		//

		public void ФормаЭлементаОбработкаЗаписиНовогоОбъекта(/*Объект, Источник, ЭтаФорма*/)
		{
			if(true/*ТипЗнч(Объект) = Тип("ПланВидовХарактеристикОбъект.СвойстваОбъектов")*/)
			{
				//ЭтаФорма.ОбработкаОбъектЗначенияСвойств.ПроверитьДобавитьНовоеСвойство(Объект.Ссылка, ЭтаФорма.ЭлементыФормы.СвойстваИЗначения);
			}
			if(true/*ТипЗнч(Объект) = Тип("СправочникОбъект.КатегорииОбъектов")*/)
			{
				//ЭтаФорма.ОбработкаОбъектКатегорииОбъекта.ПроверитьДобавитьНовуюКатегорию(Объект.Ссылка, ЭтаФорма.ЭлементыФормы.Категории);
			}
		}

		public void ФормаЭлементаПриЗаписи(/*Отказ, ЭтаФорма*/)
		{
			/*// Обработка записи свойств и категорий
*/
			//ОбработкаОбъектЗначенияСвойств 	= ЭтаФорма.ОбработкаОбъектЗначенияСвойств;
			//ОбработкаОбъектКатегорииОбъекта = ЭтаФорма.ОбработкаОбъектКатегорииОбъекта;
			//ОбработкаОбъектЗначенияСвойств.ОбъектОтбораЗначений   = ЭтаФорма.Ссылка;
			//ОбработкаОбъектЗначенияСвойств.ОбъектОтбораНазначений = ЭтаФорма.Ссылка;
			//Отказ = НЕ ОбработкаОбъектЗначенияСвойств.ЗаписатьЗначенияСвойств();
			//ОбработкаОбъектКатегорииОбъекта.ОбъектОтбораКатегорий = ЭтаФорма.Ссылка;
			//Отказ = НЕ ОбработкаОбъектКатегорииОбъекта.ЗаписатьКатегорииОбъекта();
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ - ДЕЙСТВИЯ КОМАНДНЫХ ПАНЕЛЕЙ ФОРМЫ

		public void ФормаЭлементаДействияФормыРедактироватьКод(/*Кнопка, ЭтаФорма*/)
		{
			//ЭлементыФормы = ЭтаФорма.ЭлементыФормы;
			//МеханизмНумерацииОбъектов.ИзменениеВозможностиРедактированияНомера(ЭтаФорма.Метаданные(), ЭтаФорма, ЭлементыФормы.ДействияФормы.Кнопки.Подменю, ЭлементыФормы.Код);
		}
	}
}

