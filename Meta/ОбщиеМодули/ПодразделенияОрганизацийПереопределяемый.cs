﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодразделенияОрганизацийПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы

		public object ПодобратьОрганизацию(/*Организация*/)
		{
			if(true/*Не ОбщегоНазначения.ЭтоДоступнаяОрганизация(Организация)*/)
			{
				/*//для пользователя не задана организация по умолчанию, подберем первую разрешенную
*/
				//Организация = РаботаСДиалогами.ПодобратьОрганизацию();
			}
			return null;
		}

		public void ОбновитьДополнительно(/*ЭтаФорма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ПриОткрытииДополнительно(/*ЭтаФорма, НазначаемоеДействие*/)
		{
			//ЭтаФорма.ЭлементыФормы.ДействияФормы.Кнопки.Действия.Кнопки.Вставить(10);
			//ЭтаФорма.ЭлементыФормы.ДействияФормы.Кнопки.Действия.Кнопки.Вставить(11, "Перейти", ТипКнопкиКоманднойПанели.Подменю);
			//ЭтаФорма.ЭлементыФормы.ДействияФормы.Кнопки.Действия.Кнопки.Перейти.Кнопки.Добавить("СоответствиеПодразделенийИПодразделенийОрганизаций", ТипКнопкиКоманднойПанели.Действие, "Соответствие подразделений и подразделений организаций", НазначаемоеДействие);
		}

		public void ВыполнитьДополнительныеДействия(/*ЭтаФорма, Кнопка*/)
		{
			if(true/*Кнопка.Имя = "СоответствиеПодразделенийИПодразделенийОрганизаций"*/)
			{
				if(true/*ЭтаФорма.ЭлементыФормы.СправочникСписок.ТекущиеДанные = Неопределено*/)
				{
					//Предупреждение("Не выбрано подразделение!");
				}
			}
		}

		public object ВыполняетсяДополнительноеУсловие(/*ЭтаФорма*/)
		{
			//НастройкиБухучетаДоступны = НастройкаПравДоступаПереопределяемый.ДоступнаРольРасчетчикаРегл();
			//ЭтаФорма.ЭлементыФормы.ПанельПрочихДанных.Страницы.БухучетЗарплаты.Видимость = НастройкиБухучетаДоступны;
			return null;
		}
		// Процедура получает из регистра сведений текущее отражение в учете

		public void ПрочитатьОтражениеВУчете(/*ЭтаФорма, ЭтотОбъект*/)
		{
			//Отбор = Новый Структура;
			//Отбор.Вставить("ПодразделениеОрганизации", ЭтотОбъект.Ссылка);
			//Отбор.Вставить("Организация", ЭтотОбъект.Ссылка.Владелец);
			//СрезПоследних   = РегистрыСведений.УчетОсновногоЗаработкаРаботниковПодразделенияОрганизации.СрезПоследних(ТекущаяДата(), Отбор);
			//НадписьОтражениеВБухучете = "";
			//ПодпадаетПодЕНВД = Ложь;
			//ОтражениеНачисленийПоУмолчанию = Справочники.СпособыОтраженияЗарплатыВРеглУчете.ОтражениеНачисленийПоУмолчанию;
			//БольничныйЗаСчетРаботодателяПоУмолчанию = Справочники.СпособыОтраженияЗарплатыВРеглУчете.БольничныйЗаСчетРаботодателя;
			//ПодразделенияОрганизацииДополнительный.ПолучитьСпособыОтраженияПоУмолчанию(ЭтотОбъект.Ссылка.Владелец, ОтражениеНачисленийПоУмолчанию, БольничныйЗаСчетРаботодателяПоУмолчанию, ПодпадаетПодЕНВД);
			if(true/*ЭтотОбъект.ЭтоНовый() ИЛИ СрезПоследних.Количество() = 0*/)
			{
				//НадписьОтражениеВБухучете = "Зарплата сотрудников подразделения отражается как задано для предприятия в целом:" + Символы.ПС;
				/*//добавим представление способа отражения по умолчанию
*/
				//НадписьОтражениеВБухучете = НадписьОтражениеВБухучете + ПодразделенияОрганизацииДополнительный.ПолучитьПредставлениеСпособаОтражения(ОтражениеНачисленийПоУмолчанию) + Символы.ПС;
				if(true/*ПодпадаетПодЕНВД*/)
				{
					//НадписьОтражениеВБухучете = НадписьОтражениеВБухучете + ". Расходы полностью относятся к ЕНВД" + Символы.ПС;
				}
			}
			//ЭтаФорма.ЭлементыФормы.НадписьОтражениеВБухучете.Заголовок = НадписьОтражениеВБухучете;
		}
		// ПрочитатьОтражениеВУчете()
	}
}

